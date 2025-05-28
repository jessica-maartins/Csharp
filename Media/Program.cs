Console.WriteLine("Digite a 1° nota: ");
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a 2° nota: ");
double nota2 = double.Parse(Console.ReadLine());

double media = ((nota1 + nota2) / 2);
Console.WriteLine($"A média é { media}");

if (media >= 7)
{
    Console.WriteLine("Aluno APROVADO :)");
}
else
{
    Console.WriteLine("Aluno REPROVADO :(");
}

//------------------------------------------------------------
//        OUTRA FORMA DE FAZER ESSA CONTA 

//double nota1 = double.Parse(Console.ReadLine());
//double nota2 = double.Parse(Console.ReadLine());
//double media = ((nota1 + nota2) / 2);

//string mensagem = media >= 7 ? "APROVADO" : "REPROVADO";

//Console.WriteLine($"A média é {media} | voce foi {mensagem}");

//Se eu quiser casas decimais eu uso essa estrutura abaixo (.ToString("F"))

//Console.WriteLine($"A média é {media.ToString("F")} | voce foi {mensagem}");