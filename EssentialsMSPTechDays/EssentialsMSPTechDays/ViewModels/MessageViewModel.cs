using System;
using System.Collections.Generic;

using EssentialsMSPTechDays.Models;

using Xamarin.Forms;
using Xamarin.Essentials;

namespace EssentialsMSPTechDays.ViewModels
{
    public class MessageViewModel : BaseViewModel
    {
        private MessageModel message;

        public Command SendMessageCommand { get; set; }

        public string MessageType;

        private string subject;

        public string Subject
        {
            get { return message.Subject; }
            set { message.Subject = value; OnPropertyChanged(); }
        }

        private string text;

        public string Text
        {
            get { return message.Text; }
            set { message.Text = value; OnPropertyChanged(); }
        }

        private string to;

        public string To
        {
            get { return message.To; }
            set { message.To = value; OnPropertyChanged(); }
        }

        public MessageViewModel(string messageType)
        {
            message = new MessageModel();

            MessageType = messageType;

            SendMessageCommand = new Command(async () =>
            {
                try
                {
                    switch (MessageType)
                    {
                        case "Email":
                            var email = new EmailMessage
                            {
                                Subject = Subject,
                                Body = Text,
                                To = new List<string>() { To }
                            };

                            await Email.ComposeAsync(email);
                            break;
                        case "Sms":
                            var sms = new SmsMessage
                            {
                                Body = $"{Subject} - {Text}",
                                Recipients = new List<string>() { To }
                            };

                            await Sms.ComposeAsync(sms);
                            break;
                        default:
                            break;
                    }

                }
                catch (Exception ex)
                {

                }
            });
        }
    }
}
