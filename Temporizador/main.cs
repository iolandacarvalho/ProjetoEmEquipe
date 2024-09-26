using System;
using System.Threading;
class Program
{
    public static void Main(string[] args)
    {
        return1:
        Console.Write("Quantos segundos o temporizador deve contar? ");
        if(int.TryParse(Console.ReadLine(), out int seconds))
        {
            
            Console.Clear();
            for(int i = seconds; i >= 0; i--)
            {
                if(Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true);
                    if(key.Key == ConsoleKey.Escape)
                    {
                        Console.WriteLine("O temporizaor foi parado");
                        return;
                    }
                }
                Console.WriteLine($"Tempo restante: {i} segundos");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
        else
        {
            Console.WriteLine("Valor inválido!"); 
            goto return1;
        }
    }
}
