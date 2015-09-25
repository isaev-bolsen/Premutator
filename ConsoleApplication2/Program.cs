using System;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join("\n", new Premutator("ХСАЬАРНЕ").GetCollected()));
        }
    }
}
