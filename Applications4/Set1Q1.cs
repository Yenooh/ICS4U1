using System;
using System.Globalization;

namespace Applications4Set1Q1
{
  class Program
  { 
    public static int avg(int[] a, int i, int total, int count){
      if(i == a.Length){
        return total/count;
      }
      else if(a[i] > 0){
        total += a[i];
        count++;
        return avg(a,i+1,total,count);
      }
      else{
        return avg(a,i+1,total,count);
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
      int average = avg(a,0,0,0);
      Console.WriteLine("The average of all the positive numbers is " + average);

    }
  }
}
