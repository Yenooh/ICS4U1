using System;
using System.Globalization;
using System.Reflection.Metadata;

namespace Applications4Set1Q1
{
  class Program
  { 
    public static void reverse(int[] a, int left, int right, int mid){
      if(left<= mid){
        int t = a[left];
        a[left] = a[right];
        a[right] = t;
        reverse(a,left+1,right-1,mid);
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
      reverse(a,0,a.Length-1,(0+a.Length)/2);
      for(int i = 0; i < n; i++){
        Console.Write(a[i] + " ");
      }

    }
  }
}
