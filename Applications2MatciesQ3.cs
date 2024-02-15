using System;

namespace Applications2MatricesQ3
{
  class Program
  {
    public static bool check(int n){
        if(n%7==0){
            return true;
        }
        else{
            return false;
        }
    }
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
      for(int i = 0; i < n; i++){
        for(int j = 0; j < m; j++){
            if(check(arr[i,j])){
                arr[i,j] = 0;
            }
        }
      }
      for(int i = 0; i < n; i++){
        for(int j = 0; j < m; j++){
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
      }
    }
  }
}
