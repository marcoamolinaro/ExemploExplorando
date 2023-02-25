using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Marco", sonbrenome: "Molinaro");
//p1.Nome = "Marco";
//p1.Sobrenome = "Molinaro";
//p1.Idade = 59;
//p1.Apresentar();

Pessoa p2 = new Pessoa(nome: "Aurelio", sonbrenome: "Molinaro");
//p2.Nome = "Aurelio";
//p2.Sobrenome = "Molinaro";
//p2.Idade = 60;

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);

cursoDeIngles.ListarAlunos();

