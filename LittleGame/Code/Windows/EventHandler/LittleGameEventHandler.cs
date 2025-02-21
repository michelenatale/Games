

namespace michele.natale.Games;

internal class LittleGameEventArgs : EventArgs
{
  public int Sum { get; set; }
  public int Index { get; set; }
  public bool Answer { get; set; }
  public bool NewGame { get; set; }
  public string[][]? Data { get; set; }
}
