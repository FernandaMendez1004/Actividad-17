Console.WriteLine("Crear una función que reciba el precio de un producto y el porcentaje de descuento y devuelva el precio final.");

double PrecioFinal (double precio, double descuento)
{
    double resu = precio - (precio * descuento / 100);
    return resu;
}

