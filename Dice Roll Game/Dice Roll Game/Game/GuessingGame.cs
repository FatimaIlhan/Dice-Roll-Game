using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dice_Roll_Game.UserCommunication;

namespace Dice_Roll_Game.Game
{
    public partial class GuessingGame
    {
        private readonly Dice _dice;

        private const int InitialTries = 3;
        public GuessingGame(Dice dice)
        {
            _dice = dice;

        }




        public GameResult play()
        {
            {
                var diceRollResult = _dice.Roll();

                Console.WriteLine($"Dice rolled. Guess what number it shows in {InitialTries} tries.");

                var triesLeft = InitialTries;

                while (triesLeft > 0)
                {

                    var guess = ConsoleReader.ReadInteger("Enter a number");
                    if (guess == diceRollResult)
                    {
                        return GameResult.Victory;
                    }
                    Console.WriteLine("Wrong Number. ");
                    --triesLeft;
                }
                return GameResult.Loss;
            }
        }

        public static void PrintResult(GameResult gameResult)
        {
            string message = gameResult == GameResult.Victory



                ? "You win!"
                : "You lose :( ";

            Console.WriteLine(message);
        }




    }
}
