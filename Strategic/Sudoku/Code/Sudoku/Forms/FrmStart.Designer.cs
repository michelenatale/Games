
namespace michele.natale.games.sudokus.apps;

partial class FrmStart
{
  /// <summary>
  /// Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  /// Clean up any resources being used.
  /// </summary>
  /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
  protected override void Dispose(bool disposing)
  {
    if (disposing && (components != null))
    {
      components.Dispose();
    }
    base.Dispose(disposing);
  }

  #region Windows Form Designer generated code

  /// <summary>
  /// Required method for Designer support - do not modify
  /// the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent()
  {
    this.TlpStartMain = new TableLayoutPanel();
    this.TlpStartMainMiddle = new TableLayoutPanel();
    this.BtEasy = new Button();
    this.BtMedium = new Button();
    this.BtDificult = new Button();
    this.BtExpert = new Button();
    this.BtMaster = new Button();
    this.BtExtreme = new Button();
    this.BtRngDifficultyLevel = new Button();
    this.PlStartMainTop = new Panel();
    this.TlpStartMainBottom = new TableLayoutPanel();
    this.LlMnHomepage = new LinkLabel();
    this.TlpStartMain.SuspendLayout();
    this.TlpStartMainMiddle.SuspendLayout();
    this.TlpStartMainBottom.SuspendLayout();
    this.SuspendLayout();
    // 
    // TlpStartMain
    // 
    this.TlpStartMain.BackColor = Color.Transparent;
    this.TlpStartMain.ColumnCount = 1;
    this.TlpStartMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
    this.TlpStartMain.Controls.Add(this.TlpStartMainMiddle, 0, 1);
    this.TlpStartMain.Controls.Add(this.PlStartMainTop, 0, 0);
    this.TlpStartMain.Controls.Add(this.TlpStartMainBottom, 0, 2);
    this.TlpStartMain.Dock = DockStyle.Fill;
    this.TlpStartMain.Location = new Point(0, 0);
    this.TlpStartMain.Name = "TlpStartMain";
    this.TlpStartMain.RowCount = 3;
    this.TlpStartMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 160F));
    this.TlpStartMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
    this.TlpStartMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
    this.TlpStartMain.Size = new Size(692, 473);
    this.TlpStartMain.TabIndex = 100;
    // 
    // TlpStartMainMiddle
    // 
    this.TlpStartMainMiddle.ColumnCount = 4;
    this.TlpStartMainMiddle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
    this.TlpStartMainMiddle.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
    this.TlpStartMainMiddle.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
    this.TlpStartMainMiddle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
    this.TlpStartMainMiddle.Controls.Add(this.BtEasy, 1, 1);
    this.TlpStartMainMiddle.Controls.Add(this.BtMedium, 2, 1);
    this.TlpStartMainMiddle.Controls.Add(this.BtDificult, 1, 2);
    this.TlpStartMainMiddle.Controls.Add(this.BtExpert, 2, 2);
    this.TlpStartMainMiddle.Controls.Add(this.BtMaster, 1, 3);
    this.TlpStartMainMiddle.Controls.Add(this.BtExtreme, 2, 3);
    this.TlpStartMainMiddle.Controls.Add(this.BtRngDifficultyLevel, 1, 4);
    this.TlpStartMainMiddle.Dock = DockStyle.Fill;
    this.TlpStartMainMiddle.Location = new Point(3, 163);
    this.TlpStartMainMiddle.Name = "TlpStartMainMiddle";
    this.TlpStartMainMiddle.RowCount = 6;
    this.TlpStartMainMiddle.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
    this.TlpStartMainMiddle.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
    this.TlpStartMainMiddle.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
    this.TlpStartMainMiddle.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
    this.TlpStartMainMiddle.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
    this.TlpStartMainMiddle.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
    this.TlpStartMainMiddle.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
    this.TlpStartMainMiddle.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
    this.TlpStartMainMiddle.Size = new Size(686, 227);
    this.TlpStartMainMiddle.TabIndex = 101;
    // 
    // BtEasy
    // 
    this.BtEasy.Anchor = AnchorStyles.None;
    this.BtEasy.Location = new Point(63, 17);
    this.BtEasy.Name = "BtEasy";
    this.BtEasy.Size = new Size(260, 42);
    this.BtEasy.TabIndex = 1;
    this.BtEasy.Text = "Easy";
    this.BtEasy.UseVisualStyleBackColor = true;
    this.BtEasy.Click += this.FrmStart_Click;
    // 
    // BtMedium
    // 
    this.BtMedium.Anchor = AnchorStyles.None;
    this.BtMedium.BackColor = Color.Transparent;
    this.BtMedium.Location = new Point(363, 17);
    this.BtMedium.Name = "BtMedium";
    this.BtMedium.Size = new Size(260, 42);
    this.BtMedium.TabIndex = 2;
    this.BtMedium.Text = "Medium";
    this.BtMedium.UseVisualStyleBackColor = false;
    this.BtMedium.Click += this.FrmStart_Click;
    // 
    // BtDificult
    // 
    this.BtDificult.Anchor = AnchorStyles.None;
    this.BtDificult.Location = new Point(63, 67);
    this.BtDificult.Name = "BtDificult";
    this.BtDificult.Size = new Size(260, 42);
    this.BtDificult.TabIndex = 3;
    this.BtDificult.Text = "Difficult";
    this.BtDificult.UseVisualStyleBackColor = true;
    this.BtDificult.Click += this.FrmStart_Click;
    // 
    // BtExpert
    // 
    this.BtExpert.Anchor = AnchorStyles.None;
    this.BtExpert.Location = new Point(363, 67);
    this.BtExpert.Name = "BtExpert";
    this.BtExpert.Size = new Size(260, 42);
    this.BtExpert.TabIndex = 4;
    this.BtExpert.Text = "Expert";
    this.BtExpert.UseVisualStyleBackColor = true;
    this.BtExpert.Click += this.FrmStart_Click;
    // 
    // BtMaster
    // 
    this.BtMaster.Anchor = AnchorStyles.None;
    this.BtMaster.Location = new Point(63, 117);
    this.BtMaster.Name = "BtMaster";
    this.BtMaster.Size = new Size(260, 42);
    this.BtMaster.TabIndex = 5;
    this.BtMaster.Text = "Master";
    this.BtMaster.UseVisualStyleBackColor = true;
    this.BtMaster.Click += this.FrmStart_Click;
    // 
    // BtExtreme
    // 
    this.BtExtreme.Anchor = AnchorStyles.None;
    this.BtExtreme.Location = new Point(363, 117);
    this.BtExtreme.Name = "BtExtreme";
    this.BtExtreme.Size = new Size(260, 42);
    this.BtExtreme.TabIndex = 6;
    this.BtExtreme.Text = "Extreme";
    this.BtExtreme.UseVisualStyleBackColor = true;
    this.BtExtreme.Click += this.FrmStart_Click;
    // 
    // BtRngDifficultyLevel
    // 
    this.BtRngDifficultyLevel.Anchor = AnchorStyles.None;
    this.TlpStartMainMiddle.SetColumnSpan(this.BtRngDifficultyLevel, 2);
    this.BtRngDifficultyLevel.Location = new Point(62, 167);
    this.BtRngDifficultyLevel.Name = "BtRngDifficultyLevel";
    this.BtRngDifficultyLevel.Size = new Size(562, 42);
    this.BtRngDifficultyLevel.TabIndex = 7;
    this.BtRngDifficultyLevel.Text = "Random Difficulty Level";
    this.BtRngDifficultyLevel.UseVisualStyleBackColor = true;
    this.BtRngDifficultyLevel.Click += this.FrmStart_Click;
    // 
    // PlStartMainTop
    // 
    this.PlStartMainTop.BackgroundImage = Sudoku.Properties.Resources.myLogo;
    this.PlStartMainTop.BackgroundImageLayout = ImageLayout.Center;
    this.PlStartMainTop.Dock = DockStyle.Fill;
    this.PlStartMainTop.Location = new Point(3, 3);
    this.PlStartMainTop.Name = "PlStartMainTop";
    this.PlStartMainTop.Size = new Size(686, 154);
    this.PlStartMainTop.TabIndex = 0;
    this.PlStartMainTop.Click += this.FrmStart_Click;
    // 
    // TlpStartMainBottom
    // 
    this.TlpStartMainBottom.ColumnCount = 3;
    this.TlpStartMainBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
    this.TlpStartMainBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
    this.TlpStartMainBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
    this.TlpStartMainBottom.Controls.Add(this.LlMnHomepage, 1, 1);
    this.TlpStartMainBottom.Dock = DockStyle.Fill;
    this.TlpStartMainBottom.Location = new Point(3, 396);
    this.TlpStartMainBottom.Name = "TlpStartMainBottom";
    this.TlpStartMainBottom.RowCount = 3;
    this.TlpStartMainBottom.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
    this.TlpStartMainBottom.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
    this.TlpStartMainBottom.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
    this.TlpStartMainBottom.Size = new Size(686, 74);
    this.TlpStartMainBottom.TabIndex = 102;
    // 
    // LlMnHomepage
    // 
    this.LlMnHomepage.Anchor = AnchorStyles.None;
    this.LlMnHomepage.AutoSize = true;
    this.LlMnHomepage.Font = new Font("Arial", 14F);
    this.LlMnHomepage.LinkBehavior = LinkBehavior.NeverUnderline;
    this.LlMnHomepage.LinkColor = Color.Navy;
    this.LlMnHomepage.Location = new Point(214, 23);
    this.LlMnHomepage.Name = "LlMnHomepage";
    this.LlMnHomepage.Size = new Size(258, 27);
    this.LlMnHomepage.TabIndex = 8;
    this.LlMnHomepage.TabStop = true;
    this.LlMnHomepage.Text = "michele natale - github";
    this.LlMnHomepage.LinkClicked += this.LlMnHomepage_LinkClicked;
    this.LlMnHomepage.MouseEnter += this.LlMnHomepage_MouseEnter;
    this.LlMnHomepage.MouseLeave += this.LlMnHomepage_MouseLeave;
    // 
    // FrmStart
    // 
    this.AutoScaleDimensions = new SizeF(13F, 26F);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(692, 473);
    this.Controls.Add(this.TlpStartMain);
    this.Font = new Font("Arial", 14F);
    this.Margin = new Padding(5, 4, 5, 4);
    this.MinimumSize = new Size(650, 515);
    this.Name = "FrmStart";
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Sudoku - Created by © Michele Natale 2024";
    this.TlpStartMain.ResumeLayout(false);
    this.TlpStartMainMiddle.ResumeLayout(false);
    this.TlpStartMainBottom.ResumeLayout(false);
    this.TlpStartMainBottom.PerformLayout();
    this.ResumeLayout(false);
  }

  #endregion

  private TableLayoutPanel TlpStartMain;
  private Panel PlStartMainTop;
  private TableLayoutPanel TlpStartMainMiddle;
  private Button BtEasy;
  private Button BtMedium;
  private Button BtDificult;
  private Button BtExpert;
  private Button BtMaster;
  private Button BtExtreme;
  private TableLayoutPanel TlpStartMainBottom;
  private LinkLabel LlMnHomepage;
  private Button BtRngDifficultyLevel;
}