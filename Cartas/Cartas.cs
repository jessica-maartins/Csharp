Console.WriteLine("Informe a carta 1 (1 à 13): ");
double carta1 = double.Parse(Console.ReadLine());
Console.WriteLine("Informe a carta 2 (1 à 13): ");
double carta2 = double.Parse(Console.ReadLine());

if (carta1 > carta2)
{
    Console.WriteLine($"{carta1} X {carta2} = Carta 1 é maior!");
}
else if (carta1 < carta2)
{
    Console.WriteLine($"{carta1} X {carta2} = arta 2 é maior!");
}
else
{
    Console.WriteLine($"{carta1} X {carta2} = EMPATE!");
}








