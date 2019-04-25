using System;
using System.Collections.Generic;

namespace Year.Models
{
 public class Date // class
 {
   private int _year; // properties
   private int _month;
   private int _day;

   public int Date (int year, int month, int day) // constructor
   {
     _year = year;
     _month = month;
     _day = day;
   }

   public string GetDay()

   {
     DateTime newDateTime = new DateTime (_year,  _month, _day);

     return  "Monday";
   }

 }
}
