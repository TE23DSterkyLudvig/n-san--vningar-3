using System.Diagnostics;

System.Console.WriteLine("Skriv 1 tal som ska kvadreras");
String kvaddeBoi = Console.ReadLine();
int.TryParse(kvaddeBoi, out int kvadde);
static int kvadrat(int kvadde)
{
    return kvadde * kvadde;
    
}
int c =kvadrat(kvadde);
System.Console.WriteLine(c);


System.Console.WriteLine("Skriv in första talet.");
string Tal1 = Console.ReadLine();
System.Console.WriteLine("Skriv in andra talet");
string Tal2 = Console.ReadLine();

int.TryParse(Tal1, out int tal1Num);
int.TryParse(Tal2, out int tal2Num);

static double doub(double tal1, double tal2)
{
    return tal1 * tal2;
    
}
double b = doub(tal1Num, tal2Num);
System.Console.WriteLine(b);


System.Console.WriteLine("Vad är höjden?");
string height = Console.ReadLine();
System.Console.WriteLine("Vad är längden?");
string lenght = Console.ReadLine();
int.TryParse(height, out int heightNum);
int.TryParse(lenght, out int lenghtNum);

static double triangleArea(double Height, double Lenght)
{
    return (Height * Lenght) / 2;

}
double a = triangleArea(heightNum, lenghtNum);
Console.WriteLine(a);

System.Console.WriteLine("Skriv 1 tal");
string talet = Console.ReadLine();
int.TryParse(talet, out int taletNum);

 static int getNumberinput(){
  while(true){
    
  }
}
int e = getNumberinput(taletNum);
System.Console.WriteLine(e);
Console.ReadLine();

