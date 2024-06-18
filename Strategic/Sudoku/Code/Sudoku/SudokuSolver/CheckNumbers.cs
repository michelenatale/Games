


namespace michele.natale.games.sudokus;


partial class SudokuSolver
{

  public static bool CheckNumbers(
    List<List<List<byte>>> bytes, out (int, int) xy, bool isxsudoku = false)
  {
    if (CheckVertical(bytes, out xy))
      if (CheckHorizontal(bytes, out xy))
        if (CheckBlockWise(bytes, out xy))
          if (!isxsudoku) return true;
          else return CheckDiagonal(bytes, out xy);
    return false;
  }

  public static bool CheckNumbers(
    List<List<byte>> bytes, out (int, int) xy, bool isxsudoku = false)
  {
    if (CheckVertical(bytes, out xy))
      if (CheckHorizontal(bytes, out xy))
        if (CheckBlockWise(bytes, out xy))
        {
          if (!isxsudoku) return true;
          else return CheckDiagonal(bytes, out xy);
        }
    return false;
  }

  private static bool CheckDiagonal(
    List<List<List<byte>>> grid, out (int, int) xy)
  {
    xy = (-1, -1);
    for (var i = 0; i < grid.Count; i++)
    {
      if (!CheckDiagonal(grid[i], out xy))
        return false;
    }
    return true;
  }

  private static bool CheckDiagonal(
    List<List<byte>> grid, out (int, int) xy)
  {
    xy = (-1, -1);
    var numbers = new byte[10];
    for (var rc = 0; rc < grid.Count; rc++)
    {
      if (grid[rc][rc] == 0) continue;
      if (grid[rc][rc] > 9) { xy = (rc, rc); return false; }
      numbers[grid[rc][rc]]++;
      if (numbers[grid[rc][rc]] > 1) { xy = (rc, rc); return false; }
    }

    numbers = new byte[10];
    for (var rc = 0; rc < grid.Count; rc++)
    {
      if (grid[8 - rc][8 - rc] == 0) continue;
      if (grid[8 - rc][8 - rc] > 9) { xy = (8 - rc, 8 - rc); return false; }
      numbers[grid[8 - rc][8 - rc]]++;
      if (numbers[grid[8 - rc][8 - rc]] > 1) { xy = (8 - rc, 8 - rc); return false; }
    }

    return true;
  }

  private static bool CheckVertical(
    List<List<List<byte>>> grid, out (int, int) xy)
  {
    xy = (-1, -1);
    for (var i = 0; i < grid.Count; i++)
    {
      if (!CheckVertical(grid[i], out xy))
        return false;
    }
    return true;
  }

  private static bool CheckVertical(
    List<List<byte>> grid, out (int, int) xy)
  {
    xy = (-1, -1);
    for (var c = 0; c < grid[0].Count; c++)
    {
      var numbers = new byte[10];
      for (var r = 0; r < grid.Count; r++)
      {
        if (grid[r][c] == 0) continue;
        if (grid[r][c] > 9) { xy = (c, r); return false; }
        numbers[grid[r][c]]++;
        if (numbers[grid[r][c]] > 1) { xy = (c, r); return false; }
      }
    }
    return true;
  }

  private static bool CheckHorizontal(
    List<List<List<byte>>> grid, out (int, int) xy)
  {
    xy = (-1, -1);
    for (var i = 0; i < grid.Count; i++)
    {
      if (!CheckHorizontal(grid[i], out xy))
        return false;
    }
    return true;
  }

  private static bool CheckHorizontal(
    List<List<byte>> grid, out (int, int) xy)
  {
    xy = (-1, -1);
    for (var r = 0; r < grid.Count; r++)
    {
      var numbers = new byte[10];
      for (var c = 0; c < grid[r].Count; c++)
      {
        if (grid[r][c] == 0) continue;
        if (grid[r][c] > 9) { xy = (c, r); return false; }
        numbers[grid[r][c]]++;
        if (numbers[grid[r][c]] > 1) { xy = (c, r); return false; }
      }
    }
    return true;
  }

  private static bool CheckBlockWise(
    List<List<List<byte>>> grid, out (int, int) xy)
  {
    xy = (-1, -1);
    for (var i = 0; i < grid.Count; i++)
    {
      if (!CheckBlockWise(grid[i], out xy))
        return false;
    }
    return true;
  }

  private static bool CheckBlockWise(
    List<List<byte>> grid, out (int, int) xy)
  {
    xy = (-1, -1);
    foreach (var rr in new byte[] { 0, 3, 6 })
    {
      foreach (var cc in new byte[] { 0, 3, 6 })
      {
        var numbers = new byte[10];
        for (var r = rr; r < rr + 3; r++)
        {
          for (var c = cc; c < cc + 3; c++)
          {
            if (grid[r][c] == 0) continue;
            if (grid[r][c] > 9) { xy = (c, r); return false; }
            numbers[grid[r][c]]++;
            if (numbers[grid[r][c]] > 1) { xy = (c, r); return false; }
          }
        }
      }
    }
    return true;
  }
}



