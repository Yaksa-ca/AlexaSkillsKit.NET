using Newtonsoft.Json;

namespace AlexaSkillsKit.Interfaces.InSkillPurchase.Responses
{
    public class ConnectionResponsePayload
    {
        [JsonProperty("purchaseResult")]
        public string PurchaseResult { get; set; }

        [JsonProperty("productId")]
        public string ProductId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}