/* Objetivo: Praticar a utilização de múltiplas condições com if, else if e else. 
Descrição: Desenvolva um programa que peça um número de 1 a 7 e exiba o dia da semana correspondente 
(1 para "Domingo", 2 para "Segunda-feira", etc.). 
Se o número estiver fora desse intervalo, exiba uma mensagem de erro. 
Exemplo de Saída: "Domingo", "Segunda-feira", etc., ou "Número inválido. Digite um número de 1 a 7." */


Console.WriteLine("Digite um número inteiro entre 1 e 7: ");
int dia = int.Parse(Console.ReadLine());

Console.WriteLine("===============================");

if (dia == 1)
{
    Console.WriteLine("Esse número representa: Domingo.");
}
else if (dia == 2)
{
    Console.WriteLine("Esse número representa: Segunda-feira.");
}
else if (dia == 3)
{
    Console.WriteLine("Esse número representa: Terça-feira.");
}
else if (dia == 4)
{
    Console.WriteLine("Esse número representa: Quarta-feira.");
}
else if (dia == 5)
{
    Console.WriteLine("Esse número representa: Quinta-feira.");
}
else if (dia == 6)
{
    Console.WriteLine("Esse número representa: Sexta-feira.");
}
else if (dia == 7)
{
    Console.WriteLine("Esse número representa: Sábado.");
}
else
{
    Console.WriteLine("Número inválido. Reinicie e digite um número entre 1 e 7");
}
