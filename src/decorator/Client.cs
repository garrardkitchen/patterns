using System;
namespace decorator
{
    public class Client
    {
        static public void Display(string s, IVehicle vehicle)
        {
            Console.WriteLine($"{s} {vehicle.GetDescription()}");
        }
    }
}
