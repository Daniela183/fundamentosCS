//aula 37
Console.WriteLine("Operadores Relacionais\n");
Console.WriteLine("\nUsando os operadores\n");
int x = 10;
int y = 20;

Console.WriteLine($"Valor de x {x}");
Console.WriteLine($"Valor de y {y}");

Console.WriteLine(x == y);
Console.WriteLine(x > y);
Console.WriteLine(x < y);
Console.WriteLine(x >= y);
Console.WriteLine(x <= y);
Console.WriteLine(x != y);

Console.WriteLine("\nUsando a string\n");

string a = "Curso";
string b = "curso";
Console.WriteLine(a == b);
Console.WriteLine(a.Equals(b));

Console.ReadKey();