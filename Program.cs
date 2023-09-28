using System.Drawing;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök!");


            int secretNumber = RandomNumber();
            int attempts = 5;

            
            while (attempts > 0)
            {
                int guess = GetInputNumber();
                //Console.WriteLine(CheckGuesses(guess, secretNumber))
                if (guess == secretNumber)
                {
                    Console.WriteLine("Wohoo! Du klarade det!");
                    break;
                }
                else
                {
                    CheckGuess(guess, secretNumber);
                    attempts--;
                }
            }
            if (attempts == 0)
            {
                Console.WriteLine("Du har använt dina 5 försök, tyvärr.");
            }
        }

        public static int RandomNumber() //Skapar en metod för att generera fram ett slumpmässigt nummer mellan 1-20 som retunerar det i en int.
        { 
              Random numberGenerator = new Random();
              int randomNumber = numberGenerator.Next(1, 21);

              return randomNumber;
        }

        public static int GetInputNumber() //Skapar en till metod för felsökning av inmatningen från användare. Kommer loopas tills ett heltal matas in, sedan retunerar det heltalet.
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


        public static void CheckGuess(int guess, int secretNumber)
        {
            //if (guess == secretNumber)
            //{
            //    Console.WriteLine("Wohoo! Du klarade det!");
            //}
            if (guess == secretNumber + 1 || guess == secretNumber - 1)
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

        public static string CheckGuesses(int guess, int secretNumber)
        {

            
            if (guess == secretNumber)
            {
                string respons = "Wohoo! Du klarade det!";
                return respons;
                
            }
            else if (guess == secretNumber + 1 || guess == secretNumber - 1)
            {
                string respons = "Nu bränns det, du är nära nu!";
                return respons;
            }
            else if (guess > secretNumber + 10)
            {
                string respons = "Oj du gissar alldelse för högt!";
                return respons;
            }
            else if (guess < secretNumber)
            {
                string respons = "Tyvärr du gissade för lågt!";
                return respons;
            }
            else if (guess > secretNumber)
            {
                string respons = "Tyvärr du gissade för högt!";
                return respons;
            }
            else
            {
                string respons = "Tack för att du spelar!";
                return respons;
            }
         
            

        }
    }
}

