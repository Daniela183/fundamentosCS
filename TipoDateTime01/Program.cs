Console.WriteLine("## Struct DateTime ##\n");

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);
Console.WriteLine();

//Data específica usando formato: aaaa,mm,dd
DateTime dataHoje = new DateTime(2024, 05, 29);
Console.WriteLine(dataHoje);
Console.WriteLine();

//Definindo horas
DateTime dataHoraHoje = new DateTime(2024, 05, 29, 15, 04, 31);
Console.WriteLine(dataHoraHoje);
Console.WriteLine();

Console.WriteLine("--------Data----------");

//Extraindo informações de data e hora
DateTime hoje = DateTime.Now;

Console.WriteLine(hoje.Year);
Console.WriteLine(hoje.Month);
Console.WriteLine(hoje.Day);

Console.WriteLine("--------Hora----------");
Console.WriteLine(hoje.Hour);
Console.WriteLine(hoje.Minute);
Console.WriteLine(hoje.Second);
Console.WriteLine(hoje.Millisecond);
Console.WriteLine();

//Adicionando valores
Console.WriteLine("## Adicionando valores ##\n");
Console.WriteLine(hoje.AddDays(30));
Console.WriteLine(hoje.AddMonths(1));
Console.WriteLine(hoje.AddHours(2));
Console.WriteLine(hoje.AddYears(5));
Console.WriteLine();

//Obtendo o dia da semana e o ano
Console.WriteLine("## Dia da semana e quantidade de dias do ano ##\n");
Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.DayOfYear);
Console.WriteLine();
//Data no formato longo e curto
Console.WriteLine("## Data-formato longo e curto## \n");
Console.WriteLine(hoje.ToLongDateString());
Console.WriteLine(hoje.ToShortDateString());
Console.WriteLine();

//Hora no formato longo e curto
Console.WriteLine("## Hora-formato longo e curto ##\n");
Console.WriteLine(hoje.ToLongTimeString());
Console.WriteLine(hoje.ToShortTimeString());
Console.ReadKey();
