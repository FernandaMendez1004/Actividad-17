int Sumar(int a, int b)
{
    return a + b;
}

Console.WriteLine("Ingrese un numero");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese otro numero");
int n2 = int.Parse(Console.ReadLine());

int resultado = Sumar(int n1, int n2);


