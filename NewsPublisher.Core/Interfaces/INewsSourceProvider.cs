using NewsPublisher.Core.Entities;
using System.Collections.Generic;

namespace NewsPublisher.Core.Interfaces
{
    public interface INewsSourceProvider
    {
        List<NewsContentEntity> GetNewsContents();
    }
}
