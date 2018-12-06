// Copyright 2018 Stefan Negritoiu (FreeBusy) and contributors. See LICENSE file for more information.

using System.Threading.Tasks;

namespace AlexaSkillsKit.Speechlet
{
    public interface ISpeechletWithContextAsync
    {
        Task<ISpeechletResponse> OnIntentAsync(IntentRequest intentRequest, Session session, Context context);
        Task<ISpeechletResponse> OnLaunchAsync(LaunchRequest launchRequest, Session session, Context context);
        Task OnSessionStartedAsync(SessionStartedRequest sessionStartedRequest, Session session, Context context);
        Task<ISpeechletResponse> OnSessionEndedAsync(SessionEndedRequest sessionEndedRequest, Session session, Context context);
    }
}