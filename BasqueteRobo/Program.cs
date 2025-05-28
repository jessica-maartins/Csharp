Console.WriteLine("Pontuação robô 1: ");
double robo1 = double.Parse(Console.ReadLine());
Console.WriteLine("Pontuação robô 2: ");
double robo2 = double.Parse(Console.ReadLine());





if (robo1 > robo2) //SE
   {
    Console.WriteLine($"{robo1} X {robo2} = Robô 1 é o vencedor!");
   }
else if (robo1 < robo2) //CASO
{
    Console.WriteLine($"{robo1} X {robo2} = Robô 2 é o vencedor!");
}
else //SE NÃO
{
    Console.WriteLine($"{robo1} X {robo2} = EMPATE!");
}


//------------------------------------------------------------
//        OUTRA FORMA DE FAZER

//Console.WriteLine("Pontuação robô 1: ");
//double robo1 = double.Parse(Console.ReadLine());
//Console.WriteLine("Pontuação robô 2: ");
//double robo2 = double.Parse(Console.ReadLine());

//string msg = robo1 > robo2 ? "Robô 1 é o vencedor!" : robo2 > robo1 ? "Robô 2 é o vencedor!" : "Empate!";




