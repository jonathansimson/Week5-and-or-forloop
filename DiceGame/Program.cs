using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {

            //mängus osaleb 2 mängijat - arvuti (cpu) ja kasutaja (user)
            //mõlemad mängijad viskavad täringuid
            //programm kontrollib, kumb mängija viskas rohkem
            //mängija, kes viskab rohkem, on võitja
            //*täringuid visatakse 3 korda
            //programm kuulutab välja võitja

            Random rnd = new Random();
            int cpuScore = 0;
            int userScore = 0;

            for (int i = 0; i < 3; i++)
            {

                //arvuti vise
                int cpuRandom = rnd.Next(1, 7);
                //kasutaja vise
                int userRandom = rnd.Next(1, 7);

                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");

                if (cpuRandom < userRandom)
                {
                    userScore++;
                }
                else if (cpuRandom > userRandom)
                {
                    cpuScore++;
                }

            }
            if (cpuScore < userScore)
            {
                Console.WriteLine("Kasutaja on mängu võitja. Palju õnne!");
            }
            if (cpuScore > userScore)
            {
                Console.WriteLine("Arvuti võitis!");
            }
            else if (cpuScore == userScore)
            {
                Console.WriteLine("Viik!");
            }
        }
    }
}
