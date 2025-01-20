// Ex: 24 Implemente um programa que permita ao usuário inserir números inteiros. O programa deve continuar solicitando números até que o usuário digite 0. // Ao final, quando 0 for digitado, o programa deve calcular e exibir a soma de todos os números inseridos (exceto o 0).

int soma = 0;
int numero;
Console.WriteLine("Digite um número (o para sair): ");

for (; ; )
{
    
    numero = Convert.ToInt32(Console.ReadLine()); // mesma função do int.parse
    if (numero == 0) break; // sai do loop se o usuário digitar 0
    soma += numero; // adiciona número à soma
}
Console.WriteLine("Soma total " + soma);