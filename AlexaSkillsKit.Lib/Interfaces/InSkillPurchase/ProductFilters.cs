using System;
using System.Collections.Generic;
using System.Text;

namespace AlexaSkillsKit.Interfaces.InSkillPurchase
{
    public class ProductFilters
    {
        public int? MaxResults { get; set; }
        public string Entitled { get; set; }
        public string Purchasable { get; set; }
        public string ProductType { get; set; }

        public bool AnySet => MaxResults.HasValue ||
                              !string.IsNullOrWhiteSpace(Entitled) ||
                              !string.IsNullOrWhiteSpace(Purchasable) ||
                              !string.IsNullOrWhiteSpace(ProductType);
    }
}
