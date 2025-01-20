

// 30. Encontra o maior número

int[] numeros = { 10, 5, 8, 12, 1, 7 };
int maior = numeros[0];

for (int i = 1; i < numeros.Length; i++)
{
    if (numeros[i] > maior)
    {
        maior = numeros[i];
    }
}
Console.WriteLine(maior);
