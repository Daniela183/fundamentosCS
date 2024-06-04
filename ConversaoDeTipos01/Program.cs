using Microsoft.VisualBasic;

Console.WriteLine("Conversão de tipos I \n");

//Conversão implícita sempre será possível
int varInt = 100;
double varDouble = varInt;
Console.WriteLine(varDouble);
Console.WriteLine();

int numeroInt = 2145678;
long numeroLong = numeroInt;
float numeroFloat = numeroInt;
double numeroDouble = numeroInt;
decimal numeroDecimal = numeroInt;

Console.WriteLine(numeroInt);
Console.WriteLine(numeroLong);
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroDecimal);

Console.WriteLine("\nConversão forçada");

double varDoublle = 12.456;     //8 bytes
int varIntt = (int)varDoublle;  //4 bytes (perda de precisão)
Console.WriteLine(varIntt);

Console.WriteLine("\nConversão explícita"); 
int num1 = 10;
int num2 = 4;
float resultado = (float) num1 / num2;
Console.WriteLine(resultado);

//Coversão usando métodos
Console.WriteLine("\nConversão de tipos II \n");

int valorInt = 123;
double valorDouble = 12.45;
decimal valorDecimal = 12.45678m;

string s1 = valorInt.ToString();
string s2 = valorDouble.ToString();
string s3 = valorDecimal.ToString();

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);
Console.WriteLine();

int varlInt = 10;
double varlDouble = 5.35;
bool varlBool = true;

Console.WriteLine(Convert.ToString(varlInt));
Console.WriteLine(Convert.ToDouble(varlInt));
Console.WriteLine(Convert.ToString(varlBool));
Console.WriteLine(Convert.ToInt32(varlDouble));

Console.WriteLine("\nConversão com perdas de dados");
Console.WriteLine("Dá mensagem de erro\n");
int varInnt = 100000;
Console.WriteLine(Convert.ToByte(varInnt));

Console.ReadLine();