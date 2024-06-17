


namespace michele.natale.games.sudokus;

using michele.natale.games.sudokus.Handlers;
using static michele.natale.services.Randoms.RandomHolder;

partial class SudokuSolver
{


  internal static SudokuEventArgs NewSudokuGame(SudokuEventArgs arg)
  {
    var new_game = arg.NewGame;
    var isxsudoku = arg.XSudoku;
    var sudokudatas = arg.SudokuDatas;
    var numberofsolution = arg.NumberOfSolution;
    var (dlevel, dllength) = ToDifficultyData(arg);

    if (!new_game || sudokudatas.Count > 0)
      throw new ArgumentNullException(nameof(arg),
        $"{nameof(arg)}: sudokudatas has failed!");

    var bytes = Enumerable.Range(1, SUDOKU_GRID_LENGTH)
        .Select(x => (byte)x).OrderBy(x => Instance.NextInt32()).ToArray();

    var grid = Enumerable.Range(0, SUDOKU_GRID_LENGTH)
      .Select(x => new byte[SUDOKU_GRID_LENGTH].ToList()).ToList();

    for (var i = 0; i < bytes.Length; i++)
      grid[i][i] = bytes[i];

    List<List<List<byte>>> allresult = [];
    if (SolverSudoku(grid, allresult, numberofsolution, 1, isxsudoku))
    {
      return new SudokuEventArgs
      {
        NewGame = new_game,
        XSudoku = isxsudoku,
        NumberOfSolution = numberofsolution,
        SudokuDatas = allresult,
        DifficultyLevel = dlevel,
      };
    }

    throw new ArgumentOutOfRangeException(nameof(arg));
  }

  internal static SudokuEventArgs Sudoku_Solver(SudokuEventArgs arg)
  {
    var new_game = arg.NewGame;
    var isxsudoku = arg.XSudoku;
    var sudokudatas = arg.SudokuDatas;
    var numberofsolution = arg.NumberOfSolution;
    var (dlevel, dllength) = ToDifficultyData(arg);

    if (sudokudatas is null)
      throw new ArgumentNullException(nameof(arg),
        $"{nameof(arg)}: sudokudatas has failed!");

    List<List<List<byte>>> allresult = [];
    if (SolverSudoku(sudokudatas.First(), allresult, numberofsolution, 1, isxsudoku))
    {
      return new SudokuEventArgs
      {
        NewGame = new_game,
        XSudoku = isxsudoku,
        NumberOfSolution = numberofsolution,
        SudokuDatas = allresult,
        DifficultyLevel = dlevel,
      };
    }

    throw new ArgumentOutOfRangeException(nameof(arg));
  }


  private static (DifficultyLevel DLevel, int Length) ToDifficultyData(SudokuEventArgs arg)
  {
    int dllength;
    DifficultyLevel dlevel;
    var d_level = arg.DifficultyLevel;
    if (d_level == DifficultyLevel.Random)
    {
      var (dl, dlen) = DifficultyLevelLength.RngDifficultyLevelLength();
      dlevel = dl; dllength = dlen;
    }
    else
    {
      dlevel = d_level;
      dllength = DifficultyLevelLength.ToDifficultyLevelLength(dlevel);
    }
    return (dlevel, dllength);
  }
}



