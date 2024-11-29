using System.Diagnostics;

System.Console.WriteLine("Skriv 1 tal som ska kvadreras");
String kvaddeBoi = Console.ReadLine();
int.TryParse(kvaddeBoi, out int kvadde);
static void kvadrat(int kvadde){
    System.Console.WriteLine(kvadde*kvadde);
}
kvadrat(kvadde);


System.Console.WriteLine("Skriv in första talet.");
 string Tal1 = Console.ReadLine();
 System.Console.WriteLine("Skriv in andra talet");
 string Tal2 = Console.ReadLine();

 int.TryParse(Tal1, out int tal1Num);
 int.TryParse(Tal2, out int tal2Num);

static void doub(double tal1, double tal2){
 System.Console.WriteLine( tal1*tal2);
}
doub(tal1Num, tal2Num);


System.Console.WriteLine("Vad är höjden?");
string height = Console.ReadLine();
System.Console.WriteLine("Vad är längden?");
string lenght = Console.ReadLine();
int.TryParse(height, out int heightNum);
int.TryParse(lenght, out int lenghtNum);

static void triangleArea(double Height, double Lenght){
    System.Console.WriteLine((Height*Lenght)/2);
}
triangleArea(heightNum,lenghtNum);
Console.ReadLine();


