using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleClassePessoa;

namespace ConsoleClassePessoa
{
    class Pessoa
    {
        public string Nome;
        public int Idade;
        //Só define como int quando for fazer calculos com o número
        public string RG;
        public string CPF;

        public void Acenar(Pessoa pessoaMetodo)
        {
            Console.WriteLine("{0} acenou para {1}", this.Nome, pessoaMetodo.Nome);
        }

        public void PerguntaIdade(Pessoa pessoa1, Pessoa pessoa2)
        {
            Console.WriteLine("{1} e {2}, quantos anos vocês tem?", this.Nome, pessoa1.Nome, pessoa2.Nome);
            pessoa1.RespostaIdade();
        }

        public void RespostaIdade()
        {
            Console.WriteLine("Nós temos tenho {0} anos", this.Idade);
        }

        public void ComoEsta(Pessoa pessoa1, Pessoa pessoa2)
        {
            Console.WriteLine("{0}, sabe onde está o {2} e {1} ", this.Nome, pessoa1.Nome, pessoa2.Nome);
        }
    }
}