public abstract class Funcionario
{
    public string Nome;
    public abstract void CalcularSalario();
}
public class Gerente : Funcionario
{
    public override void CalcularSalario()
    {
        Console.WriteLine($"Salário do Gerente: R$ 5.000,00");
    }
}
