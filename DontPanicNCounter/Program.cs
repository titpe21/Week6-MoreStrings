using System;

namespace DontPanicNCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab mitu 'n' tähte on
            //lauses "Don't panic"

            string dontPanic = "Don't panic".ToLower();

            int counter = 0;

            for(int i = 0; i < dontPanic.Length; i++)
            {
                if (dontPanic[i] == 'n')
                {
                    counter++;
                }
            }

            Console.WriteLine($"Lauses {dontPanic} on {counter} 'n' tähte.");
        }
    }
}
