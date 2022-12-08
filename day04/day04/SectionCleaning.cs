namespace day04;
public class SectionCleaning
{
  public static int CountContainedPairs(string input)
  {
    var assignments = input.Split("\n");
    return assignments.Select(a => AssignmentContainsOther(a)).Sum();
  }

  private static int AssignmentContainsOther(string input)
  {
    var assignment0 = input.Split(",")[0];
    var assignment1 = input.Split(",")[1];

    var (start0, end0) = (int.Parse(assignment0.Split("-")[0]), int.Parse(assignment0.Split("-")[1]));
    var (start1, end1) = (int.Parse(assignment1.Split("-")[0]), int.Parse(assignment1.Split("-")[1]));

    if (start0 <= start1 && end0 >= end1)
      return 1;
    if (start1 <= start0 && end1 >= end0)
      return 1;
    return 0;
  }
  public static int CountOverlapPairs(string input)
  {
    var assignments = input.Split("\n");
    return assignments.Select(a => AssignmentOverlapsOther(a)).Sum();
  }

  private static int AssignmentOverlapsOther(string input)
  {
    var assignment0 = input.Split(",")[0];
    var assignment1 = input.Split(",")[1];

    var (start0, end0) = (int.Parse(assignment0.Split("-")[0]), int.Parse(assignment0.Split("-")[1]));
    var (start1, end1) = (int.Parse(assignment1.Split("-")[0]), int.Parse(assignment1.Split("-")[1]));

    if (start0 <= end1 && end0 >= start1)
      return 1;
    if (start1 <= end0 && end1 >= start0)
      return 1;
    return 0;
  }
}
