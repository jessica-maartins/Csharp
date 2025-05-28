Console.WriteLine("Informe a posição: ");
int posicao = int.Parse(Console.ReadLine());

switch (posicao)
{
    case 1:
        Console.WriteLine("Ouro");
        break;
    case 2:
        Console.WriteLine("Prata");
        break;
    case 3:
        Console.WriteLine("Bronze");
        break;

    default:
        Console.WriteLine("Sem Medalha");
        break;
}