using System;

namespace Optimization
{
    public class MessageB: Message
    {
        public string MyCustomMethodOnB()
        {
            return "MyCustomMethodOnB";
        }

        public string SomeAdditionalMethodOnB()
        {
            return "SomeAdditionalMethodOnB";
        }
    }
}