
namespace michele.natale.Games;

partial class LittleGame
{

  private int Sum = 0, Index = 0;
  private List<int[]> Datas = Array.Empty<int[]>().ToList();

  private void App_LittleGame(object sender, LittleGameEventArgs e)
  {
    if (e.NewGame)
    {
      this.Sum = 0;
      this.Index = 0;
      this.Datas = Input.ToList();
    }
    else if (e.Answer)
    {
      this.Sum += this.Datas[this.Index - 1].Min();
    }

    if (this.Index < 6)
      e.Data = ToTable();

    e.Sum = this.Sum;
    e.Index = this.Index++;
  }

  private string[][] ToTable()
  {
    var data = this.Datas[this.Index];
    var result = Enumerable.Range(0, 4).Select(x => new string[8]).ToList();
    for (var i = 0; i < 4; i++)
      for (var j = 0; j < 8; j++)
        result[i][j] = this.Datas[this.Index][i * 8 + j].ToString();
    return result.ToArray();
  }

  private void Clear()
  {
    this.Sum = -1;
    this.First = false;
    this.Index = -1;
    this.Datas?.Clear();
    this.Datas = Array.Empty<int[]>().ToList();
    this.Input = Array.Empty<int[]>();
  }


}