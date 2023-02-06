
TuWas();
TuWas("C# lernen");
TuWas(wasDenn: "Optionale Parameter lernen");

TuWas(wieLange: 100);
//TuWas(100);

TuWas("C# lernen", 200);
TuWas(wieLange: 300, wasDenn: "c++ vergessen");

TuWas(wasDenn: "Pause", wieLange: 15);

void TuWas(string wasDenn="nix", int wieLange = 10)
{
  Console.WriteLine("Tut was: " + wasDenn + ", " + wieLange + " Minuten");
}