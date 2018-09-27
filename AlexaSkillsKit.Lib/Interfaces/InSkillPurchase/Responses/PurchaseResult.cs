using System;
using System.Collections.Generic;
using System.Text;

namespace AlexaSkillsKit.Interfaces.InSkillPurchase.Responses
{
    public static class PurchaseResult
    {
        public const string Accepted = "ACCEPTED";
        public const string Declined = "DECLINED";
        public const string AlreadyPurchased = "ALREADY_PURCHASED";
        public const string Error = "ERROR";
    }
}
