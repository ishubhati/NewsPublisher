namespace NewsPublisher.Core.Entities
{
    public class NewsContentEntity : ContentEntity
    {
        public string Category { get; set; }
        public bool IsHighPriority { get; set; }
    }
}
