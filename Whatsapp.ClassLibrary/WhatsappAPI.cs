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
        public string EnviarWhatsapp(string mensaje)
        {
                      
                var accountSid = "AC6ae308909bdb98ca43163475503afb1b";
                var authToken = "6044f9d986463e7313620c8067211704";
                TwilioClient.Init(accountSid, authToken);
                var messageOptions = new CreateMessageOptions(
                new PhoneNumber("whatsapp:+51929493508"));
                messageOptions.From = new PhoneNumber("whatsapp:+14155238886");
                messageOptions.Body = mensaje;

                var message = MessageResource.Create(messageOptions);
                Console.WriteLine(message.Body);
            

                         
            
            string mensajce = "entregado";
            return mensajce;
        }
    
    }
}
