/* Objetivo: Aprender a usar múltiplas condições em uma estrutura de decisão. 
Descrição: Crie um programa que peça a nota de um aluno e classifique a nota em categorias: 
"Excelente" (nota >= 9), "Boa" (7 <= nota < 9), "Regular" (5 <= nota < 7) e "Baixa" (nota < 5). 
Exiba a classificação na tela. 
Exemplo de Saída: "Excelente", "Boa", "Regular" ou "Baixa".*/

Console.WriteLine("Digite a nota do(a) aluno(a): ");
double nota = double.Parse(Console.ReadLine());

Console.WriteLine("===============================");

if (nota >= 9)
{
    Console.WriteLine("Excelente" + nota);
}
else if (nota < 9 & nota >= 7)
{
    Console.WriteLine("Boa" + nota);
}
else if (nota < 7 & nota >= 5)
{
    Console.WriteLine("Regular" + nota);
}
else
{
    Console.WriteLine("Baixa" + nota);
}
