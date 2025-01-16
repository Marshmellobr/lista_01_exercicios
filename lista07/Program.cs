/*Comparação de números
 

Objetivo: Pratique a comparação de variáveis. 
Descrição: Escreva um programa que solicite ao usuário dois números e determine qual é o maior. Use if, else if e else para exibir a mensagem apropriada. 
Exemplo de saída: "O primeiro número é maior.", "O segundo número é maior." ou "Os números são iguais."*/

Console.WriteLine("Digite primeiro numero");

float n1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite segundo numero");

float n2 = float.Parse(Console.ReadLine());

if (n1 == n2)
{
    Console.WriteLine("Os numeros são iguais");
}
else if (n1 > n2)
{
    Console.WriteLine("O primeiro número é maior que o segundo numero");
}
else if (n1 < n2)
{
    Console.WriteLine("O primeiro número é menor que o segundo numero");
}
