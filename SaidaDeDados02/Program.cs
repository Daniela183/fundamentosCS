Console.WriteLine("Saída de dados: Usando sequência de escapes \n");

//Para usar \ deve colocar outra para interpretar
string local = "c:\\dados\\poesia.txt";
Console.WriteLine(local);
Console.WriteLine();

//Para usar "" dentro de "" deve colocar \ para interpretar
string frase = "Ele falou: \"Não foi eu\"";
Console.WriteLine(frase);
Console.WriteLine();

string pizza = "\nPizza\nde\nMussarela";
Console.WriteLine(pizza);

string bolo = "\nBolo\tde\tChocolate";
Console.WriteLine(bolo);


Console.ReadLine();
