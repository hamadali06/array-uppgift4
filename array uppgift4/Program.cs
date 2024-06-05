using System;

namespace Inlamning
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = { "Ahmed", "Ameen", "Mohammed", "Ivan", "Håkon" };
            string första = namn[0];
            foreach (string n in namn)
            {
                if (string.Compare(n, första) < 0)
                {
                    första = n;
                }
            }
            Console.WriteLine(första);
        }
    }
}
