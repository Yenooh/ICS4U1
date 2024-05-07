using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection.Metadata;

namespace Applications3Q3
{
  class Program
  { 
      static void Main(string[] args)
      {
        bool exit = false;
        List <Car> carList = new List<Car>();
        while(exit == false){
          Console.WriteLine("Menu:");
          Console.WriteLine("1. Add Car");
          Console.WriteLine("2. Search car by Make and Model");
          Console.WriteLine("3. Update Car Price");
          Console.WriteLine("4. Delete Car");
          Console.WriteLine("5. Display Invento ry");
          Console.WriteLine("6. Display the most searched car Make");
          Console.WriteLine("7. Exit");
          Console.Write("Enter Option: ");
          int option = int.Parse(Console.ReadLine());
          if (option == 1){
            try{
              Car carAdd = new Car();
              bool unique = false;
              int carIDInp = 0;
              while(unique == false){
                unique = true;
                Console.Write("Enter the carID: ");
                carIDInp = int.Parse(Console.ReadLine());
                foreach(Car car in carList){
                 if(car.CarID == carIDInp){
                    unique = false;
                  }
                }
                if(unique == false){
                  Console.WriteLine("CarID is not unique.");
                }
              }
              carAdd.CarID = carIDInp;
              unique = false;
              string VINinp = "";
              while(unique == false){
                unique = true;
                Console.Write("Enter the VIN: ");
                VINinp = Console.ReadLine();
                foreach(Car car in carList){
                if(car.vIN == VINinp){
                    unique = false;
                  }
                }
                if(unique == false){
                  Console.WriteLine("VIN is not unique.");
                }
              }
              carAdd.vIN = VINinp;
              Console.Write("Enter Make: ");
              int makeInp = int.Parse(Console.ReadLine());
              carAdd.Make = makeInp;
              Console.Write("Enter the Model: ");
              string modelInp = Console.ReadLine();
              carAdd.Model = modelInp;
              Console.Write("Enter the Year: ");
              int yearInp = int.Parse(Console.ReadLine());
              carAdd.Year = yearInp;
              Console.Write("Enter the Price: ");
              double priceInp = double.Parse(Console.ReadLine());
              carAdd.Price = priceInp;
              carList.Add(carAdd);
              Console.WriteLine("Car added successfully");
              Console.WriteLine();
            }
            catch (Exception e) {
              Console.WriteLine("Wrong type of input.");
            }
            
          }
          else if(option == 2){
            Console.Write("Input car make: ");
            int makeInp = int.Parse(Console.ReadLine());
            Console.Write("Input car model: ");
            string modelInp = Console.ReadLine();
            int counter = 0;
            foreach(Car car in carList){
              if(car.Make == makeInp && car.Model == modelInp){
                Console.WriteLine("Car ID: " + car.CarID);
                Console.WriteLine("VIN: " + car.vIN);
                Console.WriteLine("Make: " + car.Make);
                Console.WriteLine("Model: " + car.Model);
                Console.WriteLine("Year: " + car.Year);
                Console.WriteLine("Price: " + car.Price);
                Console.WriteLine();
                counter++;
              }
            }
            if(counter == 0){
              Console.WriteLine("There is nothing that matches your search.");
              Console.WriteLine();
            }
          }
          else if(option == 3){
            Console.Write("Enter Make: ");
            int makeInp = int.Parse(Console.ReadLine());
            Console.Write("Enter Model: ");
            string modelInp = Console.ReadLine();
            foreach()
          }
          else if(option == 7){
            exit = true;
          }
        }

      }
  }
}
