using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Audio
{
    public class TypeWAV : AudioType
    {
        public override string AddAudioFiletype(string filename)
        {
            return filename += ".wav";
        }
    }
}
