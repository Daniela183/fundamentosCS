//aula 31
Console.WriteLine("Entrada de dados\n");

Console.WriteLine("Informe seu nome\n");

string nome = Console.ReadLine();

Console.WriteLine("\nO seu nome é " + nome); //concatenação
Console.WriteLine($"O seu nome é {nome}"); //interpolação

Console.WriteLine();
Console.WriteLine("Informe a sua idade\n");

int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nA sua idade é " + idade + " anos"); //concatenação
Console.WriteLine($"A sua idade é {idade} anos\n"); //interpolação

//Testando conhecimento
Console.WriteLine("O seu nome é " + nome + " e você tem " + idade + " anos");//concatenação
Console.WriteLine($"O seu nome é {nome} e você tem {idade} anos");//interpolação


Console.ReadKey();