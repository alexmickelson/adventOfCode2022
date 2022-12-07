using System.IO;
using NUnit.Framework;

namespace day01.test;

public class CalorieTests
{
  [SetUp]
  public void Setup()
  {
  }

  [Test]
  public void CanGetMostCalories()
  {
    TestExpectedCalories(10, "10");

    TestExpectedCalories(30, "20\n10");
    TestExpectedCalories(40, "30\n10");

    
    TestExpectedCalories(50, "30\n10\n\n50");
  }

  private void TestExpectedCalories(int expected, string input)
  {
    var mostCalories = ElfExpedition.GetLargestCalories(input);
    Assert.AreEqual(expected, mostCalories);
  }

  [Test]
  public void Part1Example()
  {
    var input = "1000\n2000\n3000\n\n4000\n\n5000\n6000\n\n7000\n8000\n9000\n\n10000";
    var expected = 24000;
    TestExpectedCalories(expected, input);
  }

  [Test]
  public void Part1()
  {
    var input = File.ReadAllText("../../../../part1Input.txt");
    var expected = 70698;
    TestExpectedCalories(expected, input);
  }

  [Test]
  public void Part2ExampleGet3Elves()
  {
    var input = "1000\n2000\n3000\n\n4000\n\n5000\n6000\n\n7000\n8000\n9000\n\n10000";
    var expected = 45000;

    var sum = ElfExpedition.SumTopElfCalories(input);
    Assert.AreEqual(expected, sum);
  }
  [Test]
  public void Part2()
  {
    var input = File.ReadAllText("../../../../part1Input.txt");
    var expected = 206643;
    var sum = ElfExpedition.SumTopElfCalories(input);
    Assert.AreEqual(expected, sum);
  }
}