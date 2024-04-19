using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection.Metadata;

namespace Applications3Q1
{
  class Program
  { 
    public static long F(int n){
      if (n <= 5){
        return n;
      }
      else {
        return 2 * F(n - 1);
      }
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Enter Number: ");
      int a = int.Parse(Console.ReadLine());
      Console.WriteLine(F(a));
      

    }
  }
}
