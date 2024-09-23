using System;
using System.Threading;
using System.Collections.Generic;
class Program {
  public static void Main (string[] args) {
    string carac = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ", num = "0123456789", exp = "!@#$%^&*";
    int r = 0;
    return1:
    Console.Write("Quantas letras você quer na senha? ");
    if(!int.TryParse(Console.ReadLine(), out int qntC) || qntC < 1)
    {
      Console.WriteLine("Por favor, insira um número válido maior que zero");
      Thread.Sleep(2500);
      Console.Clear();
      goto return1;
    }
    else
    {
      return2:
      Console.Write("Quantos caracteres numéricos você quer na senha? ");
      if(!int.TryParse(Console.ReadLine(), out int qntN) || qntC < 1)
      {
        Console.WriteLine("Por favor, insira um número válido maior que zero");
        Thread.Sleep(2500);
        Console.Clear();
        goto return2;
      }
      else
      {
        return3:
        Console.Write("Quantos caracteres especiais você quer na senha? ");
        if(!int.TryParse(Console.ReadLine(), out int qntE) || qntC < 1)
        {
          Console.WriteLine("Por favor, insira um número válido maior que zero");
          Thread.Sleep(2500);
          Console.Clear();
          goto return3;
        }
        else
        {
          int qtd = qntC + qntN + qntE;
          Random random = new Random();
          Console.Write("Sua senha é: ");
          List<char> senha = new List<char>();
          for(int i = 0; i < qntC; i++)
          {
            senha.Add(carac[random.Next(0,carac.Length)]);
          }
          for(int i = 0; i < qntN; i++)
          {
            senha.Add(num[random.Next(0,num.Length)]);
          }
          for(int i = 0; i < qntE; i++)
          {
            senha.Add(exp[random.Next(0,exp.Length)]);
          }
          List<char> senha1 = new List<char>();
          for(int i = 0; i < qtd; i++)
          {
            r = random.Next(0,senha.Count);
            senha1.Add(senha[r]);
            senha.Remove(senha[r]);
          }
          foreach(char i in senha1)
          {
            Console.Write(i);
          }
        }
      }
    }

  }
}