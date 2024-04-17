using System;
using System.Globalization;
using System.Reflection.Metadata;

namespace Applications4Set1Q1
{
  class Program
  { 
    public static bool search(int[] a, int i, int find){
      if(i == a.Length){
        return false;
      }
      else if(a[i] == find){
        return true;
      }
      else{
        return search(a,i+1,find);
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
      Console.WriteLine("Enter value to find: ");
      int find = int.Parse(Console.ReadLine());
      if(search(a,0,find) == true){
        Console.WriteLine("The value exists in the array");
      }
      else{
        Console.WriteLine("The value does not exist in the array");
      }
    }
  }
}
