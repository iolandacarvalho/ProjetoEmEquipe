// See https://aka.ms/new-console-template for more information
Console.Write("Informe o primeiro número para que possa calcular: ");
    double valor1 = double.Parse (Console.ReadLine());

Console.Write("informe o segundo número para calcular: ");
    double valor2 = double.Parse (Console.ReadLine());

Console.Write("Qual operação deseja realizar, Multiplicação, divisão, adição ou subtração? Insira a inicial da operação.: ");
string operacao = Console.ReadLine();

switch(operacao) 
{
  case "+":
    Console.WriteLine($"O resultado da adição é: {valor1 + valor2} ");
    break;
  case "/":
    Console.WriteLine($"O resultado da divisão é: {valor1 / valor2} ");
    break;
    case "*":
    Console.WriteLine($"O resultado da multiplicação é: {valor1 * valor2} ");
    break;
     case "-":
    Console.WriteLine($"O resultado da subtração é: {valor1 - valor2} ");
    break;
  default:
    Console.WriteLine("Operador inválido");
    break;
}


