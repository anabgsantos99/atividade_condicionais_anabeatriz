// Ex. 28 Criar e Imprimir um Array


int[] numero = {10,20,30,40,50};
string[] nome = { "Ana", "Beatriz", "Pedro", "João" };

for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine(numero[i]);   
}

for (int i = 0; i < nome.Length; i++)
{
    Console.WriteLine(nome[i]);
}

Console.WriteLine("O nome na posição 2 é: " + nome[2]);
Console.WriteLine("O número na posição 2 é: " + numero[2]);