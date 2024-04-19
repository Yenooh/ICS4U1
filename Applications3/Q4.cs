using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection.Metadata;

namespace Applications3Q3
{
  class Program
  { 
    public static long F(int[] v, int i){
      if (i== v.Length){
        return 0;
      }
      else{
        return v[i] + F(v,i+1);
      }
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Enter N: ");
      int n = int.Parse(Console.ReadLine());
      int[] a = new int[n];
      for(int i = 0; i < n; i++){
        Console.WriteLine("enter value " + (i+1) + ": ");
        a[i] = int.Parse(Console.ReadLine());
      }
      Console.WriteLine(F(a,0));
      

    }
  }
}
