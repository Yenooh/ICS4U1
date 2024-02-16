using System;

namespace Applications2MatricesQ3
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter N:");
      int n = int.Parse(Console.ReadLine());
      Console.Write("Enter M:");
      int m = int.Parse(Console.ReadLine());
      int[,] arr = new int[n,m];
      for(int i = 0; i < n; i++){
        for(int j = 0; j < m; j++){
            Console.Write("Enter Value of (" + i + "," + j + "):");
            arr[i,j] = int.Parse(Console.ReadLine());
        }
      }
      int[,] border = new int[n,m];
      for(int i = 0; i < m; i++){
        border[0,i] = arr[0,i];
      }
      for(int i = 0; i < m; i++){
        border[n-1,i] = arr[n-1,i];
      }
      for(int i = 0; i < n; i++){
        border[i,0] = arr[i,0];
      }
      for(int i = 0; i < m; i++){
        border[i,m-1] = arr[i,m-1];
    }
    for(int i = 0; i < n; i++){
        for(int j = 0; j < m; j++){
            if(border[i,j] != 0){
              Console.Write(border[i,j] + " ");
            }
            else{
              Console.Write("  ");
            }
        }
        Console.WriteLine();
      }
  }
}
}
