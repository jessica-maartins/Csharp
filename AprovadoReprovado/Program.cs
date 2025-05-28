Console.WriteLine("Digite uma nota: ");
double nota = double.Parse(Console.ReadLine());

if (nota >= 7)
{
    Console.WriteLine($"Sua nota é {nota} você está APROVADO :)");
}
else
{
    Console.WriteLine($"Sua nota é {nota} você está REPROVADO :( ");
}