// Calcular que recebe 2 numeros e apresenta + - * /

Console.WriteLine("Escreva o primeiro número: ");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Escreva o Segundo número: ");
int numero2 = int.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine("+ : " + (numero1 + numero2));
Console.WriteLine("- : " + (numero1 - numero2));
Console.WriteLine("* : " + (numero1 * numero2));

// Verfica se o segundo númer é diferente de zero antes de realizar a divisão

if (numero2 != 0)
{
    Console.WriteLine("/ : " + (numero1 / numero2));
}
else
{
    Console.WriteLine("/ : DIVISÃO POR ZERO NÃO É PERMITIDA");
}

Console.WriteLine("==========================");
Console.WriteLine("Os numero são iguais? " + (numero1 == numero2));
Console.WriteLine("Numero1 é maior Numero 2? " + (numero1 > numero2));
Console.WriteLine("Numero1 é menor Numero 2? " + (numero1 < numero2));
Console.WriteLine("Numero1 é maior igual Numero 2? " + (numero1 >= numero2));
Console.WriteLine("Numero1 é menor igual Numero 2? " + (numero1 <= numero2));