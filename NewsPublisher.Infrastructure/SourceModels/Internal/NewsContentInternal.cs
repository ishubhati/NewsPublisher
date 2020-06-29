using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPublisher.Infrastructure.SourceModels.Internal
{
    public class NewsContentInternal
    {
        public string Headline { get; set; }
        public string Description { get; set; }
        public string ImageCDNUrl { get; set; }
        public string ImageTitle { get; set; }
        public string Category { get; set; }
        public bool IsBreakingNews { get; set; }
    }
}
