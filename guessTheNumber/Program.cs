using System;
namespace guessTheNumber
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random random = new Random();
            int numberToGuess = random.Next(1, 100);
            int guess;
            do
            {
                Console.WriteLine("Adivina el numero entre 1 y 100, Ingresa un numero:");
                guess = int.Parse(Console.ReadLine());
                if (guess < numberToGuess)
                {
                    Console.WriteLine("Tu numero debe ser mayor");
                }
                else if ( guess > numberToGuess)
                {
                    Console.WriteLine("Tu numero debe ser menor");
                }
            } while (guess != numberToGuess);
            Console.WriteLine("Acertaste!!1!!");
        }
    }
}
