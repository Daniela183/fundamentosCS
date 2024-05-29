//aula 22
Console.WriteLine("Definindo variáveis do tipo string, object e dynamic");
Console.WriteLine();

string nome = "Curso C#";
String titulo = "Curso C# Essencial";

Console.WriteLine(nome);
Console.WriteLine(titulo);
Console.WriteLine();

string valor = "Isto é uma string";
valor = "Isto é uma string alterada";
valor = "Teste";
Console.WriteLine();

//String Builder

object nota = 10;
object valor1 = 8.55m;
object nome1 = "Maria";
object ativa = true;
object leta = 'A';

Console.WriteLine(nota);
Console.WriteLine(valor1);
Console.WriteLine(nome1);
Console.WriteLine(ativa);
Console.WriteLine(leta);
Console.WriteLine();

dynamic nota2 = 8;
dynamic valor2 = 9.05m;
dynamic nome2 = "João";
dynamic ativa1 = false;
dynamic leta1 = 'B';

Console.WriteLine(nota2);
Console.WriteLine(valor2);
Console.WriteLine(nome2);
Console.WriteLine(ativa1);
Console.WriteLine(leta1);

Console.ReadLine();