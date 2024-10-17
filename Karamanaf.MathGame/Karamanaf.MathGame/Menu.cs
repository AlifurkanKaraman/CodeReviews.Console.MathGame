using Karamanaf.MathGame;
using Karamanaf.MathGame.Models;

namespace Karamanaf.MathGame2
{
    internal class Menu
    {
        GameEngine engine = new();
        internal void ShowMenu(string name, DateTime date)
        {
            ShowIntroMessage(name, date);
            var isGameOn = true;
            do
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine($@"What would you like to play today? Choose the options below:
V - View Game History
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit
");
                Console.WriteLine("--------------------------------------------------------");
                var option = Console.ReadLine();
                GameDifficulty gameDifficulty = new GameDifficulty();
                switch (option.ToUpper().Trim())
                {
                    case "V":
                        Helpers.ViewGameHistory();
                        break;
                    case "A":
                        gameDifficulty = GetGameDifficulty();
                        engine.AdditionGame("Addition Game", gameDifficulty);
                        break;
                    case "S":
                        gameDifficulty = GetGameDifficulty();
                        engine.SubtractionGame("Subtraction Game", gameDifficulty);
                        break;
                    case "M":
                        gameDifficulty = GetGameDifficulty();
                        engine.MultiplicationGame("Multiplication Game", gameDifficulty);
                        break;
                    case "D":
                        gameDifficulty = GetGameDifficulty();
                        engine.DivisionGame("Division Game", gameDifficulty);
                        break;
                    case "Q":
                        Console.WriteLine($"Goodbye {name}");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Please press any key to continue");
                        Console.ReadLine();
                        break;
                }
            } while (isGameOn);
        }

        private void ShowIntroMessage(string name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine($"Welcome to Math Game {name}. It's {date}\n");
            Console.WriteLine("We proud that you want improve your math skills.\n");
            Console.WriteLine("Press any key to view Game Menu");
            Console.ReadLine();
        }

        internal GameDifficulty GetGameDifficulty()
        {
            Console.WriteLine(@"Choose the difficulty level of the game:
E - Easy
M - Medium
H - Hard
");
            var difficulty = Console.ReadLine();
            bool isDifficultyCreated = false;
            GameDifficulty difficultyLevel = GameDifficulty.Easy;
            do
            {
                switch (difficulty.ToUpper().Trim())
                {
                    case "E":
                        difficultyLevel = GameDifficulty.Easy;
                        isDifficultyCreated = true;
                        break;
                    case "M":
                        difficultyLevel = GameDifficulty.Medium;
                        isDifficultyCreated = true;
                        break;
                    case "H":
                        difficultyLevel = GameDifficulty.Hard;
                        isDifficultyCreated = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Please try again.");
                        difficulty = Console.ReadLine();
                        break;
                }
            } while (!isDifficultyCreated);

            return difficultyLevel;
        }

    }
}
