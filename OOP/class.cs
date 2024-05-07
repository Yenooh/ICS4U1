using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection.Metadata;

namespace Applications3Q3
{
    class Car{
        
        private int carID;
        public int CarID{
            get { return carID; }
            set { carID = value; }
        }
        private string VIN;
        public string vIN{
            get { return VIN; }
            set { VIN = value; }
        }
        private int make;
        public int Make{
            get { return make; }
            set { make = value; }
        }
        private string model;
        public string Model{
            get { return model; }
            set { model = value; }
        }
        private int year;
        public int Year{
            get { return year; }
            set { year = value; }
        }
        private double price;
        public double Price{
            get { return price; }
            set { price = value; }
        }
        public Car(){
            carID = 0;
            VIN = "";
            make = 0;
            model = "";
            year = 0;
            price = 0.00;
        }
    }

}
