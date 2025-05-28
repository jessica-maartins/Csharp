Console.WriteLine("Insira um número inteiro: ");
int num = int.Parse(Console.ReadLine());



for (int i = 1; i <=10; i++) // criei uma variavel int i = 1 (o um é o numero que vai começar a tabuada).Se i for menor ou igual 10 vai acrescentar +1 (i++)
{
    Console.WriteLine($"{num} x {i} = {num*i}"); // numero digitado x i (inteirador que começa com 1) = numero digitado * inteirador 
}

