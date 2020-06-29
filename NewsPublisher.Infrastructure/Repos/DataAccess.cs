using NewsPublisher.Core.Entities;
using NewsPublisher.Core.Interfaces;
using Newtonsoft.Json;
using System.IO;

namespace NewsPublisher.Infrastructure.Repos
{
    public class DataAccess : IDataAccess
    {
        public bool RegisterNewsSource(NewsProviderEntity newsProviderEntity)
        {
            string jsonFile = "NewsProviders.json";

            var newsProvidersData = JsonConvert.DeserializeObject<NewsProvidersData>(File.ReadAllText(jsonFile));

            newsProvidersData.NewsProviders.Add(new NewsProviderEntity
            {
                Contact = newsProviderEntity.Contact,
                Email = newsProviderEntity.Email,
                Name = newsProviderEntity.Name
            });

            var json = JsonConvert.SerializeObject(newsProvidersData);

            File.WriteAllText(jsonFile, json);

            return true;
        }
    }
}
