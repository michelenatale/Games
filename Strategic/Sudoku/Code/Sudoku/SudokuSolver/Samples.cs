


//namespace michele.natale.games.sudokus;


//using static michele.natale.services.Randoms.RandomHolder;


//partial class SudokuSolver
//{


//  public static List<List<byte>> Sample()
//  {
//    var idx = 0;
//    var d08 = new byte[] { 4, 2, 1, 3, 9, 6, 8, 5, 7 };
//    var d80 = new byte[] { 5, 3, 2, 4, 9, 8, 6, 7, 1 };
//    //Array.Reverse(d80);

//    var bytes = Enumerable.Range(0, SUDOKU_DATA_LENGTH / 9)
//      .Select(x => new byte[9].ToList()).ToList();

//    foreach (var x in d08) bytes[idx][idx++] = x;

//    idx = 8;
//    foreach (var x in d80) bytes[8 - idx][idx--] = x;

//    if (!CheckNumbers(bytes)) throw new Exception();
//    //PrintOut(bytes);

//    var numberofsolution = -1;
//    List<List<List<byte>>> result = [];
//    SolverSudoku(bytes, result, numberofsolution, 1, true);

//    if (!IsFinished(result)) throw new Exception();
//    if (!CheckNumbers(result)) throw new Exception();

//    //Wenn keine der Grids gleich dem anderen ist, 
//    //dann erfüllt der SudokuSolver die Anforderungen.
//    var tf = EqualityAll(result);
//    if (tf) throw new Exception();

//    PrintOut(result);
//    return result.First();
//  }

//  public static void NewSample()
//  {
//    var (dlevel, dllength) = DifficultyLevelLength.RngDifficultyLevelLength();

//    var bytes = Enumerable.Range(1, SUDOKU_GRID_LENGTH)
//        .Select(x => (byte)x).OrderBy(x => Instance.NextInt32()).ToArray();

//    var grid = Enumerable.Range(0, SUDOKU_GRID_LENGTH)
//      .Select(x => new byte[SUDOKU_GRID_LENGTH].ToList()).ToList();

//    for (var i = 0; i < bytes.Length; i++)
//      grid[i][i] = bytes[i];

//    var numberofsolution = 9;
//    List<List<List<byte>>> allresult = [];
//    var solv = SolverSudoku(grid, allresult, numberofsolution);

//    //WICHTIG: Beim direkten Lösen des Sudoku wird ganz am Schluss eine 
//    //         Prüfungen (siehe variable solv) gemacht, ob alles korrekt ist.
//    //Die Prüfungen werden hier nochmals gezeigt.
//    if (!IsFinished(allresult)) throw new Exception();
//    if (!CheckNumbers(allresult)) throw new Exception();

//    //Spezialprüfung: Alle Lösungen werden miteinander vergleichen. 
//    //                Nur wenn alle Lösungen ungleich sind,
//    //                wird ein 'false' zurückgegeben.
//    if (EqualityAll(allresult)) throw new Exception();

//    PrintOut(allresult);

//    var result = allresult.Last();

//    var sgrid = CustomizeGrid(result, dllength);//dllength

//    PrintOut(sgrid);

//    PrintOut(sgrid, true);

//    PrintOut(sgrid, false, true);

//    PrintOut(sgrid, true, true);

//    allresult = [];
//    SolverSudoku(sgrid, allresult, 1);
//    PrintOut(allresult.First(), true, true);
//  }

//  public static void NewSampleXSudoku()
//  {
//    var (dlevel, dllength) = DifficultyLevelLength.RngDifficultyLevelLength();

//    var bytes = Enumerable.Range(1, SUDOKU_GRID_LENGTH)
//        .Select(x => (byte)x).OrderBy(x => Instance.NextInt32()).ToArray();

//    var grid = Enumerable.Range(0, SUDOKU_GRID_LENGTH)
//      .Select(x => new byte[SUDOKU_GRID_LENGTH].ToList()).ToList();

//    for (var i = 0; i < bytes.Length; i++)
//      grid[i][i] = bytes[i];

//    var isxsudoku = true;
//    var numberofsolution = 9;
//    List<List<List<byte>>> allresult = [];
//    var solv = SolverSudoku(grid, allresult, numberofsolution, 1, isxsudoku);

//    //WICHTIG: Beim direkten Lösen des Sudoku wird ganz am Schluss eine 
//    //         Prüfungen (siehe variable solv) gemacht, ob alles korrekt ist.
//    //Die Prüfungen werden hier nochmals gezeigt.
//    if (!IsFinished(allresult)) throw new Exception();
//    if (!CheckNumbers(allresult, isxsudoku)) throw new Exception();

//    //Spezialprüfung: Alle Lösungen werden miteinander vergleichen. 
//    //                Nur wenn alle Lösungen ungleich sind,
//    //                wird ein 'false' zurückgegeben.
//    if (EqualityAll(allresult)) throw new Exception();

//    PrintOut(allresult);

//    var result = allresult.Last();

//    var sgrid = CustomizeGrid(result, 1);//dllength

//    PrintOut(sgrid);

//    PrintOut(sgrid, true);

//    PrintOut(sgrid, false, true);

//    PrintOut(sgrid, true, true);

//    allresult = [];
//    solv = SolverSudoku(sgrid, allresult, 1, 1, isxsudoku);
//    PrintOut(allresult.First(), true, true);
//  }

//}



