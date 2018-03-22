namespace Optimization
{
    public abstract class MessageDecerator : Message
    {
        protected Message _message;

        public void SetComponent(Message message)
        {
            _message = message;
        }

        public override string DoSomthingOnMessage() => _message?.DoSomthingOnMessage();
    }
}
