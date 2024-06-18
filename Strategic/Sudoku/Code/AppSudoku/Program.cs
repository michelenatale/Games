


namespace michele.natale.games.sudokus.apps;


public static class Program
{

  [STAThread]
  private static void Main()
  {
    ApplicationConfiguration.Initialize();

    var sudoku_game = new SudokuGames();
    sudoku_game.Start(new FrmStart());
  }
}