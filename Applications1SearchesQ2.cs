using System;
using System.Globalization;

namespace Applications1SearchesQ2
{
  class Program
  {
    
    static void Main(string[] args)
    {
      Console.Write("Enter # of elements: ");
      int r = int.Parse(Console.ReadLine());
      int[] mat = new int[r];
      for(int i = 0; i < r; i++){
        Console.Write("Enter value (" + i + "): ");
        mat[i] = int.Parse(Console.ReadLine());
      }
      int[] find = new int[100000];
      for(int i = 0; i < r; i++){
        find[mat[i]]++;
      }
      for(int i = 0; i < 100000; i++){
        if(find[i] > 0){
          Console.WriteLine(i + " appears " + find[i] +" times.");
        }
      }
    }
  }
}
