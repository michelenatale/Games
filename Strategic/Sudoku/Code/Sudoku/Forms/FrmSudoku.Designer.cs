
using michele.natale.games.sudokus.apps;

namespace michele.natale.games.sudokus;

partial class FrmSudoku
{
  /// <summary>
  ///  Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  ///  Clean up any resources being used.
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
  ///  Required method for Designer support - do not modify
  ///  the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent()
  {
    this.Uc_Sudoku = new UcSudoku();
    this.SuspendLayout();
    // 
    // Uc_Sudoku
    // 
    this.Uc_Sudoku.BackColor = Color.White;
    this.Uc_Sudoku.Dock = DockStyle.Fill;
    this.Uc_Sudoku.Font = new Font("Arial", 14F);
    this.Uc_Sudoku.Location = new Point(0, 0);
    this.Uc_Sudoku.Margin = new Padding(5, 4, 5, 4);
    this.Uc_Sudoku.Name = "Uc_Sudoku";
    this.Uc_Sudoku.Size = new Size(767, 478);
    this.Uc_Sudoku.TabIndex = 0;
    // 
    // FrmSudoku
    // 
    this.AutoScaleDimensions = new SizeF(13F, 26F);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(767, 478);
    this.Controls.Add(this.Uc_Sudoku);
    this.DoubleBuffered = true;
    this.Font = new Font("Arial", 14F);
    this.Margin = new Padding(5, 4, 5, 4);
    this.MinimumSize = new Size(785, 515);
    this.Name = "FrmSudoku";
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Sudoku - Created by © Michele Natale 2010";
    this.FormClosed += this.FrmSudoku_FormClosed;
    this.Load += this.FrmSudoku_Load;
    this.ResumeLayout(false);
  }

  private UcSudoku Uc_Sudoku = null;

  #endregion
 
}
