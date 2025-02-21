

namespace michele.natale.Games;

partial class FrmMain
{
  /// <summary>
  ///  Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer  Components = null;

  /// <summary>
  ///  Clean up any resources being used.
  /// </summary>
  /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
  protected override void Dispose(bool disposing)
  {
    if (disposing && (Components != null)) 
      Components.Dispose(); 
    base.Dispose(disposing);
  }

  #region Windows Form Designer generated code

  /// <summary>
  ///  Required method for Designer support - do not modify
  ///  the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent()
  {
    //this.Components = new System.ComponentModel.Container();
    this.MenuMain = new System.Windows.Forms.MenuStrip();
    this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    this.StartNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    this.InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    this.OverMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    this.InfoLittleGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    this.StatusMain = new System.Windows.Forms.StatusStrip();
    this.TsStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
    this.TlpMain = new System.Windows.Forms.TableLayoutPanel();
    this.BtClose = new System.Windows.Forms.Button();
    this.DgvMain = new System.Windows.Forms.DataGridView();
    this.TlpButtons = new System.Windows.Forms.TableLayoutPanel();
    this.MenuMain.SuspendLayout();
    this.StatusMain.SuspendLayout();
    this.TlpMain.SuspendLayout();
    ((System.ComponentModel.ISupportInitialize)(this.DgvMain)).BeginInit();
    this.SuspendLayout();
    // 
    // MenuMain
    // 
    this.MenuMain.Dock = System.Windows.Forms.DockStyle.Fill;
    this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.InfoToolStripMenuItem});
    this.MenuMain.Location = new System.Drawing.Point(0, 0);
    this.MenuMain.Name = "MenuMain";
    this.MenuMain.Size = new System.Drawing.Size(434, 28);
    this.MenuMain.TabIndex = 100;
    this.MenuMain.Text = "menuStrip1";
    // 
    // fileToolStripMenuItem
    // 
    this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartNewToolStripMenuItem,
            this.CloseToolStripMenuItem});
    this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
    this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 24);
    this.fileToolStripMenuItem.Text = "&File";
    // 
    // StartNewToolStripMenuItem
    // 
    this.StartNewToolStripMenuItem.Name = "StartNewToolStripMenuItem";
    this.StartNewToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
    this.StartNewToolStripMenuItem.Text = "&Start New";
    this.StartNewToolStripMenuItem.Click += new System.EventHandler(this.Buttons_Click);
    // 
    // CloseToolStripMenuItem
    // 
    this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
    this.CloseToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
    this.CloseToolStripMenuItem.Text = "&Close";
    this.CloseToolStripMenuItem.Click += new System.EventHandler(this.Buttons_Click);
    // 
    // InfoToolStripMenuItem
    // 
    this.InfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OverMeToolStripMenuItem,
            this.InfoLittleGameToolStripMenuItem});
    this.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
    this.InfoToolStripMenuItem.Size = new System.Drawing.Size(40, 24);
    this.InfoToolStripMenuItem.Text = "&Info";
    // 
    // OverMeToolStripMenuItem
    // 
    this.OverMeToolStripMenuItem.Name = "OverMeToolStripMenuItem";
    this.OverMeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
    this.OverMeToolStripMenuItem.Text = "&Over Me";
    this.OverMeToolStripMenuItem.Click += new System.EventHandler(this.Buttons_Click);
    // 
    // InfoLittleGameToolStripMenuItem
    // 
    this.InfoLittleGameToolStripMenuItem.Name = "InfoLittleGameToolStripMenuItem";
    this.InfoLittleGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
    this.InfoLittleGameToolStripMenuItem.Text = "Info Little Game";
    this.InfoLittleGameToolStripMenuItem.Click += new System.EventHandler(this.Buttons_Click);
    // 
    // StatusMain
    // 
    this.StatusMain.Dock = System.Windows.Forms.DockStyle.Fill;
    this.StatusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsStatusLabel});
    this.StatusMain.Location = new System.Drawing.Point(0, 433);
    this.StatusMain.Name = "StatusMain";
    this.StatusMain.Size = new System.Drawing.Size(434, 28);
    this.StatusMain.TabIndex = 1;
    this.StatusMain.Text = "statusStrip1";
    // 
    // TsStatusLabel
    // 
    this.TsStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
    this.TsStatusLabel.ForeColor = System.Drawing.Color.Green;
    this.TsStatusLabel.Name = "TsStatusLabel";
    this.TsStatusLabel.Size = new System.Drawing.Size(419, 23);
    this.TsStatusLabel.Spring = true;
    this.TsStatusLabel.Text = "     Welcome - Think of a number between 1 - 63.";
    // 
    // TlpMain
    // 
    this.TlpMain.ColumnCount = 1;
    this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
    this.TlpMain.Controls.Add(this.MenuMain, 0, 0);
    this.TlpMain.Controls.Add(this.StatusMain, 0, 4);
    this.TlpMain.Controls.Add(this.BtClose, 0, 3);
    this.TlpMain.Controls.Add(this.DgvMain, 0, 1);
    this.TlpMain.Controls.Add(this.TlpButtons, 0, 2);
    this.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
    this.TlpMain.Location = new System.Drawing.Point(0, 0);
    this.TlpMain.Name = "TlpMain";
    this.TlpMain.RowCount = 5;
    this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
    this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
    this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
    this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
    this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
    this.TlpMain.Size = new System.Drawing.Size(434, 461);
    this.TlpMain.TabIndex = 0;
    // 
    // BtClose
    // 
    this.BtClose.Dock = System.Windows.Forms.DockStyle.Fill;
    this.BtClose.Location = new System.Drawing.Point(10, 396);
    this.BtClose.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
    this.BtClose.Name = "BtClose";
    this.BtClose.Size = new System.Drawing.Size(414, 34);
    this.BtClose.TabIndex = 10;
    this.BtClose.Text = "Close";
    this.BtClose.UseVisualStyleBackColor = true;
    this.BtClose.Click += new System.EventHandler(this.Buttons_Click);
    // 
    // DgvMain
    // 
    this.DgvMain.AllowUserToAddRows = false;
    this.DgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
    this.DgvMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
    this.DgvMain.BackgroundColor = System.Drawing.Color.White;
    this.DgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.DgvMain.ColumnHeadersVisible = false;
    this.DgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
    this.DgvMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
    this.DgvMain.Location = new System.Drawing.Point(10, 38);
    this.DgvMain.Margin = new System.Windows.Forms.Padding(10);
    this.DgvMain.MultiSelect = false;
    this.DgvMain.Name = "DgvMain";
    this.DgvMain.ReadOnly = true;
    this.DgvMain.RowHeadersVisible = false;
    this.DgvMain.RowTemplate.Height = 25;
    this.DgvMain.Size = new System.Drawing.Size(414, 295);
    this.DgvMain.TabIndex = 100;
    this.DgvMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMain_CellContentClick);
    this.DgvMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMain_CellContentClick);
    // 
    // TlpButtons
    // 
    this.TlpButtons.ColumnCount = 1;
    this.TlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
    this.TlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
    this.TlpButtons.Location = new System.Drawing.Point(3, 346);
    this.TlpButtons.Name = "TlpButtons";
    this.TlpButtons.RowCount = 1;
    this.TlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
    this.TlpButtons.Size = new System.Drawing.Size(428, 44);
    this.TlpButtons.TabIndex = 101;
    // 
    // FrmMain
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.BackColor = System.Drawing.Color.White;
    this.ClientSize = new System.Drawing.Size(434, 461);
    this.Controls.Add(this.TlpMain);
    this.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
    this.MainMenuStrip = this.MenuMain;
    this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
    this.MaximumSize = new System.Drawing.Size(450, 500);
    this.MinimumSize = new System.Drawing.Size(330, 500);
    this.Name = "FrmMain";
    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
    this.Text = "LittleGame - Created by © Michele Natale";
    this.MenuMain.ResumeLayout(false);
    this.MenuMain.PerformLayout();
    this.StatusMain.ResumeLayout(false);
    this.StatusMain.PerformLayout();
    this.TlpMain.ResumeLayout(false);
    this.TlpMain.PerformLayout();
    ((System.ComponentModel.ISupportInitialize)(this.DgvMain)).EndInit();
    this.ResumeLayout(false);

  }

  #endregion

  private Button BtClose;
  private MenuStrip MenuMain;
  private DataGridView DgvMain;
  private StatusStrip StatusMain;
  private TableLayoutPanel TlpMain;
  private TableLayoutPanel TlpButtons;
  private ToolStripStatusLabel TsStatusLabel;
  private ToolStripMenuItem InfoToolStripMenuItem;
  private ToolStripMenuItem fileToolStripMenuItem;
  private ToolStripMenuItem CloseToolStripMenuItem;
  private ToolStripMenuItem OverMeToolStripMenuItem;
  private ToolStripMenuItem StartNewToolStripMenuItem;
  private ToolStripMenuItem InfoLittleGameToolStripMenuItem;
}
