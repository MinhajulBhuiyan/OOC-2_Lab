using System;

public abstract class Vehicle
{
    public string FuelType { get; set; }

    public void Start()
    {
        Console.WriteLine("Vehicle is starting.");
    }

    public void Stop()
    {
        Console.WriteLine("Vehicle is stopping.");
    }
}

interface IDriveable
{
    void Accelerate();
}

interface IRideable
{

}

class Car : Vehicle, IDriveable
{
    public Car()
    {
        FuelType = "Petrol";
    }

    public void Accelerate()
    {
        Console.WriteLine("Car is accelerating...");
    }
}

class Bus : Vehicle, IDriveable
{
    public Bus()
    {
        FuelType = "Diesel";
    }

    public void Accelerate()
    {
        Console.WriteLine("Bus is accelerating...");
    }
}

class Bicycle : Vehicle, IRideable
{
    public Bicycle()
    {
        FuelType = "No fuel";
    }
}

class Program
{
    static void Main(string[] args)
    {

        int numVehicles = int.Parse(Console.ReadLine());

        Vehicle[] vehicles = new Vehicle[numVehicles];

        for (int i = 0; i < numVehicles; i++)
        {
            Console.WriteLine($"Select vehicle type for vehicle {i + 1}:\n1. Car\n2. Bus\n3. Bicycle");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    vehicles[i] = new Car();
                    break;
                case 2:
                    vehicles[i] = new Bus();
                    break;
                case 3:
                    vehicles[i] = new Bicycle();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Defaulting to Bicycle.");
                    vehicles[i] = new Bicycle();
                    break;
            }
        }

        
    }
}