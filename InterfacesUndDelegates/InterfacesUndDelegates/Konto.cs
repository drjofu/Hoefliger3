namespace InterfacesUndDelegates
{
  class Konto : IComparable<Konto>
  {
    public int Kontonummer { get; set; }
    public string Inhaber { get; set; }
    public double Saldo { get; set; }

    public int CompareTo(Konto other)
    {
      Konto k1 = this;
      Konto k2 = other;

      //Console.WriteLine($"Vergleiche {k1.Kontonummer} mit {k2.Kontonummer}");
      return k1.Inhaber.CompareTo(k2.Inhaber);
    }

    public override string ToString()
    {
      return $"Konto {Kontonummer:000} von {Inhaber,-14} Saldo: {Saldo:0.0}";
    }
  }
}
