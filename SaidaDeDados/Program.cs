//aula 27
Console.WriteLine("Saída de dados: Formatação");
Console.WriteLine();

int idade = 25;
string nome = "Maria";
Console.WriteLine(nome);
Console.WriteLine(idade);
Console.WriteLine();

//Escrever na mesma linha
Console.Write(nome);
Console.Write(" tem ");
Console.Write(idade);
Console.Write(" anos");
Console.WriteLine();

//Usanso concatenação: usando o operador +
Console.WriteLine();
Console.WriteLine("--Concatenação--");
Console.WriteLine(nome + " tem " + idade + " anos");
Console.Write(nome + " tem " + idade + " anos");
Console.WriteLine();

//Usando interpolação de string:$ {}
Console.WriteLine();
Console.WriteLine("--Interpolação--");
Console.WriteLine($"{nome} tem {idade} anos");
Console.Write($"{nome} tem {idade} anos");
Console.WriteLine();

//Usando placeholders: usa {} com numeração
Console.WriteLine();
Console.WriteLine("--PlaceHolders--");
Console.WriteLine("{0} tem {1} anos", nome, idade);
Console.WriteLine("{0} tem {1} anos", idade, nome);

Console.ReadLine();