//+------------------------------------------------------------------+
#property library
#property copyright "Copyright 2016, MetaQuotes Software Corp."
#property link      "https://www.mql5.com"
#property version   "1.00"
#property strict
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
class Order
{
private:
public:
   int               ticket;
   string            symbol;
   double            lots;
   int               type;//OP_BUY OP_SELL OP_BUYLIMIT OP_SELLLIMIT OP_BUYSTOP OP_SELLSTOP
   double            openPrice;
   double            closePrice;
   datetime          closeTime;
   double            stopLoss;
   double            takeProfit;
   color             arrow_color;
   double            result;//money got or lost

   void order()
     {
      ticket= 0;
      result=0;
     }
     //订单类型
   bool open(int myType,double myLots,int myLossStop,int myTakeProfit)
     {
      type = myType;
      lots = myLots;
      symbol=Symbol();
      closePrice=0;
      closeTime=0;

      double gap=Ask-Bid;
      if(myType==OP_BUY)
        {
         stopLoss=NormalizeDouble(Ask-myLossStop*Point-gap,Digits);
         takeProfit=NormalizeDouble(Ask+myTakeProfit*Point+gap,Digits);
         openPrice=Ask;
        }
      if(myType==OP_SELL)
        {
         stopLoss=NormalizeDouble(Bid+myLossStop*Point+gap,Digits);
         takeProfit=NormalizeDouble(Bid-myTakeProfit*Point-gap,Digits);
         openPrice=Bid;
        }
      if(myLossStop<=0)//如果止损参数为0 
        {
         stopLoss=0;
        }
      if(myTakeProfit<=0)//如果止赢参数为0 
        {
         takeProfit=0;
        }

      int mySPREAD=(int)MarketInfo(Symbol(),MODE_SPREAD);//获取市场滑点 

      ticket=OrderSend(Symbol(),myType,myLots,openPrice,mySPREAD,stopLoss,takeProfit);
      if(ticket == -1)return false;
      else return true;
     }
   bool close()
     {
      if(OrderSelect(ticket,SELECT_BY_TICKET))
        {
         closeTime=OrderCloseTime();
         int mySPREAD=(int)MarketInfo(Symbol(),MODE_SPREAD);//获取市场滑点 
         if(closeTime==0)
           {
            if(OrderClose(ticket,lots,OrderClosePrice(),mySPREAD))
              {
               closePrice=OrderClosePrice();
               closeTime = TimeCurrent();
               return true;
              }
            return false;
           }
         else
            return true;
        }
      return false;
     }
   //+------------------------------------------------------------------+
   //|                                                                  |
   //+------------------------------------------------------------------+
   bool modify(int myLossStop,int myTakeProfit)
     {
      double gap=Ask-Bid;
      if(type==OP_BUY)
        {
         stopLoss=NormalizeDouble(Ask-myLossStop*Point-gap,Digits);
         takeProfit=NormalizeDouble(Ask+myTakeProfit*Point+gap,Digits);
        }
      if(type==OP_SELL)
        {
         stopLoss=NormalizeDouble(Bid+myLossStop*Point+gap,Digits);
         takeProfit=NormalizeDouble(Bid-myTakeProfit*Point-gap,Digits);
        }
      if(myLossStop<=0)//如果止损参数为0 
        {
         stopLoss=0;
        }
      if(myTakeProfit<=0)//如果止赢参数为0 
        {
         takeProfit=0;
        }
      return OrderModify(ticket,openPrice,stopLoss,takeProfit,0);
     }
   //+------------------------------------------------------------------+
   //|                                                                  |
   //+------------------------------------------------------------------+
   bool deleteOrder()
     {//delete pending order;
      return OrderDelete(ticket);
     }
   //+------------------------------------------------------------------+
   //|                                                                  |
   //+------------------------------------------------------------------+
   double profit()
     {
      if(OrderSelect(ticket,SELECT_BY_TICKET))
         return OrderProfit();
      else return 0.0;
     }
   //+------------------------------------------------------------------+
   //|                                                                  |
   //+------------------------------------------------------------------+
   bool reachStopLoss()
     {
      OrderSelect(ticket,SELECT_BY_TICKET);
      closePrice=OrderClosePrice();
      if(closePrice == 0)return false;
      else
        {
         if(type==OP_BUY)
           {
            if(closePrice<=stopLoss)
               return true;
           }
         if(type==OP_SELL)
           {
            if(closePrice>=stopLoss)
               return true;
           }
         return false;
        }
     }
   //+------------------------------------------------------------------+
   //|                                                                  |
   //+------------------------------------------------------------------+
   bool reachTakeProfit()
     {
      OrderSelect(ticket,SELECT_BY_TICKET);
      closePrice=OrderClosePrice();
      if(closePrice == 0)return false;
      else
        {
         if(type==OP_BUY)
           {
            if(closePrice>=takeProfit)
               return true;
           }
         if(type==OP_SELL)
           {
            if(closePrice<=takeProfit)
               return true;
           }
        }
      return false;
     }
   //+------------------------------------------------------------------+
   //|                                                                  |
   //+------------------------------------------------------------------+
   void Run()
     {
      OrderSelect(ticket,SELECT_BY_TICKET);
      if(type==OP_BUY)
        {
         if(true)
           {
            if(type==OP_SELL)
              {

              }
           }
        }
     }
   void TrailingStop(int myStopLoss)
     {
      if(OrderSelect(ticket,SELECT_BY_TICKET)==false) return;
      else
        {
         //Close[0]  等于 Bid 值， 不受 图表周期影响，因为是当前柱
         if(OrderProfit()>0 && OrderType()==OP_BUY && ((Bid-OrderStopLoss())>(myStopLoss)*Point))
           {
            OrderModify(ticket,openPrice,Bid-Point*myStopLoss,takeProfit,0);
           }
         if(OrderProfit()>0 && OrderType()==OP_SELL && ((OrderStopLoss()-Ask)>(myStopLoss)*Point))
           {
            OrderModify(ticket,openPrice,Ask+Point*myStopLoss,takeProfit,0);
           }
        }
     }
   //+------------------------------------------------------------------+
   //|                                                                  |
   //+------------------------------------------------------------------+
   bool isClosed()
     {
      if(OrderSelect(ticket,SELECT_BY_TICKET))
        {
         closeTime=OrderCloseTime();
         if(closeTime == 0)return false;
         else
           {
            result=OrderProfit();
            return true;
           }
        }
      return false;
     }
   double getResult()
     {
      return result;
     }
   double getLots()
     {
      return lots;
     }
   double getType()
     {
      return type;
     }
  };
//+------------------------------------------------------------------+ 
//止损只赢的点差：（小数点最后一位，为一个点） ask bid 之间点差 25左右
int iOpenOrders(string myType,double myLots,int myLossStop,int myTakeProfit)
  {
   int mySPREAD=(int)MarketInfo(Symbol(),MODE_SPREAD);//获取市场滑点 
   double BuyLossStop=Bid-myLossStop*Point;
   double BuyTakeProfit=Bid+myTakeProfit*Point;
   double SellLossStop=Ask+myLossStop*Point;
   double SellTakeProfit=Ask-myTakeProfit*Point;
   if(myLossStop<=0)//如果止损参数为0 
     {
      BuyLossStop=0;
      SellLossStop=0;
     }
   if(myTakeProfit<=0)//如果止赢参数为0 
     {
      BuyTakeProfit=0;
      SellTakeProfit=0;
     }
   if(myType=="Buy")
      return OrderSend(Symbol(),OP_BUY,myLots,Ask,mySPREAD,BuyLossStop,BuyTakeProfit);
   if(myType=="Sell")
      return OrderSend(Symbol(),OP_SELL,myLots,Bid,mySPREAD,SellLossStop,SellTakeProfit);
   return 0;
  }
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
/* 
函数：持仓单平仓 
平仓类型：Buy多头订单、Sell空头订单、Profit盈利订单、Loss亏损订单、All全部订单 */
//+------------------------------------------------------------------+
void iCloseOrders(string myType)
  {
   int CO_cnt;//订单计数器 
   if(OrderSelect(OrdersTotal()-1,SELECT_BY_POS)==false) return;//选择当前持仓订单 
   if(myType=="All")
     {
      for(CO_cnt=OrdersTotal();CO_cnt>=0;CO_cnt--)
        {
         if(OrderSelect(CO_cnt,SELECT_BY_POS)==false) continue;
         else OrderClose(OrderTicket(),OrderLots(),OrderClosePrice(),0);
        }
     }
   if(myType=="Buy")//平掉所有多头订单 
     {
      for(CO_cnt=OrdersTotal();CO_cnt>=0;CO_cnt--)
        {
         if(OrderSelect(CO_cnt,SELECT_BY_POS)==false) continue;
         else if(OrderType()==0) OrderClose(OrderTicket(),OrderLots(),OrderClosePrice(),0);
        }
     }
   if(myType=="Sell")//平掉所有空头订单 
     {
      for(CO_cnt=OrdersTotal();CO_cnt>=0;CO_cnt--)
        {
         if(OrderSelect(CO_cnt,SELECT_BY_POS)==false) continue;
         else if(OrderType()==1) OrderClose(OrderTicket(),OrderLots(),OrderClosePrice(),0);
        }
     }
   if(myType=="Profit")//平掉所有盈利订单 
     {
      for(CO_cnt=OrdersTotal();CO_cnt>=0;CO_cnt--)
        {
         if(OrderSelect(CO_cnt,SELECT_BY_POS)==false) continue;
         else if(OrderProfit()>0) OrderClose(OrderTicket(),OrderLots(),OrderClosePrice(),0);
        }
     }
   if(myType=="Loss")
     {
      for(CO_cnt=OrdersTotal();CO_cnt>=0;CO_cnt--)
        {
         if(OrderSelect(CO_cnt,SELECT_BY_POS)==false) continue;
         else if(OrderProfit()<0) OrderClose(OrderTicket(),OrderLots(),OrderClosePrice(),0);
        }
     }
  }
//账户最大开仓量
//AccountEquity 账户资产净值
//Symbol 当前货币对
//MarketInfo 返回保证金列表margin
double maxLots()
  {
//Print("Equity"+AccountEquity());
//Print(MarketInfo(Symbol(),MODE_MARGINREQUIRED));
   return NormalizeDouble((AccountEquity()/MarketInfo(Symbol(),MODE_MARGINREQUIRED)),2);
  }
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
/* 函数：移动止损 
   参数说明：myStopLoss预设止损点数 
   功能说明：遍历所有持仓订单，当持仓单获利达到止损点数时，修改止损价位 */

void iMoveStopLoss(int myStopLoss)
  {
   int MSLCnt;//订单计数器 
   if(OrderSelect(OrdersTotal()-1,SELECT_BY_POS)==false) return;//选择当前订单 
   if(OrdersTotal()>0)
     {
      for(MSLCnt=OrdersTotal();MSLCnt>=0;MSLCnt--)
        {
         if(OrderSelect(MSLCnt,SELECT_BY_POS)==false) continue;
         else
           {
            //Close[0]  等于 Bid 值， 不受 图表周期影响，因为是当前柱
            if(OrderProfit()>0 && OrderType()==OP_BUY && ((Close[0]-OrderStopLoss())>((2*myStopLoss)*Point)))
              {
               OrderModify(OrderTicket(),OrderOpenPrice(),Bid-Point*myStopLoss,OrderTakeProfit(),0);
              }
            if(OrderProfit()>0 && OrderType()==OP_SELL && ((OrderStopLoss()-Close[0])>((2*myStopLoss)*Point)))
              {
               OrderModify(OrderTicket(),OrderOpenPrice(),Ask+Point*myStopLoss,OrderTakeProfit(),0);
              }
           }
        }
     }
  }
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
/* 函数：两点之间画线 
   参数说明：myFirstTime 第一点时间, myFirstPrice 第一点价格, mySecondTime第二点时间, mySecondPrice第二点价格 */
//Color: Red,Green,
void iDrawLine(double Color,int myFirstTime,double myFirstPrice,int mySecondTime,double mySecondPrice)
  {
   int LineNo=0;
   string myObjectName="Line"+LineNo;
   ObjectCreate(myObjectName,OBJ_TREND,0,Time[myFirstTime],myFirstPrice,Time[mySecondTime],mySecondPrice);
   ObjectSet(myObjectName,OBJPROP_COLOR,Color);
   ObjectSet(myObjectName,OBJPROP_STYLE,STYLE_DOT);
   ObjectSet(myObjectName,OBJPROP_WIDTH,1);
   ObjectSet(myObjectName,OBJPROP_BACK,false);
   ObjectSet(myObjectName,OBJPROP_RAY,false);
//i++;
  }
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
/* 函数：标注符号 
   红箭头为卖出，绿箭头为买入，红绿圆圈为其他标记 
   参数说明：
         mySignal变量包括
            Buy-买入箭头 
            Sell-卖出箭头 
            GreenMark-绿色圆圈 
            RedMark-红色圆圈 
         myPrice当前价格，符号标注位 */
void iDrawSign(string mySignal,double myPrice)
  {
   if(mySignal=="Buy")
     {
      ObjectCreate("BuyPoint-"+Time[0],OBJ_ARROW,0,Time[0],myPrice);
      ObjectSet("BuyPoint-"+Time[0],OBJPROP_COLOR,Green);
      ObjectSet("BuyPoint-"+Time[0],OBJPROP_ARROWCODE,241);
     }
   if(mySignal=="Sell")
     {
      ObjectCreate("SellPoint-"+Time[0],OBJ_ARROW,0,Time[0],myPrice);
      ObjectSet("SellPoint-"+Time[0],OBJPROP_COLOR,Red);
      ObjectSet("SellPoint-"+Time[0],OBJPROP_ARROWCODE,242);
     }
   if(mySignal=="GreenMark")
     {
      ObjectCreate("GreenMark-"+Time[0],OBJ_ARROW,0,Time[0],myPrice);
      ObjectSet("GreenMark-"+Time[0],OBJPROP_COLOR,Green);
      ObjectSet("GreenMark-"+Time[0],OBJPROP_ARROWCODE,162);
     }
   if(mySignal=="RedMark")
     {
      ObjectCreate("RedMark-"+Time[0],OBJ_ARROW,0,Time[0],myPrice);
      ObjectSet("RedMark-"+Time[0],OBJPROP_COLOR,Red);
      ObjectSet("RedMark-"+Time[0],OBJPROP_ARROWCODE,162);
     }
  }
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
/* 函数：在屏幕上显示标签 LableName：标签名称；LableDoc：文本内容；LableX：标签X位置；LableY：标签Y位置； DocSize：文本字号；DocStyle：文本字体；DocColor：文本颜色 */
//在屏幕固定位置设置标签。
void SetLabel(string LableName,string LableDoc,int LableX,int LableY,int DocSize,string DocStyle,color DocColor)
  {
   ObjectCreate(LableName,OBJ_LABEL,0,0,0);
   ObjectSetText(LableName,LableDoc,DocSize,DocStyle,DocColor);
   ObjectSet(LableName,OBJPROP_XDISTANCE,LableX);
   ObjectSet(LableName,OBJPROP_YDISTANCE,LableY);
  }
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
void SetLabelOnBar(string LableName,string LableDoc,double price,int DocSize,string DocStyle,color DocColor)
  {
   ObjectCreate(LableName+" "+Time[0],OBJ_TEXT,0,Time[0],price);
   ObjectSetText(LableName+" "+Time[0],LableDoc,DocSize,DocStyle,DocColor);
  }
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
int LineCrossTest(double lineA0,double lineA1,double lineA2,double lineB0,double lineB1,double lineB2)
  {
   if(lineA0>lineB0 && lineA1<lineB1 && lineA2<lineB2)
     {
      return 1;
     }
//if(lineA0>lineB0 && lineA1>lineB1 && lineA2<lineB2)// add
// {
// return 1;
// }

   if(lineA0<lineB0 && lineA1>lineB1 && lineA2>lineB2)
     {
      return -1;
     }
//if(lineA0<lineB0 && lineA1<lineB1 && lineA2>lineB2)//add
// {
//  return -1;
// }
   return 0;
  }
//+------------------------------------------------------------------+
//倒叙，A0 当前点，A1 之前一个点
//A线下行 返回 -1； A线上行 返回 1；
int LineCrossPoint(double lineA0,double lineA1,double lineB0,double lineB1)
  {
   if(lineA0>lineB0 && lineA1<lineB1)
     {
      return 1;
     }

   if(lineA0<lineB0 && lineA1>lineB1)
     {
      return -1;
     }
   return 0;
  }
//+------------------------------------------------------------------+
