Console.WriteLine("Crear una función que reciba tres números y devuelva el promedio de los tres.");

double PromedioTres (double a, double b, double c)
{
    return (a + b + c) / 3;
}

Console.WriteLine("Ingrese el primer numero");
double n1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero");
double n2 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el terer numero");
double n3 = double.Parse(Console.ReadLine());

double prom = PromedioTres(n1, n2, n3);
Console.WriteLine($"El promedio es de {prom}");