System.Console.WriteLine("Skriv 1 tal som ska kvadreras");
String kvaddeboi = Console.ReadLine();
int.TryParse(kvaddeboi, out int kvadde);
static void kvadrat(int kvadde){
    System.Console.WriteLine(kvadde);
}
kvadrat(kvadde*kvadde);
Console.ReadLine();

