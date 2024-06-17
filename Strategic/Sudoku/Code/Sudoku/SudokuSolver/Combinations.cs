

namespace michele.natale.games.sudokus;

public partial class SudokuSolver
{
  private static List<List<byte>> Combinations(
    List<List<byte>> possibles, ref int idx,
    List<List<byte>>? combis = null,
    List<byte>? numbers = null,
    int level = 1)
  {
    List<byte>? number;
    List<List<byte>> result = [];

    combis ??= [];
    numbers ??= [];

    if (level == 1)
    {
      idx = 0;
      var cnt = 1;
      possibles.ForEach(x => cnt *= x.Count);
      combis = Enumerable.Range(0, cnt).Select(x => new List<byte>()).ToList();
    }

    for (var i = 0; i < possibles[level - 1].Count; i++)
    {
      numbers = numbers.Take(level - 1).ToList();
      number = possibles[level - 1].Skip(i).Take(1).ToList();

      if (!ContainsSubsequence(numbers, number))
      {
        numbers.AddRange(number);
        if (level == 9)
          combis[idx++] = numbers;
        else Combinations(possibles, ref idx, combis, numbers, level + 1);
      }
    }

    if (level == 1)
      result = combis.Take(idx).ToList();

    return result;

  }
}



