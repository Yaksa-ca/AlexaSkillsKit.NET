using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AlexaSkillsKit.Interfaces.InSkillPurchase
{
    /// <summary>
    /// Reference: https://developer.amazon.com/docs/in-skill-purchase/in-skill-product-service.html#inskillproduct
    /// </summary>
    public class InSkillProduct
    {
        /// <summary>
        /// Product identifier, guaranteed to be unique. Used for initiating product offers and purchases.
        /// productId: "amzn1.adg.product.aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeee"
        /// </summary>
        [JsonProperty("productId")]
        public string ProductId { get; set; }

        /// <summary>
        /// Name of the product in the language from the Accept-Language header
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Reference name for the product, as provided by you when you add the product to the skill
        /// </summary>
        [JsonProperty("referenceName")]
        public string ReferenceName { get; set; }

        /// <summary>
        /// Product type. Can be CONSUMABLE, SUBSCRIPTION or ENTITLEMENT
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Product summary in the language from the Accept-Language header
        /// </summary>
        [JsonProperty("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// Indicates if product can be purchased by this user. Either PURCHASABLE or NON_PURCHASABLE.
        /// </summary>
        [JsonProperty("purchasable")]
        public string Purchasable { get; set; }

        /// <summary>
        /// Enumeration value that indicates if this user is entitled to the product. Either ENTITLED or NOT_ENTITLED.
        /// </summary>
        [JsonProperty("entitled")]
        public string Entitled { get; set; }

        /// <summary>
        /// Number of entitlements the user has to this product. 
        /// For a CONSUMABLE, this is the total number of times the user purchased the product. 
        /// Note that this does not reflect the user's consumption of the purchased units, so you must manage the user's inventory. 
        /// For a SUBSCRIPTION or ENTITLEMENT, this is always either 0 or 1.
        /// </summary>
        [JsonProperty("activeEntitlementCount")]
        public int ActiveEntitlementCount { get; set; }

        [JsonProperty("purchaseMode")]
        public string PurchaseMode { get; set; }
    }
}
