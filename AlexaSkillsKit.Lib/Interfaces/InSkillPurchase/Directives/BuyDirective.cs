﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AlexaSkillsKit.Interfaces.InSkillPurchase.Directives
{
    public class BuyDirective:PaymentDirective
    {
        public BuyDirective(string productId, string token) :
            base(PaymentType.Buy, token, new PaymentPayload(productId))
        {

        }
    }
}