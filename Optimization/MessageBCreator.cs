namespace Optimization
{
    public  class MessageBCreator: MessageCreator
    {
        public override Message Create()
        {
            var message = new MessageBDecerator();
            message.SetComponent(new MessageB());
            return message;
        }
    }
}
