namespace InterfacesUndDelegates
{
  public static class Erweiterungsmethoden
  {
    public static void Ausgeben<T>(this IEnumerable<T> liste, string titel = "")
    {
      Console.WriteLine($"********** {titel} **********");

      foreach (T konto in liste)
        Console.WriteLine(konto);

      Console.WriteLine("******************************");
      Console.WriteLine();
    }
  }
}
