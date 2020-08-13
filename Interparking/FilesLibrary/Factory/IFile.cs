using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesLibrary.Factory
{
    public interface IFile
    {
        string ReadFile(string path);
    }
}
