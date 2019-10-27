using System;
namespace decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle veh = new Vehicle();
            Client.Display("1", veh);
            Client.Display("2", new Car(veh));
            Client.Display("3", new Van(veh));           
        }
    }
}
