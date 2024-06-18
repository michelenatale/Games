


namespace michele.natale.games.sudokus.apps;


internal class SaveDataInfo
{
  public List<List<List<byte>>> OrgDatas
  {
    get; set;
  } = [];
  public List<List<byte>> Datas
  {
    get; set;
  } = [];

  public DifficultyLevel DifficultyLevel
  {
    get; set;
  } = DifficultyLevel.None;

  public bool IsXSudoku
  {
    get; set;
  } = false;
}
