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

## Jogo: Acerte o Número
Aluna: Iolanda Carvalho

### Intuito:
Fazer uma aplicação do tipo console de um jogo onde o istema gera um número aleatório de 1 a 100 e o usuário precisa acertar qual é esse número apenas com dicas como "muito baixo" e "muito alto".

### O que foi usado:
- Variáveis
- Estrutura de condição ``if``
- Estrutura de decisão ``while``
- Método ``Random.Next``

### Como foi feito:
1. Foi utilizado o ``Random.Next`` para o sistema gerar um número aleatório de 1 a 100.
2. Após isso, eu usei o ``while`` para que enquanto o palpite do usuário for diferente do número gerado, o sistema continuará pedindo para que ele informe um novo palpite.
3. Usei o ``if`` para que a cada palpite do usuário o sistema faça o seguinte teste: Se o número informado pelo usuário como palpite for menor que o número que o sistema gerou, aparecerá a menságem `Muito baixo! Tente novamente.` e solicitará que ele faça um novo palpite, se o número informado pelo usuário como palpite for maior que o número que o sistema gerou, aparecerá a menságem `Muito alto! Tente novamente.` e solicitará que ele faça um novo palpite. Agora, caso o número inserido como palpite seja igual ao número gerado pelo sistema, aparecerá a mensagem `PARABÉNS, VOCÊ ACERTOU!`, informará o número e a quantidade de tentativas do usuário.

### Backlog:
- Gerar mais de um número em um intervalo maior.
- Melhorar a parte visual.