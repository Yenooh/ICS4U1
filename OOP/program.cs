using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection.Metadata;

namespace OOPassignment
{
  class Program
  { 
      static void Main(string[] args)
      {
        bool exit = false;
        List <Car> carList = new List<Car>();
        List <Search> searchList = new List<Search>();
        while(exit == false){
          int option = 0;
          Console.WriteLine("Menu:");
          Console.WriteLine("1. Add Car");
          Console.WriteLine("2. Search car by Make and Model");
          Console.WriteLine("3. Update Car Price");
          Console.WriteLine("4. Delete Car");
          Console.WriteLine("5. Display Invento ry");
          Console.WriteLine("6. Display the most searched car Make");
          Console.WriteLine("7. Exit");
          try{
            Console.Write("Enter Option: ");
            option = int.Parse(Console.ReadLine());
          }
          catch(Exception e){
            Console.Clear();
            Console.WriteLine("Invalid Input");
          }
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
              Console.Clear();
              Console.WriteLine("Car added successfully");
              Console.WriteLine();
            }
            catch (Exception e) {
              Console.Clear();
              Console.WriteLine("Wrong type of input.");
            }
            
          }
          else if(option == 2){
            try{
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
              bool found = false;
              foreach(Search search in searchList){
                if(search.SearchMake == makeInp){
                  search.SearchCount += 1;
                  found = true;
                  break;
                }
              }
              if(found == false){
                Search searchAdd = new Search();
                searchAdd.searchMake = makeInp;
                searchList.Add(searchAdd);
              }
              if(counter == 0){
                Console.WriteLine("There is nothing that matches your search.");
                Console.WriteLine();
              }
            }
            catch(Exception e) {
              Console.WriteLine("Invalid Input");
              Console.WriteLine();
            }
            
          }
          else if(option == 3){
            Console.Write("Enter Make: ");
            int makeInp = int.Parse(Console.ReadLine());
            Console.Write("Enter Model: ");
            string modelInp = Console.ReadLine();
            int count = 0;
            foreach(Car car in carList){
              if(car.Make == makeInp && car.Model == modelInp){
                count++;
              }
            }
            if(count > 1){
              Console.WriteLine("More than one car matching your search.");
              Console.Write("Enter VIN: ");
              string vinInp = Console.ReadLine();
              bool found = false;
              foreach(Car car in carList){
                if(car.Make == makeInp && car.Model == modelInp && car.vIN == vinInp){
                  found = true;
                  Console.WriteLine("The current price is " + car.Price);
                  Console.Write("Enter new price: ");
                  car.Price = int.Parse(Console.ReadLine());
                }
              }
              if(found == false){
                Console.WriteLine("No matching car.");
                Console.WriteLine();
              }
            }
            else if(count == 1){
              foreach(Car car in carList){
                if(car.Make == makeInp && car.Model == modelInp){
                  Console.WriteLine("The current price is " + car.Price);
                  Console.Write("Enter new price: ");
                  car.Price = int.Parse(Console.ReadLine());
                }
              }
            }
            else{
              Console.WriteLine("No car matching your search");
              Console.WriteLine();
            }
          }
          else if(option == 4){
            try{
              Console.Write("Enter Make: ");
              int makeInp = int.Parse(Console.ReadLine());
              Console.Write("Enter Model: ");
              string modelInp = Console.ReadLine();
              int count = 0;
              foreach(Car car in carList){
                if(car.Make == makeInp && car.Model == modelInp){
                  count++;
                }
              }
              if(count > 1){
                Console.WriteLine("More than one car matching your search.");
                Console.Write("Enter VIN: ");
                string vinInp = Console.ReadLine();
                bool found = false;
                for(int i = carList.Count-1; i >= 0; i--){
                  if(carList[i].vIN == vinInp){
                    found = true;
                    carList.RemoveAt(i);
                  }
                }
                if(found == false){
                  Console.WriteLine("No matching car.");
                }
                else{
                  Console.WriteLine("Removed Successfully");
                }
                
              }
              else if(count == 1){
                for(int i = carList.Count-1; i >= 0; i--){
                  if(carList[i].Make == makeInp && carList[i].Model == modelInp){
                    carList.RemoveAt(i);
                  }
                }
                Console.WriteLine("Removed Successfully");
              }
              else{
                Console.WriteLine("No car matching your search");
                Console.WriteLine("Nothing deleted");
                Console.WriteLine();
              }
            }
            catch(Exception e){
              Console.WriteLine("Invalid Input");
              Console.WriteLine();
            }
          }
          else if(option == 5){
            Console.WriteLine("Current Cars:");
            foreach(Car car in carList){
              Console.WriteLine("Car ID: " + car.CarID);
              Console.WriteLine("VIN: " + car.vIN);
              Console.WriteLine("Make: " + car.Make);
              Console.WriteLine("Model: " + car.Model);
              Console.WriteLine("Year: " + car.Year);
              Console.WriteLine("Price: " + car.Price);
              Console.WriteLine();
            }
          }
          else if(option == 6){
            int max = 0;
            int mostSearchedMake = 0;
            foreach(Search search in searchList){
              if(max < search.SearchCount){
                max = search.SearchCount;
                mostSearchedMake = search.searchMake;
              }
            }
            Console.WriteLine("The most searched make is: " + mostSearchedMake);
            Console.WriteLine();
          }
          else if(option == 7){
            exit = true;
          }
        }

      }
  }
}
