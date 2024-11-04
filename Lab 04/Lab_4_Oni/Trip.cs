using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{

    public enum VehicleType
    {
    SEDAN, MOTOR_BIKE, SEVEN_SEATER
    }

    public interface Ivehicle
    {

        public bool canTakeTrip();

        public int perHeadFare();

    }

    public abstract class Vehicle
    {
        public int distanceKM { get; set; }
        public int timeMinutes{ get; set; }
        public int numberOfPassengers { get; set; }
    }

    public class Sedan : Vehicle,Ivehicle
    {

        public bool canTakeTrip()
        {
            if (numberOfPassengers <= 0)
            {
                return false;
            }
            if (numberOfPassengers <= 4 && distanceKM <= 25)
            {
                return true;
            
            }
            return false;
        }

        public int perHeadFare()
        {
            return (50 + distanceKM * 30 + timeMinutes * 2) / numberOfPassengers;
        }


        //constructor
        public Sedan(int distanceKM, int timeMinutes,int numberOfPassengers) 
        {
            this.distanceKM = distanceKM;
            this.timeMinutes = timeMinutes;
            this.numberOfPassengers = numberOfPassengers;
        }

    }
    public class SEVEN_SEATER : Vehicle, Ivehicle
    {

        public bool canTakeTrip()
        {
            if (numberOfPassengers <= 0)
            {
                return false;
            }
            if (numberOfPassengers <= 7 && distanceKM >= 10)
            {
                return true;

            }
            return false;
        }

        public int perHeadFare()
        {
            return distanceKM * 30 / numberOfPassengers;
        }


        //constructor
        public SEVEN_SEATER(int distanceKM, int timeMinutes, int numberOfPassengers)
        {
            this.distanceKM = distanceKM;
            this.timeMinutes = timeMinutes;
            this.numberOfPassengers = numberOfPassengers;
        }

    }

    public class MOTOR_BIKE : Vehicle, Ivehicle
    {

        public bool canTakeTrip()
        {
            if(numberOfPassengers<=0)
            {
                return false;   
            }
            if (numberOfPassengers <= 1 && distanceKM <= 10)
            {
                return true;

            }
            return false;
        }

        public int perHeadFare()
        {                                     
            return Math.Max(25, distanceKM * 20) / numberOfPassengers;
        }


        //constructor
        public MOTOR_BIKE(int distanceKM, int timeMinutes, int numberOfPassengers)
        {
            this.distanceKM = distanceKM;
            this.timeMinutes = timeMinutes;
            this.numberOfPassengers = numberOfPassengers;
        }

    }



    public class TakeTrip//delegatorrrr
    {

        public Ivehicle v { get; set; }


        public bool canTakeTrip()
        {
            return v.canTakeTrip();
                    
        }

        public TakeTrip(Ivehicle v)
        {
            this.v = v;

        }

        public int perHeadFare()
        {
           return v.perHeadFare();
        }
    }



    public class Factory
    {
        private VehicleType vehicleType;

        public Ivehicle iv = null;

        
        public Factory(VehicleType vehicleType, int distanceKM, int timeMinutes, int numberOfPassengers)
        {
            this.vehicleType = vehicleType;

            if(vehicleType == VehicleType.SEDAN)
            {
                iv = new Sedan(distanceKM, timeMinutes, numberOfPassengers);
            }
            else if(vehicleType == VehicleType.SEVEN_SEATER)
            {
                iv = new SEVEN_SEATER(distanceKM, timeMinutes, numberOfPassengers);
            }
            else if(vehicleType == VehicleType.MOTOR_BIKE)
            {
                iv = new MOTOR_BIKE(distanceKM, timeMinutes, numberOfPassengers);
            }            
        }
    }
}
/*This code snippet represents a simple Factory class in object-oriented programming 
 * (OOP) and demonstrates the use of a factory method. Let's break down the code and explain its purpose:

public class Factory: This line declares a class named "Factory."

private VehicleType vehicleType: This line declares a private member variable called "vehicleType," 
which is an enumeration (assumed to be defined elsewhere in the code) representing different types of vehicles.

public Ivehicle iv = null;: This line declares a public member variable "iv" of type 
"Ivehicle" (presumably an interface or base class representing vehicles) and initializes 
it to null. This variable will be used to store an instance of a specific vehicle type created by the factory.

public Factory(VehicleType vehicleType, int distanceKM, int timeMinutes, int numberOfPassengers): 
This is the constructor of the Factory class. It takes several parameters:

VehicleType vehicleType: Indicates the type of vehicle to be created.
int distanceKM: Represents the distance in kilometers.
int timeMinutes: Represents the time in minutes.
int numberOfPassengers: Indicates the number of passengers.
Inside the constructor, the provided "vehicleType" is used to decide which type of vehicle to create based on a conditional check.

If "vehicleType" is equal to VehicleType.SEDAN, it creates an instance of the "Sedan" class 
with the provided parameters and assigns it to the "iv" variable.
If "vehicleType" is equal to VehicleType.SEVEN_SEATER, it creates an instance of the "SEVEN_SEATER" 
class with the provided parameters and assigns it to the "iv" variable.
If "vehicleType" is equal to VehicleType.MOTOR_BIKE, it creates an instance of the "MOTOR_BIKE" 
class with the provided parameters and assigns it to the "iv" variable.
In essence, this Factory class acts as a creator of different types of vehicles based on the 
"vehicleType" parameter. It encapsulates the object creation process, allowing the client code to 
request a vehicle without needing to know the details of how each vehicle type is constructed. 
This is a common design pattern called the Factory Method pattern.

The use of a factory method helps in achieving encapsulation, separation of concerns, and 
flexibility in object creation. It abstracts the instantiation logic from the client code and makes 
it easier to introduce new vehicle types in the future without modifying existing code./*