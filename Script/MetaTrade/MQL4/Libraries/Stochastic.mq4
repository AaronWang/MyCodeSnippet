//+------------------------------------------------------------------+
//|                                                   Stochastic.mq4 |
//|                        Copyright 2016, MetaQuotes Software Corp. |
//|                                             https://www.mql5.com |
//+------------------------------------------------------------------+
#property library
#property copyright "Copyright 2016, MetaQuotes Software Corp."
#property link      "https://www.mql5.com"
#property version   "1.00"
#property strict
//+------------------------------------------------------------------+
#include "../Libraries/BasicFunc.mq4"
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
class Stochastic
  {
private:
   double            mainValue[10];
   double            signalValue[10];
   double            currentMarketInfo;
public:
   void Stochastic()
     {
      mainValue[0]=0;
      mainValue[1]=0;
      mainValue[2]=0;
      mainValue[3]=0;
      mainValue[4]=0;
      mainValue[5]=0;
      mainValue[6]=0;
      mainValue[7]=0;
      mainValue[8]=0;
      mainValue[9]=0;
      signalValue[0]=0;
      signalValue[1]=0;
      signalValue[2]=0;
      signalValue[3]=0;
      signalValue[4]=0;
      signalValue[5]=0;
      signalValue[6]=0;
      signalValue[7]=0;
      signalValue[8]=0;
      signalValue[9]=0;
     }
   void updateStochasticeValue()
     {
      mainValue[0] =     iStochastic(NULL,0,5,3,3,MODE_SMA,0,MODE_MAIN,0);
      mainValue[1] =     iStochastic(NULL,0,5,3,3,MODE_SMA,0,MODE_MAIN,1);
      mainValue[2] =     iStochastic(NULL,0,5,3,3,MODE_SMA,0,MODE_MAIN,2);
      mainValue[3] =     iStochastic(NULL,0,5,3,3,MODE_SMA,0,MODE_MAIN,3);
      mainValue[4] =     iStochastic(NULL,0,5,3,3,MODE_SMA,0,MODE_MAIN,4);
      mainValue[5] =     iStochastic(NULL,0,5,3,3,MODE_SMA,0,MODE_MAIN,5);
      mainValue[6] =     iStochastic(NULL,0,5,3,3,MODE_SMA,0,MODE_MAIN,6);
      mainValue[7] =     iStochastic(NULL,0,5,3,3,MODE_SMA,0,MODE_MAIN,7);
      mainValue[8] =     iStochastic(NULL,0,5,3,3,MODE_SMA,0,MODE_MAIN,8);
      mainValue[9] =     iStochastic(NULL,0,5,3,3,MODE_SMA,0,MODE_MAIN,9);

      signalValue[0] =   iStochastic(NULL,0,5,3,3,MODE_SMA,0,MODE_SIGNAL,0);
      signalValue[1] =   iStochastic(NULL,0,5,3,3,MODE_SMA,0,MODE_SIGNAL,1);
      signalValue[2] =   iStochastic(NULL,0,5,3,3,MODE_SMA,0,MODE_SIGNAL,2);
      signalValue[3] =   iStochastic(NULL,0,5,3,3,MODE_SMA,0,MODE_SIGNAL,3);
      signalValue[4] =   iStochastic(NULL,0,5,3,3,MODE_SMA,0,MODE_SIGNAL,4);
      signalValue[5] =   iStochastic(NULL,0,5,3,3,MODE_SMA,0,MODE_SIGNAL,5);
      signalValue[6] =   iStochastic(NULL,0,5,3,3,MODE_SMA,0,MODE_SIGNAL,6);
      signalValue[7] =   iStochastic(NULL,0,5,3,3,MODE_SMA,0,MODE_SIGNAL,7);
      signalValue[8] =   iStochastic(NULL,0,5,3,3,MODE_SMA,0,MODE_SIGNAL,8);
      signalValue[9] =   iStochastic(NULL,0,5,3,3,MODE_SMA,0,MODE_SIGNAL,9);
     }

   double MarketInfomation_Stochastice()
     {
      double predict=0.0;
      updateStochasticeValue();
      if(mainValue[0]>80 && mainValue[1]>80 && signalValue[0]>80 && signalValue[0]>80)
        {
         //predict=LineCrossPoint(mainValue[0],mainValue[1],signalValue[0],signalValue[1]);
         //if(predict==1)
         predict=-1;
        }
      if(mainValue[0]<20 && mainValue[1]<20 && signalValue[0]<20 && signalValue[0]<20)
        {
         //predict=LineCrossPoint(mainValue[0],mainValue[1],signalValue[0],signalValue[1]);
         //if(predict==-1)
         predict=1;
        }
      if(predict!=0)
         currentMarketInfo=predict;
      else
        {

        }
      return predict;
     }
  };
//+------------------------------------------------------------------+
