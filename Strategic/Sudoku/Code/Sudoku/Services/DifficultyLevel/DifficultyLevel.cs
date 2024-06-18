


namespace michele.natale.games.sudokus;

using static michele.natale.services.Randoms.RandomHolder;

public enum DifficultyLevel : uint
{
  None = 0,
  Easy,
  Medium,
  Difficult,
  Expert,
  Master,
  Extreme,
  Random,
}


internal abstract class DifficultyLevelLength
{

  public static DifficultyLevel RngDifficultyLevel()
  {
    var dls = (DifficultyLevel[])Enum.GetValues(typeof(DifficultyLevel));
    return dls[Instance.NextInt32(1, dls.Length - 1)];
  }

  public static (DifficultyLevel DLevel, int Length) RngDifficultyLevelLength()
  {
    var dlevel = RngDifficultyLevel();
    var dllen = ToDifficultyLevelLength(dlevel);
    return (dlevel, dllen);
  }

  public static int ToDifficultyLevelLength(DifficultyLevel dlevel)
  {
    return dlevel switch
    {
      DifficultyLevel.Easy => Instance.NextInt32(39, 44),
      DifficultyLevel.Medium => Instance.NextInt32(35, 39),
      DifficultyLevel.Difficult => Instance.NextInt32(31, 35),
      DifficultyLevel.Expert => Instance.NextInt32(27, 31),
      DifficultyLevel.Master => Instance.NextInt32(23, 27),
      DifficultyLevel.Extreme => Instance.NextInt32(18, 23),
      _ => throw new ArgumentException($"{nameof(dlevel)} is failed"),
    };
  }
}
