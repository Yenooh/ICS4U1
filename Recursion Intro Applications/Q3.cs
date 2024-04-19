using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace IntroQ3
{
  class Program
  {
    public static void printI(int[] n){
      for(int i = 0; i < n.Length; i++){
        Console.Write(n[i] + " ");
      }
    }
    public static void printR(int[] n, int i){
      if(i < n.Length){
        Console.Write(n[i] + " ");
        printR(n,i+1);
      }
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Enter size:");
      int b = int.Parse(Console.ReadLine());
      int[] n = new int[b];
      for(int i = 0; i < b; i++){
        Console.WriteLine("Enter number: ");
        n[i] = int.Parse(Console.ReadLine());
      }
      Console.WriteLine("Recursive:");
      printR(n,0);
      Console.WriteLine();
      Console.WriteLine("Iterative:");
      printI(n);
    }
  }
}
