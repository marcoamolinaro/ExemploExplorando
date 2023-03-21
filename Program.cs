using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;

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

// 

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
// decimal valorMonetario = 1482.40M;

// //Console.WriteLine($"{valorMonetario:C}");
// //Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
// Console.WriteLine(valorMonetario.ToString("C1"));
// Console.WriteLine(valorMonetario.ToString("C2"));
// Console.WriteLine(valorMonetario.ToString("C3"));

// Console.WriteLine(valorMonetario.ToString("N1"));
// Console.WriteLine(valorMonetario.ToString("N2"));
// Console.WriteLine(valorMonetario.ToString("N3"));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int cep = 20250070;
// Console.WriteLine(cep.ToString("#####-###"));

// DateTime data = DateTime.Now;
// Console.WriteLine(data);
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
// Console.WriteLine(data.ToString("dd/MM/yyyy hh:mm"));
// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());

// DateTime data1 = DateTime.Parse("25/02/2023 21:37");
// Console.WriteLine(data1);

// /*
// DateTime data2 = DateTime.Parse("32/02/2023 21:37");
// Console.WriteLine(data2);
// Unhandled exception. System.FormatException: String '32/02/2023 21:37' was not recognized as a valid DateTime.
//    at System.DateTime.Parse(String s)
//    at Program.<Main>$(String[] args) in C:\Users\Marco A Molinaro\Desenvolvedor\DIO\ExemploExplorando\Program.cs:line 62
// */

// string dataString = "2023/02/25 21:41";
// DateTime data3 = DateTime.Parse(dataString);
// Console.WriteLine(data3);

// /*
// string dataString1 = "2023/13/25 21:41";
// DateTime data4 = DateTime.Parse(dataString1);
// Console.WriteLine(data4);
// Unhandled exception. System.FormatException: String '2023/13/25 21:41' was not recognized as a valid DateTime.
//    at System.DateTime.Parse(String s)
//    at Program.<Main>$(String[] args) in C:\Users\Marco A Molinaro\Desenvolvedor\DIO\ExemploExplorando\Program.cs:line 75
// */

// string dataString1 = "2023/13/25 21:41";

// bool sucesso = DateTime.TryParseExact(dataString1,
//                                         "yyyy/MM/dd HH:mm",
//                                         CultureInfo.InvariantCulture,
//                                         DateTimeStyles.None,
//                                         out DateTime data4);
// if (sucesso)
// {
//     Console.WriteLine($"Conversão da data {data4} com sucesso!");
// }
// else 
// {
//     Console.WriteLine($"A data {dataString1} é inválida");
// }

// string dataString2 = "2023/02/25 21:41";

// bool sucesso1 = DateTime.TryParseExact(dataString2,
//                                         "yyyy/MM/dd HH:mm",
//                                         CultureInfo.InvariantCulture,
//                                         DateTimeStyles.None,
//                                         out DateTime data5);
// if (sucesso1)
// {
//     Console.WriteLine($"Conversão da data {data5} com sucesso!");
// }
// else 
// {
//     Console.WriteLine($"A data {dataString2} é inválida");
// }


// Exceções e Coleções com C#

// try 
// {
//     string[] linhas = File.ReadAllLines("Arquivos/pasta1/arquivo_leitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// } 
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Arquivo de leitura não encontrado! {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Pasta do Arquivo de leitura não encontrado! {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica! {ex.Message}");
// }

// Tuplas
// (int, string, string, decimal) tupla = (1, "Marco", "Molinaro", 10.05M);

// Console.WriteLine($"Id: {tupla.Item1}, Nome: {tupla.Item2}, Sobrenome: {tupla.Item3}, Valor: {tupla.Item4}");

// ValueTuple<int, string, string, decimal> outraFormaTupla = (1, "Marco", "Molinaro", 10.05M);

// Console.WriteLine($"Id: {outraFormaTupla.Item1}");
// Console.WriteLine($"Nome: {outraFormaTupla.Item2}");
// Console.WriteLine($"Sobrenome: {outraFormaTupla.Item3}");
// Console.WriteLine($"Valor: {outraFormaTupla.Item4}");

// var outraFormaTupla2 = Tuple.Create(1, "Marco", "Molinaro", 10.05M);

// Console.WriteLine($"Id: {outraFormaTupla2.Item1}");
// Console.WriteLine($"Nome: {outraFormaTupla2.Item2}");
// Console.WriteLine($"Sobrenome: {outraFormaTupla2.Item3}");
// Console.WriteLine($"Valor: {outraFormaTupla2.Item4}");

// LeituraArquivo arquivo = new LeituraArquivo();

// //var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoleitura.txt");
// // Exemplo de descarte
// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoleitura.txt");

// if (sucesso)
// {
//     //Console.WriteLine($"Quantidade Linhas lidas: {quantidadeLinhas}");

//     foreach (string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }

// Exemplo descostrutor
// Pessoa p1 = new Pessoa("Marco", "Molinaro");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");

// Exemplo if ternário
// int numero = 15;
// bool ehPar = false;

// ehPar = numero % 2 == 0;

// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar"));

// Serialização / Deserialização

// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de Escritório", 200.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 2000.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);


// string serialiado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// Console.WriteLine(serialiado);

// File.WriteAllText("Arquivos/Vendas.json", serialiado);

// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVendas)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}" +
//         $", Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
// }

// Tipo Nulo
// bool? desejaReceberEmail = null;

// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value) 
// {
//     Console.WriteLine("O usuário optou por receber e-mail.");
// }
// else 
// {
//     Console.WriteLine("O usuário não respondeu ou optou por não receber e-mail.");
// }

// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVendas)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}" +
//         $", Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}" +
//         $"{(venda.Desconto.HasValue ? $", Desconto de: {venda.Desconto}" : "")}");
// }

// Tipos anonimos
// var tipoAnonimo = new {Nome = "Marco", Sobrenome = "Molinaro", Altura = 1.63};

// Console.WriteLine($"Nome: {tipoAnonimo.Nome}");
// Console.WriteLine($"Sobrenome: {tipoAnonimo.Sobrenome}");
// Console.WriteLine($"Altura: {tipoAnonimo.Altura}");

// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// var listaAnonimo = listaVendas.Select(v => new {v.Produto, v.Preco});

// foreach (var venda in listaAnonimo)
// {
//     Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
// }

// Tipos Dinâmicos

// dynamic variavelDinamica = 4;

// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = "Texto";

// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = true;

// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// Classe Genérica

// MeuArray<int> arrayInteiro = new MeuArray<int>();

// arrayInteiro.AdicionarElementoArray(30);

// Console.WriteLine(arrayInteiro[0]);

// MeuArray<string> arrayString = new MeuArray<string>();

// arrayString.AdicionarElementoArray("Marco");

// Console.WriteLine(arrayString[0]);


// Métodos de extensão

int numero = 15;
bool par = false;

par = numero.EhPar();

string mensagem = "O número " + numero + " " + "é " + (par ? "par" : "impar");

Console.WriteLine(mensagem);