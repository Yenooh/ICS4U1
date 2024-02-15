using System;

namespace Applications2MatricesQ2
{
  class Program
  {
    public static int minFind(int[,] prices, int n, int m){
        int min = 999999999;
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
                if(prices[i,j] < min){
                    min = prices[i,j];
                }
            }
        }
        return min;
    }
    public static int sameValue(int[,] prices, int n, int m, int min){
        int total = 0;
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
                if(prices[i,j] == min){
                    total++;
                }
            }
        }
        return total;
    }
    static void Main(string[] args)
    {
      Console.Write("Enter N:");
      int n = int.Parse(Console.ReadLine());
      Console.Write("Enter M:");
      int m = int.Parse(Console.ReadLine());
      int[,] prices = new int[n,m];
      for(int i = 0; i < n; i++){
        for(int j = 0; j < m; j++){
            Console.Write("Enter Price of (" + i + "," + j + "):");
            prices[i,j] = int.Parse(Console.ReadLine());
        }
      }
      int min = minFind(prices,n,m);
      Console.WriteLine("The minimum is: " + min);
      int duplicates = sameValue(prices,n,m,min);
      Console.WriteLine(duplicates + " have the same price as the minimum");
    }
  }
}
