using System.Drawing;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök!");

            
            
            int secretNumber = RandomNumber();
            int attempts;

            for (attempts = 5; attempts > 0; attempts--)
            {
                int guess = GetInputNumber();
                if (guess == secretNumber)
                {
                    Console.WriteLine("Wohoo! Du klarade det!");
                    break;
                }
                else if (guess == secretNumber + 1 || guess == secretNumber - 1)
                {
                    Console.WriteLine("Nu bränns det, du är nära nu!");
                }
                else if (guess > secretNumber + 10)
                {
                    Console.WriteLine("Oj du gissar alldelse för högt!");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Tyvärr du gissade för lågt!");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Tyvärr du gissade för högt!");
                }
            }
            if (attempts == 0)
            {
                Console.WriteLine("Du har använt dina 5 försök, tyvärr.");
            }

        }

        public static int RandomNumber()
        {
            Random numberGenerator = new Random();
            int randomNumber = numberGenerator.Next(1, 20);

            return randomNumber;
        }

        public static int GetInputNumber()
        {
            int result;
            while (true)
            {

            string inputNumber = Console.ReadLine();
                if (int.TryParse(inputNumber, out result))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Du måste mata in ett heltal, försökt igen!");
                }
            }
            return result;
        }

    }
}

