/*Verificação de votos
 

Objetivo: Entenda a lógica das permissões baseadas em condições. 
Descrição: Crie um programa que solicite a idade de uma pessoa e determine se ela pode votar (idade >= 16). Use uma condição if para exibir a mensagem correspondente. 
Exemplo de saída: "Você pode votar." ou "Você não pode votar."*/

Console.WriteLine("Digite a sua idade");
int num1 = int.Parse(Console.ReadLine());

if (num1 >= 16)
{
    Console.WriteLine("vc pode votar ");
}
else if (num1 < 16)
{
    Console.WriteLine("vc não ainda não pode votar ");
}
