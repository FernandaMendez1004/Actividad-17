Console.WriteLine("Crear una función que reciba el radio de un círculo y devuelva el área del círculo.");
double AreaCirculo (double a)
{
    double area = a * a * 3.1416;
    return area;
}

Console.WriteLine("Ingrese el radio del circulo");
double n1 = double.Parse(Console.ReadLine());

double resultado = AreaCirculo(n1);
Console.WriteLine($"El area del circulo es {resultado}");