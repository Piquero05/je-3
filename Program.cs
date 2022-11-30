Console.WriteLine("Introduce un numero");
int n1 =int.Parse(Console.ReadLine()) ;
Console.WriteLine("Introduce un numero");
int n2 =int.Parse(Console.ReadLine());

if(n2>n1)
{
    Console.WriteLine($"El mayor de los dos es {n2.ToString("F3")} y el menor {n1.ToString("F3")}");
}
else
{
    Console.WriteLine($"El mayor de los dos es {n1.ToString("F3")} y el menor { n2.ToString("F3")}");
}