/*Cálculo de desconto
 

Objetivo: Aplicar condições para cálculos. 
Descrição: Escreva um programa que solicite o valor de uma compra e verifique se o valor é maior que 100. Em caso afirmativo, aplique um desconto de 10% sobre o valor e mostre o valor final. Caso contrário, exiba o valor original. 
Saída de amostra: "Valor descontado: [valor final]." ou "Valor original: [valor]*/

Console.WriteLine("Digite um valor");
int n = int.Parse(Console.ReadLine());

if (n >= 100)
{
 Console.WriteLine($"O valor do desconto é {n * 0.9}");

} else
{
    Console.WriteLine("valor Original é " + n);
}

