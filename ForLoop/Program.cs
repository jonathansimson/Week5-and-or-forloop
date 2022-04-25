using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            //I WILL NOT SKATEBOARD IN THE HALLS

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{ i + 1}. I WILL NOT SKATEBOARD IN THE HALLS".ToUpper());
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
