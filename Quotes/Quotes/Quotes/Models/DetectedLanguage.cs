namespace Quotes.Models
{
    using Newtonsoft.Json;

    public class DetectedLanguage
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("score")]
        public long Score { get; set; }
    }
}
