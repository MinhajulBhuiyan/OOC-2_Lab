using System;

namespace OCP_Lab04
{
    public enum VehicleType
    {
        SEDAN, MOTOR_BIKE, SEVEN_SEATER
    }

    public interface IVehicle
    {
        int CalculateFare(int distanceKM, int timeMinutes, int numberOfPassengers);
        bool CanTakeTrip(int distanceKM, int numberOfPassengers);
    }

    public class Sedan : IVehicle
    {
        public int CalculateFare(int distanceKM, int timeMinutes, int numberOfPassengers)
        {
            return (50 + distanceKM * 30 + timeMinutes * 2) / numberOfPassengers;
        }

        public bool CanTakeTrip(int distanceKM, int numberOfPassengers)
        {
            return numberOfPassengers <= 4 && distanceKM <= 25;
        }
    }

    public class MotorBike : IVehicle
    {
        public int CalculateFare(int distanceKM, int timeMinutes, int numberOfPassengers)
        {
            return Math.Max(25, distanceKM * 20) / numberOfPassengers;
        }

        public bool CanTakeTrip(int distanceKM, int numberOfPassengers)
        {
            return numberOfPassengers <= 1 && distanceKM <= 10;
        }
    }

    public class SevenSeater : IVehicle
    {
        public int CalculateFare(int distanceKM, int timeMinutes, int numberOfPassengers)
        {
            return distanceKM * 30 / numberOfPassengers;
        }

        public bool CanTakeTrip(int distanceKM, int numberOfPassengers)
        {
            return numberOfPassengers <= 7 && distanceKM >= 10;
        }
    }

    public class Trip
    {
        private IVehicle vehicle;

        public Trip(VehicleType vehicleType)
        {
            switch (vehicleType)
            {
                case VehicleType.SEDAN:
                    vehicle = new Sedan();
                    break;
                case VehicleType.MOTOR_BIKE:
                    vehicle = new MotorBike();
                    break;
                case VehicleType.SEVEN_SEATER:
                    vehicle = new SevenSeater();
                    break;
                default:
                    throw new ArgumentException("Invalid vehicle type");
            }
        }

        public int PerHeadFare(int distanceKM, int timeMinutes, int numberOfPassengers)
        {
            int fare = vehicle.CalculateFare(distanceKM, timeMinutes, numberOfPassengers);
            return fare - (fare % 5);
        }

        public bool CanTakeTrip(int distanceKM, int numberOfPassengers)
        {
            return vehicle.CanTakeTrip(distanceKM, numberOfPassengers);
        }
    }
}
