int Sumar(int a, int b)
{
    return a + b;
}

Console.WriteLine("Ingrese un numero");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese otro numero");
int n2 = int.Parse(Console.ReadLine());

int ResultadoSuma = Sumar( n1, n2);
Console.WriteLine($"La suma es {ResultadoSuma}");


