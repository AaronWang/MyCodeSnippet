//+------------------------------------------------------------------+
//|                                                        Tools.mq4 |
//|                        Copyright 2016, MetaQuotes Software Corp. |
//|                                             https://www.mql5.com |
//+------------------------------------------------------------------+
#property library
#property copyright "Copyright 2016, MetaQuotes Software Corp."
#property link      "https://www.mql5.com"
#property version   "1.00"
#property strict
//+------------------------------------------------------------------+
//| My function                                                      |
//+------------------------------------------------------------------+
// int MyCalculator(int value,int value2) export
//   {
//    return(value+value2);
//   }
//+------------------------------------------------------------------+

void updateLossTool(int stopLossPoint)
  {
   if(OrdersTotal()>0)
     {
      for(int G_Count=OrdersTotal();G_Count>=0;G_Count--)
        {
         if(OrderSelect(G_Count,SELECT_BY_POS)==false) continue;
         else
           {
            if(OrderType()==OP_SELL)
              {
               if(OrderStopLoss()==0)
                 {
                  OrderModify(OrderTicket(),OrderOpenPrice(),Ask+stopLossPoint*Point,OrderTakeProfit(),0,Blue);
                  return;
                 }
               if(OrderStopLoss()-Ask>stopLossPoint*Point)//盈利
                  //OrderModify(OrderTicket(),OrderOpenPrice(),OrderStopLoss() -(originalPrice-Ask),OrderTakeProfit()-(originalPrice-Ask),0,Blue);
                  OrderModify(OrderTicket(),OrderOpenPrice(),Ask+stopLossPoint*Point,OrderTakeProfit(),0,Blue);
              }
            if(OrderType()==OP_BUY)
              {
               if(OrderStopLoss()==0)
                 {
                  OrderModify(OrderTicket(),OrderOpenPrice(),Bid-stopLossPoint*Point,OrderTakeProfit(),0,Red);
                  return;
                 }
               if(Bid-OrderStopLoss()>stopLossPoint*Point)//盈利
                  //OrderModify(OrderTicket(),OrderOpenPrice(),OrderStopLoss()+(Bid-originalPrice),OrderTakeProfit()+(Bid-originalPrice),0,Red);
                  OrderModify(OrderTicket(),OrderOpenPrice(),Bid-stopLossPoint*Point,OrderTakeProfit(),0,Red);
              }
           }
        }
     }
  }
//+------------------------------------------------------------------+

