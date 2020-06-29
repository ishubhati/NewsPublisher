using NewsPublisher.Core.Entities;
using NewsPublisher.Core.Interfaces;
using System.Collections.Generic;

namespace NewsPublisher.Infrastructure.Advertisement
{
    public class Advertisement : IAdvertisement
    {
        public List<AdvertisementEntity> GetAdvertisements()
        {
            var advertisementEntityList = new List<AdvertisementEntity>
            {
                new AdvertisementEntity
                {
                    Category = "Car",
                    Description = "Book a Star Online and unlock special offers from Wishbox.",
                    ImageTitle = "Best comfort in segment",
                    ImageUrl = "https://www.shop.mercedes-benz.co.in/express/WDD2131046L021277",
                    Title = "The Mercedes-Benz E-Class"
                },
                new AdvertisementEntity
                {
                    Category = "Food",
                    Description ="The Food we had enjoyed at the time of dinner. It was really delicious taste with great quality, everything had unique taste which we had ordered, nice arrangement and services from the staff while eating",
                    ImageTitle = "super food and Fun",
                    ImageUrl = "https://www.gourmetads.com/wp-content/uploads/2019/08/food-advertising-examples-green-giant-califlower-300x600.jpg",
                    Title = "Try NEW Green Giant PIZZA Crust"
                },
            };

            return advertisementEntityList;
        }
    }
}
