using System;
using System.ComponentModel.Design;

ExibirMensagem();
somar(10,5);
EhPar(12);
CalcularMedia(5.4,4.2);

void ExibirMensagem() // void é vazia, serve para exibir a mensagem
{
    Console.WriteLine("Função mensagem");
}
int somar(int a, int b)
{
    Console.WriteLine(a + b);
    return a + b;
}

bool EhPar(int numero)
{
    if (numero % 2 == 0)
    {
        Console.WriteLine(true);
        return true;
    }
    else
    {
        Console.WriteLine(false);
        return false;
    }
}
double CalcularMedia(double n1, double n2)
{
    Console.WriteLine(((n1 + n2)/2).ToString("F"));
    return (n1 + n2) / 2;
}
    
