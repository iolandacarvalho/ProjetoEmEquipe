// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("=".PadLeft(21, '='));
Console.WriteLine("- Simulador de Dado -");
Console.WriteLine("=".PadLeft(21, '='));
Console.ResetColor();
return1:
Console.Write("\n(Insira 'Pronto' para iniciar)");
Console.Write("\nPronto para jogar o dado? ");
string inicio = Console.ReadLine().ToLower();

if (inicio == "pronto")
{
    Random randNum = new Random();
	int nc = randNum.Next(1,6);
    Console.Clear();
    for (int cont = 0; cont <= 16; cont++)
    {
        Random randNumm = new Random();
		int n = randNum.Next(1,6);
        Console.WriteLine($"\nO dado está em: {n}\n");
        Thread.Sleep(300);
        Console.Clear();
    }
    Console.WriteLine($"\nO dado parou no número: {nc}\n");

}
else
{
    Console.WriteLine("\nValor inválido, digite novamente.\n");
    goto return1;
}