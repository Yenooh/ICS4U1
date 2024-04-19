using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection.Metadata;

namespace Applications4Set1Q1
{
  class Program
  { 
    public static int sum(int a, int b){
      if(a!=0){
        b += a%10;
        Console.WriteLine(b + " ");
        a = a/10;
        return sum(a, b);
      }
      else{
        return b;
      }
    }
    public static int search(int[] a, int i, int count){
      if(i == a.Length){
        return count;
      }
      else{
        int sums = sum(a[i],0);
        if(sums == 10){
          count++;
          return search(a,i+1,count);
        }
        else{
          return search(a,i+1,count);
        }
      }
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Enter Size of Array: ");
      int n = int.Parse(Console.ReadLine());
      int[] a = new int[n];
      for(int i = 0; i < n; i++){
        Console.WriteLine("Enter Value " + (i+1) + ": ");
        a[i] = int.Parse(Console.ReadLine());
      }
      Console.WriteLine("The number of elements that have the digits have a sum of 10 is " + search(a,0,0));
    }
  }
}
