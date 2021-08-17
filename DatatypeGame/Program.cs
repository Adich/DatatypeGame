using System;
using System.Linq;

namespace DatatypeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int lives = 3;
            int points = 0;

            Console.WriteLine("Velkommen til spillet, i dette spil skal du gætte datatyper.");

            while(lives > 0)
            {
                Random random = new Random();

                Console.WriteLine($"Du har pt. {points} points og {lives} liv");
                Console.WriteLine();
                Console.WriteLine();
                int randomDatatype = random.Next(1, 6);

                if(randomDatatype == 1)
                {
                    Console.WriteLine($"{random.Next(0,int.MaxValue)}");
                }
                else if (randomDatatype == 2)
                {
                    Console.WriteLine($"{random.NextDouble()}");
                }
                else if (randomDatatype == 3)
                {
                    int booleanRandom = random.Next(0, 1);
                    if(booleanRandom == 0)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (randomDatatype == 4)
                {
                    String source = "abcdefghijklmnopqrstuvxyzæøåw1234567890!#¤%&/()=?`][{€$£@-.,;:_<>";
                    string randomString = "";

                    for(int i = 0; i < random.Next(5,20); i++)
                    {
                        randomString = randomString + source.ElementAt(random.Next(0, source.Length));
                    }
                    Console.WriteLine(randomString);
                }
                else if (randomDatatype == 5)
                {
                    String source = "abcdefghijklmnopqrstuvxyzæøåw!#¤%&/()=?`][{€$£@-.,;:_<>";
                    char randomChar;

                    randomChar = source.ElementAt(random.Next(0, source.Length));
                    
                    Console.WriteLine(randomChar);
                }
                else
                {
                    Console.WriteLine("Something went wrong.");
                }

                Console.WriteLine();
                Console.WriteLine("Vælg dit svar: 1. Int, 2. Double, 3. Boolean, 4. String or 5. Char");

                int choice = int.Parse(Console.ReadLine());

                if(choice == randomDatatype)
                {
                    points++;
                }
                else
                {
                    lives--;
                }

            }

            Console.WriteLine($"Game ovver - Du endte med {points} points");
        }
    }
}
