using NewsPublisher.Core.Interfaces;
using Newtonsoft.Json;

namespace NewsPublisher.Core.ResponseModel
{
    public class GenericResponse : IResponse
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool HasError { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonIgnore]
        public string StatusCode { get; set; }
    }
}
