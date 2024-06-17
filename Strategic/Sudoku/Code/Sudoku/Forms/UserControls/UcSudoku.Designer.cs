

namespace michele.natale.games.sudokus.apps;

partial class UcSudoku
{
  /// <summary> 
  /// Erforderliche Designervariable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary> 
  /// Verwendete Ressourcen bereinigen.
  /// </summary>
  /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
  protected override void Dispose(bool disposing)
  {
    if (disposing && (components != null))
    {
      components.Dispose();
    }
    base.Dispose(disposing);
  }

  #region Vom Komponenten-Designer generierter Code

  /// <summary> 
  /// Erforderliche Methode für die Designerunterstützung. 
  /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
  /// </summary>
  private void InitializeComponent()
  {
    this.TlpUcMain = new TableLayoutPanel();
    this.TlpUcButtons = new TableLayoutPanel();
    this.CbUcDifficulti = new ComboBox();
    this.CbUcXSudoku = new CheckBox();
    this.BtSudokuSolver = new Button();
    this.BtUcSolution = new Button();
    this.BtUcSolvL = new Button();
    this.BtUcSolvR = new Button();
    this.BtUcNewSudoku = new Button();
    this.BtUcLoad = new Button();
    this.BtUcSave = new Button();
    this.PtUcLogo = new Panel();
    this.DgvMain = new DataGridView();
    this.TlpUcMain.SuspendLayout();
    this.TlpUcButtons.SuspendLayout();
    ((System.ComponentModel.ISupportInitialize)this.DgvMain).BeginInit();
    this.SuspendLayout();
    // 
    // TlpUcMain
    // 
    this.TlpUcMain.ColumnCount = 2;
    this.TlpUcMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
    this.TlpUcMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 280F));
    this.TlpUcMain.Controls.Add(this.TlpUcButtons, 1, 1);
    this.TlpUcMain.Controls.Add(this.PtUcLogo, 0, 0);
    this.TlpUcMain.Controls.Add(this.DgvMain, 0, 1);
    this.TlpUcMain.Dock = DockStyle.Fill;
    this.TlpUcMain.Location = new Point(0, 0);
    this.TlpUcMain.MinimumSize = new Size(775, 465);
    this.TlpUcMain.Name = "TlpUcMain";
    this.TlpUcMain.RowCount = 2;
    this.TlpUcMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.0388765F));
    this.TlpUcMain.RowStyles.Add(new RowStyle(SizeType.Percent, 85.96112F));
    this.TlpUcMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
    this.TlpUcMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
    this.TlpUcMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
    this.TlpUcMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
    this.TlpUcMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
    this.TlpUcMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
    this.TlpUcMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
    this.TlpUcMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
    this.TlpUcMain.Size = new Size(785, 475);
    this.TlpUcMain.TabIndex = 100;
    // 
    // TlpUcButtons
    // 
    this.TlpUcButtons.ColumnCount = 5;
    this.TlpUcButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
    this.TlpUcButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
    this.TlpUcButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
    this.TlpUcButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
    this.TlpUcButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
    this.TlpUcButtons.Controls.Add(this.CbUcDifficulti, 0, 0);
    this.TlpUcButtons.Controls.Add(this.CbUcXSudoku, 0, 1);
    this.TlpUcButtons.Controls.Add(this.BtSudokuSolver, 0, 5);
    this.TlpUcButtons.Controls.Add(this.BtUcSolution, 1, 4);
    this.TlpUcButtons.Controls.Add(this.BtUcSolvL, 0, 4);
    this.TlpUcButtons.Controls.Add(this.BtUcSolvR, 4, 4);
    this.TlpUcButtons.Controls.Add(this.BtUcNewSudoku, 0, 3);
    this.TlpUcButtons.Controls.Add(this.BtUcLoad, 0, 7);
    this.TlpUcButtons.Controls.Add(this.BtUcSave, 3, 7);
    this.TlpUcButtons.Dock = DockStyle.Fill;
    this.TlpUcButtons.Location = new Point(508, 69);
    this.TlpUcButtons.Name = "TlpUcButtons";
    this.TlpUcButtons.RowCount = 9;
    this.TlpUcButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
    this.TlpUcButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
    this.TlpUcButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
    this.TlpUcButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
    this.TlpUcButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
    this.TlpUcButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
    this.TlpUcButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
    this.TlpUcButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
    this.TlpUcButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
    this.TlpUcButtons.Size = new Size(274, 403);
    this.TlpUcButtons.TabIndex = 101;
    // 
    // CbUcDifficulti
    // 
    this.CbUcDifficulti.Anchor = AnchorStyles.None;
    this.TlpUcButtons.SetColumnSpan(this.CbUcDifficulti, 5);
    this.CbUcDifficulti.DrawMode = DrawMode.OwnerDrawFixed;
    this.CbUcDifficulti.DropDownStyle = ComboBoxStyle.DropDownList;
    this.CbUcDifficulti.FormattingEnabled = true;
    this.CbUcDifficulti.Location = new Point(12, 7);
    this.CbUcDifficulti.Margin = new Padding(5, 4, 5, 4);
    this.CbUcDifficulti.Name = "CbUcDifficulti";
    this.CbUcDifficulti.Size = new Size(250, 35);
    this.CbUcDifficulti.TabIndex = 1;
    this.CbUcDifficulti.DrawItem += this.CbUcDifficulti_DrawItem;
    // 
    // CbUcXSudoku
    // 
    this.CbUcXSudoku.Anchor = AnchorStyles.None;
    this.TlpUcButtons.SetColumnSpan(this.CbUcXSudoku, 5);
    this.CbUcXSudoku.Location = new Point(12, 46);
    this.CbUcXSudoku.Margin = new Padding(5, 4, 5, 4);
    this.CbUcXSudoku.Name = "CbUcXSudoku";
    this.CbUcXSudoku.Size = new Size(250, 34);
    this.CbUcXSudoku.TabIndex = 2;
    this.CbUcXSudoku.Text = "XSudoku";
    this.CbUcXSudoku.TextAlign = ContentAlignment.MiddleCenter;
    this.CbUcXSudoku.UseVisualStyleBackColor = true;
    this.CbUcXSudoku.CheckedChanged += this.UcButtons_ClickChange;
    // 
    // BtSudokuSolver
    // 
    this.BtSudokuSolver.Anchor = AnchorStyles.None;
    this.TlpUcButtons.SetColumnSpan(this.BtSudokuSolver, 5);
    this.BtSudokuSolver.Location = new Point(12, 243);
    this.BtSudokuSolver.Margin = new Padding(5, 4, 5, 4);
    this.BtSudokuSolver.Name = "BtSudokuSolver";
    this.BtSudokuSolver.Size = new Size(250, 34);
    this.BtSudokuSolver.TabIndex = 5;
    this.BtSudokuSolver.Text = "Sudoku Solver";
    this.BtSudokuSolver.UseVisualStyleBackColor = true;
    this.BtSudokuSolver.Click += this.UcButtons_ClickChange;
    // 
    // BtUcSolution
    // 
    this.BtUcSolution.Anchor = AnchorStyles.None;
    this.TlpUcButtons.SetColumnSpan(this.BtUcSolution, 3);
    this.BtUcSolution.Location = new Point(55, 201);
    this.BtUcSolution.Margin = new Padding(5, 4, 5, 4);
    this.BtUcSolution.Name = "BtUcSolution";
    this.BtUcSolution.Size = new Size(164, 34);
    this.BtUcSolution.TabIndex = 4;
    this.BtUcSolution.Text = "Solution";
    this.BtUcSolution.UseVisualStyleBackColor = true;
    this.BtUcSolution.Click += this.UcButtons_ClickChange;
    // 
    // BtUcSolvL
    // 
    this.BtUcSolvL.Anchor = AnchorStyles.Right;
    this.BtUcSolvL.Enabled = false;
    this.BtUcSolvL.ForeColor = SystemColors.ControlText;
    this.BtUcSolvL.Location = new Point(12, 201);
    this.BtUcSolvL.Margin = new Padding(5, 4, 5, 4);
    this.BtUcSolvL.Name = "BtUcSolvL";
    this.BtUcSolvL.Size = new Size(33, 34);
    this.BtUcSolvL.TabIndex = 3;
    this.BtUcSolvL.Text = "◄";
    this.BtUcSolvL.UseVisualStyleBackColor = true;
    // 
    // BtUcSolvR
    // 
    this.BtUcSolvR.Anchor = AnchorStyles.Left;
    this.BtUcSolvR.Enabled = false;
    this.BtUcSolvR.ForeColor = SystemColors.ControlText;
    this.BtUcSolvR.Location = new Point(229, 201);
    this.BtUcSolvR.Margin = new Padding(5, 4, 5, 4);
    this.BtUcSolvR.Name = "BtUcSolvR";
    this.BtUcSolvR.Size = new Size(33, 34);
    this.BtUcSolvR.TabIndex = 3;
    this.BtUcSolvR.Text = "►";
    this.BtUcSolvR.UseVisualStyleBackColor = true;
    // 
    // BtUcNewSudoku
    // 
    this.BtUcNewSudoku.Anchor = AnchorStyles.None;
    this.TlpUcButtons.SetColumnSpan(this.BtUcNewSudoku, 5);
    this.BtUcNewSudoku.Location = new Point(12, 159);
    this.BtUcNewSudoku.Margin = new Padding(5, 4, 5, 4);
    this.BtUcNewSudoku.Name = "BtUcNewSudoku";
    this.BtUcNewSudoku.Size = new Size(250, 34);
    this.BtUcNewSudoku.TabIndex = 3;
    this.BtUcNewSudoku.Text = "New Sudoku";
    this.BtUcNewSudoku.UseVisualStyleBackColor = true;
    this.BtUcNewSudoku.Click += this.UcButtons_ClickChange;
    // 
    // BtUcLoad
    // 
    this.BtUcLoad.Anchor = AnchorStyles.Right;
    this.TlpUcButtons.SetColumnSpan(this.BtUcLoad, 2);
    this.BtUcLoad.Location = new Point(12, 356);
    this.BtUcLoad.Margin = new Padding(5, 4, 5, 4);
    this.BtUcLoad.Name = "BtUcLoad";
    this.BtUcLoad.Size = new Size(113, 34);
    this.BtUcLoad.TabIndex = 6;
    this.BtUcLoad.Text = "Load";
    this.BtUcLoad.UseVisualStyleBackColor = true;
    this.BtUcLoad.Click += this.UcButtons_ClickChange;
    // 
    // BtUcSave
    // 
    this.BtUcSave.Anchor = AnchorStyles.Left;
    this.TlpUcButtons.SetColumnSpan(this.BtUcSave, 2);
    this.BtUcSave.Enabled = false;
    this.BtUcSave.Location = new Point(149, 356);
    this.BtUcSave.Margin = new Padding(5, 4, 5, 4);
    this.BtUcSave.Name = "BtUcSave";
    this.BtUcSave.Size = new Size(113, 34);
    this.BtUcSave.TabIndex = 7;
    this.BtUcSave.Text = "Save";
    this.BtUcSave.UseVisualStyleBackColor = true;
    // 
    // PtUcLogo
    // 
    this.PtUcLogo.BackgroundImage = Sudoku.Properties.Resources.myLogo;
    this.PtUcLogo.BackgroundImageLayout = ImageLayout.Zoom;
    this.TlpUcMain.SetColumnSpan(this.PtUcLogo, 2);
    this.PtUcLogo.Dock = DockStyle.Fill;
    this.PtUcLogo.Location = new Point(3, 3);
    this.PtUcLogo.Name = "PtUcLogo";
    this.PtUcLogo.Size = new Size(779, 60);
    this.PtUcLogo.TabIndex = 9;
    this.PtUcLogo.Click += this.UcButtons_ClickChange;
    // 
    // DgvMain
    // 
    this.DgvMain.AllowUserToAddRows = false;
    this.DgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    this.DgvMain.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
    this.DgvMain.BackgroundColor = Color.White;
    this.DgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.DgvMain.ColumnHeadersVisible = false;
    this.DgvMain.Dock = DockStyle.Fill;
    this.DgvMain.EditMode = DataGridViewEditMode.EditProgrammatically;
    this.DgvMain.Location = new Point(10, 76);
    this.DgvMain.Margin = new Padding(10);
    this.DgvMain.MultiSelect = false;
    this.DgvMain.Name = "DgvMain";
    this.DgvMain.ReadOnly = true;
    this.DgvMain.RowHeadersVisible = false;
    this.DgvMain.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
    this.DgvMain.RowTemplate.Height = 25;
    this.DgvMain.Size = new Size(485, 389);
    this.DgvMain.TabIndex = 102;
    this.DgvMain.CellDoubleClick += this.DgvMain_CellContentClick;
    this.DgvMain.CellLeave += this.DgvMain_CellEndEdit;
    this.DgvMain.CellPainting += this.DgvMain_CellPainting;
    this.DgvMain.CellValueChanged += this.DgvMain_CellEndEdit;
    // 
    // UcSudoku
    // 
    this.AutoScaleDimensions = new SizeF(13F, 26F);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.Controls.Add(this.TlpUcMain);
    this.Font = new Font("Arial", 14F);
    this.Margin = new Padding(5, 4, 5, 4);
    this.Name = "UcSudoku";
    this.Size = new Size(785, 475);
    this.Resize += this.UcButtons_ClickChange;
    this.TlpUcMain.ResumeLayout(false);
    this.TlpUcButtons.ResumeLayout(false);
    ((System.ComponentModel.ISupportInitialize)this.DgvMain).EndInit();
    this.ResumeLayout(false);
  }

  #endregion

  private Panel PtUcLogo;
  private Button BtUcLoad;
  private Button BtUcSave;
  private Button BtUcSolvL;
  private Button BtUcSolvR;
  private Button BtUcSolution;
  private CheckBox CbUcXSudoku;
  private Button BtUcNewSudoku;
  private DataGridView DgvMain;
  private Button BtSudokuSolver;
  private ComboBox CbUcDifficulti;
  private TableLayoutPanel TlpUcMain;
  private TableLayoutPanel TlpUcButtons;
}
