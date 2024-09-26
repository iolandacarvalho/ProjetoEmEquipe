using System;
using System.Threading;
class Program
{
    public static void Main(string[] args)
    {
        return1:
        Console.Write("Quantos segundos o cronometro deve contar? ");
        if(int.TryParse(Console.ReadLine(), out int seconds))
        {
            
            Console.Clear();
            for(int i = 0; i <= seconds; i++)
            {
                if(Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true);
                    if(key.Key == ConsoleKey.Escape)
                    {
                        Console.WriteLine("O cronometro foi parado");
                        return;
                    }
                    
                }
                Console.WriteLine($"Tempo restante: {i} segundos");
                Thread.Sleep(1000);
                Console.Clear();
            }
            Console.WriteLine("Tempo esgotado!");
        }
        else
        {
            Console.WriteLine("Valor inválido!"); 
            goto return1;
        }
    }
}
