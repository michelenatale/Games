



namespace michele.natale.games.sudokus;

using static michele.natale.services.Randoms.RandomHolder;

public partial class SudokuSolver
{

  public static List<List<byte>> CustomizeGrid(List<List<byte>> grid, DifficultyLevel dlevel)
  {
    DifficultyLevel newdlevel;
    if (dlevel == DifficultyLevel.Random)
      newdlevel = DifficultyLevelLength.RngDifficultyLevelLength().DLevel;
    else newdlevel = dlevel;
    return CustomizeGrid(grid, DifficultyLevelLength.ToDifficultyLevelLength(newdlevel));
  }

  public static List<List<byte>> CustomizeGrid(List<List<byte>> grid, int dllength)
  {
    var visible = SUDOKU_GRID_LENGTH * SUDOKU_GRID_LENGTH;
    var todelete = visible - dllength;

    var result = grid.Select(x => x.ToList()).ToList(); //copy
    var idxs = Enumerable.Range(0, visible)
        .Select(x => (byte)x).OrderBy(x => Instance.NextInt32()).Take(todelete);

    foreach (var idx in idxs)
    {
      var x = idx % SUDOKU_GRID_LENGTH;
      var y = idx / SUDOKU_GRID_LENGTH;
      result[y][x] = 0;
    }

    return result;
  }
}



