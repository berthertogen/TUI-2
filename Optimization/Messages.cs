using System;
using System.Collections.Generic;
using System.Text;

namespace Optimization
{
    public class Messages
    {
        public static string DiplayMessages(Message message)
        {
            if (message is MessageA)
            {
                var messageA = message as MessageA;
                return messageA?.MyCustomMethodOnA();
            }
            else if (message is MessageB)
            {
                var messageB = message as MessageB;
                return $"{messageB?.MyCustomMethodOnB()} en {messageB?.SomeAdditionalMethodOnB()}" ;
            }
            else if (message is MessageC)
            {
                var messageC = message as MessageC;
                return messageC?.MyCustomMethodOnC();
            }
            throw new ArgumentOutOfRangeException();
        }
    }
}
