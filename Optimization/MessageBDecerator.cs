namespace Optimization
{
    public class MessageBDecerator : MessageDecerator
    {
        public override string DoSomthingOnMessage()
        {
            return $"{base.DoSomthingOnMessage()} en {SomeAdditionalMethodOnB()}";
        }

        string SomeAdditionalMethodOnB() => "SomeAdditionalMethodOnB";

    }
}
