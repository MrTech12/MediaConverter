using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    public interface IFileHandling
    {
        void ChangeFiletype();

        void CreateNewFile();
    }
}
