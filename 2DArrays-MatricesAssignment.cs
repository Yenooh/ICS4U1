using System;

namespace Applications2MatricesQ3
{
  class Program
  {
    public static void multiplyMatrix(){
      Console.Write("Enter rows: ");
      int r = int.Parse(Console.ReadLine());
      Console.Write("Enter column: ");
      int c = int.Parse(Console.ReadLine());
      int[,] mat1 = new int[r,c];
      int[,] mat2 = new int[c,r];
      int[,] final = new int[r,r];
      Random rnd = new Random();
      for(int i = 0; i < r; i++){
        for(int j = 0; j < c; j++){
          mat1[i,j] = rnd.Next(10);
        }
      }
      for(int i = 0; i < c; i++){
        for(int j = 0; j < r; j++){
          mat2[i,j] = rnd.Next(10);
        }
      }
      for(int i = 0; i < r; i++){
        for(int j = 0; j < r; j++){
          int tot = 0;
          for(int n = 0; n < c; n++){
            tot += (mat1[i,n]*mat2[n,j]);
          }
          final[i,j] = tot;
        }
      }
      for(int i = 0; i < r; i++){
           for(int j = 0;j < c; j++){
              Console.Write(mat1[i,j] + " ");
            }
            Console.WriteLine();
          }
          Console.WriteLine();
      for(int i = 0; i < c; i++){
        for(int j = 0;j < r; j++){
          Console.Write(mat2[i,j] + " ");
        }
          Console.WriteLine();
        }
      Console.WriteLine();
      for(int i = 0; i < r; i++){
        for(int j = 0;j < r; j++){
          Console.Write(final[i,j] + " ");
        }
          Console.WriteLine();
        }
      Console.WriteLine();
    }
    public static void multiplyMatrixByConstant(int[,] mat){  
      int r = mat.GetLength(0);
      int c = mat.GetLength(1);
      int[,] multi = new int[r,c];
      Console.Write("Enter value to multiply by: ");
      int m = int.Parse(Console.ReadLine());
      for(int i = 0; i < r; i++){
        for(int j = 0; j < c; j++){
          multi[i,j] = mat[i,j]*m;
        }
      }
      for(int i = 0; i < r; i++){
        for(int j = 0; j < c; j++){
          Console.Write(multi[i,j] + " ");
        }
        Console.WriteLine();
      }
      Console.WriteLine();
    }
    public static void generateTranspose(int[,] mat){
      int cnew = mat.GetLength(0);
      int rnew = mat.GetLength(1);
      int[,] tran = new int[rnew,cnew];
      for(int i = 0; i < rnew; i++){
        for(int j = 0; j < cnew; j++){
          tran[j,i] = mat[i,j];
        }
      }
      Console.WriteLine("Old Matrix: ");
      for(int i = 0; i < rnew; i++){
        for(int j = 0; j < cnew; j++){
          Console.Write(mat[i,j] + " ");
        }
        Console.WriteLine();
      }
      Console.WriteLine();
      Console.WriteLine("Transposed Matrix: ");
      for(int i = 0; i < rnew; i++){
        for(int j = 0; j < cnew; j++){
          Console.Write(tran[i,j] + " ");
        }
        Console.WriteLine();
      }
      Console.WriteLine();
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
      bool exit = false;
      
      int[,] mat = new int[50,60];
      while(exit == false){
        Console.WriteLine("----------Welcome to the Matrix Program!---------------");
        Console.WriteLine("Please select one of the following options:");
        Console.WriteLine();
        Console.WriteLine("1: The Random Matrix");
        Console.WriteLine("2: The Transpose Matrix");
        Console.WriteLine("3: Multiplying a Matrix by a Constant");
        Console.WriteLine("4: Multiplying Two Matrices");
        Console.WriteLine("5: Exit");
        Console.Write("Select an Option: ");
        int choice = int.Parse(Console.ReadLine());
        switch(choice){
          case 1:
          mat = generateMatrix();
          for(int i = 0; i < mat.GetLength(0); i++){
           for(int j = 0;j < mat.GetLength(1); j++){
              Console.Write(mat[i,j] + " ");
            }
            Console.WriteLine();
          }
          Console.WriteLine();
          break;

          case 2:
            generateTranspose(mat);
            break;

          case 3:
            multiplyMatrixByConstant(mat);
            break;
          
          case 4:
            multiplyMatrix();
            break;

          case 5:
            exit = true;
            break;
      }
      }
      
    }
  }
}
