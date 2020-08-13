using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesLibrary.Strategies
{
    public abstract class Strategy
    {
       public abstract string ApplyStrategy(string file);
    }
}

