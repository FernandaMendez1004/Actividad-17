Console.WriteLine("Crear una función que reciba el salario por hora y las horas trabajadas y devuelva el salario total.");

int SalarioFinal (int salahora, int horatraba)
{
    return salahora * horatraba;
}

Console.WriteLine("Ingrese el salario por hora");
int sh = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese las horas trabajadas");
int hr = int.Parse(Console.ReadLine());

int total = SalarioFinal(sh, hr);
Console.WriteLine($"El salario total es de {total}");
