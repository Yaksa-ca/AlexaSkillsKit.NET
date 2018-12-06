﻿using Newtonsoft.Json;

namespace AlexaSkillsKit.Interfaces.InSkillPurchase.Directives
{
    public class PaymentPayload
    {
        public PaymentPayload()
        {
        }

        public PaymentPayload(string productId, string upsellMessage)
        {
            InSkillProduct = new PaymentPayloadProduct(productId);
            UpsellMessage = upsellMessage;
        }

        public PaymentPayload(string productId)
        {
            InSkillProduct = new PaymentPayloadProduct(productId);
            UpsellMessage = null;
        }


        [JsonProperty(PropertyName = "InSkillProduct")] public PaymentPayloadProduct InSkillProduct { get; set; }

        [JsonProperty(PropertyName ="upsellMessage",NullValueHandling = NullValueHandling.Ignore)] public string UpsellMessage { get; set; }
    }
}