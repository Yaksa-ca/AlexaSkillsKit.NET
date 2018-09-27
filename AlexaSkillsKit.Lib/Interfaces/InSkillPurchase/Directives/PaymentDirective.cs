using System.Text;
using AlexaSkillsKit.Speechlet;
using Newtonsoft.Json;

namespace AlexaSkillsKit.Interfaces.InSkillPurchase.Directives
{
    public class PaymentDirective: Directive
    {
        public PaymentDirective() : base("Connections.SendRequest") { }

        public PaymentDirective(string paymentType, string correlationToken, PaymentPayload payload) : this()
        {
            Name = paymentType;
            Payload = payload;//new PaymentPayload(productId);
            Token = correlationToken;
        }

        //[JsonProperty("type")]
        //public string Type => "Connections.SendRequest";

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("token")] public string Token { get; set; }

        [JsonProperty("payload")] public PaymentPayload Payload { get; set; }
    }
}
