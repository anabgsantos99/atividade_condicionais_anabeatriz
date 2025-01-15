/* Objetivo: Praticar a comparação entre variáveis. 
Descrição: Escreva um programa que solicita dois números ao usuário e determina qual deles é maior. 
Utilize if, else if e else para exibir a mensagem adequada. 
Exemplo de Saída: "O primeiro número é maior.", "O segundo número é maior." ou "Os números são iguais." */



Console.WriteLine("Digite o primeiro número: ");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o primeiro número: ");
double num2 = double.Parse(Console.ReadLine());

Console.WriteLine("===============================");

if (num1 > num2)
{
    Console.WriteLine("O primeiro número é maior.");
}
else if (num1 < num2)
{
    Console.WriteLine("O segundo número é maior.");
}

else
{
    Console.WriteLine("Os números são iguais.");
}
