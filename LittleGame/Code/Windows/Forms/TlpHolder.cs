

namespace michele.natale.Games;

partial class FrmMain
{
  private class TlpHolder : IDisposable
  {
    public bool IsDisposed { get; private set; }
    internal Button BtNo { get; private set; }
    internal Button BtYes { get; private set; }
    internal Button BtStart { get; private set; }
    internal TableLayoutPanel[] CacheTlp { get; private set; } = Array.Empty<TableLayoutPanel>();

    public TlpHolder()
    {
      (Button btno, Button btyes, Button btstart) = CreateNewButtons();
      this.BtNo = btno;
      this.BtYes = btyes;
      this.BtStart = btstart;
      this.CacheTlp = this.NewTlpButtons();
    }

    private static (Button BtNo, Button BtYes, Button BtStart) CreateNewButtons()
    {
      return
        (CreateNewButton("BtNo", "No", 5),
         CreateNewButton("BtYes", "Yes", 4),
         CreateNewButton("BtStart", "Start", 0));
    }

    private static Button CreateNewButton(string name, string text, int tabindex) =>
      new()
      {
        Anchor = AnchorStyles.None,
        Location = new Point(3, 10),
        Name = name,
        Size = new Size(50, 34),
        TabIndex = tabindex,
        Text = text,
        UseVisualStyleBackColor = true,
        Dock = DockStyle.Fill
      };

    private TableLayoutPanel[] NewTlpButtons() =>
      new[]
      {
         NewTlpButtons(1,new[]{ 100f},1,new[]{ 100f},new[]{this.BtStart },"TlpButtonsStart",1),
         NewTlpButtons(1,new[]{ 100f},2,new[]{ 50f,50f},new[]{this.BtYes,this.BtNo, },"TlpButtonsYesNo",1),
      };

    private static TableLayoutPanel NewTlpButtons(
      int rowcnt, float[] rowpercent,
      int columncnt, float[] columnpercent,
      Button[] buttons, string name, int tabindex)
    {
      var tlp = new TableLayoutPanel { ColumnCount = columncnt };

      foreach (var prc in columnpercent)
        tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, prc));

      for (var i = 0; i < buttons.Length; i++)
        tlp.Controls.Add(buttons[i], i, 0);

      tlp.Dock = DockStyle.Fill;
      tlp.Location = new Point(8, 8);
      tlp.Margin = new Padding(8, 3, 8, 3);
      tlp.Name = name; tlp.RowCount = rowcnt;

      foreach (var prc in rowpercent)
        tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, prc));

      tlp.Size = new Size(290, 42);
      tlp.TabIndex = tabindex;
      return tlp;
    }

    private void Dispose(bool disposing)
    {
      if (!this.IsDisposed)
      {
        if (disposing)
        {
          this.BtNo?.Dispose();
          this.BtYes?.Dispose();
          this.BtStart?.Dispose();
          if (this.CacheTlp is not null)
            for (var i = 0; i < this.CacheTlp.Length; i++)
              this.CacheTlp[i]?.Dispose();
        }
        this.IsDisposed = true;
      }
    }

    ~TlpHolder() => this.Dispose(false);

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize(this);
    }
  }
}
