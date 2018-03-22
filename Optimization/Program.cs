using System;

namespace Optimization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Messages.DiplayMessages(new MessageA()));
            Console.WriteLine(Messages.DiplayMessages(new MessageB()));
            Console.WriteLine(Messages.DiplayMessages(new MessageC()));
            Console.ReadLine();
        }

    }
}
