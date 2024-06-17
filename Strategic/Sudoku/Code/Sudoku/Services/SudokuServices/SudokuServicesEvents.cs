
using System.Diagnostics;

namespace michele.natale.games.sudokus.services;

partial class SudokuServices
{

  public static void OpenUrl(string url_address)
  {
    try
    {
      VisitLink(url_address);
    }
    catch (Exception ex)
    {
      MessageBox.Show("Unable to open link that was clicked.\n" + ex.Message);
    }
  }

  private static void VisitLink(string url_address)
  {
    Process.Start(new ProcessStartInfo
    {
      FileName = url_address,
      UseShellExecute = true
    });
  }
}
