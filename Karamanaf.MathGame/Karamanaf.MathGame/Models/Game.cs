﻿namespace Karamanaf.MathGame.Models;
internal class Game
{
    public GameType Type { get; set; }
    public DateTime Date { get; set; }
    public int Score { get; set; }
    public GameDifficulty Difficulty { get; set; }
}

internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division
}

internal enum GameDifficulty
{
    Easy,
    Medium,
    Hard
}