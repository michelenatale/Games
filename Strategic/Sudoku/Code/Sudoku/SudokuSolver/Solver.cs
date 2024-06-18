


namespace michele.natale.games.sudokus;


using static michele.natale.services.Randoms.RandomHolder;

partial class SudokuSolver
{
  public static bool SolverSudoku(
    List<List<byte>> bytes,
    List<List<List<byte>>> result,
    int numberofsolution = 1,
    int level = 1, bool xsudoku = false)
  {
    if (!CheckNumbers(bytes, out var xy, xsudoku)) return false;
    var count = HowManyNumbersAreSet(bytes);
    if (count <= 10) SolverSudokuInit(bytes);

    Solver_Sudoku(bytes, result, numberofsolution, level, xsudoku);
    return IsFinished(result) && CheckNumbers(result, out xy, xsudoku);
  }

  private static void Solver_Sudoku(
    List<List<byte>> bytes,
    List<List<List<byte>>> result,
    int numberofsolution = 1,
    int level = 1, bool xsudoku = false)
  {

    numberofsolution = numberofsolution == 0 ? DEFAULT_NUMBER_OF_SOLUTION : numberofsolution;
    numberofsolution = numberofsolution < 0 ? MAX_NUMBER_OF_SOLUTION : numberofsolution;
    if (result.Count >= numberofsolution) return;

    var dia08list = new List<byte>();
    var dia80list = new List<byte>();
    var rowlist = Enumerable.Range(0, 9).Select(x => new List<byte>()).ToList();
    var collist = Enumerable.Range(0, 9).Select(x => new List<byte>()).ToList();
    var b3x3list = Enumerable.Range(0, 9).Select(x => new List<byte>()).ToList();

    FindPossibleNumbers(bytes, dia08list, dia80list, rowlist, collist, b3x3list, xsudoku);
    SetPossibleNumbers(bytes, dia08list, dia80list, rowlist, collist, b3x3list, xsudoku);
    var rowidx = FindIndexLongestRow(rowlist);

    if (rowidx == -1)
    {
      result.Add(bytes.Select(x => x.ToList()).ToList());//copy
    }
    else
    {
      var idx = 0;

      var possibles = ToPossibleNumbers(
        bytes, dia08list, dia80list, rowlist, collist, b3x3list, rowidx, xsudoku);
      if (possibles is null) return;

      var rowscombis = Combinations(possibles, ref idx);

      for (var i = 0; i < rowscombis.Count; i++)
      {
        var copybytes = bytes.Select(x => x.ToList()).ToList();
        for (var j = 0; j < 9; j++) copybytes[rowidx][j] = rowscombis[i][j];
        switch (level)
        {
          case 9:
            {
              result.Add(copybytes.Select(x => x.ToList()).ToList());
              if (result.Count >= numberofsolution) return;
              break;
            }
          default:
            {
              Solver_Sudoku(copybytes, result, numberofsolution, level + 1, xsudoku);
              if (result.Count >= numberofsolution) return;
              break;
            }
        }
      }
    }

    if (level == 1) return;
  }

  private static void FindPossibleNumbers(
    List<List<byte>> bytes,
    List<byte> dia08list,
    List<byte> dia80list,
    List<List<byte>> rowlist,
    List<List<byte>> collist,
    List<List<byte>> b3x3list,
    bool xsudoku)
  {
    for (var r = 0; r < 9; r++)
    {
      for (var c = 0; c < 9; c++)
      {
        if (bytes[r][c] > 0)
        {
          var idx = r / 3 * 3 + c / 3;
          rowlist[r].Add(bytes[r][c]);
          collist[c].Add(bytes[r][c]);
          b3x3list[idx].Add(bytes[r][c]);
          if (xsudoku && r == c) dia08list.Add(bytes[r][c]);
          if (xsudoku && r + c == 8) dia80list.Add(bytes[r][c]);
        }
      }
    }
  }

  private static void SetPossibleNumbers(
    List<List<byte>> bytes,
    List<byte> dia08list,
    List<byte> dia80list,
    List<List<byte>> rowlist,
    List<List<byte>> collist,
    List<List<byte>> b3x3list,
    bool xsudoku)
  {
    var found = true;
    var tmp = (byte)0;
    while (found)
    {
      found = false;
      for (var r = 0; r < 9; r++)
      {
        for (int c = 0, cnt = 0; c < 9; c++)
        {
          if (bytes[r][c] == 0)
          {
            cnt = 0; tmp = 0;
            var idx = r / 3 * 3 + c / 3;
            var concats = rowlist[r].Concat(collist[c]).Concat(b3x3list[idx]);

            if (xsudoku && r == c) concats = concats.Concat(dia08list);
            if (xsudoku && r + c == 8) concats = concats.Concat(dia80list);

            concats = concats.Distinct().OrderBy(x => x);

            for (var i = (byte)1; i < 10; i++)
              if (!concats.Contains(i)) { tmp = i; cnt++; }

            if (cnt == 1)
            {
              if (!rowlist[r].Contains(tmp)) rowlist[r].Add(tmp);
              if (!collist[c].Contains(tmp)) collist[c].Add(tmp);
              if (!b3x3list[idx].Contains(tmp)) b3x3list[idx].Add(tmp);
              if (xsudoku && r == c && !dia08list.Contains(tmp)) dia08list.Add(tmp);
              if (xsudoku && r + c == 8 && !dia80list.Contains(tmp)) dia80list.Add(tmp);
              bytes[r][c] = tmp;
              found = true;
            }
          }
        }
      }
    }
  }

  private static List<List<byte>>? ToPossibleNumbers(
    List<List<byte>> bytes,
    List<byte> dia08list,
    List<byte> dia80list,
    List<List<byte>> rowlist,
    List<List<byte>> collist,
    List<List<byte>> b3x3list,
    int rowlen,
    bool xsudoku)
  {
    var x = -1;
    var r = rowlen;
    var result = Enumerable.Range(0, 9).Select(x => new List<byte>()).ToList();
    for (var c = 0; c < 9; c++)
    {
      x += 1;
      if (bytes[r][c] == 0)
      {
        var idx = r / 3 * 3 + c / 3;
        var concats = rowlist[r].Concat(collist[c]).Concat(b3x3list[idx]);
        concats = concats.Distinct().OrderBy(x => x);

        if (xsudoku && r == c) concats = concats.Concat(dia08list);
        if (xsudoku && r + c == 8) concats = concats.Concat(dia80list);

        for (var i = (byte)1; i < 10; i++)
          if (!concats.Contains(i))
            result[x].Add(i);
        if (result[x].Count == 0) return null;
      }
      else result[x] = [bytes[r][c]];
    }
    return result;
  }

  private static int FindIndexLongestRow(
    List<List<byte>> rowlist)
  {
    var count = -1;
    var result = -1;
    for (var i = 0; i < 9; i++)
    { 
      var len = rowlist[i].Count;
      if (len < 9 && len > count)
      {
        count = rowlist[i].Count;
        result = i;
      } 
    }
    return result;
  }

  private static void SolverSudokuInit(List<List<byte>> grid)
  {
    //Increases the calculation speed

    List<List<byte>> copy;

    var count = HowManyNumbersAreSet(grid);
    if (count > 10) return;

    if (count > 0 && !CheckNumbers(grid, out var xyz)) return;

    if (!CheckDia08(grid))
    {
      do
      {
        copy = grid.Select(x => x.ToList()).ToList();
        var bytes = Enumerable.Range(1, SUDOKU_GRID_LENGTH)
            .Select(x => (byte)x).OrderBy(x => Instance.NextInt32()).ToArray();

        for (var i = 0; i < bytes.Length; i++)
          copy[i][i] = bytes[i];
      } while (!CheckNumbers(copy, out xyz));

      Copy(grid, copy);
      return;
    }

    var tf = !CheckDia08(grid, out var xy);

    if (xy.Length == 9 && CheckNumbers(grid, out xyz)) return;

    do
    {
      copy = grid.Select(x => x.ToList()).ToList();
      var bytes = Enumerable.Range(1, SUDOKU_GRID_LENGTH - count)
          .Select(x => (byte)x).OrderBy(x => Instance.NextInt32()).ToArray();

      for (var i = 0; i < bytes.Length; i++)
      {
        var x = Instance.NextInt32(SUDOKU_GRID_LENGTH);
        var y = Instance.NextInt32(SUDOKU_GRID_LENGTH);
        if (copy[y][x] > 0) { i -= 1; continue; }
        copy[y][x] = bytes[i];
      }
    } while (!CheckNumbers(copy, out xyz));

    Copy(grid, copy);
  }
}



