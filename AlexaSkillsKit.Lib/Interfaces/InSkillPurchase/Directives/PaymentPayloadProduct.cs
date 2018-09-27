using Newtonsoft.Json;

namespace AlexaSkillsKit.Interfaces.InSkillPurchase.Directives
{
    public class PaymentPayloadProduct
    {
        public PaymentPayloadProduct() { }

        public PaymentPayloadProduct(string productId)
        {
            ProductId = productId;
        }

        [JsonProperty("productId")] public string ProductId { get; private set; }
    }
}