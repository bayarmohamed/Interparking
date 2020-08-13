using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesLibrary.Factory
{
    public class JsonFile : IFile
    {
        public string ReadFile(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
