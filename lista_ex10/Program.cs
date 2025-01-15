/* Objetivo: Aplicar condições para cálculos. 
Descrição: Escreva um programa que peça o valor de uma compra e verifique se o valor é maior que 100.
Se sim, aplique um desconto de 10% no valor e mostre o valor final. Caso contrário, exiba o valor original. 
Exemplo de Saída: "Valor com desconto: [valor final]." ou "Valor original: [valor] */

Console.WriteLine("Digite o valor do produto: ");
double valor = double.Parse(Console.ReadLine());
int desconto = 10;
Console.Clear();

if (valor >= 100)
{
    double valorfinal = (valor - (valor * desconto) / 100);
    Console.WriteLine("Foi aplicado " + desconto + "% de desconto na sua compra e o valor final é: R$" + valorfinal);
}
else
{
    Console.WriteLine("O valor final da sua compra é: R$" + valor);
}