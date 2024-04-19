using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Application4Set2Q4
{
  class Program
  {
    public static long[] F(long n, long[] count){
      if(n == 0){
        return count;
      }
      else{
        long digit = n%10;
        count[digit] += 1;
        return F(n/10, count);
      }
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Enter n:");
      long n = long.Parse(Console.ReadLine());
      long[] count =  new long[10];
      count = F(n,count);
      for(int i = 0; i < 10; i++){
        Console.WriteLine("The number " + i +" has appeared " + count[i] + " times");
      }
    }
  }
}
