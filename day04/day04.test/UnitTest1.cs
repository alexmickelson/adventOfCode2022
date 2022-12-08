using System.IO;
using NUnit.Framework;

namespace day04.test;

public class Tests
{
  [SetUp]
  public void Setup()
  {
  }

  [Test]
  public void TestDoesNotContain()
  {
    var input = "2-4,6-8";
    var containedCount = SectionCleaning.CountContainedPairs(input);
    Assert.AreEqual(0, containedCount);
  }
  [Test]
  public void TestDoesContain()
  {
    var input = "2-4,6-8\n6-6,4-6";
    var containedCount = SectionCleaning.CountContainedPairs(input);
    Assert.AreEqual(1, containedCount);
  }
  [Test]
  public void ExamplePart1()
  {
    var input = File.ReadAllText("../../../../exampleInput.txt");
    var containedCount = SectionCleaning.CountContainedPairs(input);
    Assert.AreEqual(2, containedCount);
  }
  [Test]
  public void Part1()
  {
    var input = File.ReadAllText("../../../../input.txt");
    var containedCount = SectionCleaning.CountContainedPairs(input);
    Assert.AreEqual(498, containedCount);
  }
  [Test]
  public void ExamplePart2()
  {
    var input = File.ReadAllText("../../../../exampleInput.txt");
    var containedCount = SectionCleaning.CountOverlapPairs(input);
    Assert.AreEqual(4, containedCount);
  }
  [Test]
  public void Part2()
  {
    var input = File.ReadAllText("../../../../input.txt");
    var containedCount = SectionCleaning.CountOverlapPairs(input);
    Assert.AreEqual(859, containedCount);
  }
}