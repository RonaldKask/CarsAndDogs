using System;

namespace Car
{
    class Program
    {

        class Car
        {
            string markName;
            string modelName;
            string registrationNumber;
            string colour;
            int odometer;
            int fuelTank;

            public Car(string _markName, string _modelName, string _colour, string _registrationNumber)
            {
                markName = _markName;
                modelName = _modelName;
                colour = _colour;
                if(_registrationNumber.Length != 6)
                {
                    registrationNumber = "undefined";
                }else
                {
                    registrationNumber = _registrationNumber;
                }
                odometer = 0;
                fuelTank = 60;
            }

            public string MarkName
            {
                get { return markName; }
            }

            public string ModelName
            {
                get { return modelName; }
            }

            public string Colour
            {
                get { return colour; }
            }

            public int FuelTank
            {
                get { return fuelTank; }
            }

            public int Odometer
            {
                get { return odometer; }
            }

            public void Drive()
            {
                Console.WriteLine("The car has driven a lap");
                fuelTank -= 5;
                odometer += 100;
            }

            public void ShowCarData()
            {
                Console.WriteLine($"The cars mark is {markName}, mark number is {modelName}, colour is {colour}, the fuel tank has {fuelTank} gas left and the odometer is at {odometer}.");
            }


        }


        static void Main(string[] args)
        {
            Car newCar = new Car("Honda", "Civic", "Red", "567856");
            while(newCar.FuelTank != 0)
            {
                newCar.Drive();
            }

            Console.WriteLine("The ride is over.");
            newCar.ShowCarData();
        }
    }
}
