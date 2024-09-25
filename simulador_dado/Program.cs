using System;

class Program 
{
    static void Main(string[] args)
    {
        string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        //int tamanho = ContarCaracteres(caracteres); // Conta os caracteres manualmente
        //Console.WriteLine($"Tamanho da string de caracteres: {tamanho}");

        Console.WriteLine("Digite o tamanho da senha que deseja gerar:");
        if (!int.TryParse(Console.ReadLine(), out int tamanhosenha))
        {
            Console.WriteLine("Insira um valor válido.");
            return;
        }

        string senha = GerarSenha(tamanhosenha, caracteres,);
        Console.WriteLine($"Senha gerada: {senha}");
    }

    //static int ContarCaracteres(string caracteres)
    //{
       // int contador = 0;
       // foreach (char c in caracteres)
        //{
           // contador++; // Incrementa o contador para cada caractere
//}
//return contador;
    //}

    static string GerarSenha(int tamanho, string caracteres, int tamanhoCaracteres)
    {
        Random random = new Random();
        string senha = "";
        for (int i = 0; i < tamanho; i++)
        {
            int index = random.Next(tamanhoCaracteres.length); // Usa o tamanho contado manualmente
            senha += caracteres[index];
        }

        return senha;
    }
}
