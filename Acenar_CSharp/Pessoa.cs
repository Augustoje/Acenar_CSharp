using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClassePessoa
{
    class Pessoa
    {
        public string nome;
        public int idade;
        //Só define como int quando for fazer calculos com o número
        public string rg;
        public string cpf;

        public void Acenar(Pessoa pessoa)
        {
            Console.WriteLine("{0} acenou para {1}", this.nome, pessoa.nome);
        }

        public void PerguntaIdade(Pessoa pessoa)
        {
            Console.WriteLine("{0}, quantos anos você tem?", pessoa.nome);
            pessoa.RespostaIdade();
        }

        public void RespostaIdade()
        {
            Console.WriteLine("Eu tenho {0} anos", this.idade);
        }
    }
}