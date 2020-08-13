using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FilesLibrary.Factory
{
    public class XmLFile : IFile
    {

        public string ReadFile(string path)
        {
            using (XmlTextReader reader = new XmlTextReader(path))
            {
                var str = new StringBuilder();

                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            str.Append("<" + reader.Name);
                            str.Append(">");
                            break;
                        case XmlNodeType.Text:
                            str.Append(reader.Value);
                            break;
                        case XmlNodeType.EndElement:
                            str.Append("</" + reader.Name);
                            str.Append(">");
                            break;
                    }
                }
                return str.ToString();
            }

        }
    }
}
