

using System.Text;

namespace michele.natale.games.sudokus.services;

partial class SudokuServices
{

  public static void SaveData(ReadOnlySpan<byte> bytes_data, string fileext = "suc")
  {
    Stream mystream;
    {
      using var withBlock = new SaveFileDialog
      {
        Filter = $"{fileext} files (*.{fileext})|*.{fileext}|All files (*.*)|*.*",
        FilterIndex = 2,
        InitialDirectory = Application.StartupPath,
        RestoreDirectory = true
      };
      if (withBlock.ShowDialog() == DialogResult.OK)
      {
        mystream = withBlock.OpenFile();
        if (mystream != null)
        {
          var buffer = bytes_data.ToArray();
          mystream.Write(buffer, 0, buffer.Length);
          mystream.Close();
        }
      }
    }
  }

  public static byte[] LoadData(string fileext = "suc")
  {
    Stream? mystream = null;
    {
      using var withBlock = new OpenFileDialog
      {
        Filter = $"{fileext} files (*.{fileext})|*.{fileext}|All files (*.*)|*.*",
        FilterIndex = 2,
        InitialDirectory = Application.StartupPath,
        RestoreDirectory = true
      };
      try
      {
        if (withBlock.ShowDialog() == DialogResult.OK)
        {
          mystream = withBlock.OpenFile();
          if (mystream != null)
          {
            var len = Convert.ToInt32(mystream.Length);
            var buffer = new byte[len];
            mystream.Read(buffer, 0, buffer.Length);
            return buffer;
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Can not read file: {ex}", "Info OFD System");
      }
      finally
      {
        mystream?.Close();
      }
    }
    return [];
  }
}
