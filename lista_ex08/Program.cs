/* Objetivo: Compreender a lógica de permissões baseadas em condições. 
Descrição: Crie um programa que pergunte a idade de uma pessoa e determine se ela pode votar (idade >= 16). 
Utilize uma condição if para exibir a mensagem correspondente. 
Exemplo de Saída: "Você pode votar." ou "Você não pode votar." */

Console.WriteLine("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

Console.Clear();

if (idade < 16)
{
    Console.WriteLine("Você não pode votar, pois não tem idade mínima.");
}
else if (idade > 16 && idade < 18 )
{
    Console.WriteLine("Você pode votar! Voto opcional.");
}
else if (idade >= 18 && idade <= 60)
{
    Console.WriteLine("Você pode votar! Voto obrigatório.");
}
else 
{
    Console.WriteLine("Você pode votar! Voto opcional.");
}