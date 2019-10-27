namespace decorator
{
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
