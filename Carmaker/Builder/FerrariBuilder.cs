using Carmaker.Products;

namespace Carmaker.Builder
{
    public class FerrariBuilder : IVehicleBuilder
    {
        readonly Vehicle objVehicle = new();
        public Vehicle GetVehicle()
        {
            return objVehicle;
        }

        public void SetAccessories()
        {
            objVehicle.Accessories.Add("Cobertura do assento");
            objVehicle.Accessories.Add("Espelho retrovisor");
            objVehicle.Accessories.Add("Capacete");
            objVehicle.Accessories.Add("Radio");
            objVehicle.Accessories.Add("Glove compartment");
        }

        public void SetBody()
        {
            objVehicle.Body = "Fibra de vidro";
        }

        public void SetEngine()
        {
            objVehicle.Engine = "4 cavalos";
        }

        public void SetModel()
        {
            objVehicle.Model = "Ferrari 360";
        }

        public void SetTransmission()
        {
            objVehicle.Transmission = "280 Km/hr";
        }
    }
}
