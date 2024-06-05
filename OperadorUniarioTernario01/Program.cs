//aula 41
Console.WriteLine("Operador Uniário e Ternário\n");
Console.WriteLine("Operador Uniário");

int positivo = 1;
int resultado;
resultado = +positivo;
Console.WriteLine(resultado);

Console.WriteLine("\nInforme o número:");
var n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"O negativo de {n} é {-n}\n");

Console.WriteLine("Operador Ternário");
Console.WriteLine("Informe a temperatura:");
var temp = Convert.ToDouble(Console.ReadLine());

var result = temp > 27 ? "Quente" : "Frio";
Console.WriteLine($"O tempo está {result}");

Console.WriteLine("\nAninhando Operador");
Console.WriteLine("Informe o valor de x:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y:");
int y = Convert.ToInt32(Console.ReadLine());

string res = x > y ? "x é maior que y" :
             x < y ? "x é menor que y" :
             x == y ? "x é igual a y" : 
             "Sem resultado";
Console.WriteLine(res);

Console.ReadKey();