using Carmaker.Builder;
using Carmaker.Products;

namespace Carmaker.Director
{
    public class VehicleCreator
    {
        private readonly IVehicleBuilder objBuilder;
        public VehicleCreator(IVehicleBuilder vehicleBuilder)
        {
            objBuilder = vehicleBuilder;
        }

        public void CreateVehicle()
        {
            objBuilder.SetModel();
            objBuilder.SetEngine();
            objBuilder.SetBody();
            objBuilder.SetTransmission();
            objBuilder.SetAccessories();
        }

        public Vehicle GetVehicle()
        {
            return objBuilder.GetVehicle();
        }
    }
}
