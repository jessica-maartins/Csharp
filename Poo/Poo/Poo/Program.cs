// Programação Orientada a Objetos
// Classes, atributos e métodos.

using poo;

Pessoa pessoa = new Pessoa();


// Recebendo os valores para os atributos do objeto pessoa
//pessoa.nome = Console.ReadLine();
//pessoa.idade = int.Parse(Console.ReadLine());

// Atribuindo valores para os atributos do objetos diretamente
pessoa.nome = "nome";
pessoa.idade = 2025;


// Acessando o método da classe pessoa.
pessoa.Apresentar();


// ---- Encapsulamento ---- //

ContaBancaria conta = new ContaBancaria();
conta.Depositar(1000);
conta.Depositar(550.75);
conta.Sacar(10.75);

Console.WriteLine($"R${conta.ConsultarSaldo()}");

//---------------------Herança--------------------
Cachorro dog = new Cachorro();
dog.Comer();
dog.Latir();
dog.DadosAnimal();


//---------------------Polimorfismo---------------
Forma forma = new Circulo(); 
forma.Desenhar();


//-------------------Abstração--------------------
Funcionario funcionario = new Gerente();
funcionario.CalcularSalario();  
