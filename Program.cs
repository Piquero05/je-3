Console.WriteLine("Introduce un numero");
double n1 =double.Parse(Console.ReadLine()) ;
Console.WriteLine("Introduce un numero");
double n2 =double.Parse(Console.ReadLine());
double n3 = n1/n2;
Console.WriteLine($"El coeficiente de estos numeros es {n3.ToString("F3")}");