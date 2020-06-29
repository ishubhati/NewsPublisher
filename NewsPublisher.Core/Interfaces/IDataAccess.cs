using NewsPublisher.Core.Entities;

namespace NewsPublisher.Core.Interfaces
{
    public interface IDataAccess
    {
        bool RegisterNewsSource(NewsProviderEntity newsProviderEntity);
    }
}
