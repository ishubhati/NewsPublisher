using NewsPublisher.Core.Interfaces;
using Newtonsoft.Json;


namespace NewsPublisher.Core.ResponseModel
{
    public class SingleResponse<TModel> : ISingleResponse<TModel>
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        public bool HasError { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TModel Model { get; set; }
        [JsonIgnore]
        public string StatusCode { get; set; }

        [JsonIgnore]
        public double pageId { get; set; }
    }
}
