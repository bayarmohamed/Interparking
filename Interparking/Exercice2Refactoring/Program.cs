using Exercice2Refactoring.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            // In the exercice, the code is bad because it doesn't respect the solid princilpes
            // The Open Closed principle was not respected
            // This is a refactoring : we can add a new message type without breaking our code and without modification by using inheritance

            var message = Factory.MessageFactory.CreateMessage(nameof(MessageA));
            message.MyCustomMethod();
            if (message is MessageB) (message as MessageB).MyCustomAdditionMethod();
            Console.ReadKey();
        }
    }
}
