﻿/*Ex14.Soma de Números
   Escreva um programa que permita ao usuário inserir números inteiros. O programa deve continuar solicitando números até que o usuário digite 0. Ao final, quando 0 for digitado, o programa deve calcular e exibir a soma de todos os números inseridos (exceto o 0). Utilize um laço while para realizar essa tarefa.
*/

int numero;
int soma = 0;

Console.WriteLine("Digite números inteiros para somar. Digite 0 para finalizar.");

numero = int.Parse(Console.ReadLine());

while (numero != 0)
{
    soma += numero;
    numero = int.Parse(Console.ReadLine()); // Lê o próxima número.
}

Console.WriteLine("Soma total " + soma);
