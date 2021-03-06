//+------------------------------------------------------------------+
//|                                            MovingAverageTest.mq4 |
//|                        Copyright 2016, MetaQuotes Software Corp. |
//|                                             https://www.mql5.com |
//+------------------------------------------------------------------+
#property copyright "Copyright 2016, MetaQuotes Software Corp."
#property link      "https://www.mql5.com"
#property version   "1.00"
#property strict

#include "../Libraries/BasicFunc.mq4"
#include "../Libraries/SimpleStrategy.mq4"
#include "../Libraries/MovingAverage.mq4"
#include "../Libraries/OrderStrategyA.mq4"
#include "../Libraries/StrategyA.mq4"
#include "../Libraries/StrategyB.mq4"
//#include "../Libraries/Tools.mq4"
//+------------------------------------------------------------------+
//| Expert initialization function                                   |
//+------------------------------------------------------------------+
int OnInit()
  {
//---

//---
   return(INIT_SUCCEEDED);
  }
//+------------------------------------------------------------------+
//| Expert deinitialization function                                 |
//+------------------------------------------------------------------+
void OnDeinit(const int reason)
  {
//---
   delete strategy;
  }

int stopLossPoint=1000;
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+

StrategyA *strategy;
StrategyB *strategyB;
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
void OnTick()
  {
//---
   double result=MarketInfomation_MovingAverage();
   if(result>=0.6)
     {
      iDrawSign("GreenMark",Bid);//close[0];
     }
   if(result<=-0.6)
     {
      iDrawSign("RedMark",Ask);
     }

   SimpleStrategy(result,stopLossPoint); //this is a test strategy
//----------here is strategy A-------------------------------------
// if(result==1) dayOrderStrategy("Buy");
// else if(result==-1)dayOrderStrategy("Sell");
// else dayOrderStrategy("N/A");
//--------------------------------------------------
//   if(strategy==NULL)
//   {
//  strategy=new StrategyA;
//strategy.setTrend(1);
//}
//else
// {
//strategy.Run(result,stopLossPoint);
//  strategy.Run(1,stopLossPoint);
// }
//--------------------------------------------------
   if(strategyB==NULL)
     {
      strategyB=new StrategyB;
     }
   else
     {
      strategyB.Run(result,250,0.01);
     }
//-------------------------------------------------
//updateLossTool(stopLossPoint);
//  iMoveStopLoss(stopLossPoint);
  }
//+------------------------------------------------------------------+
