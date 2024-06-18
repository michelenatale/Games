


namespace michele.natale.games.sudokus;

using michele.natale.games.sudokus.apps;
using Sudoku.Properties;
using sudokus.Handlers;

internal partial class FrmSudoku : Form
{

  internal event EventHandler<SudokuEventArgs>? SudokuHandler;

  public DifficultyLevel DLevel { get; private set; } = DifficultyLevel.None;

  public FrmSudoku(DifficultyLevel dlevel)
  {
    this.DLevel = dlevel;
    this.InitializeComponent();

    this.Uc_Sudoku!.SudokuHandler += this.App_SudokuGame_Forwart!;

    this.Uc_Sudoku?.SetDLevel(dlevel);

    this.Icon = Resources.myLogo64;

  }

  private void App_SudokuGame_Forwart(object sender, SudokuEventArgs e)
  {
    if (sender is UcSudoku)
      this.SudokuHandler?.Invoke(sender, e);
  }

  private void FrmSudoku_FormClosed(object sender, FormClosedEventArgs e)
  {
    this.Uc_Sudoku.SudokuHandler -= this.App_SudokuGame_Forwart!;
  }

  private void FrmSudoku_Load(object sender, EventArgs e)
  {
    this.Uc_Sudoku.NewSudoku();
  }
}
