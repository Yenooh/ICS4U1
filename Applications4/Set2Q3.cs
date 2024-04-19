using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Application4Set2Q3
{
  class Program
  {
    public static bool F(long n){
      if(n == 0){
        return true;
      }
      else if((n%10) > ((n/10)%10)){
        return F(n/10);
      }
      else{
        return false;
      }
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
