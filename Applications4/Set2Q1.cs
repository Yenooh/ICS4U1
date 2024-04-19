using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Application4Set2Q1
{
  class Program
  {
    public static int elim(int n){
      if(n == 0){
        return 0;
      }
      int lastdig = n%10;
      if(lastdig % 2 == 0){
        return elim(n/10);
      }
      else{
        return elim(n/10)*10 + lastdig;
      }
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Enter n:");
      int n = int.Parse(Console.ReadLine());
      Console.WriteLine(elim(n));
      
      
    }
  }
}
