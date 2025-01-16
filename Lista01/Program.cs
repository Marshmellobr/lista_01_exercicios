// See https://aka.ms/new-console-template for more information

/*Verificação de paridade Objetivo: 
 * Pratique o uso do operador % (módulo) e estruturas condicionais simples.
Descrição: Crie um programa que solicite que o usuário digite um número inteiro. O programa deve verificar se o número é par ou ímpar. Use a condição if para determinar o resultado e exibir uma mensagem apropriada. 
Exemplo de saída: "O número é par." ou "O número é ímpar".*/

Console.WriteLine("Digite um numero");
int num1 = int.Parse (Console.ReadLine());

if (num1 % 2 == 0)
{
    Console.WriteLine("O numero é par");
}

else if (num1 % 2 == 1)
{
    Console.WriteLine("O numero é impar");
}
