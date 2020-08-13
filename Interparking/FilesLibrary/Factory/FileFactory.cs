using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesLibrary.Factory
{
    public static class FileFactory
    {
        public static IFile GetFile(string file)
        {
            switch (file)
            {
                case nameof(TxTFile):
                    return new TxTFile();
                case nameof(XmLFile):
                    return new XmLFile();
                case nameof(JsonFile):
                    return new JsonFile();
                default:
                    return null;
            }
        }
    }
}
