/* See https://aka.ms/new-console-template for more information
Verificação de idade
 

Objetivo: Aplicar condições para classificar os dados. 
Descrição: Desenvolva um programa que pergunte a idade de uma pessoa e determine se ela é maior de idade (18 anos ou mais) ou menor de idade. Use if e else para exibir a mensagem apropriada. 
Exemplo de saída: "Você é maior de idade." ou "Você é menor de idade".*/

Console.WriteLine("Digite a sua idade");
int num1 = int.Parse(Console.ReadLine());

if (num1 >= 18)
{
    Console.WriteLine("vc é maior de idade");
}
else if (num1 < 18 )
{
    Console.WriteLine("vc é menor de idade ");
}