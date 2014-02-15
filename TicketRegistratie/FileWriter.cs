using System;
using System.IO;

namespace TicketRegistratie
{
  public static class FileWriter
  {
    private static readonly appsettings AppSettings;

    static FileWriter()
    {
      AppSettings = new appsettings();
    }
    public static void WriteToFile(Probleem probleem)
    {
      var path = Path.Combine(AppSettings.OutputPath, AppSettings.FileName);
      if (!File.Exists(path))
      {
        File.Create(path);
      }
      using (var streamWriter = File.AppendText(path))
      {
        streamWriter.WriteLine("--------------------------------------------------------------------");
        streamWriter.WriteLine("Tijd/Datum  : {0}", DateTime.Now);
        streamWriter.WriteLine("Probleem    : {0}", probleem.Issue);
        streamWriter.WriteLine("Filiaal     : {0}", probleem.Filiaal);
        streamWriter.WriteLine("Ticketnummer: {0}", probleem.Ticketnummer);
        streamWriter.WriteLine("Oplossing   : {0}", probleem.Oplossing);
        streamWriter.WriteLine("--------------------------------------------------------------------");
        streamWriter.WriteLine();
      }
    }
  }
}
