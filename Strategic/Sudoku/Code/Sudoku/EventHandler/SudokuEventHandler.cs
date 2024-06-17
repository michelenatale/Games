

namespace michele.natale.games.sudokus.Handlers;


internal class SudokuEventArgs : EventArgs
{ 
  public bool NewGame { get; set; } = false;
  public bool XSudoku { get; set; } = false;
  public int NumberOfSolution { get; set; } = 10;
  public List<List<List<byte>>> SudokuDatas { get; set; } = [];
  public DifficultyLevel DifficultyLevel { get; set; }=DifficultyLevel.None;
}



//internal class LittleGameEventArgs : EventArgs
//{
//  public int Sum
//  {
//    get; set;
//  }
//  public int Index
//  {
//    get; set;
//  }
//  public bool Answer
//  {
//    get; set;
//  }
//  public bool NewGame
//  {
//    get; set;
//  }
//  public string[][]? Data
//  {
//    get; set;
//  }
//}