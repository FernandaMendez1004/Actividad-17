Console.WriteLine("Crear una función que reciba un número y devuelva su doble.");

int DobleNumero(int a)
{
    return a * 2;
}

Console.WriteLine("Ingrese un numero");
int num1 = int.Parse(Console.ReadLine());

int resultado = DobleNumero(num1);
Console.WriteLine($"El doble de un numero {resultado}");
