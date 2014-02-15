using System;

namespace TicketRegistratie
{
  class Program
  {
    private static bool problemen = true;

    static void Main(string[] args)
    {
      while (problemen)
      {
        Console.WriteLine("Is er een probleem?: Y/N");
        problemen = isErEenProbleem(Console.ReadLine());
        if (problemen)
        {
          ProbleemBuilder();
        }
      }
    }

    private static bool isErEenProbleem(string _input)
    {
      switch (_input.ToLower())
      {
        case "n":
          {
            return false;
          }
        default:
          {
            return true;
          }
      }
    }

    private static void ProbleemBuilder()
    {
      var probleem = new Probleem();

      Console.WriteLine("Wat is het probleem, vriend?: ");
      probleem.Issue = Console.ReadLine();
      Console.WriteLine("Wat is het filiaal, vriend?: ");
      probleem.Filiaal = Console.ReadLine();
      Console.WriteLine("Is er een ticketnummer, vriend?: ");
      probleem.Ticketnummer = Console.ReadLine();
      Console.WriteLine("Wat heb je gedaan, vriend?: ");
      probleem.Oplossing = Console.ReadLine();

      FileWriter.WriteToFile(probleem);
    }
  }

  public class Probleem
  {
    public string Issue { get; set; }
    public string Filiaal { get; set; }
    public string Ticketnummer { get; set; }
    public string Oplossing { get; set; }
  }
}
