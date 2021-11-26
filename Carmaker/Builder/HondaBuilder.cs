using Carmaker.Products;

namespace Carmaker.Builder
{
    public class HondaBuilder : IVehicleBuilder
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
        }

        public void SetBody()
        {
            objVehicle.Body = "Plástico";
        }

        public void SetEngine()
        {
            objVehicle.Engine = "4 cavalos";
        }

        public void SetModel()
        {
            objVehicle.Model = "Honda";
        }

        public void SetTransmission()
        {
            objVehicle.Transmission = "125 Km/hr";
        }
    }
}
