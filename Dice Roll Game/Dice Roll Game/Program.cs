using Dice_Roll_Game.Game;
using static Dice_Roll_Game.Game.GuessingGame;

namespace Dice_Roll_Game
{
    public class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var dice = new Dice(random);
            var guessingGame = new GuessingGame(dice);

            GameResult gameResult = guessingGame.play();
            GuessingGame.PrintResult(gameResult);



            Console.ReadLine();
        }
        
    }
}
