namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _nome;
        public string Nome
        {
            get => _nome.ToUpper() ?? "";

            set
            {
                if (value == "")
                {
                    throw new ArgumentNullException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }

        public string Sobrenome
        {
            get; set;
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        private int _idade;
        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("A idade não pode ser menor que zero");
                }
                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade {Idade}");
        }
    }
}