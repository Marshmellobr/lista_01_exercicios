/* Faixa de valor
 
Objetivo: Compreender a aplicação das condições para a tomada de decisão. 
Descrição: Escreva um programa que solicite a nota de um aluno. Se a nota for maior ou igual a 6, o aluno é considerado "Aprovado". Caso contrário, ele está "falhando". Exiba a situação do aluno na tela. 
Exemplo de saída: "Aluno aprovado." ou "Aluno reprovado".*/

Console.WriteLine("Digite a sua nota:");
float num1 = float.Parse(Console.ReadLine());

if (num1 >= 6)
{
    Console.WriteLine(" Vc está Aprovado!!!");
}

else if (num1 < 6)
{
    Console.WriteLine("Vc infelizmente foi reprovado...");
}


