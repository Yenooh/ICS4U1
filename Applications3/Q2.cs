using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection.Metadata;

namespace Applications3Q2
{
  class Program
  { 
    public static long F(long m, long num){
      if (m == 0) return num;
      else{
        num = num * 10 + m % 10;
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
