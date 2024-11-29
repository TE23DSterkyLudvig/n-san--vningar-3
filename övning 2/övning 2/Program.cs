using System.Diagnostics;

System.Console.WriteLine("Skriv 1 tal som ska kvadreras");
String kvaddeboi = Console.ReadLine();
int.TryParse(kvaddeboi, out int kvadde);
static void kvadrat(int kvadde){
    System.Console.WriteLine(kvadde * kvadde);
}
kvadrat(kvadde);


System.Console.WriteLine("Skriv in första talet.");
 string Tal1 = Console.ReadLine();
 System.Console.WriteLine("Skriv in andra talet");
 string Tal2 = Console.ReadLine();

 int.TryParse(Tal1, out int Tal1num);
 int.TryParse(Tal2, out int Tal2num);

static void doub(double tal1, double tal2){
 System.Console.WriteLine( tal1*tal2);
}
doub(Tal1num, Tal2num);
Console.ReadLine();

