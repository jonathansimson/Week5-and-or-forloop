using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja salasõna "admin1234"
            //siis kuvatakse konsoolis "Tere tulemast!;
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti."
            //kasutajal on 3 katset


            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta salasõna:");
                string userPassword = Console.ReadLine();

                if (userName != "admin" || userPassword != "admin1234")
                {
                    i++;
                    Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti.");
                    Console.WriteLine($"Teil on jäänud {3 - i} katset");
                }
                else
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
            }
        }
    }
}

    
