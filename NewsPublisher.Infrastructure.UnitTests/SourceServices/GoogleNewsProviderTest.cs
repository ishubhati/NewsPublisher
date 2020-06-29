using NewsPublisher.Core.Entities;
using NewsPublisher.Infrastructure.SourceServices;
using NUnit.Framework;
using System.Collections.Generic;

namespace NewsPublisher.Infrastructure.UnitTests.SourceServices
{
    public class GoogleNewsProviderTest
    {
        private readonly GoogleNewsProvider _googleNewsProvider;
        public GoogleNewsProviderTest()
        {
            _googleNewsProvider = new GoogleNewsProvider();
        }
        [Test]
        public void GetNewsContents_ResultTest()
        {
            var result = _googleNewsProvider.GetNewsContents();
            Assert.IsNotNull(result);
        }

        [Test]
        public void GetNewsContents_CountNotZeroTest()
        {
            var result = _googleNewsProvider.GetNewsContents();
            Assert.NotZero(result.Count);
        }
        [Test]
        public void GetNewsContents_InstanceOfContentEntityTest()
        {
            var result = _googleNewsProvider.GetNewsContents();
            Assert.IsInstanceOf<List<NewsContentEntity>>(result);
        }


    }
}
