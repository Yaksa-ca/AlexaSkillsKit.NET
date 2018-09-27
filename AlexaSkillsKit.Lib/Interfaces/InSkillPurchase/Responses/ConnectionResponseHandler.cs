using AlexaSkillsKit.Speechlet;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlexaSkillsKit.Interfaces.InSkillPurchase.Responses
{
    public class ConnectionResponseHandler: ExtendedSpeechletRequest
    {
        public static readonly string TypeName = "Connections.Response";

        public ConnectionResponseHandler(string subtype, JObject json) : base(TypeName, subtype, json)
        {
        }

        //public bool CanConvert(string requestType)
        //{
        //    return requestType == "Connections.Response";
        //}

        //public Request.Type.Request Convert(string requestType)
        //{
        //    return new ConnectionResponseRequest();
        //}

        //public static void AddToRequestConverter()
        //{
        //    if (RequestConverter.RequestConverters.Where(rc => rc != null)
        //        .All(rc => rc.GetType() != typeof(ConnectionResponseHandler)))
        //    {
        //        RequestConverter.RequestConverters.Add(new ConnectionResponseHandler());
        //    }
        //}
    }
}
