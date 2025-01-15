/* Objetivo: Praticar o uso do operador % (módulo) e estruturas condicionais simples. 
Descrição: Crie um programa que peça ao usuário para digitar um número inteiro. 
O programa deve verificar se o número é par ou ímpar. 
Utilize a condição if para determinar o resultado e exiba uma mensagem apropriada. 
Exemplo de Saída: "O número é par." ou "O número é ímpar." */

Console.WriteLine("Digite um número inteiro: ");
int num = int.Parse(Console.ReadLine());

Console.Clear();

if (num % 2 == 0)
{
    Console.WriteLine("O número é par");
}
else
{
    Console.WriteLine("O número é ímpar");
}
