using ExemploExplorando.Models;
using System.Globalization;

/* Aula Validando Data com TryParse    
string dataString = "2023-20-15 18:26";

bool sucesso = DateTime.TryParseExact(dataString,
                       "yyyy-MM-dd HH:mm",
                       CultureInfo.InvariantCulture,
                       DateTimeStyles.None,
                       out DateTime data);
Console.WriteLine(data);
if (sucesso)
{
    Console.WriteLine("Conversão com Sucesso");
} 
else
{
    Console.WriteLine("Data Inválida");
}
*/

/* Aula Formatando Date Time     
DateTime data1 = DateTime.Parse("17/04/2022");
DateTime data = DateTime.Now; //Data e hora atual do sistema
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
*/

/* Aula Formatando Porcentagem     
double porcentagem = 0.3421;
Console.WriteLine(porcentagem.ToString("P"));
*/

/* Aula Alterando a localização da cultura     
using System.Globalization;
decimal valorMonetario = 82.40M;
// No formato de reais
Console.WriteLine(valorMonetario.
    ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
*/

/* Aula Alterando a Localização do Código    
using System.Globalization;
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
*/

/* Aula Formatando valores monetários    
decimal valorMonetario = 82.40M;
// No formato de reais
Console.WriteLine($"{valorMonetario:C}");
*/

/* Aula Concatenação de valores     
string numero1 = "10";
string numero2 = "20";
string resultado = numero1 + numero2;
Console.WriteLine(resultado);
*/

/* Aulas: Introdução manipulação valores, concatenando/Interpolação Strings
Pessoa p1 = new Pessoa("Pedro", "Dias");
p1.Idade = 21;

Pessoa p2 = new Pessoa(nome: "Jose", sobrenome: "Pedro");
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
*/
