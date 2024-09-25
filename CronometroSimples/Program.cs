internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Quantos segundos o cronômetro deve rodar?: ");

        int segundos = int.Parse(Console.ReadLine());
        for (int i = segundos; i >= 0; i--)
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true); // Lê a tecla pressionada
                if (key.Key == ConsoleKey.Escape) // Verifica se é a tecla Esc
                {
                    Console.WriteLine("Cronômetro encerrado.");
                    return; // Encerra o programa
                }
            }
            Console.WriteLine(i + " segundos");
            Thread.Sleep(1000);
            Console.Clear();
        }
        Console.WriteLine("Cronômetro encerrado.");
    }
}