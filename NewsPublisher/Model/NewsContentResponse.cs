using NewsPublisher.Core.Enum;

namespace NewsPublisher.Model
{
    public class NewsContentResponse : NewsContent
    {
        public ContentType Type { get; set; }
    }
}
