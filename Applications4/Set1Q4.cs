using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace RecursionAlgorithmsAssignment
{
  class Program
  {
    public static int Add(int a, int b){
      if(a==0){
        return b;
      }
      else{
        b += a%10;
        return Add(a/10,b);
      }
    }
    public static int count(int[] a, int i, int counter){
      if(i == a.Length){
        return counter;
      }
      else{
        int sum = Add(a[i], 0);
        if(sum == 10){
          return count(a,i+1,counter+1);
        }
        else{
          return count(a,i+1,counter);
        }
      }
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Enter n:");
      int n = int.Parse(Console.ReadLine());
      int[] a = new int [n];
      for (int i = 0; i < n; i++){
        Console.WriteLine ("Enter value " + (i+1) + ": ");
        a[i] = int.Parse(Console.ReadLine());
      }
      Console.WriteLine(count(a,0,0) +" have a sum of 10");
      
    }
  }
}
