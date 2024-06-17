


namespace michele.natale.games.sudokus;

public partial class SudokuSolver
{

  public static bool IsFinished(List<List<List<byte>>> grid)
  {

    for (var i = 0; i < grid.Count; i++)
    {
      if (!IsFinished(grid[i]))
        return false;
    }
    return true;
  }

  public static bool IsFinished(List<List<byte>> grid)
  {
    var numbers = new byte[10];

    for (var r = 0; r < grid.Count; r++)
    {
      for (var c = 0; c < grid[r].Count; c++)
      {
        if (grid[r][c] == 0) return false;
        if (grid[r][c] > 9) return false;
        numbers[grid[r][c]]++;
        if (numbers[grid[r][c]] > 9) return false;
      }
    }
    if (numbers.First() != 0) return false;
    for (var i = 1; i < numbers.Length; i++)
      if (numbers[i] != 9) return false;
    return true;
  }
}



