using System.Drawing;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök!");

            int secretNumber = RandomNumber(); //Tilldelar int genom att anropa metoden.
            int attempts = 5;

            while (attempts > 0)
            {
                int userGuess = GetInputNumber(); //Tilldelar användarens input till en fast int.

                Console.WriteLine(CheckGuess(userGuess, secretNumber)); //Skickar med userGuess och secretNumber till metoden som retunerar string direkt för utskrift
                if (CheckGuess(userGuess, secretNumber) == "Wohoo! Du klarade det!") //Bryter loopen om metoden retunerar stringen med korrekt text.
                {
                    break;
                }
                else
                {
                    attempts--;
                }
            }
            if (attempts == 0)
            {
                Console.WriteLine("Du har använt dina 5 försök, tyvärr.");
            }
            else
            {
                Console.WriteLine("Vad grym du är på att gissa!");
            }
        }

        public static int RandomNumber() //Skapar en metod för att generera fram ett slumpmässigt nummer mellan 1-20 som retunerar det i en int.
        { 
              Random numberGenerator = new Random();
              int randomNumber = numberGenerator.Next(1, 21);

              return randomNumber;
        }

        public static int GetInputNumber() //Skapar en till metod för felsökning av inmatningen från användare. Kommer loopas tills ett heltal matas in, sedan retunerar det heltalet i en int.
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

        public static string CheckGuess(int userInput, int goalNumber) //Skapar en if sats i en metod som retunerar olika texter(string) beroende på hur nära userInput ligger mot goalNumber.
        {
            if (userInput == goalNumber)
            {
                string respons = "Wohoo! Du klarade det!";
                return respons;
                
            }
            else if (userInput == goalNumber + 1 || userInput == goalNumber - 1)
            {
                string respons = "Nu bränns det, du är nära nu!";
                return respons;
            }
            else if (userInput > goalNumber + 10)
            {
                string respons = "Oj du gissar alldelse för högt!";
                return respons;
            }
            else if (userInput < goalNumber)
            {
                string respons = "Tyvärr du gissade för lågt!";
                return respons;
            }
            else 
            {
                string respons = "Tyvärr du gissade för högt!";
                return respons;
            }
        }
    }
}

