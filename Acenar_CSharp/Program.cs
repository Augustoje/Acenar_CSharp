using System;

namespace ConsoleClassePessoa
{
    class Program
    {
        static void Main(string[] aRGs)
        {
            Pessoa pessoaV = new Pessoa();

            Console.Write("Digite o Nome: ");
            pessoaV.Nome = Console.ReadLine();

            Console.Write("Idade: ");
            pessoaV.Idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite seu RG: ");
            pessoaV.RG = Console.ReadLine();

            Console.Write("Digite seu CPF: ");
            pessoaV.CPF = Console.ReadLine();

            Console.WriteLine("Nome: {0}", pessoaV.Nome);
            Console.WriteLine("Idade: {0}", pessoaV.Idade);
            Console.WriteLine("RG: {0}", pessoaV.RG);
            Console.WriteLine("CPF: {0}", pessoaV.CPF);

            Pessoa pessoaSimone = new Pessoa();

            pessoaSimone.Nome = "Simone";
            pessoaSimone.Idade = 35;
            pessoaSimone.RG = "12.000.000-0";
            pessoaSimone.CPF = "123.000.000-00";

            Console.WriteLine("Nome: {0}", pessoaSimone.Nome);
            Console.WriteLine("Idade: {0}", pessoaSimone.Idade);
            Console.WriteLine("RG: {0}", pessoaSimone.RG);
            Console.WriteLine("CPF: {0}", pessoaSimone.CPF);

            Pessoa pessoaAfonso = new Pessoa();

            pessoaAfonso.Nome = "Afonso";
            pessoaAfonso.Idade = 36;
            pessoaAfonso.RG = "12.045.000-0";
            pessoaAfonso.CPF = "123.000.789-00";

            Console.WriteLine("Nome: {0}", pessoaAfonso.Nome);
            Console.WriteLine("Idade: {0}", pessoaAfonso.Idade);
            Console.WriteLine("RG: {0}", pessoaAfonso.RG);
            Console.WriteLine("CPF: {0}", pessoaAfonso.CPF);


            pessoaAfonso.Acenar(pessoaSimone);
            pessoaSimone.PerguntaIdade(pessoaV, pessoaAfonso);
            pessoaAfonso.ComoEsta(pessoaSimone, pessoaV);



        }
    }
}