
using System.Security.Cryptography;

namespace michele.natale.services.Randoms;

internal class RandomHolder
{
  private readonly RandomNumberGenerator Rand;
  public readonly static RandomHolder Instance = new();

  public RandomHolder()
  {
    this.Rand ??= RandomNumberGenerator.Create();
  }

  public byte NextByte()
  {
    return this.RngBytes(1).First();
  }

  public byte NextByte(byte max)
  {
    return this.NextByte(0, max);
  }

  public byte NextByte(byte min, byte max)
  {
    ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(min, max);

    var d = max - min;
    var tmp = this.RngBytes(1).First() % d;
    return (byte)(min + tmp);
  }

  public byte[] RngBytes(int size)
  {
    var bytes = new byte[size];
    this.RngBytes(bytes);
    return bytes;
  }

  public byte[] RngBytes(int size, byte max)
  {
    return this.RngBytes(size, 0, max);
  }

  public byte[] RngBytes(int size, byte min, byte max)
  {
    var bytes = new byte[size];
    this.RngBytes(bytes, min, max);
    return bytes;
  }

  public void RngBytes(byte[] bytes, bool with_zeros = false)
  {
    if (with_zeros) this.Rand.GetBytes(bytes);
    else this.Rand.GetNonZeroBytes(bytes);
  }

  public void RngBytes(byte[] bytes, byte max, bool with_zeros = false)
  {
    this.RngBytes(bytes, 0, max, with_zeros);
  }

  public void RngBytes(byte[] bytes, byte min, byte max, bool with_zeros = false)
  {
    ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(min, max);

    var d = (byte)(max - min);
    var length = bytes.Length;
    if (with_zeros) this.Rand.GetBytes(bytes);
    else this.Rand.GetNonZeroBytes(bytes);
    for (int i = 0; i < length; i++)
      bytes[i] = (byte)(min + bytes[i] % d);
  }

  public int NextInt32()
  {
    return this.RngInt32(1).First();
  }

  public int NextInt32(int max)
  {
    return this.NextInt32(0, max);
  }

  public int NextInt32(int min, int max)
  {
    return this.RngInt32(1, min, max).First();
  }

  public int[] RngInt32(int size)
  {
    var result = new int[size];
    this.RngInt32(result);
    return result;
  }

  public int[] RngInt32(int size, int max)
  {
    return this.RngInt32(size, 0, max);
  }

  public int[] RngInt32(int size, int min, int max)
  {
    var result = new int[size];
    this.RngInt32(result, min, max);
    return result;
  }

  public void RngInt32(int[] ints)
  {
    var type_bits = 4;
    var length = ints.Length;
    var bytes = new byte[type_bits * length];
    this.Rand.GetNonZeroBytes(bytes);
    for (int i = 0; i < length; i++)
      ints[i] = int.Abs(BitConverter.ToInt32(bytes, i * type_bits));
  }

  public void RngInt32(int[] ints, int max)
  {
    this.RngInt32(ints, 0, max);
  }

  public void RngInt32(int[] ints, int min, int max)
  {
    ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(min, max);

    var type_bits = 4;
    var d = min - max;
    var length = ints.Length;
    var bytes = new byte[type_bits * length];
    this.Rand.GetNonZeroBytes(bytes);
    for (int i = 0; i < length; i++)
    {
      var tmp = (int)(BitConverter.ToUInt32(bytes, i * type_bits) % d);
      ints[i] = min + tmp;
    }
  }
}
