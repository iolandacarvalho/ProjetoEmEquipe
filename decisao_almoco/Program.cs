using System;
class Program
{
    private static void Main()
    {

// Nome do restaurante
        Console.WriteLine("Bem-vindo ao Restaurante do Ricardo!\n");

        // Cardápio com itens e preços
        Dictionary<string, double> menu = new Dictionary<string, double>()
        {
            { "Salsicha", GerarPrecoAleatorio() },
            { "Linguica", GerarPrecoAleatorio() },
            { "Pepino", GerarPrecoAleatorio() },
            { "Banana", GerarPrecoAleatorio() },
            { "Ovo", GerarPrecoAleatorio() }
        };

        // Mostrar cardápio
        Console.WriteLine("Cardápio:");
        foreach (var item in menu)
        {
            Console.WriteLine($"{item.Key}: R$ {item.Value:F2}");
        }

        // Lista para armazenar os itens escolhidos
        List<string> escolhidos = new List<string>();
        string? escolha; // Permitir nulo
        double precoTotal = 0;

        // Solicitar ao menos uma escolha
        do
        {
            Console.Write("\nEscolha um item do cardápio (ou digite 'sair' para finalizar): ");
            escolha = Console.ReadLine();

            if (!string.IsNullOrEmpty(escolha) && menu.ContainsKey(escolha))
            {
                escolhidos.Add(escolha);
                precoTotal += menu[escolha];
                Console.WriteLine($"{escolha} adicionado. Preço: R$ {menu[escolha]:F2}");
            }
            else if (escolha?.ToLower() != "sair")
            {
                Console.WriteLine("Item inválido. Tente novamente.");
            }

        } while (escolha?.ToLower() != "sair" || escolhidos.Count == 0);

        // Mostrar itens escolhidos e preço total
        if (escolhidos.Count > 0)
        {
            Console.WriteLine("\nItens escolhidos:");
            foreach (var item in escolhidos)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"\nPreço total: R$ {precoTotal:F2}");
        }
        else
        {
            Console.WriteLine("Nenhum item foi escolhido.");
        }
    

    // Função para gerar preços aleatórios entre 5 e 15 reais
    static double GerarPrecoAleatorio()
    {
        Random randNum = new Random();
		int g = randNum.Next(5, 16);
        return g; // Preços entre 5 e 15 reais

    }
    }
}