using AlexaSkillsKit.Speechlet;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AlexaSkillsKit.Interfaces.InSkillPurchase.Responses
{
    public class ConnectionResponse: ISpeechletResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("status")]
        public ConnectionResponseStatus Status { get; set; }

        [JsonProperty("payload")]
        public ConnectionResponsePayload Payload { get; set; }
    }
}
