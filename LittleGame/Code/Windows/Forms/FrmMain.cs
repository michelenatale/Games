

using System.Diagnostics;

namespace michele.natale.Games;

internal partial class FrmMain : Form
{
  private int Sum = -1, Index = -1;
  private readonly TlpHolder? TblButtonsHolder;
  internal event EventHandler<LittleGameEventArgs>? LittleGameHandler;

  public FrmMain()
  {
    this.InitializeComponent();
    this.TblButtonsHolder = new();
    this.SetTlpButtons(0);
    this.TblButtonsHolder.BtStart.Select();

    this.TblButtonsHolder.BtNo.Click += new EventHandler(this.Buttons_Click!);
    this.TblButtonsHolder.BtYes.Click += new EventHandler(this.Buttons_Click!);
    this.TblButtonsHolder.BtStart.Click += new EventHandler(this.Buttons_Click!);

    this.DgvMain.RowTemplate.Resizable = DataGridViewTriState.True;
    this.DgvMain.RowTemplate.MinimumHeight = this.DgvMain.Height / 4;
    this.DgvMain.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;
    this.DgvMain.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    this.DgvMain.RowsAdded += new DataGridViewRowsAddedEventHandler(this.DgvMain_RowsAdded!);

    this.Icon = FrmLittleGame.Properties.Resources.myIcon;
  }

  private void Buttons_Click(object sender, EventArgs e)
  {
    switch (sender)
    {
      case Button obj when obj == this.BtClose: this.CloseForm(); break;
      case Button obj when obj == this.TblButtonsHolder!.BtNo: this.Run(false); break;
      case Button obj when obj == this.TblButtonsHolder!.BtYes: this.Run(true); break;
      case Button obj when obj == this.TblButtonsHolder!.BtStart: Start(); break;

      case ToolStripMenuItem obj when obj == this.OverMeToolStripMenuItem!: OverMe(); break;
      case ToolStripMenuItem obj when obj == this.StartNewToolStripMenuItem: Start(); break;
      case ToolStripMenuItem obj when obj == this.CloseToolStripMenuItem!: CloseForm(); break;
      case ToolStripMenuItem obj when obj == this.InfoLittleGameToolStripMenuItem!: InfoLittleGame(); break;
    }
  }

  private void DgvMain_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) =>
    this.DgvMain.Rows[e.RowIndex].Height = this.DgvMain.Height / 4;

  private void DgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e) =>
    this.DgvMain.ClearSelection();

  private void CloseForm()
  {
    this.TblButtonsHolder?.Dispose();
    this.Close();
  }

  private void Start()
  {
    this.SetTlpButtons(1);
    this.RaiseEvent(true, false);
  }

  private void Run(bool answer)
  {
    if (this.DgvMain.Rows.Count == 0)
    {
      if (!answer) this.CloseForm();
      else this.Start();
      return;
    }

    this.RaiseEvent(false, answer);

    if (this.Index > 5)
    {
      this.DgvMain.Rows.Clear();

      MessageBox.Show($"Your Number is {this.Sum}", "Result");

      this.TsStatusLabel.Text = $"      Another round?";
      this.Index = -1;
      this.SetTlpButtons(0);
      this.TblButtonsHolder!.BtStart.Select();
    }
  }

  private void RaiseEvent(bool newgame, bool answer)
  {
    var args = new LittleGameEventArgs
    {
      Answer = answer,
      NewGame = newgame,
      Index = -1,
      Sum = -1,
    };
    LittleGameHandler?.Invoke(this, args);

    if (args.Data is not null)
      SetDatas(args.Data!);

    this.Sum = args.Sum;
    this.Index = args.Index;
  }

  private void SetDatas(string[][] data)
  {
    this.DgvMain.Rows.Clear();
    var columns = data.Max(x => x.Length);
    this.DgvMain.ColumnCount = columns;
    Array.ForEach(data, x => this.DgvMain.Rows.Add(x));
    this.TsStatusLabel.Text = "      Is the number in this table?";
    this.DgvMain.ClearSelection();
  }

  private void SetTlpButtons(int index)
  {
    this.TlpButtons?.SuspendLayout();
    this.SuspendLayout();

    this.TlpMain.Controls.Remove(this.TlpButtons);
    this.TlpButtons = this.TblButtonsHolder!.CacheTlp[index];

    this.TlpMain.Controls.Add(this.TlpButtons, 0, 2);
    this.TlpButtons.Dock = DockStyle.Fill;

    this.TlpButtons?.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  private static void OverMe() =>
    Process.Start(new ProcessStartInfo("https://github.com/michelenatale") { UseShellExecute = true });

  private static void InfoLittleGame() =>
    Process.Start(new ProcessStartInfo("https://github.com/michelenatale/LittleGame") { UseShellExecute = true });

}