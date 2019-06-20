using System;
using System.Linq;

using EssentialsMSPTechDays.Models;

using Xamarin.Forms;
using Xamarin.Essentials;

namespace EssentialsMSPTechDays.ViewModels
{
    public class TextToSpeechViewModel : BaseViewModel
    {
        private TextToSpeechModel tts;
        public Command SpeakCommand { get; set; }

        private string text;

        public string Text
        {
            get { return tts.Text; }
            set { tts.Text = value; OnPropertyChanged(); }
        }

        private float volume;

        public float Volume
        {
            get { return tts.Volume; }
            set { tts.Volume = value; OnPropertyChanged(); }
        }

        private float pitch;

        public float Pitch
        {
            get { return tts.Pitch; }
            set { tts.Pitch = value; OnPropertyChanged(); }
        }

        public TextToSpeechViewModel()
        {
            tts = new TextToSpeechModel()
            {
                Volume = .75f,
                Pitch = 1.0f
            };

            SpeakCommand = new Command(async () =>
            {
                try
                {
                    var locales = await TextToSpeech.GetLocalesAsync();
                    var locale = locales.FirstOrDefault();

                    var settings = new SpeechOptions()
                    {
                        Pitch = Pitch,
                        Volume = Volume,
                        Locale = locale
                    };

                    await TextToSpeech.SpeakAsync(Text, settings);
                }
                catch (Exception ex)
                {

                }
            });
        }
    }
}
