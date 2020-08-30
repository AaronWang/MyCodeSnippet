//+------------------------------------------------------------------+
//|                                                  lot_risk_sl.mq4 |
//+------------------------------------------------------------------+
#property library
#property version "1.0"

extern int SL=40;
extern double Lot_sl_risk=2;
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
double perc_lot_by_stop_f()
  {
   if(SL<=0) {Alert("Need SL to be set!..min lot mode");return(MarketInfo(Symbol(),MODE_MINLOT));}

   double lose_on_stop_lose=SL*(MarketInfo(Symbol(),MODE_TICKVALUE)/100);
   double propotion=(AccountBalance()/100*Lot_sl_risk)/lose_on_stop_lose;
   double Loto_=MarketInfo(Symbol(),MODE_MINLOT)*propotion;

   if(Loto_<MarketInfo(Symbol(),MODE_MINLOT))
      Loto_=MarketInfo(Symbol(),MODE_MINLOT);
   if(Loto_>MarketInfo(Symbol(),MODE_MAXLOT))
      Loto_=MarketInfo(Symbol(),MODE_MAXLOT);
   if(MarketInfo(Symbol(),MODE_MARGINREQUIRED)*Loto_>AccountFreeMargin())
     {
      Alert("Not enouth money to open order!..min lot mode");
      return(MarketInfo(Symbol(),MODE_MINLOT));
     }

   return(Loto_);
  }
//+------------------------------------------------------------------+
