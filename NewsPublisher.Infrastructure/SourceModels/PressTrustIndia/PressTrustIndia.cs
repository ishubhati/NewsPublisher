using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPublisher.Infrastructure.SourceModels.PressTrustIndia
{
    class PressTrustIndia
    {
        public string NewsTitle { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string ImageTitle { get; set; }
        public string type { get; set; }
        public bool IsHotNews { get; set; }
    }
}
