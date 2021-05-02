using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Audio
{
    public class TypeMP3 : AudioType
    {
        public override string AddAudioFiletype(string filename)
        {
            return filename += ".mp3";
        }
    }
}
