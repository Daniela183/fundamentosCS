//aula 39
Console.WriteLine("Precedência de Operadores\n");
Console.WriteLine("Ordem de precedência 01");
int x = 10 - 2 * 3;
Console.WriteLine(x);

int y = (10 - 2) * 3;
Console.WriteLine(y);

Console.WriteLine("\nOrdem de precedência 02");
bool z = !(9 != 8) && (5 >= 7 || 8 >= 6);
Console.WriteLine(z);

Console.WriteLine("\nOrdem de precedência 03");
int a = 5, b = 6, c = 4;
int r = --a * b - ++c;
Console.WriteLine(r);

Console.WriteLine("\nPrecedência e associatividade");
int d = 5, e = 6, f = 3;
int resultado = d = e = f;
Console.WriteLine(resultado);

Console.ReadKey();
