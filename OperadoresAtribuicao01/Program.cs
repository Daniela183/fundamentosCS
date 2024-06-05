//aula 34
using System.Drawing;
Console.WriteLine("Operadores de Atribuição\n");

//Usando operadores atribuição com tipos numéricos
Console.WriteLine("Usando o var");

var x = 10;

Console.WriteLine($"Valor inicial de x = {x}");
Console.WriteLine($"x += 5 ==> {x += 5}");
Console.WriteLine($"x -= 3 ==> {x -= 3}");
Console.WriteLine($"x *= 4 ==> {x *= 4}");
Console.WriteLine($"x /= 5 ==> {x /= 5}");
Console.WriteLine($"x %= 5 ==> {x %= 5}");
Console.WriteLine();

Console.WriteLine("Usando o float");

float y = 10;

Console.WriteLine($"Valor inicial de y = {y}");
Console.WriteLine($"y += 5 ==> {y += 5}");
Console.WriteLine($"y -= 3 ==> {y -= 3}");
Console.WriteLine($"y *= 4 ==> {y *= 4}");
Console.WriteLine($"y /= 5 ==> {y /= 5}");
Console.WriteLine($"y %= 5 ==> {y %= 5}");

Console.WriteLine("\nUsando o operdador com string\n");

var z = 123;
Console.WriteLine($"Valor inicial de z = {z}");
Console.WriteLine($"z += \"456\" ==>  {z.ToString() + "456"}");

string w = null;
Console.WriteLine($"\nValor inicial de w = {w}");
Console.WriteLine($"w += \"456\" ==> {w += 456} ");

Console.ReadKey();
