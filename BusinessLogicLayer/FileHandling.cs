using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    public abstract class FileHandling
    {
        public abstract void ChangeFiletype(string currentFiletype);

        public abstract void CreateNewFile();
    }
}
