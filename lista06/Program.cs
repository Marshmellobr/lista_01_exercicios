/* Classificação de notas
 

Objetivo: Aprenda a usar várias condições em uma estrutura de decisão. 
Descrição: Crie um programa que solicite a nota de um aluno e classifique a nota em categorias: "Excelente" (nota >= 9), 
"Bom" (7 <= nota < 9), "Regular" (5 <= nota < 7) e "Baixo" (nota < 5). Exiba a classificação na tela. 
Saída de amostra: "Excelente", "Bom", "Razoável" ou "Baixo".*/

Console.WriteLine("Digite a sua nota");
int num1 = int.Parse(Console.ReadLine());

if (num1 >= 9)
{
    Console.WriteLine("Excelente");
}

else if (num1 >= 7 && num1 < 9) 
{
    Console.WriteLine("Bom");
}
else if (num1 >= 5 && num1 < 7) 
{
    Console.WriteLine("Regular");
}
else if (num1 < 5) 
{
    Console.WriteLine("baixa");
}