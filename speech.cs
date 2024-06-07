using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Windows.Controls;

namespace TextToSpeech
{

    public class speech
    {
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        public speech(ComboBox voices)
        {
            foreach (InstalledVoice voice in synthesizer.GetInstalledVoices())
            {
                if (voice.Enabled)
                {
                    voices.Items.Add(voice.VoiceInfo.Name);
                }
            }
        }

        public void SelectVoice(string voiceName)
        {
            synthesizer.SelectVoice(voiceName);
        }

        public void VoiceIt(string text)
        {
            synthesizer.Speak(text);
        }


    }
}
