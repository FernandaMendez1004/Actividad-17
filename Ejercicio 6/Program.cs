Console.WriteLine("Crear una función que reciba un número en grados Celsius y devuelva el valor convertido a Fahrenheit.");

double ConvertirFahrenheit (double gradoscel)
{
    double Fahrenheit = (gradoscel * 9 / 5) + 32;
    return Fahrenheit;
}

Console.WriteLine("Ingrese grados celsius");
double num1 = double.Parse(Console.ReadLine());

double grados = ConvertirFahrenheit(num1);
Console.WriteLine($"Los grados fh son {grados}");