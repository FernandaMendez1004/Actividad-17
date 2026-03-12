Console.WriteLine("Crear una función que reciba un número y devuelva el cubo del número.");

int CuboNumero (int a)
{
    return a * a * a;
}

Console.WriteLine("Ingrese un numero para calcular el cubo");
int n1 = int.Parse(Console.ReadLine());

int cuboresu = CuboNumero(n1);
Console.WriteLine($"El cubo es {cuboresu}");
