// See https://aka.ms/new-console-template for more information
return1:
Console.Write("\nInsira a temperatura em celsius: ");
if (!decimal.TryParse(Console.ReadLine(), out decimal temp))
{
    Console.WriteLine ("Valor inválido, por favor, tente novamente.");
    goto return1;
}
else 
{
    return2:
    Console.Write("Você deseja converter essa temperatura para Fahrenheit ou Kelvin? (Insira 'F' para 'Fahrenheit' e 'K' para 'Kelvin')  ");
    string conv = Console.ReadLine().ToLower();
    if(conv=="f")
    {
        decimal result=temp*1.8m+32;
        Console.Write($"\n{temp}°C equivale a {Math.Round(result, 1)}°F");
    }

    else if(conv=="k")
    {
        decimal result = temp + 273;
        Console.Write($"\n{temp}°C equivale a {Math.Round(result, 1)}K");
    }
    else
    {
        Console.WriteLine ("Valor inválido, por favor, tente novamente.");
        goto return2;
    }
}



