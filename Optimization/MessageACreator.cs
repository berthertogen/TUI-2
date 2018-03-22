namespace Optimization
{
    public class MessageACreator : MessageCreator
    {
        public override Message Create()
        {
            return new MessageA();
        }
    }
}
