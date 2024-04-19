using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Application4Set2Q2
{
  class Program
  {
    public static long ReverseN(long n, long rn = 0){
      if (n == 0){
        return rn;
      }
      long lastDigit = n % 10;

      rn = (rn * 10) + lastDigit;

      return ReverseN(n / 10, rn);
    }
    public static bool F(long n){
      long originalNumber = n;
      long reversedNumber = ReverseN(n);

      return originalNumber == reversedNumber;
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Enter n:");
      long n = long.Parse(Console.ReadLine());
      if(F(n)){
        Console.WriteLine("Yes");
      }
      else{
        Console.WriteLine("No");
      }
      
      
    }
  }
}
