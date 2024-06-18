


//namespace michele.natale.games.sudokus;

//partial class SudokuSolver
//{

//  private static void PrintOut(byte[] bytes)
//  {
//    for (int i = 0; i < 9; i++)
//    {
//      var a = bytes.Skip(i * 9).Take(9);
//      var s = string.Join("", a.Select(x => $" {x} "));
//      Console.WriteLine(s);
//    }
//    Console.WriteLine();
//  }

//  private static void PrintOut(List<List<List<byte>>> bytes, bool zero_is_space = false)
//  {
//    for (int i = 0; i < bytes.Count; i++)
//    {
//      PrintOut(bytes[i], zero_is_space);
//    }
//    Console.WriteLine();
//  }

//  private static void PrintOut(List<List<byte>> bytes, bool zero_is_space = false, bool sudoku_grid = false)
//  {
//    if (!sudoku_grid)
//    {
//      if (!zero_is_space)
//      {
//        for (int i = 0; i < bytes.Count; i++)
//        {
//          Console.WriteLine(string.Join(" ", bytes[i]));
//        }
//        Console.WriteLine();
//        return;
//      }

//      for (var i = 0; i < 9; i++)
//      {
//        for (var j = 0; j < 9; j++)
//          if (bytes[i][j] != 0)
//            Console.Write($"{bytes[i][j]} ");
//          else Console.Write("  ");
//        Console.WriteLine();
//      }
//      Console.WriteLine();

//      return;
//    }

//    if (!zero_is_space)
//    {
//      for (var i = 0; i < 9; i++)
//      {
//        if (i > 0 && i % 3 == 0)
//          Console.WriteLine(new string('-', 21));
//        for (var j = 0; j < 9; j++)
//        {
//          if (j > 1 && j % 3 == 0)
//            Console.Write("| ");
//          Console.Write($"{bytes[i][j]} ");
//        }
//        Console.WriteLine();
//      }
//      Console.WriteLine();
//      return;
//    }

//    for (var i = 0; i < 9; i++)
//    {
//      if (i > 0 && i % 3 == 0)
//        Console.WriteLine(new string('-', 21));
//      for (var j = 0; j < 9; j++)
//      {
//        if (j > 1 && j % 3 == 0)
//          Console.Write("| ");
//        if (bytes[i][j] != 0)
//          Console.Write($"{bytes[i][j]} ");
//        else Console.Write($"  ");
//      }
//      Console.WriteLine();
//    }
//    Console.WriteLine();
//  }

//}



