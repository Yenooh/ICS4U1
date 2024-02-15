using System;

namespace Applications2Matrices
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter N: ");
      int n = int.Parse(Console.ReadLine());
      Console.Write("Enter M: ");
      int m = int.Parse(Console.ReadLine());
      int[,] arr = new int[n,m];
      for(int i = 0; i < n; i++){
          for(int j = 0; j < m; j++){
              Console.Write("Enter (" + i + "," + j + "):");
              arr[i,j] = int.Parse(Console.ReadLine());
          }
      }
      Console.WriteLine("First row:");
      for(int i = 0; i < m; i++){
        Console.Write(arr[0,i] + " ");
      }
      Console.WriteLine();
      Console.WriteLine("Last row:");
      for(int i = 0; i < m; i++){
        Console.Write(arr[n-1,i] + " ");
      }
      Console.WriteLine();
      Console.WriteLine("First Column:");
      for(int i = 0; i < n; i++){
        Console.Write(arr[i,0] + " ");
      }
      Console.WriteLine();
      Console.WriteLine("Last Column:");
      for(int i = 0; i < m; i++){
        Console.Write(arr[i,m-1] + " ");
      }

    }
  }
}
