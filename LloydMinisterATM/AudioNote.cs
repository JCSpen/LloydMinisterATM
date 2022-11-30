using System;
using System.Speech.Synthesis;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class AudioNote
    {
        private SpeechSynthesizer Synthesizer;

        public AudioNote(string TextToSpeak)
    {
        Synthesizer = new SpeechSynthesizer();
        Speak(TextToSpeak);
    }

        private void Speak(string text)
    {
        Synthesizer.Speak(text);
        Synthesizer.Dispose();
    }
    }

