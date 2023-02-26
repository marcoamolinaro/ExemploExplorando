using ExemploExplorando.Models;

// Pessoa p1 = new Pessoa(nome: "Marco", sonbrenome: "Molinaro");
// //p1.Nome = "Marco";
// //p1.Sobrenome = "Molinaro";
// //p1.Idade = 59;
// //p1.Apresentar();

// Pessoa p2 = new Pessoa(nome: "Aurelio", sonbrenome: "Molinaro");
// //p2.Nome = "Aurelio";
// //p2.Sobrenome = "Molinaro";
// //p2.Idade = 60;

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);

// cursoDeIngles.ListarAlunos();

// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);

using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
decimal valorMonetario = 1482.40M;

//Console.WriteLine($"{valorMonetario:C}");
//Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
Console.WriteLine(valorMonetario.ToString("C1"));
Console.WriteLine(valorMonetario.ToString("C2"));
Console.WriteLine(valorMonetario.ToString("C3"));

Console.WriteLine(valorMonetario.ToString("N1"));
Console.WriteLine(valorMonetario.ToString("N2"));
Console.WriteLine(valorMonetario.ToString("N3"));

double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P"));

int cep = 20250070;
Console.WriteLine(cep.ToString("#####-###"));

DateTime data = DateTime.Now;
Console.WriteLine(data);
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(data.ToString("dd/MM/yyyy hh:mm"));
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());

DateTime data1 = DateTime.Parse("25/02/2023 21:37");
Console.WriteLine(data1);

/*
DateTime data2 = DateTime.Parse("32/02/2023 21:37");
Console.WriteLine(data2);
Unhandled exception. System.FormatException: String '32/02/2023 21:37' was not recognized as a valid DateTime.
   at System.DateTime.Parse(String s)
   at Program.<Main>$(String[] args) in C:\Users\Marco A Molinaro\Desenvolvedor\DIO\ExemploExplorando\Program.cs:line 62
*/

string dataString = "2023/02/25 21:41";
DateTime data3 = DateTime.Parse(dataString);
Console.WriteLine(data3);

/*
string dataString1 = "2023/13/25 21:41";
DateTime data4 = DateTime.Parse(dataString1);
Console.WriteLine(data4);
Unhandled exception. System.FormatException: String '2023/13/25 21:41' was not recognized as a valid DateTime.
   at System.DateTime.Parse(String s)
   at Program.<Main>$(String[] args) in C:\Users\Marco A Molinaro\Desenvolvedor\DIO\ExemploExplorando\Program.cs:line 75
*/

string dataString1 = "2023/13/25 21:41";

bool sucesso = DateTime.TryParseExact(dataString1,
                                        "yyyy/MM/dd HH:mm",
                                        CultureInfo.InvariantCulture,
                                        DateTimeStyles.None,
                                        out DateTime data4);
if (sucesso)
{
    Console.WriteLine($"Conversão da data {data4} com sucesso!");
}
else 
{
    Console.WriteLine($"A data {dataString1} é inválida");
}

string dataString2 = "2023/02/25 21:41";

bool sucesso1 = DateTime.TryParseExact(dataString2,
                                        "yyyy/MM/dd HH:mm",
                                        CultureInfo.InvariantCulture,
                                        DateTimeStyles.None,
                                        out DateTime data5);
if (sucesso1)
{
    Console.WriteLine($"Conversão da data {data5} com sucesso!");
}
else 
{
    Console.WriteLine($"A data {dataString2} é inválida");
}
