

namespace michele.natale.Randoms;

public class RandomHoder
{
  public static readonly Random Rand = new();

  public static void WarmUp()
  {
    var cnt = Rand.Next() % 1000 + 1234;
    for (var i = 0; i < cnt; i++) Rand.Next();
  }
}
