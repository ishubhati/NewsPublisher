using NewsPublisher.Core.ResponseModel;
using NewsPublisher.Model;
using System.Collections.Generic;

namespace NewsPublisher.Interfaces
{
    public interface INewsPublisherModelService
    {
        SingleResponse<List<NewsContentResponse>> GetNewsContents(int PageId);
        GenericResponse RegisterNewsSource(NewsSourceProvider newsSourceprovider);
    }
}
