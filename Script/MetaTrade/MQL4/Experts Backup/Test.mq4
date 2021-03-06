//+------------------------------------------------------------------+
//|                                                         Test.mq4 |
//|                        Copyright 2016, MetaQuotes Software Corp. |
//|                                             https://www.mql5.com |
//+------------------------------------------------------------------+
#property copyright "Copyright 2016, MetaQuotes Software Corp."
#property link      "https://www.mql5.com"
#property version   "1.00"
#property strict
#include "../Libraries/BasicFunc.mq4"

input int trend=0;//趋势方向，1涨-1跌
input double highRange;//最大值 范围
input double lowRang;// 最小值范围

input int gridSize=45;//常规网格
                      //input int gridSize=5;//常规网格 test

input int gridSizeOnTrend=30;//趋势方向 网格
input int gridSizeOffTrend=60;//非趋势方向 网格

input double lotsSize=0.01;//单子大小

//+------------------------------------------------------------------+
//| Expert initialization function                                   |
//+------------------------------------------------------------------+

static Order ordersBuy[2000];
static Order ordersSell[2000];
static int orderBuySize=0;
static int orderSellSize=0;
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
int OnInit()
  {
   Print("current symbol : "+Symbol());
   
   orderBuySize = 0;
   orderSellSize = 0;
   string symbol=Symbol();
   int G_Count=OrdersTotal();
   for(int i=0;i<G_Count;i++)
     {
      OrderSelect(i,SELECT_BY_POS);
      if(OrderSymbol()==symbol)
        {
         //Print("order symbol : "+OrderSymbol());
         //Print("order ticket : "+OrderTicket());
         //Print("order lots : "+OrderLots());
         //Print("order type : "+OrderType());
         //Print("order openPrice : "+OrderOpenPrice());
         //Print("order status : ");
         //Print("order closePrice : "+OrderClosePrice());// current price
         //Print("order closeTime : "+OrderCloseTime());//current time
         //Print("order stopLoss : "+OrderStopLoss());
         //Print("order takeProfit : "+OrderTakeProfit());
         if(OrderType()==OP_BUY)
           {
            ordersBuy[orderBuySize].symbol = OrderSymbol();
            ordersBuy[orderBuySize].ticket = OrderTicket();
            ordersBuy[orderBuySize].stopLoss=OrderStopLoss();
            ordersBuy[orderBuySize].takeProfit=OrderTakeProfit();
            ordersBuy[orderBuySize].type=OrderType();
            ordersBuy[orderBuySize].openPrice=OrderOpenPrice();
            ordersBuy[orderBuySize].closePrice= 0;
            ordersBuy[orderBuySize].closeTime = 0;
            ordersBuy[orderBuySize].lots=OrderLots();
            orderBuySize++;
           }
         if(OrderType()==OP_SELL)
           {
            ordersSell[orderSellSize].symbol = OrderSymbol();
            ordersSell[orderSellSize].ticket = OrderTicket();
            ordersSell[orderSellSize].stopLoss=OrderStopLoss();
            ordersSell[orderSellSize].takeProfit=OrderTakeProfit();
            ordersSell[orderSellSize].type=OrderType();
            ordersSell[orderSellSize].openPrice=OrderOpenPrice();
            ordersSell[orderSellSize].closePrice= 0;
            ordersSell[orderSellSize].closeTime = 0;
            ordersSell[orderSellSize].lots=OrderLots();
            orderSellSize++;
           }
        }
     }
//---
   return(INIT_SUCCEEDED);
  }
//+------------------------------------------------------------------+
//| Expert deinitialization function                                 |
//+------------------------------------------------------------------+
void OnDeinit(const int reason)
  {
//---
   if(Ask<=Bid)
     {
      iDrawSign("Sell",Ask);
      Print("999999999999999999999999999999999999999999999");
     }
  }
//+------------------------------------------------------------------+
//| Expert tick function                                             |
//+------------------------------------------------------------------+
void OnTick()
  {
//---
   ArrayClean();
   MakingOrderSituation();
// test buy situation
// test sell situation


  }
//+------------------------------------------------------------------+

void AddOrderIntoArray(Order &o)
  {
//insert into array, arraysize ++
   if(o.type==OP_BUY)
     {
      if(orderBuySize==0)//没有order 存在
        {
         CopyOrder(o,ordersBuy[orderBuySize]);
         orderBuySize++;
         return;
        }
      else
        {
         if(o.openPrice<ordersBuy[0].openPrice)//下部
           {
            InsertOrderPosition(o,0);
           }
         else if(o.openPrice>ordersBuy[orderBuySize-1].openPrice)//上部
           {
            CopyOrder(o,ordersBuy[orderBuySize]);
            orderBuySize++;
           }
         else//中间
           {
            for(int i=0;i<orderBuySize-1;i++)
              {
               if(o.openPrice>ordersBuy[i].openPrice && o.openPrice<ordersBuy[i+1].openPrice)
                 {
                  InsertOrderPosition(o,i+1);
                  return;
                 }
              }
           }
        }
     }
   else if(o.type==OP_SELL)
     {
      if(orderSellSize==0)//没有order 存在
        {
         CopyOrder(o,ordersSell[orderSellSize]);
         orderSellSize++;
         return;
        }
      else
        {
         if(o.openPrice<ordersSell[0].openPrice)//下部
           {
            InsertOrderPosition(o,0);
           }
         else if(o.openPrice>ordersSell[orderSellSize-1].openPrice)//上部
           {
            CopyOrder(o,ordersSell[orderSellSize]);
            orderSellSize++;
           }
         else//中间
           {
            for(int i=0;i<orderSellSize-1;i++)
              {
               if(o.openPrice>ordersSell[i].openPrice && o.openPrice<ordersSell[i+1].openPrice)
                 {
                  InsertOrderPosition(o,i+1);
                  return;
                 }
              }
           }
        }
     }
  }
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
void InsertOrderPosition(Order &o,int pos)//pos 包括0位置
  {//插入 定点数列

   if(o.type==OP_BUY)
     {
      for(int i=orderBuySize-1;i>=pos;i--)
        {
         CopyOrder(ordersBuy[i],ordersBuy[i+1]);
        }
      CopyOrder(o,ordersBuy[pos]);
      orderBuySize++;
      return;
     }
   if(o.type==OP_SELL)
     {
      for(int i=orderSellSize-1;i>=pos;i--)
        {
         CopyOrder(ordersSell[i],ordersSell[i+1]);
        }
      CopyOrder(o,ordersSell[pos]);
      orderSellSize++;
      return;
     }
  }
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
void RemoveOrderBuy(int pos)
  {
   for(int i=pos;i<orderBuySize-1;i++)
     {
      CopyOrder(ordersBuy[i+1],ordersBuy[i]);
     }
   orderBuySize--;
  }
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
void RemoveOrderSell(int pos)
  {
   for(int i=pos;i<orderSellSize-1;i++)
     {
      CopyOrder(ordersSell[i+1],ordersSell[i]);
     }
   orderSellSize--;
  }
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
void CopyOrder(Order &from,Order &to)
  {
   to.ticket = from.ticket;
   to.symbol = from.symbol;
   to.lots = from.lots;
   to.type = from.type;
   to.openPrice=from.openPrice;
   to.closePrice= from.closePrice;
   to.closeTime = from.closeTime;
   to.stopLoss=from.stopLoss;
   to.takeProfit=from.takeProfit;
   to.arrow_color=from.arrow_color;
   to.result=from.result;
  }
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
void ArrayClean()
  {
//remove the closed orders.
   for(int i=0;i<orderBuySize;i++)
     {
      if(ordersBuy[i].isClosed())
        {
         RemoveOrderBuy(i);
         i--;
        }
     }
   for(int i=0;i<orderSellSize;i++)
     {
      if(ordersSell[i].isClosed())
        {
         RemoveOrderSell(i);
         i--;
        }
     }
  }
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
void MakingOrderSituation()
  {
   double buyPrice=Ask;  //数值大， 买 要花大价钱，得到的是bid的价钱
   double sellPrice=Bid; //数值小   卖 要花小价钱，得到的是Ask的价钱

   Print("start making dicision :  Ask = "+Ask+"   Bid = "+Bid+"---------------------------------------------");
   Print("Total Sell Order Number :         "+orderSellSize);
   Print("Total Buy  Order Number :         "+orderBuySize);
//Test Buy Situation
   if(orderBuySize==0)
     { // 没有一个 buy order
      //open first order
      //Print("First Buy Order !!!!!!!!!!!!!!");
      OpenBuyOrder(0,gridSize*10);
     }
   else
     {
      if(buyPrice<ordersBuy[0].openPrice)
        {
         // smaler than smalest order price ;
         //Print("Sitation 1 : ");
         switch(trend)
           {
            case 1:
               if(ordersBuy[0].openPrice-buyPrice>gridSizeOnTrend*Point*10)
                 {
                  OpenBuyOrder(0,gridSizeOnTrend*10);
                 }
               break;
            case 0:
               if(ordersBuy[0].openPrice-buyPrice>gridSize*Point*10)
                 {
                  OpenBuyOrder(0,gridSize*10);
                 }
               break;
            case -1:
               if(ordersBuy[0].openPrice-buyPrice>gridSizeOffTrend*Point*10)
                 {
                  OpenBuyOrder(0,gridSizeOffTrend*10);
                 }
               break;
           }
        }
      else if(buyPrice>ordersBuy[orderBuySize-1].openPrice)
        {
         //Print("Sitation 2 : ");
         //biger than biggest order price;
         switch(trend)
           {
            case 1:
               if(buyPrice-ordersBuy[orderBuySize-1].openPrice>gridSizeOnTrend*Point*10)
                 {
                  OpenBuyOrder(0,gridSizeOnTrend*10);
                 }
               break;
            case 0:
               if(buyPrice-ordersBuy[orderBuySize-1].openPrice>gridSize*Point*10)
                 {
                  OpenBuyOrder(0,gridSize*10);
                 }
               break;
            case -1:
               if(buyPrice-ordersBuy[orderBuySize-1].openPrice>gridSizeOffTrend*Point*10)
                 {
                  OpenBuyOrder(0,gridSizeOffTrend*10);
                 }
               break;
           }
        }
      else
        {// in the middle
         //Print("Sitation 3 : ");
         for(int i=0;i<orderBuySize-1; i++)
           {
            if(buyPrice>ordersBuy[i].openPrice && buyPrice<ordersBuy[i+1].openPrice)
              {
               switch(trend)
                 {
                  case 1:
                     if(buyPrice-ordersBuy[i].openPrice>gridSizeOnTrend*Point*10 && ordersBuy[i+1].openPrice-buyPrice>gridSizeOnTrend*Point*10)
                       {
                        OpenBuyOrder(0,gridSizeOnTrend*10);
                       }
                     break;
                  case 0:
                     if(buyPrice-ordersBuy[i].openPrice>gridSize*Point*10 && ordersBuy[i+1].openPrice-buyPrice>gridSize*Point*10)
                       {
                        OpenBuyOrder(0,gridSize*10);
                       }
                     break;
                  case -1:
                     if(buyPrice-ordersBuy[i].openPrice>gridSizeOffTrend*Point*10 && ordersBuy[i+1].openPrice-buyPrice>gridSizeOffTrend*Point*10)
                       {
                        OpenBuyOrder(0,gridSizeOffTrend*10);
                       }
                     break;
                 }
               return;
              }
           }
        }
     }
//Test Sell
   
   if(orderSellSize==0)
     { // 没有一个 Sell order
      //open first order
      Print("First Sell Order !!!!!!!!!!!!!!");
      OpenSellOrder(0,gridSize*10);
     }
   else
     {
      if(sellPrice<ordersSell[0].openPrice)
        {
         //Print("Sitation 1 : ");
         // smaler than smalest order price ;
         switch(trend)
           {
            case 1:
               if(ordersSell[0].openPrice-sellPrice>gridSizeOffTrend*Point*10)
                 {
                  OpenSellOrder(0,gridSizeOffTrend*10);
                 }
               break;
            case 0:
               if(ordersSell[0].openPrice-sellPrice>gridSize*Point*10)
                 {
                  OpenSellOrder(0,gridSize*10);
                 }
               break;
            case -1:
               if(ordersSell[0].openPrice-sellPrice>gridSizeOnTrend*Point*10)
                 {
                  OpenSellOrder(0,gridSizeOnTrend*10);
                 }
               break;
           }
        }
      else if(sellPrice>ordersSell[orderSellSize-1].openPrice)
        {
         //Print("Sitation 2 : ");
         //biger than biggest order price;
         switch(trend)
           {
            case 1:
               if(sellPrice-ordersSell[orderSellSize-1].openPrice>gridSizeOffTrend*Point*10)
                 {
                  OpenSellOrder(0,gridSizeOffTrend*10);
                 }
               break;
            case 0:
               if(sellPrice-ordersSell[orderSellSize-1].openPrice>gridSize*Point*10)
                 {
                  OpenSellOrder(0,gridSize*10);
                 }
               break;
            case -1:
               if(sellPrice-ordersSell[orderSellSize-1].openPrice>gridSizeOnTrend*Point*10)
                 {
                  OpenSellOrder(0,gridSizeOnTrend*10);
                 }
               break;
           }
        }
      else
        {// in the middle
         //Print("Sitation 3 : ");
         for(int i=0;i<orderSellSize-1; i++)
           {
            if(sellPrice>ordersSell[i].openPrice && sellPrice<ordersSell[i+1].openPrice)
              {
               switch(trend)
                 {
                  case 1:
                     if(sellPrice-ordersSell[i].openPrice>gridSizeOffTrend*Point*10 && ordersSell[i+1].openPrice-sellPrice>gridSizeOffTrend*Point*10)
                       {
                        OpenSellOrder(0,gridSizeOffTrend*10);
                       }
                     break;
                  case 0:
                     if(sellPrice-ordersSell[i].openPrice>gridSize*Point*10 && ordersSell[i+1].openPrice-sellPrice>gridSize*Point*10)
                       {
                        OpenSellOrder(0,gridSize*10);
                       }
                     break;
                  case -1:
                     if(sellPrice-ordersSell[i].openPrice>gridSizeOnTrend*Point*10 && ordersSell[i+1].openPrice-sellPrice>gridSizeOnTrend*Point*10)
                       {
                        OpenSellOrder(0,gridSizeOnTrend*10);
                       }
                     break;
                 }
               return;
              }
           }
        }
     }
  }
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
void OpenBuyOrder(int stopLostPoint,int  takeProfitPoint)
  {
   Order newOrder;
   newOrder.ticket=iOpenOrders("Buy",lotsSize,stopLostPoint,takeProfitPoint);
   OrderSelect(newOrder.ticket,SELECT_BY_TICKET);
   newOrder.symbol=OrderSymbol();
   newOrder.stopLoss=OrderStopLoss();
   newOrder.takeProfit=OrderTakeProfit();
   newOrder.type=OrderType();
   newOrder.openPrice=OrderOpenPrice();
   newOrder.closePrice= 0;
   newOrder.closeTime = 0;
   newOrder.lots=lotsSize;
   if(newOrder.ticket==0)
      return;
   AddOrderIntoArray(newOrder);
  }
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
void OpenSellOrder(int stopLostPoint,int takeProfitPoint)
  {
   Order newOrder;
   newOrder.ticket=iOpenOrders("Sell",lotsSize,stopLostPoint,takeProfitPoint);
   OrderSelect(newOrder.ticket,SELECT_BY_TICKET);
   newOrder.symbol=OrderSymbol();
   newOrder.stopLoss=OrderStopLoss();
   newOrder.takeProfit=OrderTakeProfit();
   newOrder.type=OrderType();
   newOrder.openPrice=OrderOpenPrice();
   newOrder.closePrice=0;
   newOrder.closeTime=0;
   newOrder.lots=lotsSize;
   if(newOrder.ticket==0)
      return;
   AddOrderIntoArray(newOrder);
  }
//+------------------------------------------------------------------+
