namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int QuantidadeAlunos()
        {
            return Alunos.Count;
        }

        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }

        public void ListarAluno()
        {
            Console.WriteLine($"Alunos do: {Nome}");

            for (int i = 0; i < Alunos.Count; i++)
            {
                //string texto = "N° " + (i+1) + " - " + Alunos[i].NomeCompleto;
                string texto = $"N° {i+1} - {Alunos[i].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }
    }
}