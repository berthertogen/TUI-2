using System;

namespace Optimization
{
    public class MessageB: Message
    {
        public string DoSomthingOnMessage() 
            => $"MyCustomMethodOnB en {SomeAdditionalMethodOnB()}";

        string SomeAdditionalMethodOnB() => "SomeAdditionalMethodOnB";
    }
}