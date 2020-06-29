using Moq;
using NewsPublisher.Core.Entities;
using NewsPublisher.Core.Interfaces;
using NewsPublisher.Model;
using NewsPublisher.ModelServices;
using NUnit.Framework;
using System.Collections.Generic;

namespace NewsPublisher.UnitTests.ModelService
{
    public class NewsPublisherModelServiceTest
    {
        private readonly Mock<IDataAccess> _dataAccess;
        private readonly Mock<IAdvertisement> _advertisement;
        public NewsPublisherModelServiceTest()
        {
            _dataAccess = new Mock<IDataAccess>();
            _advertisement = new Mock<IAdvertisement>();
        }

        [Test]
        public void RegisterNewsSource_HasError()
        {
            // Arrange
            bool expected = false;

            var request = new NewsSourceProvider
            {
                Name = "GoogleNews",
                Email = "Test@ImTest.com",
                Contact = "5454545555"
            };

            _dataAccess.Setup(service => service.RegisterNewsSource(It.IsAny<NewsProviderEntity>())).Returns(expected);

            var accountModelService = new NewsPublisherModelService(_dataAccess.Object, null);

            //Act
            var result = accountModelService.RegisterNewsSource(request);

            //Assert
            Assert.IsTrue(result.HasError);
        }
        [Test]
        public void RegisterNewsSource_SomethingWentWrong()
        {
            // Arrange
            bool expected = false;

            var request = new NewsSourceProvider
            {
                Name = "GoogleNews",
                Email = "Test@ImTest.com",
                Contact = "5454545555"
            };

            _dataAccess.Setup(service => service.RegisterNewsSource(It.IsAny<NewsProviderEntity>())).Returns(expected);

            var accountModelService = new NewsPublisherModelService(_dataAccess.Object, null);
            //Act
            var result = accountModelService.RegisterNewsSource(request);
            //Assert
            Assert.AreSame("Something went wrong", result.ErrorMessage);
        }

        [Test]
        public void RegisterNewsSource_AddedSuccessfully()
        {
            // Arrange
            bool expected = true;

            var request = new NewsSourceProvider
            {
                Name = "GoogleNews",
                Email = "Test@ImTest.com",
                Contact = "5454545555"
            };

            _dataAccess.Setup(service => service.RegisterNewsSource(It.IsAny<NewsProviderEntity>())).Returns(expected);

            var accountModelService = new NewsPublisherModelService(_dataAccess.Object, null);
            //Act
            var result = accountModelService.RegisterNewsSource(request);
            // Assert
            Assert.AreSame("News provider added successfully.", result.Message);
        }
        [Test]
        public void RegisterNewsSource_StatusCode201()
        {
            // Arrange
            bool expected = true;

            var request = new NewsSourceProvider
            {
                Name = "GoogleNews",
                Email = "Test@ImTest.com",
                Contact = "5454545555"
            };

            _dataAccess.Setup(service => service.RegisterNewsSource(It.IsAny<NewsProviderEntity>())).Returns(expected);

            var accountModelService = new NewsPublisherModelService(_dataAccess.Object, null);

            // Act
            var result = accountModelService.RegisterNewsSource(request);

            // Assert
            Assert.AreSame("201", result.StatusCode);
        }


        public void GetNewsContents_SuccessResult()
        {
            List<AdvertisementEntity> expected = new List<AdvertisementEntity>();

            var pageId = 0;


            _dataAccess.Setup(service => service.RegisterNewsSource(It.IsAny<NewsProviderEntity>())).Returns(false);
            _advertisement.Setup(service => service.GetAdvertisements()).Returns(expected);

            var accountModelService = new NewsPublisherModelService(_dataAccess.Object, _advertisement.Object);

            var result = accountModelService.GetNewsContents(pageId);

            Assert.IsNotNull(result);
        }
    }
}
