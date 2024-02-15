using System;

namespace Applications2Matrices
{
  class Program
  {
    public static void printArr(int[,] arr, int n, int m){
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
                Console.Write(arr[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
    
    public static int findNum(int[,] arr, int n, int m){
        int total = 0;
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
                if(arr[i,j] < 500 && arr[i,j] > 100){
                    total++;
                }
            }
        }
        return total;
    }
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
      printArr(arr,n,m);
      Console.WriteLine(findNum(arr,n,m));
    }
  }
}
