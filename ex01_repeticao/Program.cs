/*1.Um funcionário deseja contar quantos dias de trabalho ele teve em um mês. 
 * Para isso, ele deve inserir os dias trabalhados (de 1 a 31) até que digite 0, que indica que terminou de informar os dias. 
 O aluno deve implementar essa contagem utilizando as estruturas de repetição while, do while e for.*/

using static System.Runtime.InteropServices.JavaScript.JSType;

int dia;
int contagem = 0;

Console.WriteLine("while===========================================");

Console.WriteLine("Digite os dias trabalhados. Digite 0 para finalizar.");

dia = int.Parse(Console.ReadLine());

while (dia != 0)
{
    contagem++;
    dia = int.Parse(Console.ReadLine());
}

Console.WriteLine("Dias trabalhados " + contagem);

Console.WriteLine("do while===========================================");

int diadw;
int contagemdw = 0;

Console.WriteLine("Digite os dias trabalhados. Digite 0 para finalizar.");

diadw = int.Parse(Console.ReadLine());

do
{
    contagemdw++;
    diadw = int.Parse(Console.ReadLine());
}

while (diadw != 0);

Console.WriteLine("Dias trabalhados " + contagemdw);

Console.WriteLine("for===========================================");

int diaf;
int contagemf = 0;

Console.WriteLine("Digite os dias trabalhados. Digite 0 para finalizar.");

diaf = int.Parse(Console.ReadLine()); 

for (; ; )
{
    diaf = int.Parse(Console.ReadLine());
    contagemf++;
    if (diaf == 0) break; // sai do loop se o usuário digitar 0
}
Console.WriteLine("Dias trabalhados " + contagemf);