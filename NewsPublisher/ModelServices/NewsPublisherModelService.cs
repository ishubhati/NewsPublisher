using NewsPublisher.Core.Entities;
using NewsPublisher.Core.Enum;
using NewsPublisher.Core.Interfaces;
using NewsPublisher.Core.ResponseModel;
using NewsPublisher.Interfaces;
using NewsPublisher.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace NewsPublisher.ModelServices
{
    public class NewsPublisherModelService : INewsPublisherModelService
    {
        private readonly IDataAccess _dataAccesse;
        private readonly IAdvertisement _advertisement;

        public const int PAGE_LIMIT = 8;

        public int ID = 1;
        public NewsPublisherModelService(IDataAccess dataAccesse, IAdvertisement advertisement)
        {
            _dataAccesse = dataAccesse;
            _advertisement = advertisement;
        }

        public GenericResponse RegisterNewsSource(NewsSourceProvider newsSourceprovider)
        {
            var response = new GenericResponse();
            var record = _dataAccesse.RegisterNewsSource(new NewsProviderEntity
            {
                Contact = newsSourceprovider.Contact,
                Email = newsSourceprovider.Email,
                Name = newsSourceprovider.Name
            });

            if (record)
            {
                response.Message = "News provider added successfully.";
                response.StatusCode = "201";
            }
            else
            {
                response.ErrorMessage = "Something went wrong";
                response.HasError = true;
            }

            return response;
        }

        public SingleResponse<List<NewsContentResponse>> GetNewsContents(int PageId)
        {
            var returnResponse = new SingleResponse<List<NewsContentResponse>>();

            var newsContentResponse = new List<NewsContentResponse>();

            string jsonFile = "NewsProviders.json";
            NewsProvidersData newsProvidersData = null;

            newsProvidersData = JsonConvert.DeserializeObject<NewsProvidersData>(File.ReadAllText(jsonFile));

            var infraAssembly = AppDomain.CurrentDomain.GetAssemblies().ToList().Find(itm => itm.FullName.Contains("NewsPublisher.Infrastructure"));

            foreach (var item in newsProvidersData.NewsProviders)
            {
                List<NewsContentEntity> newsContents = GetNewsContentDynamically(infraAssembly, item);

                FillNewsContents(newsContentResponse, newsContents);
            }

            newsContentResponse = SetPages(PageId, returnResponse, newsContentResponse);

            newsContentResponse = AddAdvertisement(newsContentResponse);

            returnResponse.Model = newsContentResponse;

            return returnResponse;
        }

        private List<NewsContentResponse> AddAdvertisement(List<NewsContentResponse> newsContentResponse)
        {
            var totalHighPriority = newsContentResponse.FindAll(itm => itm.IsHighPriority == true).Count;
            if (totalHighPriority == newsContentResponse.Count)
                return newsContentResponse;

            var ads = _advertisement.GetAdvertisements();

            if (newsContentResponse.Count == PAGE_LIMIT)
            {
                newsContentResponse = newsContentResponse.SkipLast(2).ToList();
                foreach (var ad in ads)
                {
                    FillAdd(newsContentResponse, ad);
                    ID++;

                }
            }
            else if (newsContentResponse.Count < PAGE_LIMIT / 2)
            {
                if (ads.Count > 0)
                {
                    FillAdd(newsContentResponse, ads[0]);
                }
            }
            else if (newsContentResponse.Count < PAGE_LIMIT)
            {
                if (ads.Count > 0)
                {
                    FillAdd(newsContentResponse, ads[0]);
                }
            }

            return newsContentResponse;

        }

        private void FillAdd(List<NewsContentResponse> newsContentResponse, AdvertisementEntity ad)
        {
            newsContentResponse.Add(new NewsContentResponse
            {
                Id = ID,
                Category = ad.Category,
                Description = ad.Description,
                ImageTitle = ad.ImageTitle,
                ImageUrl = ad.ImageUrl,
                Title = ad.Title,
                Type = ContentType.Ad
            });
        }

        private static List<NewsContentResponse> SetPages(int PageId, SingleResponse<List<NewsContentResponse>> returnResponse, List<NewsContentResponse> newsContentResponse)
        {
            if (newsContentResponse.Count >= PAGE_LIMIT)
            {
                var totalPages = Math.Ceiling(Convert.ToDouble(newsContentResponse.Count) / Convert.ToDouble((PAGE_LIMIT)));

                if (PageId > 1)
                    newsContentResponse = newsContentResponse.Skip(PAGE_LIMIT * (PageId - 1)).Take(PAGE_LIMIT).ToList();
                else
                    newsContentResponse = newsContentResponse.Take(PAGE_LIMIT * PageId).ToList();

                if (PageId < totalPages)
                {
                    returnResponse.pageId = PageId + 1;
                }

            }

            return newsContentResponse;
        }

        private void FillNewsContents(List<NewsContentResponse> newsContentResponse, List<NewsContentEntity> newsContents)
        {

            foreach (var news in newsContents)
            {
                newsContentResponse.Add(new NewsContentResponse
                {
                    Id = ID,
                    Category = news.Category,
                    Description = news.Description,
                    ImageTitle = news.ImageTitle,
                    ImageUrl = news.ImageUrl,
                    IsHighPriority = news.IsHighPriority,
                    Title = news.Title,
                    Type = ContentType.News
                });
                ID++;
            }
        }

        private static List<NewsContentEntity> GetNewsContentDynamically(Assembly infraAssembly, NewsProviderEntity item)
        {
            List<NewsContentEntity> newsContents = null;
            var className = string.Format("{0}.SourceServices.{1}Provider", infraAssembly.GetName().Name, item.Name);
            Type classstart = infraAssembly.GetType(className);
            try
            {
                Type AbserveStart = classstart.GetInterface("NewsPublisher.Core.Interfaces.INewsSourceProvider");
                MethodInfo startMethod = AbserveStart.GetMethod("GetNewsContents");
                object interfaceObject = Activator.CreateInstance(classstart);
                newsContents = (List<NewsContentEntity>)startMethod.Invoke(interfaceObject, null);
            }
            catch
            {
                //Log exception provider interface needs to be implemnetd
                newsContents = new List<NewsContentEntity>();
            }
            return newsContents;
        }


    }
}
