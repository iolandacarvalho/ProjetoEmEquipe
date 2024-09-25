return1:
Console.Write("Insira o seu peso: ");
if(!decimal.TryParse(Console.ReadLine(), out decimal peso))
{
    Console.WriteLine("Valor inválido. Tente novamente");
    goto return1;
}
else
{
    return2:
    Console.Write("Insira sua altura em metros: ");
    if(!decimal.TryParse(Console.ReadLine(), out decimal altura))
    {
        Console.WriteLine("Valor inválido. Tente novamente");
        goto return2;
    }
    else
    {
        decimal imc=peso/(altura*altura);

        if (imc < 15 && imc <= 18.5m)
        {
            Console.WriteLine($"Seu IMC: {imc:D2}");
            Console.WriteLine("você está abaixo do peso");
        }
        else if (imc >= 18.6m && imc <= 24.9m)
        {
            Console.WriteLine($"Seu IMC: {imc:D2}");
            Console.WriteLine("você está no seu peso normal");
        }
        else if (imc >= 25 && imc <= 29.9m)
        {
            Console.WriteLine($"Seu IMC: {imc:D2}");
            Console.WriteLine("você está acima do peso");
        }
        else
        {
            Console.WriteLine($"Seu IMC: {imc:D2}");
            Console.WriteLine("você está obeso");
        }
    }
}

