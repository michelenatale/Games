

namespace michele.natale.Games;

using static michele.natale.Randoms.RandomHoder;

internal abstract class LittleGameBase
{
  internal  bool First = false;
  private  int[][] MInput = Array.Empty<int[]>();

  internal int[][] Input
  {
    get
    {
      if (!First) { WarmUp(); this.First = true; }
      return this.MInput = CopyMixInput(this.MInput);
    }
    set => this.MInput = value;
  }

  public LittleGameBase() =>
    this.MInput = MixInput(CreateInput());

  private static int[][] CreateInput()
  {
    var result = Enumerable.Range(0, 6).Select(x => new int[32]).ToArray();
    for (int row = 0, value = 1 << row; row < result.Length; row++, value = 1 << row)
      for (int col = 0, distance = value; col < result[row].Length; value += distance)
        for (var i = 0; i < distance; i++)
          result[row][col++] = value++;
    return result;
  }

  private static int[][] CopyMixInput(int[][] input) =>
    MixInput(CopyInput(input));

  private static int[][] MixInput(int[][] input)
  {
    var result = input.OrderBy(x => Rand.Next()).ToArray();
    for (var i = 0; i < result.Length; i++)
      if ((Rand.Next() & 1) == 0)
        Array.Reverse(result[i]);
    return result;
  }

  private static int[][] CopyInput(int[][] input)
  {
    int rlength = input.Length, clength = input[0].Length;
    var result = Enumerable.Range(0, rlength).Select(x => new int[clength]).ToArray();
    for (int row = 0; row < rlength; row++)
      for (int col = 0; col < clength; col++)
        result[row][col] = input[row][col];
    return result;
  }
}
