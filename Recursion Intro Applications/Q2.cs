using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace IntroQ2
{
  class Program
  {
    public static int sumI(int n){
      int sum = 0;
      for(int i = 0; i <= n; i++){
        sum += i;
      }
      return sum;
    }
    public static int sumR(int n){
      if(n == 0){
        return 0;
      }
      else{
        return sumR(n-1) + n;
      }
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Enter n:");
      int n = int.Parse(Console.ReadLine());
      Console.WriteLine("Recursive:");
      Console.WriteLine(sumR(n));
      Console.WriteLine("Iterative:");
      Console.WriteLine(sumI(n));
    }
  }
}
