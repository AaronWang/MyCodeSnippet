//+------------------------------------------------------------------+
//|                                               TestStochastic.mq4 |
//|                        Copyright 2016, MetaQuotes Software Corp. |
//|                                             https://www.mql5.com |
//+------------------------------------------------------------------+
#property copyright "Copyright 2016, MetaQuotes Software Corp."
#property link      "https://www.mql5.com"
#property version   "1.00"
#property strict
#include "../Libraries/BasicFunc.mq4"
#include "../Libraries/SimpleStrategy.mq4"
#include "../Libraries/MACD.mq4"
#include "../Libraries/OrderStrategyA.mq4"
#include "../Libraries/StrategyA.mq4"
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

int stopLossPoint=200;//stop lost should much larger than (Ask-Bid)/Point
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
MACD *rules;
StrategyA *strategy;
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
void OnTick()
  {
//---
   if(rules==NULL)
      rules=new MACD;
   double result=rules.MarketInfomation_MACD();
   if(result==1.0)
     {
      iDrawSign("GreenMark",Bid);//close[0];
     }
   if(result==-1.0)
     {
      iDrawSign("RedMark",Ask);
     }
 stopLossPoint=caculateStopLossPoint();
   Print("Stop lost pin : "+stopLossPoint);
//SimpleStrategy(result,stopLossPoint); //this is a test strategy
//----------here is strategy A-------------------------------------
// if(result==1) dayOrderStrategy("Buy");
// else if(result==-1)dayOrderStrategy("Sell");
// else dayOrderStrategy("N/A");
//--------------------------------------------------
//Print("Ask - Bid = "+(Ask-Bid)/Point);
   if(strategy==NULL)
     {
      strategy=new StrategyA;
      //strategy.setTrend(1);
     }
   else
     {
      strategy.Run(result,stopLossPoint);
      //  strategy.Run(1,stopLossPoint);
     }
//--------------------------------------------------
//updateLossTool(stopLossPoint);
//  iMoveStopLoss(stopLossPoint);
  }
//+------------------------------------------------------------------+
int caculateStopLossPoint()
  {
   double distance=0;
   for(int i=0;i<10;i++)
     {
      distance+=High[i]-Low[i];
     }
   distance=distance/10/2;

   return MathAbs(distance/Point);
  }
//+------------------------------------------------------------------+
