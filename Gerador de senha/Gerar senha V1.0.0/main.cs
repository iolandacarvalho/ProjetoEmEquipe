using System;
using System.Threading;
class Program {
  public static void Main (string[] args) {
    string carac = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*";
    return1:
    Console.Write("Quantos caracteres você quer na senha? ");
    if(!int.TryParse(Console.ReadLine(), out int qntd) || qntd < 1)
    {
      Console.WriteLine("Por favor, insira um número válido maior que zero");
      Thread.Sleep(2500);
      Console.Clear();
      goto return1;
    }
    else
    {
      Random random = new Random();
      Console.Write("\nSua senha nova é: ");
      for(int i = 0; i < qntd; i++)
      {
        int roll = random.Next(1, carac.Length);
        Console.Write(carac[roll]);
      }
    }
    
  }
}