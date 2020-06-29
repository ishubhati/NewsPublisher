namespace NewsPublisher.Model
{
    public class NewsContent : Content
    {
        public string Category { get; set; }
        public bool IsHighPriority { get; set; }
    }
}
