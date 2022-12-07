using System.Diagnostics;
using System.Linq;

namespace day01;
public static class ElfExpedition
{

  public static int GetLargestCalories(string input)
  {
    var elfCalorieTotals = parseElfCalorieTotals(input);

    return elfCalorieTotals.Max();
  }
  public static int SumTopElfCalories(string input, int topCount = 3)
  {
    var elfCalorieTotals = parseElfCalorieTotals(input);
    var sum = 0;

    for (int i = 0; i < topCount; i++)
    {
      var localMax = elfCalorieTotals.Max();
      sum += localMax;
      elfCalorieTotals.Remove(localMax);
    }
    return sum;
  }

  private static List<int> parseElfCalorieTotals(string input)
  {
    var elvesRaw = input.Split("\n\n");
    var elfNumbers = elvesRaw.Select(getElfNumbers);
    return elfNumbers.Select(n => n.Sum()).ToList();
  }

  private static Func<string, IEnumerable<int>> getElfNumbers =
    e => e
      .Split("\n")
      .Select(s =>
      {
        try
        {
          return int.Parse(s);
        }
        catch (Exception e)
        {
          throw new Exception($"Cannot parse {s} as int");
        }
      });
}
