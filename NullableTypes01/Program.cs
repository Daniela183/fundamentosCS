//aula 24
Console.WriteLine("Nullable Types \n");

//Não pode atribuir valor null para int
//int valor = null;
//Console.WriteLine(valor);

//Sintaxe padrão
Nullable<int> a = null;
Nullable<double> b = null;
Nullable<bool> c = null ;

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine("Não aparece erro por conta da sintaxe!");

//Sintaxe simplificada
int? d = null;
double? e = null;
bool? f = null;

Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);
Console.WriteLine("Não aparece erro por conta da sintaxe!\n");

int? g = 1;
int h = g ?? 0;
Console.WriteLine(g);
Console.WriteLine();

Console.WriteLine("Atribuição por expresão\n");
int? x = 4;
int? y = 3;
int? z = x * y;
Console.WriteLine(z);

Console.WriteLine("HasValue\n");
int? w = 100;
if (w.HasValue)
{
    Console.WriteLine($"w = {w.Value}");
}
else
{
    Console.WriteLine("w não possui valor! (é null)");
}
Console.ReadKey();
