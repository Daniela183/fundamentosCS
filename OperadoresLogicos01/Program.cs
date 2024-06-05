//aula38
Console.WriteLine("Operadores Lógicos");

bool c1 = 5 >= 7;
bool c2 = 9 != 8;
bool resultado;

Console.WriteLine($"c1 = {c1}");
Console.WriteLine($"c2 = {c2}\n");

//Console.WriteLine("Operador AND -> &&");
resultado = c1 && c2;
Console.WriteLine("Operador AND(&&): " + resultado);

//Console.WriteLine("Operador OR -> ||");
resultado = c1 || c2;
Console.WriteLine("Operador OR(||): " + resultado);

//Console.WriteLine("Operador NOT -> !");
resultado = !c1;
Console.WriteLine("Operador NOT(!) c1: " + resultado);

resultado = !c2;
Console.WriteLine("Operador NOT(!) c2: " + resultado);

Console.ReadKey();