using System;
using System.Globalization;

namespace Applications1SearchesQ1
{
  class Program
  {
    
    static void Main(string[] args)
    {
      Console.Write("Enter # of Rows: ");
      int r = int.Parse(Console.ReadLine());
      Console.Write("Enter # of Columns: ");
      int c = int.Parse(Console.ReadLine());
      int[,] mat = new int[r,c];
      for(int i = 0; i < r; i++){
        for(int j = 0; j < c; j++){
          Console.Write("Enter value (" + i + "," + j + "): ");
          mat[i,j] = int.Parse(Console.ReadLine());
        }
      }
      Console.Write("Enter target number: ");
      int target = int.Parse(Console.ReadLine());
      int total = 0;
      Console.WriteLine("The indexes of the target number are: ");
      for(int i = 0; i < r; i++){
        for(int j = 0; j < c; j++){
          if(mat[i,j] == target){
            total++;
            Console.WriteLine("(" + i + "," + j + ")");
          }
        }
      }
      if(total == 0){
        Console.WriteLine("There is no target number in the matrix.");
      }
      else{
        Console.WriteLine("The target number appears " + total + " times");
      }
    }
  }
}
