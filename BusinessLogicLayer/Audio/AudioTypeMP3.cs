using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Audio
{
    public class AudioTypeMP3 : IAudioType
    {
        public string AddAudioFiletype(string filename)
        {
            return filename += ".mp3";
        }
    }
}
