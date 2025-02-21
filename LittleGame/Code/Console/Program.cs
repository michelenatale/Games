


using System.Text;

namespace michele.natale.Games;

using static LittleGame;

public class Program
{

  public static void Main()
  {
    Console.WriteLine("A little game, if you please.");
    Console.WriteLine("*****************************\n");
    Console.WriteLine("Created by © Michele Natale\n\n");
    Start();

    while (true)
    {
      var sum = 0;
      var index = 0;
      var data = Data;
      while (index < 6)
      {
        PrintOut(data, index);
        Console.Write($"Is the number in this table? >> ");

        (bool exit, int s) = GiveAnswer(data, index);
        if (exit) return;

        sum += s;
        Console.WriteLine();
        index++;
      }
      Console.WriteLine($"\nYour Number is {sum}\n");
      Console.Write("Another round? >> ");
      if (GiveAnswer()) return;
      Console.WriteLine("\n");
      Console.WriteLine("\n");
    }
  }

  private static bool GiveAnswer()
  {
    while (true)
    {
      string result;
      result = Console.ReadLine()!;
      if (result!.Trim().ToLower() == "n") return true;
      if (result!.Trim().ToLower() == "exit") return true;
      if (result!.Trim().ToLower() == "y") return false;
    }
  }

  private static (bool Exit, int sum) GiveAnswer(int[][] data, int index)
  {
    var sum = 0;
    string result;
    while (true)
    {
      result = Console.ReadLine()!;
      if (result!.Trim().ToLower() == "n") break;
      if (result == string.Empty) continue;
      if (result == "exit") return (true, 0);
      if (result!.Trim().ToLower() == "y")
      { sum += data[index].Min(); break; }
    }
    return (false, sum);
  }

  private static void PrintOut(int[][] data, int index)
  {
    var sb = new StringBuilder();
    for (var i = 0; i < 4; i++)
    {
      var nums = data[index].Skip(i * 8).Take(8).ToArray();
      foreach (var num in nums)
        sb.Append(num.ToString().PadLeft(3));
      sb.AppendLine();
    }
    Console.WriteLine(sb.ToString());
  }
}