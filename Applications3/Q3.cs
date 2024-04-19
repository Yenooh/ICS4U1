using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection.Metadata;

namespace Applications3Q3
{
  class Program
  { 
    public static long F(long m, long num){
      if (m == 0) {
        return num;
      }
      else{
        if(num < m % 10){
          num = m % 10;
        }
        return F(m / 10, num);
      }
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Enter Number: ");
      long a = long.Parse(Console.ReadLine());
      Console.WriteLine(F(a,0));
      

    }
  }
}
