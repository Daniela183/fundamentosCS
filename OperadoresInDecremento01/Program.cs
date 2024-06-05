//aula 36
Console.WriteLine("Operadores de Incremento e Decremento\n");

Console.WriteLine("Incremento");
Console.WriteLine("Usando o operador ++");
int w = 10;
w++;
Console.WriteLine(w);

Console.WriteLine("Usando a operação x = x + 1");
int x = 10;
x = x + 1;
Console.WriteLine(x);

Console.WriteLine("\nDecremento");
Console.WriteLine("Usando o operador --");
int y = 10;
y--;
Console.WriteLine(y);
Console.WriteLine("Usando a operação z = z - 1");
int z = 10;
z = z - 1;
Console.WriteLine(z); 

Console.WriteLine("\n-------------------------");
//Pós-incremento -> resolve primeiro e depois incrementa
Console.WriteLine("\nPós-incremento");

int a = 0;
Console.WriteLine($"a = {a}");

int resultado01 = a++ + 10;
Console.WriteLine($"Pós-incremento ==> {resultado01}");
Console.WriteLine($"Valor de a ==> {a}");

//Pré-incremento -> incrementa primeiro e depois resolve
Console.WriteLine("\nPré-incremento");

int b = 0;
Console.WriteLine($"b = {b}");

int resultado02 = ++b + 10;
Console.WriteLine($"Pré-incremento ==> {resultado02}");
Console.WriteLine($"Valor de b ==> {b}");

Console.WriteLine("\n-------------------------");

Console.WriteLine("\nPós-decremento");

int c = 0;
Console.WriteLine($"c = {c}");

int resultado03 = c-- + 10;
Console.WriteLine($"Pós-decremento ==> {resultado03}");
Console.WriteLine($"Valor de c ==> {c}");

//Pré-incremento -> incrementa primeiro e depois resolve
Console.WriteLine("\nPré-decremento");

int d = 0;
Console.WriteLine($"d = {d}");

int resultado04 = --d + 10;
Console.WriteLine($"Pré-decremento ==> {resultado04}");
Console.WriteLine($"Valor de d ==> {d}");

Console.ReadKey();