//aula 33
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Inferência de Tipos (Var)\n");

int idade = 25;
string nome = "Maria";
decimal salario = 25000.00m;

var idade1 = 27;
var nome1 = "Luis";
var salario1 = 15000.00m;

Console.WriteLine($"{nome} tem {idade} anos e ganha {salario.ToString("c")}"); //inter
Console.WriteLine($"{nome1} tem {idade1} anos e ganha {salario1.ToString("c")}"); //inter

//var limitação
//var salario = null;
//var titulo;
//var salario, imposto, total;

//não posso mudar o tipo apos iniciar
var num = 10;
num = num + 20;
//num = "Teste";

var teste = new Teste();
teste.MeuMetodo();
Console.ReadKey();
class Teste
{
    public void MeuMetodo()
    {
        Console.WriteLine("\nMeu Método");
    }
}
