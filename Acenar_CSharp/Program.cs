using System;

namespace ConsoleClassePessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Digite o nome: ");
            pessoa.nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            pessoa.idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite seu RG: ");
            pessoa.rg = Console.ReadLine();

            Console.WriteLine("Digite seu CPF: ");
            pessoa.cpf = Console.ReadLine();

            Console.WriteLine("Nome: {0}", pessoa.nome);
            Console.WriteLine("Idade: {0}", pessoa.idade);
            Console.WriteLine("Rg: {0}", pessoa.rg);
            Console.WriteLine("CPF: {0}", pessoa.cpf);

            Pessoa pessoaSimone = new Pessoa();
            pessoaSimone.nome = "Simone Jesus";
            pessoaSimone.idade = 35;
            pessoaSimone.rg = "12.000.000-0";
            pessoaSimone.cpf = "123.000.000-00";

            Console.WriteLine("Nome: {0}", pessoaSimone.nome);
            Console.WriteLine("Idade: {0}", pessoaSimone.idade);
            Console.WriteLine("Nome: {0}", pessoaSimone.rg);
            Console.WriteLine("Idade: {0}", pessoaSimone.idade);

            pessoa.Acenar(pessoaSimone);
            pessoa.PerguntaIdade(pessoaSimone);



        }
    }
}