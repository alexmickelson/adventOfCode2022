namespace day03;
public class RucksackManagement
{
  public static int GetValuesOfDuplicates(string input)
  {
    return input.Split("\n").Select(s => GetSingleRucksackValues(s)).Sum();
  }

  public static int GetSingleRucksackValues(string input)
  {
    var halfCount = input.Count() / 2;
    var firstHalf = input.Take(halfCount).ToList();
    var secondHalf = input.Skip(halfCount).ToList();
    var duplicates = firstHalf.Where(c => secondHalf.Contains(c)).Distinct().ToList();

    var duplicateValues = duplicates.Select(GetItemValue);
    return duplicateValues.Sum();
  }

  private static int GetItemValue(char c)
  {
    var charInt = (int)c;
    var aAscii = 97;
    var AAscii = 65;
    if (c >= aAscii)
    {
      return charInt - aAscii + 1;
    }
    return charInt - AAscii + 27;
  }

  public static int GetBadgesSum(string input)
  {
    var groups = input.Split("\n").Chunk(3).Select(l => String.Join("\n", l));
    return groups.Select(g => getGroupBadgeValue(g)).Sum();
  }

  private static int getGroupBadgeValue(string input)
  {
    var elf0 = input.Split("\n")[0];
    var elf1 = input.Split("\n")[1];
    var elf2 = input.Split("\n")[2];

    var badge = elf0.Where(c => elf1.Contains(c) && elf2.Contains(c)).ToArray()[0];

    return GetItemValue(badge);
  }
}

