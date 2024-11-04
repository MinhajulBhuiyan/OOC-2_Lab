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

        bool canTakeTrip();

        int perHeadFare();

    }

    public abstract class Vehicle
    {
        public int distanceKM { get; set; }
        public int timeMinutes { get; set; }
        public int numberOfPassengers { get; set; }
    }

    public class Sedan : Vehicle, Ivehicle
    {
        public Sedan(int distanceKM, int timeMinutes, int numberOfPassengers)
        {
            this.distanceKM = distanceKM;
            this.timeMinutes = timeMinutes;
            this.numberOfPassengers = numberOfPassengers;
        }

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


        

    }
    public class SEVEN_SEATER : Vehicle, Ivehicle
    {
        public SEVEN_SEATER(int distanceKM, int timeMinutes, int numberOfPassengers)
        {
            this.distanceKM = distanceKM;
            this.timeMinutes = timeMinutes;
            this.numberOfPassengers = numberOfPassengers;
        }

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

    }

    public class MOTOR_BIKE : Vehicle, Ivehicle
    {
        public MOTOR_BIKE(int distanceKM, int timeMinutes, int numberOfPassengers)
        {
            this.distanceKM = distanceKM;
            this.timeMinutes = timeMinutes;
            this.numberOfPassengers = numberOfPassengers;
        }

        public bool canTakeTrip()
        {
            if (numberOfPassengers <= 0)
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

    }



    public class TakeTrip
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

            if (vehicleType == VehicleType.SEDAN)
            {
                iv = new Sedan(distanceKM, timeMinutes, numberOfPassengers);
            }
            else if (vehicleType == VehicleType.SEVEN_SEATER)
            {
                iv = new SEVEN_SEATER(distanceKM, timeMinutes, numberOfPassengers);
            }
            else if (vehicleType == VehicleType.MOTOR_BIKE)
            {
                iv = new MOTOR_BIKE(distanceKM, timeMinutes, numberOfPassengers);
            }
        }
    }
}