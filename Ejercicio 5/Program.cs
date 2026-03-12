Console.WriteLine("Crear una función que reciba la base y la altura de un rectángulo y devuelva su área.");
int AreaRectangulo (int basec, int alturac)
{
    int area = basec * alturac;
    return area;
}

Console.WriteLine("Ingrese la base");
int basecua = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la area");
int areacua = int.Parse(Console.ReadLine());

int resucua = AreaRectangulo(basecua, areacua);
Console.WriteLine($"El area del cuadrado es {resucua}");