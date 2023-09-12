using ExemploExplorando.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Pedro";
p1.Sobrenome = "Dias";
p1.Idade = 21;

Pessoa p2 = new Pessoa();
p2.Nome = "Jose";
p2.Sobrenome = "Pedro";
p2.Idade = 21;

Pessoa p3 = new Pessoa();
p3.Nome = "Kleber";
p3.Sobrenome = "Junior";
p3.Idade = 21;

Curso curso = new Curso();
curso.Nome = "Curso de Inglês";
curso.Alunos = new List<Pessoa>();
curso.AdicionarAluno(p1);
curso.AdicionarAluno(p2);
curso.AdicionarAluno(p3);
curso.ListarAluno();
