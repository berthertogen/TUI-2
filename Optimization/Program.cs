using System;

namespace Optimization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Messages.DiplayMessages(new MessageACreator().Create()));
            Console.WriteLine(Messages.DiplayMessages(new MessageBCreator().Create()));
            Console.WriteLine(Messages.DiplayMessages(new MessageCCreator().Create()));
            Console.ReadLine();
        }

    }
}
