public class Animal

{
    private string nome = "Toddy";
    private string raca = "Burder Coller";
    public void Comer()
    {
        Console.WriteLine("O animal esta comendo!");
    }

    public void DadosAnimal()
    {
        Console.WriteLine($"Nome: {this.nome}");
        Console.WriteLine($"Raça: {this.raca}");

    }

}


//Classe cachorro herda todos os atributos de metodo animal
public class Cachorro : Animal //2 pontos é para herdar a classe
{
    public void Latir()
    {
        Console.WriteLine("O cachorro está latindo!");
    }

}  
