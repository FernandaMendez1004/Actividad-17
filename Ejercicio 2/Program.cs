int Cuadrado (int a)
{
    return a * a;
}

Console.WriteLine("Ingrese un numero para elevar al cuadrado");
int n1 = int.Parse(Console.ReadLine());

int resultado = Cuadrado(n1);
Console.WriteLine($"El resultado es {resultado}");
