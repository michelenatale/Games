

namespace michele.natale.games.sudokus;

partial class SudokuSolver
{

  private static bool ContainsSubsequence<T>(List<T> sequence, List<T> subsequence)
  {
    return Enumerable
      .Range(0, sequence.Count - subsequence.Count + 1)
      .Any(n => sequence.Skip(n).Take(subsequence.Count).SequenceEqual(subsequence));
  }


  private static IEnumerable<byte> To3x3Indexes()
  {
    var result = new List<byte>();
    for (var c = 0; c < 9; c++)
    {
      for (var r = 0; r < 9; r++)
      {
        var v = (byte)(c / 3 * 3 + r / 3 * 27);
        if (!result.Contains(v)) result.Add(v);
      }
    }
    return [.. result.OrderBy(x => x)];
  }

  private static int HowManyNumbersAreSet(List<List<byte>> grid)
  {
    var result = 0;
    for (var r = 0; r < 9; r++)
    {
      for (var c = 0; c < 9; c++)
      {
        if (grid[r][c] > 9)
          throw new ArgumentOutOfRangeException(nameof(grid));
        if (grid[r][c] > 0) result++;
      }
    }
    return result;
  }


  private static bool CheckDia08(List<List<byte>> grid)
  {
    for (var i = 0; i < grid.Count; i++)
    {
      if (grid[i][i] > 9) return false;
      if (grid[i][i] > 0) return true;
    }
    return false;
  }

  private static bool CheckDia08(List<List<byte>> grid, out (int x, int y)[] xy)
  {
    xy = [];
    var xyout = new List<(int x, int y)>();
    for (var i = 0; i < grid.Count; i++)
    {
      if (grid[i][i] > 9) xyout.Add((i, i));
      if (grid[i][i] > 0 && grid[i][i] < 10) xyout.Add((i, i));
    }

    if (xyout.Count > 0) xy = [.. xyout];
    return xyout.Count > 0;
  }

  private static List<List<byte>> Copy(List<List<byte>> data)
  {
    return data.Select(x => x.ToList()).ToList();
  }

  private static void Copy(List<List<byte>> empty, List<List<byte>> data)
  {
    if (data.Count != empty.Count)
      throw new ArgumentOutOfRangeException(nameof(empty));

    ClearGrid(empty);
    for (var r = 0; r < data.Count; r++)
      for (var c = 0; c < data[r].Count; c++)
        empty[r][c] = data[r][c];
  }

  private static void ClearGrid(List<List<byte>> grid)
  {
    for (var r = 0; r < grid.Count; r++)
      for (var c = 0; c < grid[r].Count; c++)
        grid[r][c] = 0;
  }
}



