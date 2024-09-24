// See https://aka.ms/new-console-template for more information
        double num1, num2;

        // Solicitar o primeiro número
        Console.Write("Digite o primeiro número: ");
        while (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
        }

        // Solicitar o segundo número
        Console.Write("Digite o segundo número: ");
        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
        }

        // Solicitar a operação
        Console.Write("Digite a operação (+, -, *, /): ");
        string? inputOperacao = Console.ReadLine();

        // Verificar se a entrada é válida
        if (string.IsNullOrEmpty(inputOperacao) || inputOperacao.Length != 1)
        {
            Console.WriteLine("Operação inválida. Por favor, digite uma operação válida (+, -, *, /).");
            return;
        }
        
        char operacao = inputOperacao[0]; // Pega o primeiro caractere

        double resultado = 0; // Inicialização da variável resultado

        // Realizar o cálculo com base na operação
        switch (operacao)
        {
            case '+':
                resultado = num1 + num2;
                break;
            case '-':
                resultado = num1 - num2;
                break;
            case '*':
                resultado = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero.");
                    return; // Finaliza o programa
                }
                break;
            default:
                Console.WriteLine("Operação inválida. Por favor, digite uma operação válida (+, -, *, /).");
                return; // Finaliza o programa
        }

        // Exibir o resultado
        Console.WriteLine($"Resultado: {resultado}");