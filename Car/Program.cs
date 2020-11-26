using System;

namespace Car
{
    class Program
    {

        class Car
        {
            string markName;
            string modelName;
            int registrationNumber;
            string colour;
            int odometer;
            int fuelTank;

            public Car(string _markName, string _modelName, string _colour)
            {
                markName = _markName;
                modelName = _modelName;
                colour = _colour;
                odometer = 0;
                fuelTank = 60;
            }

            public int Odometer
            {
                get { return odometer; }
            }

            public void Drive()
            {
                Console.WriteLine("The car has driven a lap");
                fuelTank =- 5;
                odometer = +100;
            }

            public void ShowCarData()
            {
                Console.WriteLine($"The cars name is {markName}, mark number is {}");
            }


        }


        static void Main(string[] args)
        {
            Car newCar = new Car("", )
            Console.WriteLine("");
        }
    }
}
