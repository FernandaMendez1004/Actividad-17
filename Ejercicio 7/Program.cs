Console.WriteLine("Crear una función que reciba el precio de un producto y el porcentaje de descuento y devuelva el precio final.");

double PrecioFinal (double precio, double descuento)
{
    double resu = precio - (precio * descuento / 100);
    return resu;
}

Console.WriteLine("Ingrese el precio del producto");
double pr = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el descuento");
double des = double.Parse(Console.ReadLine());

double resultado = PrecioFinal(pr, des);
Console.WriteLine($"El precio final es {resultado}");