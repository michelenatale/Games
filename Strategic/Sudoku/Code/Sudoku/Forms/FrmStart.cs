


using Sudoku.Properties;

namespace michele.natale.games.sudokus.apps;

using static services.SudokuServices;

public partial class FrmStart : Form
{
  private readonly string LinkValue = "https://github.com/michelenatale";
  public DifficultyLevel DLevel { get; private set; } = DifficultyLevel.None;

  public FrmStart()
  {
    this.InitializeComponent();

    this.Icon = Resources.myLogo64;
    this.DialogResult = DialogResult.None;
  }

  private void FrmStart_Click(object sender, EventArgs e)
  {
    switch (sender)
    {
      case Button obj when obj == this.BtEasy: this.Close_Form(DifficultyLevel.Easy); break;
      case Button obj when obj == this.BtMedium: this.Close_Form(DifficultyLevel.Medium); break;
      case Button obj when obj == this.BtDificult: this.Close_Form(DifficultyLevel.Difficult); break;
      case Button obj when obj == this.BtExpert: this.Close_Form(DifficultyLevel.Expert); break;
      case Button obj when obj == this.BtMaster: this.Close_Form(DifficultyLevel.Master); break;
      case Button obj when obj == this.BtExtreme: this.Close_Form(DifficultyLevel.Extreme); break;
      case Button obj when obj == this.BtRngDifficultyLevel: this.Close_Form(DifficultyLevel.Random); break;

      case Panel obj when obj == this.PlStartMainTop: OpenUrl(this.LinkValue); break;
    }
  }

  private void LlMnHomepage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.LlMnHomepage.LinkVisited = true;

    OpenUrl(this.LinkValue);

    e.Link!.Visited = true;
  }

  private void LlMnHomepage_MouseEnter(object sender, EventArgs e)
  {
    var llabel = (LinkLabel)sender;
    var lfont = llabel.Font;
    llabel.Font = new Font(lfont.FontFamily, lfont.Size, FontStyle.Italic);
  }

  private void LlMnHomepage_MouseLeave(object sender, EventArgs e)
  {
    var llabel = (LinkLabel)sender;
    var lfont = llabel.Font;
    llabel.Font = new Font(lfont.FontFamily, lfont.Size, FontStyle.Regular);

  }

  private void Close_Form(DifficultyLevel dlevel)
  {
    this.DLevel = dlevel;
    this.DialogResult = DialogResult.OK; 
    this.Close();
  }

}
