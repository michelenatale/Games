


namespace michele.natale.games.sudokus;

public partial class SudokuSolver
{

  private static bool EqualityAll(params List<List<byte>>[] grids)
  {
    return EqualityAll(grids.ToList());
  }

  private static bool EqualityAll(List<List<List<byte>>> grids)
  {
    //Alle Grids müssen ungleich sein. Keiner der 
    //Lösungsvorschläge darf einem anderen gleichen.
    //if (grids.Count == 0) return true;
    if (grids.Count < 2) return false;
    for (var i = 0; i < grids.Count - 1; i++)
      for (var j = i + 1; j < grids.Count; j++)
        if (Equality(grids[i], grids[j]))
          return true;
    return false;
  }

  private static bool Equality(List<List<byte>> left, List<List<byte>> right)
  {
    if (left.Count != right.Count) return false;
    for (int i = 0; i < left.Count; i++)
      if (!left[i].SequenceEqual(right[i]))
        return false;
    return true;
  }
}



