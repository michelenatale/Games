

namespace michele.natale.Games;

using static RandomHoder;

public class LittleGame
{
  private static bool First = false;
  private static int[][] MData = Array.Empty<int[]>();

  public static int[][] Data
  {
    get
    {
      if (!First) { WarmUp(); First = true; }
      return MData = CopyMixData(MData);
    }
  }

  public static void Start()
  {
    var result = CreateDatas().OrderBy(x => Rand.Next()).ToArray();
    for (var i = 0; i < result.Length; i++)
      if ((Rand.Next() & 1) == 0)
        Array.Reverse(result[i]);
    MData = result;
  }

  private static int[][] CreateDatas()
  {
    var result = Enumerable.Range(0, 6).Select(x => new int[32]).ToArray();
    for (int row = 0, value = 1 << row; row < result.Length; row++, value = 1 << row)
      for (int col = 0, distance = value; col < result[row].Length; value += distance)
        for (var i = 0; i < distance; i++)
          result[row][col++] = value++;
    return result;
  }

  private static int[][] CopyMixData(int[][] data) =>
    MixData(CopyData(data));

  private static int[][] MixData(int[][] data)
  {
    var result = data.OrderBy(x => Rand.Next()).ToArray();
    for (var i = 0; i < result.Length; i++)
      if ((Rand.Next() & 1) == 0)
        Array.Reverse(result[i]);
    return result;
  }

  private static int[][] CopyData(int[][] data)
  {
    var result = Enumerable.Range(0, 6).Select(x => new int[32]).ToArray();
    for (int row = 0; row < result.Length; row++)
      for (int col = 0; col < result[row].Length; col++)
        result[row][col] = data[row][col];
    return result;
  }
}


public class RandomHoder
{
  public static readonly Random Rand = new();

  public static void WarmUp()
  {
    var cnt = Rand.Next() % 1000 + 1234;
    for (var i = 0; i < cnt; i++) Rand.Next();
  }
}
