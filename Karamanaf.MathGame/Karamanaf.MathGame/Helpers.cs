using Karamanaf.MathGame.Models;

namespace Karamanaf.MathGame
{
    internal class Helpers
    {
        static List<Game> games = new();

        internal static void ViewGameHistory()
        {
            Console.Clear();
            Console.WriteLine("-----------------------");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - Game Name: {game.Type} with {game.Score} pts.");
            }
            Console.WriteLine("-----------------------\n");
            Console.WriteLine("Press any key to go to menu.");
            Console.ReadLine();
        }

        internal static void AddGameToHistory(int gameScore, GameType gameName, GameDifficulty gameDifficulty)
        {
            games.Add(new Game { 
                Type = gameName,
                Date = DateTime.Now,
                Score = gameScore,
                Difficulty = gameDifficulty
            });
        }

        internal static int[] GetDivisionNumbers(GameDifficulty difficulty)
        {
            Random random = new Random();
            int[] numByDifficulty = GetRangeNumbersByDifficulty(difficulty);
            int firstNumByDifficulty = numByDifficulty[0];
            int secondNumByDifficulty = numByDifficulty[1];
            int firstNum = random.Next(firstNumByDifficulty, secondNumByDifficulty);
            int secondNum = random.Next(firstNumByDifficulty, secondNumByDifficulty);
            int[] results = new int[2];
            while (firstNum % secondNum != 0)
            {
                firstNum = random.Next(firstNumByDifficulty, secondNumByDifficulty);
                secondNum = random.Next(firstNumByDifficulty, secondNumByDifficulty);
            }
            results[0] = firstNum;
            results[1] = secondNum;

            return results;
        }

        internal static int[] GetNumbersByDifficulty(GameDifficulty difficulty)
        {
            Random random = new Random();
            int[] results = new int[2];
            int[] numByDifficulty = GetRangeNumbersByDifficulty(difficulty);
            results[0] = random.Next(numByDifficulty[0], numByDifficulty[1]);
            results[1] = random.Next(numByDifficulty[0], numByDifficulty[1]);
            return results;
        }

        internal static int[] GetRangeNumbersByDifficulty(GameDifficulty difficulty)
        {
            int[] nums = new int[2];
            switch (difficulty)
            {
                case GameDifficulty.Easy:
                    nums[0] = 1;
                    nums[1] = 11;
                    break;
                case GameDifficulty.Medium:
                    nums[0] = 10;
                    nums[1] = 501;
                    break;
                case GameDifficulty.Hard:
                    nums[0] = 500;
                    nums[1] = 1001;
                    break;
            }
            return nums;
        }

        internal static int ValidateInput()
        {
            var result = Console.ReadLine();
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("The input should an integer. Please try again!");
                result = Console.ReadLine();
            }

            return int.Parse(result);
        }

        internal static string GetName()
        {
            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("The name cannot be empty.");
                name = Console.ReadLine();
            }
            return name;
        }
    }
}
