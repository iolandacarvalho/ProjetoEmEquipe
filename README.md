# Projeto Em Grupo - Grupo 5

## Simulador de Dado
Aluna: Iolanda Carvalho

### Intuito:
Fazer uma aplicação do tipo console que simule que o usuário está jogando um dado.

### O que foi usado:
- Estrutura de repetição ``for``
- Estrutura de condição ``if``
- Método ``Random.Next``

### Como foi feito:
1. Peço para o usuário escrever "Pronto" para que o simulador "jogue" o dado.
Usei o ``if`` para que se o usuário escrever qualquer outra coisa diferente disso, aparece uma mensagem de erro e retorna para o início.
2. Quando o usuário digita "Pronto", o simulador inicia.
3. Utilizei o ``for`` e ``Random`` para causar a impressão de que o dado está rodando, passando por vários números aleatórios de 1 a 6.
4. Como resultado final, o sistema escolhe um número aleatório de 1 a 6 e informa ao usuário onde o dado parou.

### Backlog:
- Permitir que o usuário "jogue" mais de um dado ao mesmo tempo.
- Melhorar a questão visual da aplicação.

## Calculadora 
Aluno: Ricardo Henrique 

### Intuito:
Fazer uma aplicação do tipo console de uma calculadora simples de 2 números capaz de realizar adição, subtração, divisão e multiplicação

### O que foi usado:
- Variáveis
- Estrutura de condição ``if``
- Estrutura de decisão ``Switch case``
- Estrutura de repetição ``While``

### Como foi feito:
1. É pedido ao usuário para informar dois números para então realizar uma ação, que será decidida por ele próprio.
2. O Usuário poderá decidir se será uma adição, subtração, ou divisão.
3. Utilizei o ``if`` para Caso um número invalido for informado, o usuário recebe uma notificação que o número dado é inválido e o aplicativo se encerra.
4. Ao colocar adequadamente os números e informar a operação desejada, utilizei o ``switch case`` para que então o resultado da operação escolhida seja exibido no console.

### Backlog:
- Evitar que o aplicativo se encerre quando o usuário coloca um número inválido.
- Melhorar a estrutura para que o aplicativo suporte mais do que dois números.
- Otimizar as linhas de códigos.

## Decisão de Almoço
Aluno: Ricardo Henrique 

### Intuito:
Fazer uma aplicação do tipo console de um restaurante fictício onde o usuário poderá escolher entre 5 opções de comida no cardápio.

### O que foi usado:
- Variáveis
- Estrutura de condição ``if``
- Estrutura de decisão ``do while``
- Método ``Random.Next``

### Como foi feito:
1. Inicialmente, um cardápio é exibido ao usuário, ele contém 5 opções diferentes com preços gerados aleatoriamente pelo sistema. Para isso, utilizei o ``Random.Next``
2. O Usuário poderá escolher, da forma que desejar, entre as opções apresentadas, um valor irá se acumular mediante as escolhas do usuário.
3. Após a escolha, um valor final é apresentado. O valor é a soma de todos os produtos que o usuário escolheu.

### Backlog:
- Fazer um recibo, contendo os valores acumulados em detalhe para o cliente.
- Adicionar mais opções ao cliente.
- Otimizar as linhas de códigos.