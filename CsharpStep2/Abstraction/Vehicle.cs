using System;

namespace vehicleConfigurationSystem
{
    //rule+Implement method
    abstract class Vehicle
    {

        //Methods with out a body and implemented in derived class(child class)
        //abstract method without body
        //public abstract void StartEngine();
        ////concrete method with body
        //public void StopEngine()
        //{
        //    Console.WriteLine("Engine stopped.");
        //}
        //rules = stop();
        //start();

        public abstract void start();
        public abstract void stop();
        public abstract void Engine();

        //properties
        public string FuelType {get; set;}
        public int Capacity { get; set; }

        //concrete method

        public void showDetails()
        {
            Console.WriteLine($"fuel Type: {FuelType}");
            Console.WriteLine($"Capacity: {Capacity} passengers");

        }

    }


    class Car : Vehicle
    {
        //we uese override keyword in csharp  when we implement abstract method in derived class(if you remove overide it acts as direct call)
        public override void Engine()
        {
            Console.WriteLine($"car engine has started with 4 cyclinder engine");
        }

        public override void start()
        {
            Console.WriteLine("Car has started.");
        }

        public override void stop()
        {
            Console.WriteLine("Car has stopped.");
        }

        //direct method
        public void CarPurchaseDateandTime()
        {
            Console.WriteLine("car purshased on 2012-08-49 at 10:00 AM");
        }
    }

    class Bike : Vehicle
    {
        public override void Engine()
        {
            Console.WriteLine("Bike engine start with 2 stroke");
        }

        public override void start()
        {
            Console.WriteLine("Bike engine start");
        }

        public override void stop()
        {
            Console.WriteLine("Bike engine stop");
        }
    }

    class program
    {
        static void Main()
        {
            //can't create Instance for abstract class
            //Vehicle myVehicle = new Vehicle(); //error: cannot create instance of abstract class

            //Vehicle carvehicle = new Car();
            //carvehicle.start();
            //carvehicle.stop();
            //carvehicle.Engine();
            //carvehicle.FuelType = "Diesel";
            //carvehicle.Capacity = 5;
            //carvehicle.showDetails();

            Vehicle carvehicle = new Car()
            {
                FuelType = "Petrol",
                Capacity = 3
            };
            carvehicle.showDetails();
            carvehicle.start();
            carvehicle.stop();
            carvehicle.Engine();

            Vehicle bikevehicle = new Bike()
            {
                FuelType = "Petrol",
                Capacity = 2
            };
            bikevehicle.start();
            bikevehicle.stop();
            bikevehicle.Engine();
            bikevehicle.showDetails();

        }
    }
}
