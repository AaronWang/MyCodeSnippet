//+------------------------------------------------------------------+
//|                                               SimpleStrategy.mq4 |
//|                        Copyright 2016, MetaQuotes Software Corp. |
//|                                             https://www.mql5.com |
//+------------------------------------------------------------------+
#property library
#property copyright "Copyright 2016, MetaQuotes Software Corp."
#property link      "https://www.mql5.com"
#property version   "1.00"
#property strict
#include "../Libraries/BasicFunc.mq4"
//+------------------------------------------------------------------+
//| My function                                                      |
//+------------------------------------------------------------------+

// -1 下跌 +1 上涨
void SimpleStrategy(double marketInfo,int stopLossPoint)
  {
   if(OrdersTotal()==0)
     {
      if(marketInfo==1.0)
        {
         //order *newOrder=new order;
         iOpenOrders("Buy",0.01,stopLossPoint,stopLossPoint);
        }
      if(marketInfo==-1.0)
        {
         iOpenOrders("Sell",0.01,stopLossPoint,stopLossPoint);
        }
     }
   else
     {
      OrderSelect(OrdersTotal()-1,SELECT_BY_POS);
      if(marketInfo==1.0)
        {
         iCloseOrders("Sell");
        }
      if(marketInfo==-1.0)
        {
         iCloseOrders("Buy");
        }
      //OrderOpenTime();//没有订单时，返回0
      //if(TimeCurrent()-OrderOpenTime()<=orderPeriod)//default 10分钟
      //return; //小于最小下单周期，返回
     }
  }
//+------------------------------------------------------------------+
