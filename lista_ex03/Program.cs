/*Objetivo: Compreender a aplicação de condições para tomada de decisão. 
Descrição: Escreva um programa que pergunte a nota de um aluno. 
Se a nota for maior ou igual a 6, o aluno é considerado "Aprovado". 
Caso contrário, ele é "Reprovado". Exiba a situação do aluno na tela. 
Exemplo de Saída: "Aluno aprovado." ou "Aluno reprovado." */

Console.WriteLine("Digite a nota do(a) aluno(a): ");
double nota = double.Parse(Console.ReadLine());

Console.Clear();

if (nota >= 6)
{
    Console.WriteLine("Aluno aprovado!");
}
else
{
    Console.WriteLine("Aluno reprovado!");
}
