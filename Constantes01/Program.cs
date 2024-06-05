//aula 35
Console.WriteLine("Constantes\n");

//Ano 
Console.WriteLine("Usando const para dividir os dias pelos meses do ano");
const int ANO = 12;

const int MES = 30, SEMANA = 7, QUINZENA = 15;

const int MESES_ANO = 12;
const int DIAS_ANO = 365;

const float DIAS_POR_MES = (float)DIAS_ANO/(float)MESES_ANO;

Console.WriteLine(DIAS_POR_MES);

//Calculo da área e perimetro de um circulo
double raio, perimetro, area;
const double PI = 3.14;

Console.WriteLine("\nUsando somente PI");
Console.WriteLine("Informe o raio do círculo:");
raio = Convert.ToDouble(Console.ReadLine());

perimetro = 2 * PI * raio;
area = PI * raio * raio;

Console.WriteLine($"Peímetro = {perimetro}");
Console.WriteLine($"Área = {area}");

//outra forma usando o math

double raio1, perimetro1, area1;
const double PII = 3.14;

Console.WriteLine("\nUsando o Math");
Console.WriteLine("Informe o raio do círculo");
raio1 = Convert.ToDouble(Console.ReadLine());

perimetro1 = 2 * Math.PI * raio1;
area1 = Math.PI * Math.Pow(raio1,2);

Console.WriteLine($"Peímetro = {perimetro1}");
Console.WriteLine($"Área = {area1}");

Console.ReadKey();