using System;

namespace Applications2Matrices
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter N: ");
      int n = int.Parse(Console.ReadLine());
      int[,] arr = new int[n,n];
      for(int i = 0; i < n; i++){
          for(int j = 0; j < n; j++){
              Console.Write("Enter (" + i + "," + j + "):");
              arr[i,j] = int.Parse(Console.ReadLine());
          }
      }
      int[,] diag = new int[n,n];
      int row = 0; int col = 0;
      for(int i = 0; i < n; i++){
        for(int j = 0; j < n; j++){
            if(i == row && j == col){
                diag[i,j] = arr[i,j];
                row++;
                col++;
            }
            else{
                diag[i,j] = 0;
            }
        }
      }
      row = 0; col =n-1;
      for(int i = 0; i < n; i++){
        for(int j = 0; j < n; j++){
            if(i == row && j == col){
                diag[i,j] = arr[i,j];
                row++;
                col--;
            }
        }
      }
      for(int i = 0; i < n; i++){
        for(int j = 0; j < n; j++){
            if(diag[i,j] != 0){
                Console.Write(diag[i,j] + " ");
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
