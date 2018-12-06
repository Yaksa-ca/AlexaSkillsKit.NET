using AlexaSkillsKit.Speechlet;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AlexaSkillsKit.Interfaces.InSkillPurchase.Responses
{
    public class ConnectionResponse: ExtendedSpeechletRequest
    {
        public static readonly string TypeName = "Connections.Response";

        public ConnectionResponse(string subtype, JObject json) : base(TypeName, subtype, json)
        {
            Token = json.Value<string>("token");
            Name = json.Value<string>("name");
        }

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
