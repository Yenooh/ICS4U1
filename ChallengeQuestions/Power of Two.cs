using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace PowerOfTwo
{
  class Program
  {
    public static bool F(int n){
      if(n==1){
        return true;
      }
      if(n%2 != 0 || n<=0){
        return false;
      }
      return F(n/2);
    }
    static void Main(string[] args)
    {
      Console.Write("Enter Number: ");
      int n = int.Parse(Console.ReadLine());
      if(F(n)){
        Console.WriteLine("true");
      }
      else{
        Console.WriteLine("false");
      }
    }
  }
}
