using Karamanaf.MathGame.Models;

namespace Karamanaf.MathGame
{
    internal class GameEngine
    {
        internal void AdditionGame(string message, GameDifficulty difficulty)
        {
            int num1;
            int num2;
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                int[] nums = Helpers.GetNumbersByDifficulty(difficulty);
                num1 = nums[0];
                num2 = nums[1];
                Console.WriteLine($"{num1} + {num2}");
                var guess = Helpers.ValidateInput();
                if (num1 + num2 == guess)
                {
                    Console.WriteLine("Correct answer! Type any key to continue.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Wrong answer, try again. Type any key to continue.");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine($"Game over!\nYour score is {score}. Please type any key to go back to main menu");
                    Console.ReadLine();
                }
            }
            Helpers.AddGameToHistory(score, GameType.Addition, difficulty);
        }

        internal void SubtractionGame(string message, GameDifficulty difficulty)
        {
            int num1;
            int num2;
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                int[] nums = Helpers.GetNumbersByDifficulty(difficulty);
                num1 = nums[0];
                num2 = nums[1];
                Console.WriteLine($"{num1} - {num2}");
                var guess = Helpers.ValidateInput();
                if (num1 - num2 == guess)
                {
                    Console.WriteLine("Correct answer! Type any key to continue.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Wrong answer, try again. Type any key to continue.");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine($"Game over!\nYour score is {score}. Please type any key to go back to main menu");
                    Console.ReadLine();
                }
            }
            Helpers.AddGameToHistory(score, GameType.Subtraction, difficulty);

        }

        internal void MultiplicationGame(string message, GameDifficulty difficulty)
        {
            int num1;
            int num2;
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                int[] nums = Helpers.GetNumbersByDifficulty(difficulty);
                num1 = nums[0];
                num2 = nums[1];
                Console.WriteLine($"{num1} * {num2}");
                var guess = Helpers.ValidateInput();
                if (num1 * num2 == guess)
                {
                    Console.WriteLine("Correct answer! Type any key to continue.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Wrong answer, try again. Type any key to continue.");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine($"Game over!\nYour score is {score}. Please type any key to go back to main menu");
                    Console.ReadLine();
                }
            }
            Helpers.AddGameToHistory(score, GameType.Multiplication, difficulty);

        }

        internal void DivisionGame(string message, GameDifficulty difficulty)
        {
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var divisionNumber = Helpers.GetDivisionNumbers(difficulty);
                var num1 = divisionNumber[0];
                var num2 = divisionNumber[1];

                Console.WriteLine($"{num1} / {num2}");
                var guess = Helpers.ValidateInput();
                if (num1 / num2 == guess)
                {
                    Console.WriteLine("Correct answer! Type any key to continue.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Wrong answer, try again. Type any key to continue.");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine($"Game over!\nYour score is {score}. Please type any key to go back to main menu");
                    Console.ReadLine();
                }
            }
            Helpers.AddGameToHistory(score, GameType.Division, difficulty);

        }

    }
}
