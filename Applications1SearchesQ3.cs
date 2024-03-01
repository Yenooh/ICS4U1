using System;
using System.Globalization;

namespace Applications1SearchesQ3
{
  class Program
  {
    public static bool BinarySearch(int[] A, int search){
      int L = 0; int R = A.Length - 1;
      while (L <= R){
        int m = (L + R) / 2;
        if (A[m] == search)
          return true;
        else if (A[m] > search)
          R = m - 1;
        else
          L = m + 1;
      }
    return false;
    }
    
    static void Main(string[] args)
    {
      Console.Write("Enter # of rows: ");
      int r = int.Parse(Console.ReadLine());
      Console.Write("Enter # of columns: ");
      int c = int.Parse(Console.ReadLine());
      int[,] mat = new int[r,c];
      for(int i = 0; i < r; i++){
        for(int j = 0; j < c; j++){
          Console.Write("Enter value (" + (i+1) + "," + (j+1) + "): ");
          mat[i,j] = int.Parse(Console.ReadLine());
        }
      }
      int l = 0;
      while(true){
        Console.Write("Enter column # to search: ");
        l = int.Parse(Console.ReadLine());
        if(l < 0 || l > c){
          Console.WriteLine("Out of bounds");
        }
        else{
          break;
        }
      }
      Console.Write("Enter target number: ");
      int target = int.Parse(Console.ReadLine());
      int[] matn = new int[r];
      for(int i = 0; i < r; i++){
        matn[i] = mat[i,l-1];
      }
      if(BinarySearch(matn, target)){
        Console.WriteLine("It is in the column");
      }
      else{
        Console.WriteLine("It is not in the column");
      }
    }
  }
}
