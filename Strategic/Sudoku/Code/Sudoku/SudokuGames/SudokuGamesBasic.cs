


namespace michele.natale.games.sudokus;

using static SudokuSolver;
using static michele.natale.services.Randoms.RandomHolder;

public abstract class SudokuGamesBase
{ 
  public DifficultyLevel DLevel { get; private set; } = DifficultyLevel.None;

  public SudokuGamesBase()
  {
    this.SetDifficultyLevel();
  }

  public SudokuGamesBase(DifficultyLevel dlevel)
  {
    this.DLevel = dlevel;
    this.SetDifficultyLevel();
  }

  public List<List<byte>> ToNewSudokuGame()
  {
    this.SetDifficultyLevel();
    return CustomizeGrid(NewSudokuGames(), this.DLevel);
  }

  public List<List<byte>> ToNewSudokuGame(DifficultyLevel dlevel)
  {
    this.DLevel = dlevel;
    this.SetDifficultyLevel();
    return CustomizeGrid(NewSudokuGames(), this.DLevel);
  }

  private static List<List<byte>> NewSudokuGames()
  {
    var bytes = Enumerable.Range(1, SUDOKU_GRID_LENGTH)
        .Select(x => (byte)x).OrderBy(x => Instance.NextInt32()).ToArray();

    var grid = Enumerable.Range(0, SUDOKU_GRID_LENGTH)
      .Select(x => new byte[SUDOKU_GRID_LENGTH].ToList()).ToList();

    for (var i = 0; i < bytes.Length; i++)
      grid[i][i] = bytes[i];

    var isxsudoku = true;
    var numberofsolution = 9;
    List<List<List<byte>>> allresult = [];
    var solv = SolverSudoku(grid, allresult, numberofsolution, 1, isxsudoku);

    if (solv)
      return allresult.First();

    return [];
  }

  private void SetDifficultyLevel()
  {
    if (this.DLevel == DifficultyLevel.None)
      this.DLevel = DifficultyLevel.Easy;
    //if (this.DLevel == DifficultyLevel.Random)
    //  this.DLevel = DifficultyLevelLength.RngDifficultyLevelLength().DLevel;
  }
}
