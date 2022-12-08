using System.IO;
using NUnit.Framework;

namespace day03.test;

public class Tests
{

  [Test]
  public void OneLine()
  {
    var input = "vJrwpWtwJgWrhcsFMMfFFhFp";
    var valueOfDuplicateItems = RucksackManagement.GetValuesOfDuplicates(input);
    Assert.AreEqual(16, valueOfDuplicateItems);
  }
  [Test]
  public void TwoLine()
  {
    var input = "vJrwpWtwJgWrhcsFMMfFFhFp\njqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL";
    var valueOfDuplicateItems = RucksackManagement.GetValuesOfDuplicates(input);
    Assert.AreEqual(54, valueOfDuplicateItems);
  }

  [Test]
  public void Part1Example()
  {
    var input = File.ReadAllText("../../../../sampleInput.txt");
    var valueOfDuplicateItems = RucksackManagement.GetValuesOfDuplicates(input);
    Assert.AreEqual(157, valueOfDuplicateItems);
  }
  [Test]
  public void Part1()
  {
    var input = File.ReadAllText("../../../../input.txt");
    var valueOfDuplicateItems = RucksackManagement.GetValuesOfDuplicates(input);
    Assert.AreEqual(7850, valueOfDuplicateItems);
  }

  [Test]
  public void CanGetGroupBadge()
  {
    var input = "vJrwpWtwJgWrhcsFMMfFFhFp\njqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL\nPmmdzqPrVvPwwTWBwg";
    var badgesSum = RucksackManagement.GetBadgesSum(input);
    Assert.AreEqual(18, badgesSum);
  }

  [Test]
  public void CanGetMultiGroupBadge()
  {
    var input = "vJrwpWtwJgWrhcsFMMfFFhFp\njqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL\nPmmdzqPrVvPwwTWBwg";
    input += "\nwMqvLMZHhHMvwLHjbvcjnnSBnvTQFn\nttgJtRGJQctTZtZT\nCrZsJsPPZsGzwwsLwLmpwMDw";
    var badgesSum = RucksackManagement.GetBadgesSum(input);
    Assert.AreEqual(70, badgesSum);
  }

  [Test]
  public void Part2()
  {
    var input = File.ReadAllText("../../../../input.txt");
    var badgesSum = RucksackManagement.GetBadgesSum(input);
    Assert.AreEqual(2581, badgesSum);
  }
}