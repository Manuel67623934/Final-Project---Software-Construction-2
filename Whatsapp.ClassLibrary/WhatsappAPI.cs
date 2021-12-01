using Dato.ClassLibrary;
using Entidad.ClassLibrary;
using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Whatsapp.ClassLibrary
{
    public class WhatsappAPI
    {
        public void EnviarWhatsapp(string msg)
        {
            var accountSid = "AC16cf5b676838ce1300104d42945cdd65";
            var authToken = "30dc2b8bb9c8f7df94403a499c94f80f";
            TwilioClient.Init(accountSid, authToken);

            var messageOptions = new CreateMessageOptions(
                new PhoneNumber("whatsapp:+51929493508"));
            messageOptions.From = new PhoneNumber("whatsapp:+14155238886");
            messageOptions.Body = msg;

            var message = MessageResource.Create(messageOptions);
            Console.WriteLine(message.Body);
        }

    }
}
