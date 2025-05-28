Console.WriteLine("Informe o 1° num: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o 2° num: ");
int num2 = int.Parse(Console.ReadLine());

int soma = (num1 + num2);
int subtracao = (num1 - num2);
int multiplicacao = (num1 * num2);
int divisao = (num1 / num2);

Console.WriteLine("\nO resultado dos números informados é\n");

Console.WriteLine($"{num1} + {num2} = {soma}");
Console.WriteLine($"{num1} - {num2} = {subtracao}");
Console.WriteLine($"{num1} * {num2} = {multiplicacao}");
Console.WriteLine($"{num1} / {num2} = {divisao}");




//------------------------------------------------------------
//        OUTRA FORMA DE FAZER


//Console.WriteLine("Informe o 1° num: ");
//double num1 = double.Parse(Console.ReadLine());
//Console.WriteLine("Informe o 2° num: ");
//double num2 = double.Parse(Console.ReadLine());

//double soma = num1 + num2;
//double subtracao = num1 - num2;
//double multiplicacao = num1 * num2;
//double divisao = num1 / num2;
//double resto = num1 % num2;

//Console.WriteLine("\nO resultado dos números informados é\n");

//Console.WriteLine($"{num1} + {num2} = {soma:f2}");  :f2 é as casas decimais
//Console.WriteLine($"{num1} - {num2} = {subtracao:f2}");
//Console.WriteLine($"{num1} * {num2} = {multiplicacao:f2}");
//Console.WriteLine($"{num1} / {num2} = {divisao:f2}");
//Console.WriteLine($"{num1} % {num2} = {resto:f2}");



