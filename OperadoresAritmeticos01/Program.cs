Console.WriteLine("Operadores Aritméticos\n");

Console.WriteLine("Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nInforme o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n---Class math---");
Console.WriteLine($"Raiz quadrada de x = {Math.Sqrt(x)}");
Console.WriteLine($"A potência de x elevado a y = {Math.Pow(x,y)}");
Console.WriteLine($"O valor mínimo entre x e y = {Math.Min(x,y)}");
Console.WriteLine($"O valor máximo entre x e y = {Math.Max(x, y)}");
Console.WriteLine($"O cosseno de x = {Math.Cos(x)}");
Console.WriteLine($"O seno de x = {Math.Sin(x)}");
Console.WriteLine($"O exponencial de x = {Math.Exp(x)}");

Console.WriteLine("\n---Operações simples---");
Console.WriteLine($"A soma de x + y = {x+y}");
Console.WriteLine($"A subtração de x - y = {x - y}");
Console.WriteLine($"A multiplicação de x * y = {x * y}");
double divisao = (double)x / y;
Console.WriteLine($"A divisão de x / y = {divisao}");
Console.WriteLine($"O módulo de x % y = {x % y}");

Console.ReadKey();
