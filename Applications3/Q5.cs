using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection.Metadata;

namespace Applications3Q3
{
  class Program
  { 
    public static long F(long a, long sum){
      if(a == 0){
        return sum;
      }
      else{
        sum += a%10;
        return F(a/10,sum);
      }
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Enter unumber: ");
      long a = long.Parse(Console.ReadLine());
      Console.WriteLine(F(a,0));
      

    }
  }
}
