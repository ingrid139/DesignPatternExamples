using AbstractFactory.Factory;
using AbstractFactory.Interface;
using AbstractFactory.Model;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            CriarPorFuncionario();
            CriarPorAbstractFactory();
            CriarPorFactory();

            Console.ReadKey();
        }

        static void CriarPorFuncionario()
        {
            Console.WriteLine("~~UglyFactory Funcionario!~~\n");
            Funcionario funcionario = new Funcionario(TipoFuncionario.Auxiliar, 2000, "193.260.793-50");
            funcionario.GetBonificacao();
            funcionario.AumentarSalario();
        }

        static void CriarPorAbstractFactory()
        {
            Console.WriteLine("~~Abstract Factory!~~\n");

            Auxiliar funcionario1 = new Auxiliar("578.628.249-03");
            funcionario1.GetBonificacao();
            funcionario1.AumentarSalario();

            Designer funcionario2 = new Designer("498.851.570-26");
            funcionario2.GetBonificacao();
            funcionario2.AumentarSalario();

            Diretor funcionario3 = new Diretor("363.418.659-37");
            funcionario3.GetBonificacao();
            funcionario3.AumentarSalario();

        }

        static void CriarPorFactory()
        {
            Console.WriteLine("~~Factory!~~\n");

            IFuncionarioFactory func = new FuncionarioFactory();
            var auxiliar = func.CriarFuncionario(TipoFuncionario.Auxiliar, "193.260.793-50");
            auxiliar.GetBonificacao();
            auxiliar.AumentarSalario();
        }
    }
}
