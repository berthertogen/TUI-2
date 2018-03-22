namespace Optimization
{
    public  class MessageCCreator : MessageCreator
    {
        public override Message Create()
        {
            return new MessageC();
        }
    }
}
