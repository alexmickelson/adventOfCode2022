namespace day02;
public static class ScoreCalculator
{
  public enum Options
  {
    Rock = 1,
    Paper = 2,
    Scissors = 3
  }

  public static int TournamentScore(string input)
  {
    return input
      .Split("\n")
      .Select(parseRound)
      .Select(calculateRoundScore)
      .Sum();
  }

  private static int calculateRoundScore((Options myChoice, Options opponentChoice) choices)
  {
    var (myChoice, opponentChoice) = choices;
    if (myChoice == opponentChoice)
      return (int)myChoice + 3;

    var iWin = (myChoice, opponentChoice) switch
    {
      (Options.Rock, Options.Scissors) => true,
      (Options.Paper, Options.Rock) => true,
      (Options.Scissors, Options.Paper) => true,
      _ => false,
    };

    if (iWin)
      return (int)myChoice + 6;

    return (int)myChoice + 0;
  }

  private static (Options, Options) parseRound(string input)
  {
    var opponentChoiceCode = input.Split(" ")[0];
    var myChoiceCode = input.Split(" ")[1];

    var opponentChoice = opponentChoiceCode switch
    {
      "A" => Options.Rock,
      "B" => Options.Paper,
      "C" => Options.Scissors,
    };
    var myChoice = myChoiceCode switch
    {
      "X" => Options.Rock,
      "Y" => Options.Paper,
      "Z" => Options.Scissors,
    };
    return (myChoice, opponentChoice);
  }
}
