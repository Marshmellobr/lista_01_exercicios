/*Dia da semana (usando if-else)
 

Objetivo: Pratique o uso de várias condições com if, else if e else. 
Descrição: Desenvolva um programa que solicite um número de 1 a 7 e exiba o dia da semana correspondente (1 para "domingo", 2 para "segunda-feira", etc.). Se o número estiver fora desse intervalo, exiba uma mensagem de erro. 
Exemplo de saída: "Domingo", "Segunda-feira", etc., ou "Número inválido. Digite um número de 1 a 7."*/

Console.WriteLine("digite um numero de 1 a 7");
int n = int.Parse(Console.ReadLine());

if (n == 1)
{
    Console.WriteLine("hoje é domigno");
}

else if (n == 2)
{
    Console.WriteLine("hoje é Segunda");
}
else if (n == 3)
{
    Console.WriteLine("hoje é terça-feria");
}
else if (n == 4)
{
    Console.WriteLine("hoje é Quarta-feira");
}
else if (n == 5)
{
    Console.WriteLine("hoje é Quinta-feira");
}
else if (n == 6)
{
    Console.WriteLine("hoje é sexta-feira");
}
else if (n == 7)
{
    Console.WriteLine("hoje é sabado");
}
else if (n > 7 && n < 1)
{ 
    Console.WriteLine("Esse numero é invalido!");
}
