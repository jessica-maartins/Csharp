public class Forma
{
    public virtual void Desenhar()
    {
        Console.WriteLine("Desenhando uma forma genérica");
    }

}

public class Circulo : Forma
{
    public override void Desenhar() // override estou sobreescrevendo a classe de cima (forma)
    {
        Console.WriteLine("Desenhando um circulo");
    }
}
