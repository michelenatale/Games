namespace michele.natale.games.sudokus;

using apps;
using Handlers;

public class SudokuGames : SudokuGamesBase
{

  public SudokuGames() : base()
  {
  }

  public void Start(FrmStart? frmmain)
  {
    using var frm_start = frmmain;

    while (true)
    {
      var dres = frm_start!.ShowDialog();
      var dlevel = frm_start.DLevel;
      if (dres == DialogResult.OK)
      {
        frm_start.Hide();

        using var frm_sudoku = new FrmSudoku(dlevel);
        frm_sudoku.SudokuHandler += this.App_SudokuGame!;
        frm_sudoku.ShowDialog();
        frm_sudoku.SudokuHandler -= this.App_SudokuGame!;
      }
      else break;
    }
  }


  private void App_SudokuGame(object sender, SudokuEventArgs e)
  {
    if (sender is UserControl ucs && ucs.Name == "Uc_Sudoku")
    {
      SudokuEventArgs args;
      if (e.NewGame)
      {
        args = SudokuSolver.NewSudokuGame(e);
        e.XSudoku = e.XSudoku;
        e.NewGame = args.NewGame;
        e.SudokuDatas = args.SudokuDatas;
        e.NumberOfSolution = args.NumberOfSolution;
        e.DifficultyLevel = args.DifficultyLevel;

        return;
      }

      args = SudokuSolver.Sudoku_Solver(e);
      e.XSudoku = args.XSudoku;
      e.NewGame = args.NewGame;
      e.SudokuDatas = args.SudokuDatas;
      e.NumberOfSolution = args.NumberOfSolution;
      e.DifficultyLevel = args.DifficultyLevel;

    }
  }
}
