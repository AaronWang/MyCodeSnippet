//+------------------------------------------------------------------+
//|                                                          EA2.mq4 |
//|                        Copyright 2016, MetaQuotes Software Corp. |
//|                                             https://www.mql5.com |
//+------------------------------------------------------------------+
#property copyright "Copyright 2016, MetaQuotes Software Corp."
#property link      "https://www.mql5.com"
#property version   "1.00"
#property strict
//MACD与补仓
/* 货币对：EURUSD 
时间周期：M15 
技术指标：MACD 10,50 
开仓条件：MACD当前柱大（小）于前第n柱，MACD当前值大（小）于0，并且价格也高于（低于）前第n柱，开多（空）仓 
加仓条件：满足开仓条件，且建仓价大（小）于前一单建仓价，加多（空）仓 再次加仓，满足加仓条件做以下操作： 
   1、如果新订单盈利，加仓单开仓量恢复正常 
   2、如果新订单亏损，加仓单开仓量再加倍 
   3、设定开仓量0.01手，翻倍补仓条件为余额盈利n%，每盈利n%，开仓手数翻倍 
平仓条件：当前柱小（大）于前第n柱，并且价格也低于（高于）前第n柱，平所有订单 止损止盈：多空互换，不间断交易 
资金控制：如果出现亏损，下一单开仓量加倍，加倍仓盈利，下一单按正常量建仓 按账户余额一定的比例（n%）计算保证金比例，确定开仓量。 */

extern double Init_Lots=0.01;
extern double Profit_Rate=34;
extern double Max_Bet_Lots=0.4;
extern double LostRate=2;

int Order_Total=50; //最多下单个数
int Bet_Order=50;//最多加倍订单数量
bool LotsDouble=true;
int iBet_Order=0;//加倍订单计数器变量 
double perProfit=0;//每批订单总盈亏变量 
double iLots;//追加订单开仓量变量 
double Init_Balance;//账户初始余额变量 
double xMax_Bet_Lots;//最大浮动开仓量变量 
int TicketNo;
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
int init()
  {
   iLots=Init_Lots;
   xMax_Bet_Lots=Max_Bet_Lots;
   Init_Balance=AccountBalance();//取初始账户余额 
   return 0;//**************
  }
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
int start()
  {
//提取市场信号 
   string mktSignal=ReturnMarketInfomation(); //显示市场信息 
   SetLable("时间栏","星期"+DayOfWeek()+" 市场时间："+Year()+"-"+Month()+"-"+Day()+" "+Hour()+":"+Minute()+":"+Seconds(),300,0,9,"Verdana",Red);
   SetLable("信息栏","市场信号："+mktSignal+" 最大开仓量："+DoubleToStr(xMax_Bet_Lots,2),5,60,10,"Verdana",Yellow);
   SetLable("信息栏1","初始余额："+DoubleToStr(Init_Balance,2)+" 当前余额："+DoubleToStr(AccountBalance(),2),5,20,10,"Verdana",Yellow);
   SetLable("信息栏2","最低开仓量："+DoubleToStr(NewLots(),2)+" 浮动开仓量："+DoubleToStr(iLots,2),5,40,10,"Verdana",Yellow); //新开仓 
   if(OrdersTotal()==0)//订单量为0，前一批订单如果盈利ilots 不变，如果亏损 ilots 翻倍
     {
      if(perProfit<0 && LotsDouble==true) //LotsDouble 一直为true，LostRate 一直为2
        {
         iLots=iLots*LostRate;//如果前一批订单盈利为负数且允许亏损加倍，开仓量翻倍 
         LotsDouble=false;
        }
      if(iLots>xMax_Bet_Lots)
         iLots=xMax_Bet_Lots;//限制最大开仓量 
      Open_New_Order(iLots);
      perProfit=0;//前一批订单盈利变量清0 
     }
   else LotsDouble=true;

//处理已有订单 
   if(OrdersTotal()>0)
     {
      //OrderSelect(OrdersTotal()-1,SELECT_BY_POS); 最近的order
      //OrderSelect(0,SELECT_BY_POS); 最久远的order
      OrderSelect(OrdersTotal()-1,SELECT_BY_POS);//选择当前订单 //新开仓订单时间不足一个时间周期，不做任何操作返回 

        {//test
         int period=Period();//30
         double timeNow=TimeCurrent();
         double openTime=OrderOpenTime();
         double orderPeriod=(timeNow-openTime);  //订单到 但当前时间的秒数
        }
      if(TimeCurrent()-OrderOpenTime()<=Period()*6)//临时改为 3分钟
         return(0); //30*60=1800秒=30分钟 , 小于最小下单周期，返回

      //追加盈利订单 ， 
      double iiLots=iLots;
      if(iBet_Order>Bet_Order-1)
         iiLots=NewLots();//如果超过加倍订单数量，交易量恢复初始值 

      //OP_BUY     0      Buy operation
      //OP_SELL    1      Sell operation

      if(OrderType()==0 && mktSignal=="Buy" && OrdersTotal()<=Order_Total && Bid>OrderOpenPrice())//追加买入订单 
        {
         TicketNo=OrderSend(Symbol(),OP_BUY,iiLots,Ask,0,0,0);
         Draw_Mark(TicketNo);
         iBet_Order=iBet_Order+1;//加倍订单计数 
        }

      //止损平仓。如果出现反向信号，平掉所有订单 
      if(OrderType()==0 && mktSignal=="Sell")
        {
         for(int G_Count=OrdersTotal();G_Count>=0;G_Count--)
           {
            if(OrderSelect(G_Count,SELECT_BY_POS)==false) continue;
            else OrderClose(OrderTicket(),OrderLots(),OrderClosePrice(),0);//平仓 
            perProfit=perProfit+OrderProfit();//利润累加 
           }
         if(perProfit>=0)
            iLots=NewLots();
         //计算盈利后新开仓量 
         iBet_Order=0;//加倍订单变量清零 
        }

      if(OrderType()==1 && mktSignal=="Sell" && OrdersTotal()<=Order_Total && Ask<OrderOpenPrice())//追加卖出订单 
        {
         TicketNo=OrderSend(Symbol(),OP_SELL,iiLots,Bid,0,0,0);
         Draw_Mark(TicketNo);
         iBet_Order=iBet_Order+1;//加倍订单计数 
        }

      if(OrderType()==1 && mktSignal=="Buy")
        {
         for(int G_Count=OrdersTotal();G_Count>=0;G_Count--)
           {
            if(OrderSelect(G_Count,SELECT_BY_POS)==false)continue;
            else OrderClose(OrderTicket(),OrderLots(),OrderClosePrice(),0);//平仓 
            perProfit=perProfit+OrderProfit();//利润累加 
           }
         if(perProfit>=0)
            iLots=NewLots();
         //计算盈利后，更新开仓量 
         iBet_Order=0;//加倍订单变量清零 
        }
     }
   return(0);
  }
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
/* 计算账户余额，返回最新开仓量(手数) */
double NewLots()
  {
//计算开仓翻倍倍数, xRate = 当前盈利率/目标盈利率，  xRate已完成目标的比例。1已完成目标盈利率，0.5已完成一般目标盈利率
   double xRate=((AccountBalance()-Init_Balance)/Init_Balance)/(Profit_Rate/100);//取倍率的整数部分 //计算开仓手数 
   double xLots=NormalizeDouble(Init_Lots*xRate,2);//未完成目标盈利率，xLots=最小标准手，如果完成目标，xLots加大最小标准手。
   if(xLots<0.01)
      xLots=0.01;
   if(xRate>1)//完成目标盈利率，完成目标盈利率，加大最大开仓变量。
      xMax_Bet_Lots=Max_Bet_Lots*xRate;//如果翻倍倍数大于1，才计算最大浮动开仓量变量 
   return(xLots);
  }
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+


/* 根据市场信号开新仓，带开仓量参数 */
void Open_New_Order(double MyLots)
  {
   double myLossStop=300;
   double myTakeProfit=300;

   double BuyLossStop=Ask-myLossStop*Point;
   double BuyTakeProfit=Ask+myTakeProfit*Point;
   double SellLossStop=Bid+myLossStop*Point;
   double SellTakeProfit=Bid-myTakeProfit*Point;

   if(ReturnMarketInfomation()=="Buy")
      TicketNo=OrderSend(Symbol(),OP_BUY,MyLots,Ask,0,0,0);
   if(ReturnMarketInfomation()=="Sell")
      TicketNo=OrderSend(Symbol(),OP_SELL,MyLots,Bid,0,0,0);
   Draw_Mark(TicketNo);
  }
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
/* 判断MACD以及市场价格，提交"Buy"和"Sell"信号 */
string ReturnMarketInfomation()
  {
   string MktInfo="N/A";
   double MACD_0=iMACD(NULL,0,10,60,1,PRICE_CLOSE,MODE_SIGNAL,0);
   double MACD_2=iMACD(NULL,0,10,60,1,PRICE_CLOSE,MODE_SIGNAL,10);
   double price_0=Close[0];
   double price_high_2=High[2];
   double price_low_2=Low[2];
   if(MACD_0>(MACD_2+0.00003) && price_0>price_high_2)
     {
      MktInfo="Sell";
     }
   else if(MACD_0<(MACD_2-0.00003) && price_0<price_low_2)
     {
      MktInfo="Buy";
     }
   return(MktInfo);
  }
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
/* 函数：在屏幕上显示标签 LableName：标签名称；LableDoc：文本内容；LableX：标签X位置；LableY：标签Y位置； DocSize：文本字号；DocStyle：文本字体；DocColor：文本颜色 */
void SetLable(string LableName,string LableDoc,int LableX,int LableY,int DocSize,string DocStyle,color DocColor)
  {
   ObjectCreate(LableName,OBJ_LABEL,0,0,0);
   ObjectSetText(LableName,LableDoc,DocSize,DocStyle,DocColor);
   ObjectSet(LableName,OBJPROP_XDISTANCE,LableX);
   ObjectSet(LableName,OBJPROP_YDISTANCE,LableY);
  }
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
/* 函数：在屏幕上做开仓标记，红色箭头为卖出订单，绿色箭头为买入订单 MyTicket：订单号 */
void Draw_Mark(int MyTicket)
  {
   string ArrowMyTicket="Arrow:"+DoubleToStr(MyTicket,0);
   OrderSelect(OrdersTotal()-1,SELECT_BY_POS);//选定当前订单 
                                              //建立箭头模型 
   int ArrowValue;color ArrowColor;
   if(OrderType()==0)
     {
      ArrowValue=221;
      ArrowColor=Green;
     }
   if(OrderType()==1)
     {
      ArrowValue=222;
      ArrowColor=Red;
     }
   ObjectCreate(ArrowMyTicket,OBJ_ARROW,0,Time[0],OrderOpenPrice());
   ObjectSet(ArrowMyTicket,OBJPROP_ARROWCODE,ArrowValue);
//设置箭头，向上的箭头221，向下的箭头222 
   ObjectSet(ArrowMyTicket,OBJPROP_COLOR,ArrowColor);//设置箭头颜色，买入为Green，卖出为Red 
  }
//+------------------------------------------------------------------+
