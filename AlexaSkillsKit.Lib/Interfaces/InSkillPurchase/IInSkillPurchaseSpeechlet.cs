using AlexaSkillsKit.Interfaces.InSkillPurchase.Responses;
using AlexaSkillsKit.Speechlet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexaSkillsKit.Interfaces.InSkillPurchase
{
    public interface IInSkillPurchaseSpeechlet
    {
        ConnectionResponse OnInPurchaseIntent(ExtendedSpeechletRequest InPurchaseRequest, Context context);
    }
}
