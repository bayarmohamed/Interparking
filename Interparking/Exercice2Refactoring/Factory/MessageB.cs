using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2Refactoring.Factory
{
    public class MessageB:IMessage
    {
        public void MyCustomMethod() { Console.WriteLine(" My Custom Method B "); }
        public void MyCustomAdditionMethod() { Console.WriteLine(" My Custom Addition Method B "); }
    }
}
