namespace InterfacesUndDelegates
{
  class Konto
  {
    public int Kontonummer { get; set; }
    public string Inhaber { get; set; }
    public double Saldo { get; set; }

    public override string ToString()
    {
      return $"Konto {Kontonummer:000} von {Inhaber,-14} Saldo: {Saldo:0.0}";
    }
  }
}
