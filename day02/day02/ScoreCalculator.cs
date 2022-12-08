namespace day02;
public static class ScoreCalculator
{
  public enum Options
  {
    Rock = 1,
    Paper = 2,
    Scissors = 3,
  }

  public enum Result
  {
    Win = 6,
    Draw = 3,
    Loss = 0,
  }

  public static int TournamentScore(string input)
  {
    return input
      .Split("\n")
      .Select(parseRound)
      .Select(calculateRoundScore)
      .Sum();
  }

  private static int calculateRoundScore((Options opponentChoice, Result result) choices)
  {
    var (opponentChoice, result) = choices;
    var myChoice = opponentChoice switch
    {
      Options.Paper => result switch
      {
        Result.Win => Options.Scissors,
        Result.Draw => Options.Paper,
        Result.Loss => Options.Rock,
      },
      Options.Rock => result switch
      {
        Result.Win => Options.Paper,
        Result.Draw => Options.Rock,
        Result.Loss => Options.Scissors,
      },
      Options.Scissors => result switch
      {
        Result.Win => Options.Rock,
        Result.Draw => Options.Scissors,
        Result.Loss => Options.Paper,
      },
    };

    if (result == Result.Draw)
      return (int)myChoice + 3;


    if (result == Result.Win)
      return (int)myChoice + 6;

    return (int)myChoice + 0;
  }

  private static (Options, Result) parseRound(string input)
  {
    var opponentChoiceCode = input.Split(" ")[0];
    var myChoiceCode = input.Split(" ")[1];

    var opponentChoice = opponentChoiceCode switch
    {
      "A" => Options.Rock,
      "B" => Options.Paper,
      "C" => Options.Scissors,
    };
    var result = myChoiceCode switch
    {
      "X" => Result.Loss,
      "Y" => Result.Draw,
      "Z" => Result.Win,
    };
    return (opponentChoice, result);
  }
}
