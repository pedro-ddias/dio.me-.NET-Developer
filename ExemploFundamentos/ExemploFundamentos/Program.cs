// Ponto de entrada do sistema
using System;
using ExemploFundamentos.Common.Models;

/* Aula: Comentários e Boas Práticas em C#
// Instancia da classe
Pessoa p = new Pessoa();

// Atribui dados
p.Nome = "Pedro";
p.Idade = 21;

// Faz a pessoa apresentar-se
p.Apresentar();
*/

/*
Comentarios
de
varias
linhas
*/

/* Aula: Array e Listas em C#
List<string> listaString = new List<string>();
listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");

for (int i = 0; i < listaString.Count; i++)
{
Console.WriteLine(listaString[i]);
}

foreach (var item in listaString)
{
Console.WriteLine(item);
}

int[] arrayInteiros = new int[3];
arrayInteiros[0] = 35;
arrayInteiros[1] = 16;
arrayInteiros[2] = 15;

// Alterar o tamanho do Array - dobrando o tamanho
Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

for (int i = 0; i < arrayInteiros.Length; i++)
{
Console.WriteLine(arrayInteiros[i]);
}

foreach (var valor in arrayInteiros)
{
Console.WriteLine(valor);
}

int[] arrayInteirosDobrados = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrados, arrayInteiros.Length);
*/

/* Aula: Estruturas de repetição
//   Menu interativo
 String ?opcao;
bool programa = true;
while (programa)
{
    Console.WriteLine("Digete uma opção");
    Console.WriteLine("1- Cadastra cliente \n2-Buscar cliente \n3- Apagar cliente \n4-Encerrar");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
        case "2":
            Console.WriteLine("Buscar cliente");
            break;
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        case "4":
            Console.WriteLine("Sair");
            programa = false;
            break;
    }
}
int soma = 0;
int numero = 0;
do
{
    Console.WriteLine("Digite um número");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;
} while (numero != 0);
Console.WriteLine(soma);

int numero = 5;
int i = 0;
while (i <= 10)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
    i++;

    quebrando o laço
     if (i == 5)
    {
        break;
    }
}

int numero = 5;
Tabuada
 for (int i = 0; i <= 10; i++)
 {
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}

Aula: Operadores Aritmeticos
 Calculadora cal = new Calculadora();
cal.Somar(2, 3);
cal.Subtrair(10, 7);
cal.Multiplicar(15, 45);
cal.Dividir(10, 5);
cal.Potencia(3, 3);
cal.Seno(30);
cal.Coseno(30);
cal.Tangente(30);
int numero = 10;
Console.WriteLine(numero);
Console.WriteLine("Incrementando o 10" + numero++);

int numeroDecremento = 10;
Console.WriteLine(numeroDecremento);
Console.WriteLine("Decrementando o 10" + numeroDecremento--);
*/

/*Aula: Operadores Logicos
//  Operador NOT
 Inversão de um valor booleano
 bool choveu = true;
 bool estaTarde = true;

 if (!choveu && !estaTarde)
 {
     Console.WriteLine("Vou peladar");
 }
 else
 {
     Console.WriteLine("Não vou pedalar");
 }

//   Operador AND
 bool possuiPresencaMinima = true;
 double media = 7.5;
 if(possuiPresencaMinima && media >= 7)
 {
     Console.WriteLine("Aprovado");
 }
 else
 {
     Console.WriteLine("Reprovado");
 }

//  Operador OR
 bool ehMaiorDeIdade = true;
 bool possuiAutorizacaoDoResponsavel = true;

 if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
 {
     Console.WriteLine("Entrada liberada");
 }
 else 
 {
     Console.WriteLine("Entrada não liberada");
 }
*/

/* Aula: Operadores condicionais
Console.WriteLine("Digite uma letra");
string? letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("É uma vogal");
        break;

    default:
        Console.WriteLine("Não é uma vogal");
        break;
}

int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida");
}
else if (possivelVenda)
{
    Console.WriteLine("Venda realizada");
}
else
{
    Console.WriteLine("Desculpe, não temos a quantidade em estoque");
}
*/

/* Aula: Conversão de variáveis
    conversão de tipo - cast
    int a = Convert.ToInt32("5"); // com convert a informação pode ser null
    int b = int.Parse("3"); // ou com Parse
    Console.WriteLine(a);
    Console.WriteLine(b);
    convertando String
    int a = 5;
    string b = a.ToString();
    string a = "15";
    int b = Convert.ToInt32(a);
*/

/*  Aula: Operarador atribuição - modificação + combinação
    int a = 10;
    int b = 20;
    int c = a+b;
    c = c + 5; //modificando o valor, adicionando 5 ao valor ja atribuido a C (combinação de operadores)
    c += 5; //modificando o valor, adicionando 5 ao valor ja atribuido a C (combinação de operadores)
    Console.WriteLine(c);
*/

/*  Aula: DataTime
    DateTime dataAtual = DateTime.Now; //data atual da máquina
    Console.WriteLine(dataAtual);
    DateTime dataMudada = DateTime.Now.AddDays(5); //data atual da máquina adicionado 5 dias
    Console.WriteLine(dataMudada.ToString("dd/MM/yyyy")); //colocou a data para aparecer no formato que quis sem a hora
*/

/*  Aula: Manipulado Variáveis
    string apresentacao = "Olá, seja bem vindo";
    int quantidade = 1;
    double altura = 1.79;
    decimal preco = 1.80M;
    bool condicao = true;
    Console.WriteLine(apresentacao);
    Console.WriteLine("O valor de quantidade é :" +quantidade);
    Console.WriteLine("O valor de altura é " +altura);
    Console.WriteLine("O valor de preco é " +preco);
    Console.WriteLine("O valor de condição é "+condicao);
*/

/*  Aula 1
    Pessoa p = new Pessoa();
    p.Nome = "Pedro";
    p.Idade = 21;
    p.Apresentar();
*/