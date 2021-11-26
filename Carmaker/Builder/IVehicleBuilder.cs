using Carmaker.Products;

namespace Carmaker.Builder
{
    public interface IVehicleBuilder
    {
        void SetModel();
        void SetEngine();
        void SetTransmission();
        void SetBody();
        void SetAccessories();
        Vehicle GetVehicle();
    }
}
