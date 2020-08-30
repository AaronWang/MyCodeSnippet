//+------------------------------------------------------------------+
//|                                                  TestOneHour.mq4 |
//|                        Copyright 2016, MetaQuotes Software Corp. |
//|                                             https://www.mql5.com |
//+------------------------------------------------------------------+
#property copyright "Copyright 2016, MetaQuotes Software Corp."
#property link      "https://www.mql5.com"
#property version   "1.00"
#property strict
#include "../Libraries/OneHour.mq4"
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
OneHour *rules;
StrategyA *strategy;
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
void OnTick()
  {
//---
   if(rules==NULL)
      rules=new OneHour;
   double result=rules.MarketInfomation();
   if(result==1.0)
     {
      iDrawSign("GreenMark",Bid);//close[0];
     }
   if(result==-1.0)
     {
      iDrawSign("RedMark",Ask);
     }
   //Print("Stop lost point : "+stopLossPoint);
   
  }
//+------------------------------------------------------------------+
