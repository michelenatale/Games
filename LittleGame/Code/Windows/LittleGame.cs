

namespace michele.natale.Games;

internal partial class LittleGame: LittleGameBase
{

  public LittleGame():base()
  { 
  }

  public void Start(FrmMain? frmmain)
  { 
    using var frm = frmmain;
    frm!.LittleGameHandler += App_LittleGame!;
    frm!.ShowDialog();

    frm!.LittleGameHandler -= App_LittleGame!;

    this.Clear();
  }
}