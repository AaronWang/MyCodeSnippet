//+------------------------------------------------------------------+
//|                                                MovingAverage.mq4 |
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
// Moving Average
double weekValue[4]={0,0,0,0};
int weekPeriod=1*24*60*60;//1 day;
double weekUpdateTime=0;

double dayValue[7]={0,0,0,0,0,0,0};
double dayValue7[7]={0,0,0,0,0,0,0};
int dayPeriod=1*60*60;//1 hour;
double dayUpdateTime=0;

double minValue[10]={0,0,0,0,0,0,0};
int minPeriod=10*60;//10 minues;
double minUpdateTime=0;

string trend="N/A";
//+------------------------------------------------------------------+
void updateMovingAverageValue()
  {
//update weekValue;
   if(TimeCurrent()-weekUpdateTime>weekPeriod)
     {
      weekUpdateTime=TimeCurrent();
      weekValue[0] = iMA(NULL,PERIOD_W1,14,0,MODE_EMA,PRICE_CLOSE,0);
      weekValue[1] = iMA(NULL,PERIOD_W1,14,0,MODE_EMA,PRICE_CLOSE,1);
      weekValue[2] = iMA(NULL,PERIOD_W1,14,0,MODE_EMA,PRICE_CLOSE,2);
      weekValue[3] = iMA(NULL,PERIOD_W1,14,0,MODE_EMA,PRICE_CLOSE,3);
     }
//update dayValue;
   if(TimeCurrent()-dayUpdateTime>dayPeriod)
     {
      dayUpdateTime=TimeCurrent();
      dayValue[0]=iMA(NULL,PERIOD_D1,14,0,MODE_EMA,PRICE_CLOSE,0);
      dayValue[1]=iMA(NULL,PERIOD_D1,14,0,MODE_EMA,PRICE_CLOSE,1);
      dayValue[2]=iMA(NULL,PERIOD_D1,14,0,MODE_EMA,PRICE_CLOSE,2);
      dayValue[3]=iMA(NULL,PERIOD_D1,14,0,MODE_EMA,PRICE_CLOSE,3);
      dayValue[4]=iMA(NULL,PERIOD_D1,14,0,MODE_EMA,PRICE_CLOSE,4);
      dayValue[5]=iMA(NULL,PERIOD_D1,14,0,MODE_EMA,PRICE_CLOSE,5);
      dayValue[6]=iMA(NULL,PERIOD_D1,14,0,MODE_EMA,PRICE_CLOSE,6);

      dayValue7[0] = iMA(NULL,PERIOD_D1,7,0,MODE_EMA,PRICE_CLOSE,0);
      dayValue7[1] = iMA(NULL,PERIOD_D1,7,0,MODE_EMA,PRICE_CLOSE,1);
      dayValue7[2] = iMA(NULL,PERIOD_D1,7,0,MODE_EMA,PRICE_CLOSE,2);
      dayValue7[3] = iMA(NULL,PERIOD_D1,7,0,MODE_EMA,PRICE_CLOSE,3);
      dayValue7[4] = iMA(NULL,PERIOD_D1,7,0,MODE_EMA,PRICE_CLOSE,4);
      dayValue7[5] = iMA(NULL,PERIOD_D1,7,0,MODE_EMA,PRICE_CLOSE,5);
      dayValue7[6] = iMA(NULL,PERIOD_D1,7,0,MODE_EMA,PRICE_CLOSE,6);

      if(weekValue[0]>weekValue[1] && weekValue[1]>weekValue[2] && weekValue[2]>weekValue[3] && 
         dayValue[0]>dayValue[1] && dayValue[1]>dayValue[2] && dayValue[2]>dayValue[3] && dayValue[3]>dayValue[4] && dayValue[4]>dayValue[5] && dayValue[5]>dayValue[6])
        {
         trend="Up";
        }
      else if(weekValue[0]<weekValue[1] && weekValue[1]<weekValue[2] && weekValue[2]<weekValue[3] && 
         dayValue[0]<dayValue[1] && dayValue[1]<dayValue[2] && dayValue[2]<dayValue[3] && dayValue[3]<dayValue[4] && dayValue[4]<dayValue[5] && dayValue[5]<dayValue[6])
           {
            trend="Down";
           }
         else trend="N/A";
     }
   if(TimeCurrent()-minUpdateTime>minPeriod)
     {
      minUpdateTime=TimeCurrent();
      //minValue[0] = iMA(NULL,PERIOD_M15,14,0,MODE_EMA,PRICE_CLOSE,0);
      minValue[0] = Close[0];
      minValue[1] = Close[1];
      minValue[2] = Close[2];


      minValue[3] = Close[3];
      minValue[4] = Close[4];
      minValue[5] = Close[5];
      minValue[6] = Close[6];
      minValue[7] = Close[7];
      minValue[8] = Close[8];
      minValue[9] = Close[9];
     }

   dayValue[0] = iMA(NULL,PERIOD_D1,14,0,MODE_EMA,PRICE_CLOSE,0);
   dayValue[1] = iMA(NULL,PERIOD_D1,14,0,MODE_EMA,PRICE_CLOSE,1);
   dayValue[2] = iMA(NULL,PERIOD_D1,14,0,MODE_EMA,PRICE_CLOSE,2);
   dayValue7[0] = iMA(NULL,PERIOD_D1,7,0,MODE_EMA,PRICE_CLOSE,0);
   dayValue7[1] = iMA(NULL,PERIOD_D1,7,0,MODE_EMA,PRICE_CLOSE,1);
   dayValue7[2] = iMA(NULL,PERIOD_D1,7,0,MODE_EMA,PRICE_CLOSE,2);
  }
//+------------------------------------------------------------------+

double MarketInfomation_MovingAverage()
  {
   double predict=0.0;
   updateMovingAverageValue();
   predict=LineCrossTest(dayValue7[0],dayValue7[1],dayValue7[2],dayValue[0],dayValue[1],dayValue[2]);

   if(predict==-1)
     {
      //LableName：标签名称；LableDoc：文本内容；LableX：标签X位置；LableY：标签Y位置； DocSize：文本字号；DocStyle：文本字体；DocColor：文本颜色
      // SetLabelOnBar("Down",
      //              NormalizeDouble(minValue[0],3)+" "+NormalizeDouble(minValue[1],3)+" "+NormalizeDouble(minValue[2],3)+"/"+NormalizeDouble(dayValue[0],3)+" "+NormalizeDouble(dayValue[1],3)+" "+NormalizeDouble(dayValue[2],3),
      //             dayValue[0],10,"Verdana",Red);
     }
   if(trend=="Up")
     {
      //predict+=0.2;
     }
   else if(trend=="Down")
     {
      //predict-=0.2;
     }
   return predict;
  }
//+------------------------------------------------------------------+
