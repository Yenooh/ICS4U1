using System;

namespace Applications2MatricesQ3
{
  class Program
  {
    public static void generateTranspose(int[,] mat){
      
    }
    public static int[,] generateMatrix(){
      Console.Write("Enter # of rows: ");
      int r = int.Parse(Console.ReadLine());
      while(true){
        if(r < 0 || r > 50){
          Console.WriteLine("Out of bounds");
          Console.Write("Enter new # of rows: ");
          r = int.Parse(Console.ReadLine());
        }
        else{
          break;
        }
      }
      Console.Write("Enter # of columns: ");
      int c = int.Parse(Console.ReadLine());
      while(true){
        if(c < 0 || c > 50){
          Console.WriteLine("Out of bounds");
          Console.Write("Enter new # of columns: ");
          c = int.Parse(Console.ReadLine());
        }
        else{
          break;
        }
      }
      int[,] mat = new int[r,c];
      Random rnd = new Random();
      for(int i = 0; i < r; i++){
        for(int j = 0;j < c; j++){
          mat[i,j] = rnd.Next(10);
        }
      }
      return mat;
    }
    static void Main(string[] args)
    {
      Console.WriteLine("----------Welcome to the Matrix Program!---------------");
      Console.WriteLine("Please select one of the following options:");
      Console.WriteLine();
      Console.WriteLine("1: The Random Matrix");
      Console.WriteLine("2: The Transpose Matrix");
      Console.WriteLine("3: Multiplying a Matrix by a Constant");
      Console.WriteLine("4: Multiplying Two Matrices");
      Console.WriteLine("5: Exit");
      int choice = int.Parse(Console.ReadLine());
      int[,] mat;
      switch(choice){
        case 1:
        mat = generateMatrix();
        for(int i = 0; i < mat.GetLength(0); i++){
          for(int j = 0;j < mat.GetLength(1); j++){
            Console.Write(mat[i,j] + " ");
          }
          Console.WriteLine();
        }
        break;

        case 2:
        generateTranspose(mat);
        break;
      }
    }
  }
}
