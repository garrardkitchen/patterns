using System;
namespace decorator
{
    public interface IVehicle
    {
        string GetDescription();
    }

    public class Vehicle : IVehicle
    {
        public string GetDescription()
        {
            return "This is a";
        }
    }

    public class Car : IVehicle
    {
        private readonly IVehicle vehicle;

        public Car(IVehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public string GetDescription()
        {
            return $"{vehicle.GetDescription()} car";    
        }
    }

    public class Van : IVehicle
    {
        private readonly IVehicle vehicle;

        public Van(IVehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public string GetDescription()
        {
            return $"{vehicle.GetDescription()} van";
        }
    }
}
