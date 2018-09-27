using Newtonsoft.Json;

namespace AlexaSkillsKit.Interfaces.InSkillPurchase.Responses
{
    public class ConnectionResponseStatus
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}