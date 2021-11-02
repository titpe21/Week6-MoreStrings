using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Don't panic" 
            //läbiva suurtähega ja tagurpidi

            string dontPanic = "Don't panic".ToUpper();
            for (int i = dontPanic.Length - 1; i >= 0; i--)
            {
                Console.Write(dontPanic[i]);
            }
        }
    }
}
