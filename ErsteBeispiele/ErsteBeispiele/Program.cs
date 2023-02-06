

using ErsteBeispiele;
using System;
using System.Globalization;

Console.WriteLine("Hello world!");

CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");

int i = 10;

Console.WriteLine(i);
int k = 20;

int m = i + k;
Console.WriteLine(m);

Console.WriteLine("i hat den Wert {0}, k: {1}, m: {2}", i, k, m);

double x = 10000000.234567;
Console.WriteLine("x: {0:#,###,###.00}", x);

x = k;
Console.WriteLine(x);
x = 12.345;
k = (int)x;

Console.WriteLine(k);

//k = 10;
//k += k++ + ++k;

//Console.WriteLine(k);

double y = 10.0 / 3;
Console.WriteLine(y);

Console.WriteLine("***************************************");

for (int n = 0; n < 10; n++)
{
  Console.WriteLine(n);
}

string text = "Hallo Welt, die Farben sind Rot, Grün, Gelb, Blau";

//text = text.ToUpper();
//Console.WriteLine(text);
Console.WriteLine("***************************************");

int index = text.IndexOf("Rot");

Console.WriteLine(index);
Console.WriteLine(text.Substring(index));
Console.WriteLine(text.Substring(index, 9));

index = text.IndexOf(",");
Console.WriteLine(index);

index = text.IndexOf(",", index + 1);
Console.WriteLine(index);

Console.WriteLine("***************************************");

string[] teile = text.Split(",");
for (int n = 0; n < teile.Length; n++)
{
  Console.WriteLine(teile[n].Trim());
}

Console.WriteLine("***************************************");

foreach (string zeile in teile)
{
  Console.WriteLine(zeile.Trim());
}

Console.WriteLine(string.Join("----", teile));

Console.WriteLine("***************************************");

text = "abc";
//int zahl = int.Parse(text);

if (int.TryParse(text, out int zahl))
{
  Console.WriteLine("Zahl: " + zahl);
}
else
{
  Console.WriteLine(text + " ist keine gültige Zahl. 'zahl' hat den Wert " + zahl);
}

Console.WriteLine("***************************************");

string t = $"x hat den Wert {x: 0.00}, text: {text}, i: {i * 100}"; // String interpolation
Console.WriteLine(t);
t = $"x hat den Wert {x: 0.00}, text: {text,10}, i: {i * 100}"; // String interpolation
Console.WriteLine(t);
t = $"x hat den Wert {x: 0.00}, text: {text,-10}, i: {i * 100}"; // String interpolation
Console.WriteLine(t);

Console.WriteLine("***************************************");

DateTime jetzt = DateTime.Now;
Console.WriteLine(jetzt);
Console.WriteLine($"{jetzt:dddd dd.MMMM.yyyy}");
Console.WriteLine($"{jetzt:d}");
Console.WriteLine($"{jetzt:D}");
Console.WriteLine($"{jetzt:t}");
Console.WriteLine($"{jetzt:T}");
Console.WriteLine($"{jetzt:g}");
Console.WriteLine($"{jetzt:G}");

DateTime neulich = new DateTime(2015, 6, 7);
Console.WriteLine(neulich);

TimeSpan zeitspanne = jetzt - neulich;
Console.WriteLine($"{zeitspanne.TotalDays}");

Console.WriteLine(jetzt.ToUniversalTime());
Console.WriteLine(neulich.ToUniversalTime());

Console.WriteLine(jetzt.Kind);
Console.WriteLine(jetzt.ToUniversalTime().Kind);
Console.WriteLine(neulich.Kind);
//DateTimeOffset

Console.WriteLine("**********************************");

Längenmaß maß = new Längenmaß();
maß.LängeInMeter = 100;
Console.WriteLine(maß.LängeInMeter);
Console.WriteLine(maß.LängeInZentimeter);
Console.WriteLine(maß.LängeInZoll);

maß.LängeInZoll = 1000;
Console.WriteLine(maß.LängeInMeter);
Console.WriteLine(maß.LängeInZentimeter);
Console.WriteLine(maß.LängeInZoll);

Console.ReadLine();