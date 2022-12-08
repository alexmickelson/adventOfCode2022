using System.IO;
using NUnit.Framework;

namespace day02.test;

public class Day02Tests
{
  [Test]
  public void TestWin()
  {
    var input = "A Y";
    var actualScore = ScoreCalculator.TournamentScore(input);
    Assert.AreEqual(4, actualScore);
  }
  [Test]
  public void TestLoss()
  {
    var input = "B X";
    var actualScore = ScoreCalculator.TournamentScore(input);
    Assert.AreEqual(1, actualScore);
  }
  [Test]
  public void TestDraw()
  {
    var input = "C Z";
    var actualScore = ScoreCalculator.TournamentScore(input);
    Assert.AreEqual(7, actualScore);
  }
  [Test]
  public void TestTwo()
  {
    var input = "A Y\nC Z";
    var actualScore = ScoreCalculator.TournamentScore(input);
    Assert.AreEqual(11, actualScore);
  }
  
  [Test]
  public void Example()
  {
    var input = File.ReadAllText("../../../../sampleInput.txt");
    Assert.AreEqual(12, ScoreCalculator.TournamentScore(input));
  }
  
  [Test]
  public void Part1()
  {
    var input = File.ReadAllText("../../../../input.txt");
    Assert.AreEqual(11186, ScoreCalculator.TournamentScore(input));
  }
}