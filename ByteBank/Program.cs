using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            //CalcularBonificacao();

            UsarSistema();
            Console.ReadLine();

        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("789.456.123-21");
            roberta.Nome = "Roberta";
            roberta.Senha = "abc";

            GerenteDeConta camila = new GerenteDeConta("369.258.147-87");
            camila.Nome = "Camila";
            camila.Senha = "123";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "12345";

            sistemaInterno.Logar(parceiro, "12345");
            sistemaInterno.Logar(roberta, "abc");
            sistemaInterno.Logar(camila, "123");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("123.456.789-87");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("789.456.123-21");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("741.852.963-32");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("369.258.147-87");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor("654.321.987-82");
            guilherme.Nome = "Guilherme";
            

            gerenciadorBonificacao.RegistrarFuncionario(pedro);
            gerenciadorBonificacao.RegistrarFuncionario(roberta);
            gerenciadorBonificacao.RegistrarFuncionario(igor);
            gerenciadorBonificacao.RegistrarFuncionario(camila);
            gerenciadorBonificacao.RegistrarFuncionario(guilherme);

            Console.WriteLine("Total de bonificações do mês: " + gerenciadorBonificacao.GetTotalBonificacao());
        }

    }
}
