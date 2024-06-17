

namespace michele.natale.games.sudokus.apps;

using sudokus;
using Handlers;
using static sudokus.SudokuSolver;
using static services.SudokuServices;

public partial class UcSudoku : UserControl
{

  #region Variables

  private int Index = -1;

  private List<List<List<byte>>> Datas = [];

  internal event EventHandler<SudokuEventArgs>? SudokuHandler;

  public DifficultyLevel DLevel { get; private set; } = DifficultyLevel.None;

  #endregion Variables

  #region Contructor
  public UcSudoku()
  {
    this.InitializeComponent();

    this.SetBtSaveButtons(false);

    this.CbUcDifficulti.DrawMode = DrawMode.OwnerDrawFixed;
    this.CbUcDifficulti.DropDownStyle = ComboBoxStyle.DropDownList;

    this.DgvMain.ReadOnly = false;
    //this.DgvMain.AutoGenerateColumns = true;
    this.DgvMain.AllowUserToResizeRows = false;
    this.DgvMain.RowTemplate.Resizable = DataGridViewTriState.True;
    this.DgvMain.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
    this.DgvMain.EditMode = DataGridViewEditMode.EditOnEnter;//EditProgrammatically
    this.DgvMain.CellBorderStyle = DataGridViewCellBorderStyle.Raised; //Sunken 
    this.DgvMain.RowTemplate.MinimumHeight = this.DgvMain.Height / SUDOKU_GRID_LENGTH;
    this.DgvMain.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;
    this.DgvMain.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    this.DgvMain.RowsAdded += new DataGridViewRowsAddedEventHandler(this.DgvMain_RowsAdded!);
  }

  internal void SetDLevel(DifficultyLevel dlevel)
  {
    this.DLevel = dlevel;
    this.FillComboBox(dlevel);
  }
  #endregion Contructor

  #region Control / Button Events
  private void UcButtons_ClickChange(object sender, EventArgs e)
  {
    switch (sender)
    {
      case Button obj when obj == this.BtUcLoad: this.Load_Data(); return;
      case Button obj when obj == this.BtUcSave: this.Save_Data(); return;
      case Button obj when obj == this.BtSudokuSolver: this.ToSudokuSolver(); return;
      case Button obj when obj == this.BtUcSolution: this.ToSolution(); return;
      case Button obj when obj == this.BtUcNewSudoku: this.NewSudoku(); return;
      case Button obj when obj == this.BtUcSolvR: this.ToSetBtUcSolvRLSettings(true); return;
      case Button obj when obj == this.BtUcSolvL: this.ToSetBtUcSolvRLSettings(false); return;

      case Panel obj when obj == this.PtUcLogo: ToHomePage(); return;

      case CheckBox obj when obj == this.CbUcXSudoku: this.NewSudoku(); return;
      case ComboBox obj when obj == this.CbUcDifficulti: this.NewSudoku(); return;

      case UcSudoku obj when obj == this: this.UcResize(false); return;
    }
  }

  private void DgvMain_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
  {
    if (e.ColumnIndex > -1 && e.RowIndex > -1)
    {
      using var grid_line_pen = new Pen(this.DgvMain.GridColor, 1);
      var top_left_point = new Point(e.CellBounds.Left, e.CellBounds.Top);
      var top_right_point = new Point(e.CellBounds.Right - 1, e.CellBounds.Top);
      var bottom_left_point = new Point(e.CellBounds.Left, e.CellBounds.Bottom - 1);

      if (this.DgvMain[e.ColumnIndex, e.RowIndex].Selected)
      {
      }
      else
      {
        e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);
        if (e.RowIndex > 0 && e.RowIndex < 8 && e.RowIndex % 3 == 0)
          e.Graphics?.DrawLine(grid_line_pen, top_left_point, top_right_point);

        if (e.ColumnIndex > 0 && e.ColumnIndex < 8 && e.ColumnIndex % 3 == 0)
          e.Graphics?.DrawLine(grid_line_pen, top_left_point, bottom_left_point);
      }
      e.Handled = true;
    }
  }

  private void CbUcDifficulti_DrawItem(object sender, DrawItemEventArgs e)
  {
    if (sender is ComboBox cbx)
    {
      e.DrawBackground();
      if (e.Index >= 0)
      {
        var sf = new StringFormat
        {
          LineAlignment = StringAlignment.Center,
          Alignment = StringAlignment.Center
        };
        Brush sbrush = new SolidBrush(cbx.ForeColor);
        if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
          sbrush = SystemBrushes.HighlightText;
        e.Graphics.DrawString(cbx.Items[e.Index]!.ToString(), cbx.Font, sbrush, e.Bounds, sf);
      }
    }
  }

  private void DgvMain_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) =>
    this.DgvMain.Rows[e.RowIndex].Height = this.DgvMain.Height / SUDOKU_GRID_LENGTH;

  private void DgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e) =>
    this.DgvMain.ClearSelection(); //if doubleclick

  private void DgvMain_CellEndEdit(object sender, DataGridViewCellEventArgs e)
  {
    if (string.IsNullOrEmpty((string)this.DgvMain.Rows[e.RowIndex].Cells[e.ColumnIndex].Value))
      return;

    if (this.DgvMain.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == " ")
      this.DgvMain.Rows[e.RowIndex].Cells[e.ColumnIndex].Value =
        this.DgvMain.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()!.Trim();

    if ((string)this.DgvMain.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != "")
    {
      var grid = this.ToDgvMainDatas();
      if (!CheckNumbers(grid, out var xy, this.CbUcXSudoku.Checked))
      {
        MessageBox.Show($"Set a correctly number in r = {xy.Item2 + 1} and c = {xy.Item1 + 1}");
        this.DgvMain.CurrentCell = this.DgvMain.Rows[e.RowIndex].Cells[e.ColumnIndex];
      }
      else if (IsFinished(grid))
      {
        var titel = "Sudoku System Information";
        var str = "Congratulations. The game was finished correctly!";
        MessageBox.Show(str, titel, MessageBoxButtons.OK, MessageBoxIcon.Information);

        this.UcResize(true);
      }
    }


    this.DgvMain.ClearSelection();
  }
  #endregion Control / Button Events

  #region Button Methodes
  internal void NewSudoku()
  {
    this.BtUcNewSudoku.Enabled = false;

    if (!this.CbUcDifficulti.Enabled)
      this.SetCurrentEvents(true);

    this.SetDefaultButtons();
    this.RaiseEvent(true, 1);

    this.BtUcNewSudoku.Enabled = true;
  }

  private void Save_Data()
  {
    this.BtUcSave.Enabled = false;
    if (this.DgvMain.Rows.Count == SUDOKU_GRID_LENGTH)
      if (this.DgvMain.Columns.Count == SUDOKU_GRID_LENGTH)
      {
        if (this.Datas.Count > 0)
        {
          var sdi = new SaveDataInfo
          {
            OrgDatas = this.Datas,
            Datas = this.ToDgvMainDatas(),
            DifficultyLevel = (DifficultyLevel)this.CbUcDifficulti.SelectedItem!,
            IsXSudoku = this.CbUcXSudoku.Checked,
          };
          SaveData(SerializeJson(sdi));
        }
      }
    this.BtUcSave.Enabled = true;
  }

  private void ToSudokuSolver()
  {
    this.BtSudokuSolver.Enabled = false;

    this.SetCellChangeEvents(false);
    this.DgvMain.Rows.Clear();
    this.DgvMain.Columns.Clear();
    this.SetCellChangeEvents(true);

    this.SetDefaultButtons();

    var datas = Enumerable.Range(0, SUDOKU_GRID_LENGTH)
      .Select(x => Enumerable.Range(0, SUDOKU_GRID_LENGTH)
      .Select(y => byte.MinValue).ToList()).ToList();

    this.Datas = [datas];
    this.SetCurrentEvents(false);
    this.SetDgvDatas(datas, false);

    this.DgvMain.Update();
    this.Validate();

    this.BtSudokuSolver.Enabled = true;
  }

  private void ToSolution()
  {
    this.BtUcSolution.Enabled = false;
    if (this.BtUcSolvR.Enabled) return;

    var data = this.ToDgvMainDatas();
    this.RaiseEvent(false, 10);
    this.Datas.Insert(0, data);

    this.SetCellChangeEvents(false);
    this.SetSolutionButtons(true);

    this.DgvMain.Update();
    this.Validate();
  }

  private void Load_Data()
  {

    this.BtUcLoad.Enabled = false;

    if (!this.CbUcDifficulti.Enabled)
      this.SetCurrentEvents(true);

    this.SetDefaultButtons();

    this.SetCellChangeEvents(false);
    this.DgvMain.Rows.Clear();
    this.DgvMain.Columns.Clear();
    this.SetCellChangeEvents(true);

    this.SetCurrentEvents(false);

    var datas = DeserializeJson<SaveDataInfo>(LoadData());
    if (datas is not null)
    {
      this.Datas = datas.OrgDatas.Select(x => x.Select(y => y.ToList()).ToList()).ToList();
      this.CbUcXSudoku.Checked = datas.IsXSudoku;
      this.CbUcDifficulti.SelectedItem = datas.DifficultyLevel;
      this.SetDgvDatas(datas?.Datas!, false);
      if (this.Datas.Count > 1) this.SetSolutionButtons(true); ;
      this.DgvMain.Update();
    }
    this.SetCurrentEvents(true);
    this.Validate();

    this.BtUcLoad.Enabled = true;
  }

  private void ToSetBtUcSolvRLSettings(bool is_btr)
  {
    if (is_btr)
    {
      if (this.Index >= this.Datas.Count - 1) return;
      if (this.Datas.Count > this.Index + 1) this.Index++;
      if (this.Datas.Count > this.Index)
      {
        this.SetDgvDatas(this.Datas[this.Index], true);
        this.BtUcSolution.Text = $"Solution [{this.Index}]";

        if (this.Index > 0 && !this.BtUcSolvL.Enabled)
          this.SetBtUcSolvLButtons(true);
      }
      this.DgvMain.Update();
      this.Validate();
      return;
    }

    this.Index--;
    if (this.Index < 0) return;

    this.SetDgvDatas(this.Datas[this.Index], true);
    this.BtUcSolution.Text = $"Solution [{this.Index}]";
    if (this.Index < 1) this.SetBtUcSolvLButtons(false);
    this.DgvMain.Update();
    this.Validate();
  }
  #endregion Button Methodes

  #region Settings Methodes

  private void SetCellChangeEvents(bool set)
  {
    if (set)
    {
      this.DgvMain.CellLeave += this.DgvMain_CellEndEdit!;
      this.DgvMain.CellValueChanged += this.DgvMain_CellEndEdit!;
      return;
    }

    this.DgvMain.CellLeave -= this.DgvMain_CellEndEdit!;
    this.DgvMain.CellValueChanged -= this.DgvMain_CellEndEdit!;
  }

  private void SetSolutionButtons(bool set)
  {
    this.BtUcSolution.Enabled = !set;
    this.SetBtUcSolvRButtons(set);

    this.Index = -1;
    this.ToSetBtUcSolvRLSettings(set);
  }

  private void SetDefaultButtons()
  {
    this.SetBtUcSolvLButtons(false);
    this.SetBtUcSolvRButtons(false);
    this.BtUcSolution.Enabled = true;
    this.BtUcSolution.Text = "Solution";
  }

  private void SetBtUcSolvLButtons(bool set)
  {
    this.BtUcSolvL.Enabled = set;
    if (set)
      this.BtUcSolvL.Click += this.UcButtons_ClickChange!;
    else this.BtUcSolvL.Click -= this.UcButtons_ClickChange!;
  }

  private void SetBtUcSolvRButtons(bool set)
  {
    this.BtUcSolvR.Enabled = set;
    if (set)
      this.BtUcSolvR.Click += this.UcButtons_ClickChange!;
    else this.BtUcSolvR.Click -= this.UcButtons_ClickChange!;
  }

  private void SetBtSaveButtons(bool set)
  {
    this.BtUcSave.Enabled = set;
    if (set)
      this.BtUcSave.Click += this.UcButtons_ClickChange!;
    else this.BtUcSave.Click -= this.UcButtons_ClickChange!;
  }

  private void SetCurrentEvents(bool set)
  {
    this.CbUcXSudoku.Enabled = set;
    this.CbUcDifficulti.Enabled = set;

    if (set)
    {
      this.CbUcDifficulti.DrawItem += this.CbUcDifficulti_DrawItem!;
      this.CbUcXSudoku.CheckedChanged += this.UcButtons_ClickChange!;
      this.CbUcDifficulti.SelectedIndexChanged += this.UcButtons_ClickChange!;
    }
    else
    {
      this.CbUcDifficulti.DrawItem -= this.CbUcDifficulti_DrawItem!;
      this.CbUcXSudoku.CheckedChanged -= this.UcButtons_ClickChange!;
      this.CbUcDifficulti.SelectedIndexChanged -= this.UcButtons_ClickChange!;
    }
  }

  private void FillComboBox(DifficultyLevel dlevel)
  {
    var dcl = (DifficultyLevel[])Enum.GetValues(typeof(DifficultyLevel));
    dcl = dcl.Skip(1).ToArray(); //None

    var idx = Array.IndexOf(dcl, dlevel);

    this.CbUcDifficulti.Items.AddRange(dcl.Select(x => (object)x).ToArray());
    this.CbUcDifficulti.SelectedIndex = idx;

    this.CbUcDifficulti.SelectedIndexChanged += this.UcButtons_ClickChange!;
  }
  #endregion Settings Methodes

  #region DGV Methodes
  private List<List<byte>> ToDgvMainDatas()
  {
    if (this.DgvMain.Rows.Count == 9)
      if (this.DgvMain.Columns.Count == 9)
      {
        var result = new List<List<byte>>();
        for (int r = 0; r < this.DgvMain.Rows.Count; r++)
        {
          var rr = new List<byte>();
          for (int c = 0; c < this.DgvMain.Columns.Count; c++)
          {
            if (this.DgvMain.Rows[r].Cells[c].Value is not null)
            {
              var v = this.DgvMain.Rows[r].Cells[c].Value.ToString()?.Trim();
              if (byte.TryParse(v, out var n)) rr.Add(n);
              else rr.Add(0);
            }
            else rr.Add(0);
          }
          result.Add(rr);
        }
        return result;
      }
    throw new NotImplementedException();
  }

  private void SetDgvDatas(SudokuEventArgs args, int idx, bool cell_must_readonly)
  {
    this.Datas = [];
    var gamedata = args.SudokuDatas[idx].Select(x => x.ToList()).ToList();
    var dllength = DifficultyLevelLength.ToDifficultyLevelLength(args.DifficultyLevel);
    var sgrid = CustomizeGrid(gamedata, dllength);
    this.Datas.Add(sgrid);

    this.SetDgvDatas(sgrid, cell_must_readonly);

    if (!BtUcSave.Enabled)
      this.SetBtSaveButtons(true);

  }

  private void SetDgvDatas(List<List<byte>> data, bool cell_must_readonly)
  {
    this.DgvMain.SuspendLayout();

    var sdata = data
        .Select(x => x.Select(y => y == 0 ? string.Empty : y.ToString())
        .ToArray()).ToArray();

    this.SetCellChangeEvents(false);
    this.DgvMain.Rows.Clear();
    this.DgvMain.Columns.Clear();
    this.SetCellChangeEvents(true);

    this.DgvMain.ColumnCount = SUDOKU_GRID_LENGTH;
    Array.ForEach(sdata, x => this.DgvMain.Rows.Add(x));
    this.DgvMain.ClearSelection();

    this.DgvUpdate(cell_must_readonly);
    this.UcResize(cell_must_readonly);
    this.DgvMain.Update();
    this.DgvMain.Refresh();
    this.DgvMain.ResumeLayout(false);
  }

  private void DgvUpdate(bool must_readonly)
  {
    if (this.DgvMain.Rows.Count != 9)
      return;

    var isxs = this.CbUcXSudoku.Checked;

    for (int r = 0; r < 9; r++)
    {
      for (int c = 0; c < 9; c++)
      {
        var f = this.DgvMain.Font;
        ((DataGridViewTextBoxCell)this.DgvMain.Rows[r].Cells[c]).ReadOnly = true;
        ((DataGridViewTextBoxCell)this.DgvMain.Rows[r].Cells[c]).MaxInputLength = 1;
        ((DataGridViewTextBoxCell)this.DgvMain.Rows[r].Cells[c]).Style.ForeColor = SystemColors.ControlText;
        ((DataGridViewTextBoxCell)this.DgvMain.Rows[r].Cells[c]).Style.WrapMode = DataGridViewTriState.NotSet;
        ((DataGridViewTextBoxCell)this.DgvMain.Rows[r].Cells[c]).Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        ((DataGridViewTextBoxCell)this.DgvMain.Rows[r].Cells[c]).Style.Font = new Font(f.FontFamily, f.Size, FontStyle.Regular);

        if (isxs && r == c)
        {
          ((DataGridViewTextBoxCell)this.DgvMain.Rows[r].Cells[c]).Style.BackColor = Color.PeachPuff;
          ((DataGridViewTextBoxCell)this.DgvMain.Rows[r].Cells[8 - c]).Style.BackColor = Color.PeachPuff;
        }

        if (this.Datas[0][r][c] == 0)
        {
          ((DataGridViewTextBoxCell)this.DgvMain.Rows[r].Cells[c]).ReadOnly = must_readonly;
        }
        else
        {
          ((DataGridViewTextBoxCell)this.DgvMain.Rows[r].Cells[c]).ReadOnly = true;
          ((DataGridViewTextBoxCell)this.DgvMain.Rows[r].Cells[c]).Style.ForeColor = Color.DarkGreen;
          ((DataGridViewTextBoxCell)this.DgvMain.Rows[r].Cells[c]).Style.Font = new Font(f.FontFamily, f.Size, FontStyle.Italic | FontStyle.Bold);
        }

      }
    }
  }
  #endregion DGV Methodes

  #region RaiseEvent Methodes

  private void RaiseEvent(bool newgame, int nos)
  {
    var args = new SudokuEventArgs
    {
      NewGame = newgame, //newgame or sudokusolver
      XSudoku = this.CbUcXSudoku.Checked,
      DifficultyLevel = (DifficultyLevel)this.CbUcDifficulti.SelectedItem!,
      SudokuDatas = newgame ? [] : [this.ToDgvMainDatas()],
      NumberOfSolution = nos,
    };
    SudokuHandler?.Invoke(this, args);

    if (newgame && args.SudokuDatas is not null)
      this.SetDgvDatas(args, 0, false);
    else this.Datas = args.SudokuDatas!;

    this.Validate();
  }
  #endregion RaiseEvent Methodes

  #region UserControl Methodes
  private void UcResize(bool cell_must_readonly)
  {
    this.DgvMain.SuspendLayout();

    if (!this.BtUcSolution.Enabled)
      cell_must_readonly = true;

    Thread.Sleep(5);
    var h = (this.DgvMain.Height - 1) / SUDOKU_GRID_LENGTH;
    this.DgvMain.RowTemplate.Height = h;
    this.DgvMain.RowTemplate.MinimumHeight = h;
    foreach (DataGridViewRow row in this.DgvMain.Rows)
    {
      row.MinimumHeight = h;
      row.Height = h;
    }

    var w = this.DgvMain.Width / SUDOKU_GRID_LENGTH;
    foreach (DataGridViewColumn col in this.DgvMain.Columns)
      col.Width = w;

    this.DgvUpdate(cell_must_readonly);
    this.DgvMain.Update();

    this.DgvMain.ResumeLayout(false);

  }
  #endregion UserControl Methodes

  #region Homepage Methodes
  private static void ToHomePage()
  {
    OpenUrl("https://github.com/michelenatale");
  }
  #endregion homepage Methodes
}
