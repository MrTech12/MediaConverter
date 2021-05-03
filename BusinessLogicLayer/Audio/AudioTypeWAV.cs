using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Audio
{
    public class AudioTypeWAV : IAudioType
    {
        public string AddAudioFiletype(string filename)
        {
            return filename += ".wav";
        }
    }
}
