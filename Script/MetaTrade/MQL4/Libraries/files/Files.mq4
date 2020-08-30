//+------------------------------------------------------------------+
//|                                                        Files.mq4 |
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
class Files
  {
private:
public:
   string            fileName;
   string            terminal_data_path;
   void Files(string name)
     {
      fileName=name;
      int filehandle=FileOpen(fileName,FILE_READ|FILE_CSV);
      FileClose(filehandle);
      filehandle=FileOpen(fileName,FILE_WRITE|FILE_CSV);
      //FileClose(filehandle);
      //filehandle=FileOpen("fractals.csv",FILE_WRITE|FILE_CSV);
      if(filehandle!=INVALID_HANDLE)
        {
         FileWrite(filehandle,TimeCurrent(),Symbol(),EnumToString(ENUM_TIMEFRAMES(_Period)));
         FileClose(filehandle);
         Print("FileOpen OK");
        }
      else Print("Operation FileOpen failed, error ",GetLastError());

     }
   void deleteFile()
     {
      FileDelete(fileName);
     }
  };
//+------------------------------------------------------------------+
