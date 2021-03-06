//+------------------------------------------------------------------+
//|                                                      AUD-CHF.mq4 |
//|                        Copyright 2019, MetaQuotes Software Corp. |
//|                                             https://www.mql5.com |
//+------------------------------------------------------------------+
#property copyright "Copyright 2019, MetaQuotes Software Corp."
#property link      "https://www.mql5.com"
#property version   "1.00"
#property strict
#include "../../Libraries/BasicFunc.mq4"

//--- input parameters
input int   Gap = 1000; //每两个订单之间的距离
input double lotSize = 0.01;
input int sellLimit = 1; // number of sell limit order
static Order ordersSell[300];
static Order sellLimitOrder[10];
static Order highestOrder;
static int activeOrderNumber;
static int pendingOrderNumber;
static double pendingOrderOpenPrice;
//+------------------------------------------------------------------+
//| Expert initialization function                                   |
//+------------------------------------------------------------------+
int OnInit()
  {
//---
   Print("current symbol : "+Symbol());
//---
   return(INIT_SUCCEEDED);
  }
//+------------------------------------------------------------------+
//| Expert deinitialization function                                 |
//+------------------------------------------------------------------+
void OnDeinit(const int reason)
  {
//---

  }
//+------------------------------------------------------------------+
//| Expert tick function                                             |
//+------------------------------------------------------------------+
void OnTick()
  {
//---
//if(Symbol() != "USAZAR")
// return;
   int total = OrdersTotal();

//      Print("订单的总数：" + total);

//      part one
//      1. 获得所有订单
//      2. 如果没有设置获利，设置订单获利
   activeOrderNumber = 0;
   pendingOrderNumber = 0;
   pendingOrderOpenPrice = 0;
   highestOrder.openPrice = 0;

   for(int i = 0; i<total; i++)
     {
      if(OrderSelect(i,SELECT_BY_POS) == true && OrderSymbol() == Symbol())
        {
         if(OrderType() == OP_SELL)
           {

            ordersSell[activeOrderNumber].openPrice = OrderOpenPrice();
            ordersSell[activeOrderNumber].takeProfit = OrderTakeProfit();
            ordersSell[activeOrderNumber].ticket = OrderTicket();
            ordersSell[activeOrderNumber].type = OrderType();
            if(ordersSell[activeOrderNumber].takeProfit == 0)
              {
               //Print("Digits:",Digits); // Digits 等于 5
               ordersSell[activeOrderNumber].takeProfit = NormalizeDouble(ordersSell[activeOrderNumber].openPrice - Gap*1.5*Point,Digits);
               Print("print take profit : ",ordersSell[activeOrderNumber].takeProfit);
               if(Ask < ordersSell[activeOrderNumber].takeProfit)
                 {
                  if(OrderClose(OrderTicket(),OrderLots(),OrderClosePrice(),3,CLR_NONE))
                     return;
                 }
               if(OrderModify(OrderTicket(),OrderOpenPrice(),OrderStopLoss(),NormalizeDouble(ordersSell[activeOrderNumber].takeProfit,Digits),0))
                  Print("Modify order : adding takeprofit Successful.");
               else
                 {
                  ordersSell[activeOrderNumber].takeProfit  = 0;
                  Print("modify order : adding takeprofit Failed.");
                 }
              }
            if(highestOrder.openPrice < ordersSell[activeOrderNumber].openPrice)
              {
               highestOrder.ticket = ordersSell[activeOrderNumber].ticket;
               highestOrder.openPrice = ordersSell[activeOrderNumber].openPrice;
              }
            activeOrderNumber++;
           }
         else
            if(OrderType() == OP_SELLLIMIT)
               pendingOrderNumber++;
        }
     }
//特殊情况，1，没有一个active订单，也没有一个pending订单。新建一个lot = 0.01，takeprofit=gap*1.5 的订单
//      2.没有一个active订单，但是有pending订单。新建一个Lots*2，takeprofit = gap*2的订单
   if(activeOrderNumber == 0 && pendingOrderNumber == 0)
     {
      OrderSend(Symbol(),OP_SELL,lotSize,Bid,3,0,NormalizeDouble(Bid - Gap*1.5*Point,Digits),NULL,0,0,CLR_NONE);
      Sleep(2000);
      return;
     }
   if(activeOrderNumber == 0 && pendingOrderNumber != 0)
     {
      OrderSend(Symbol(),OP_SELL,lotSize*1,Bid,3,0,NormalizeDouble(Bid - Gap*2*Point,Digits),NULL,0,0,CLR_NONE);
      Sleep(2000);
      return;
     }

//      part two
//      1. 获得最小订单,part one 已经获得
//      2. 获得所有预设订单，selllimit
//      3. 修改所有预设订单和获利位置
   int s = 0;
   sellLimitOrder[0].ticket = 0;
   sellLimitOrder[1].ticket = 0;
   sellLimitOrder[2].ticket = 0;
   sellLimitOrder[3].ticket = 0;
   sellLimitOrder[4].ticket = 0;
   sellLimitOrder[0].openPrice = 100000;
   sellLimitOrder[1].openPrice = 100000;
   sellLimitOrder[2].openPrice = 100000;
   sellLimitOrder[3].openPrice = 100000;
   sellLimitOrder[4].openPrice = 100000;
   for(int i = 0; i < total; i++)
     {
      if(OrderSelect(i,SELECT_BY_POS) == true && OrderType() == OP_SELLLIMIT && OrderSymbol() == Symbol())
        {
         if(s >= sellLimit)
           {
            OrderDelete(OrderTicket());
            continue;
           }
         sellLimitOrder[s].ticket = OrderTicket();
         sellLimitOrder[s].openPrice = OrderOpenPrice();
         s ++;
        }
     }
// buy limit order 排序，最大的 OpenPrice 在4上面
   for(int i = 4; i >= 1; i--)
     {
      for(int j = i-1; j>=0; j--)
        {
         if(sellLimitOrder[i].openPrice < sellLimitOrder[j].openPrice)
           {
            int tmp = sellLimitOrder[i].ticket;
            sellLimitOrder[i].ticket = sellLimitOrder[j].ticket;
            sellLimitOrder[j].ticket = tmp;
            double tmp1 = sellLimitOrder[i].openPrice;
            sellLimitOrder[i].openPrice = sellLimitOrder[j].openPrice;
            sellLimitOrder[j].openPrice = tmp1;
            double tmp2 = sellLimitOrder[i].takeProfit;
            sellLimitOrder[i].takeProfit = sellLimitOrder[j].takeProfit;
            sellLimitOrder[j].takeProfit = tmp2;
           }
        }
     }

//first BuyLimit OpenPrice
   double pendingOrderOpenPrice = 0;
   double pendingOrderOpenPriceProfit = 0;
   int realposition = 0;
   for(int i = 0; i < sellLimit; i++)
     {
      pendingOrderOpenPrice = highestOrder.openPrice+(i+1)*Gap*Point;
      pendingOrderOpenPriceProfit = NormalizeDouble(pendingOrderOpenPrice-1.5*Gap*Point,Digits);
      //1. Pending order 是否存在 ，a,存在，移动或删除或不动。 b 不存在，创建或者不创建
      if(sellLimitOrder[realposition].ticket == 0)
        {
         // pending order 不存在，就先建一个pending order
         if(pendingOrderOpenPrice > Bid)
           {
            sellLimitOrder[realposition].ticket = OrderSend(Symbol(),OP_SELLLIMIT,lotSize,pendingOrderOpenPrice,3,0,pendingOrderOpenPriceProfit,NULL,0,0,CLR_NONE);
            realposition++;
           }
        }
      else
        {
         // pending order 在它应该在的地方，就不动，否则移动或者删除
         if(pendingOrderOpenPrice > Bid)//相互匹配
           {
            if(MathAbs(sellLimitOrder[realposition].openPrice-pendingOrderOpenPrice) > Point*3)
              {
               //移动，移动不成功，就删除。
               if(OrderModify(sellLimitOrder[realposition].ticket,pendingOrderOpenPrice,0,pendingOrderOpenPriceProfit,0,CLR_NONE) == false)
                  OrderDelete(sellLimitOrder[realposition].ticket);
              }
            realposition++;
           }
        }
     }
//没有一个 pending 订单，并且Bid 已经大幅上涨。
   if(sellLimitOrder[1].ticket == 0 && sellLimitOrder[2].ticket == 0 && highestOrder.openPrice + Gap*Point*2 < Bid)
     {
      OrderSend(Symbol(),OP_SELL,lotSize,Bid,3,0,0,NULL,0,0,CLR_NONE);
     }
  }
//+------------------------------------------------------------------+
