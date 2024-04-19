using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace IntroQ1
{
  class Program
  {
    public static int factorialI(int n){
      int product = 1;
      for(int i = 1; i <= n; i++){
        product *= i;
      }
      return product;
    }
    public static int factorialR(int n){
      if(n == 1){
        return 1;
      }
      else{
        return factorialR(n-1) * n;
      }
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Enter n:");
      int n = int.Parse(Console.ReadLine());
      Console.WriteLine("Recursive:");
      Console.WriteLine(factorialR(n));
      Console.WriteLine("Iterative:");
      Console.WriteLine(factorialI(n));
    }
  }
}
