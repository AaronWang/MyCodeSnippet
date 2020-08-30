//+------------------------------------------------------------------+
//|                                          UpDownOrderStrategy.mq4 |
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
// int MyCalculator(int value,int value2) export
//   {
//    return(value+value2);
//   }
//+------------------------------------------------------------------+
class OrderPair
  {
private:
   int               maxLostOrderNum;
   order            *buyOrders[50];
   order            *sellOrders[50];
   int               buy,sell;
   int               stopLoss;
   int               takeProfit;
   bool              closeOneOrder;
   bool              closed;
   double            buyProfit;
   double            sellProfit;
public:
   void OrderPair(int maxLostOrderNum,int stopLoss,int takeProfit)
     {
      buy=1;
      sell=1;
      closeOneOrder=false;
      closed=false;
      this.stopLoss=stopLoss;
      this.takeProfit=takeProfit;
      this.maxLostOrderNum=maxLostOrderNum;
      buyOrders[0]=new order;
      buyOrders[0].open(OP_BUY,0.01,stopLoss,takeProfit);
      sellOrders[0]=new order;
      sellOrders[0].open(OP_SELL,0.01,stopLoss,takeProfit);
     }
   bool closeHalf()
     {
      return closeOneOrder;
     }
   bool Run()
     {
      if(closed)return closed;
      buyProfit=0;
      sellProfit=0;
      if(buy==1 && sell==1)
        {
         if(buyOrders[0].reachTakeProfit())
           {
            buy--;
            closeOneOrder=true;
            sellOrders[1]=new order;
            sellOrders[1].open(OP_SELL,0.02,stopLoss,takeProfit);
            sell++;
           }
         if(sellOrders[0].reachTakeProfit())
           {
            sell--;
            closeOneOrder=true;
            buyOrders[1]=new order;
            buyOrders[1].open(OP_BUY,0.02,stopLoss,takeProfit);
            buy++;
           }
         if(buy==1 && sell==1)return false;
        }

      if(buy==0 && sell==0)
        {
         closed=true;
         return true;
        }
      if(buy==maxLostOrderNum || sell==maxLostOrderNum)
        {
         closed=true;
         for(int i=0;i<buy;i++)
           {
            buyOrders[i].close();
           }
         for(int i=0;i<sell;i++)
           {
            sellOrders[i].close();
           }
         return true;
        }
      if(sell>1)
        {
         for(int i=0;i<sell;i++)
           {
            sellProfit+=sellOrders[i].profit();
           }
         if(sellProfit>=0.05)
           {
            for(int i=0;i<sell;i++)
              {
               sellOrders[i].close();
              }
            closed=true;
            return true;
           }
         else
           {
            if(Bid-sellOrders[sell-1].openPrice>takeProfit*Point)
              {
               sellOrders[sell]=new order;
               sellOrders[sell].open(OP_SELL,sellOrders[sell-1].lots*2,stopLoss,takeProfit);
               sell++;
              }
           }
        }
      if(buy>1)
        {
         for(int i=0;i<buy;i++)
           {
            buyProfit+=buyOrders[i].profit();
           }
         if(buyProfit>=0.05)
           {
            for(int i=0;i<buy;i++)
              {
               buyOrders[i].close();
              }
            closed=true;
            return true;
           }
         else
           {
            if(buyOrders[buy-1].openPrice-Ask>takeProfit*Point)
              {
               buyOrders[buy]=new order;
               buyOrders[buy].open(OP_BUY,buyOrders[buy-1].lots*2,stopLoss,takeProfit);
               buy++;
              }
           }
        }
      return closed;
     }
  };
//+------------------------------------------------------------------+
