using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesLibrary.Strategies
{
    public class Encryption : Strategy
    {
      

        public override string ApplyStrategy(string file)
        {
            return new string( file.Reverse().ToArray());
        }
    }
}
