using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2Refactoring.Factory
{
    public static class MessageFactory
    {
        public static IMessage CreateMessage(string messageType)
        {
            switch (messageType)
            {
                case nameof(MessageA):
                    return new MessageA();
                case nameof(MessageB):
                    return new MessageB();
                case nameof(MessageC):
                    return new MessageC();

                default:
                    return null;
            }
        }
    }
}
