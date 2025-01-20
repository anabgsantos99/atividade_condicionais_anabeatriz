// Ex 29. Somar Elementos

int[] numeros = { 1, 2, 3, 4 };
int soma = 0;

for (int i = 0; i < numeros.Length; i++)
{
    soma += numeros[i];
}
Console.WriteLine(soma);