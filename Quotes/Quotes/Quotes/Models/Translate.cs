namespace Quotes.Models
{
    using Newtonsoft.Json;

    public class Translate
    {
        [JsonProperty("detectedLanguage")]
        public DetectedLanguage DetectedLanguage { get; set; }

        [JsonProperty("translations")]
        public Translation[] Translations { get; set; }
    }
}
