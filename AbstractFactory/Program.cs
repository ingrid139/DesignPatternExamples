using AbstractFactory.Factory;
using AbstractFactory.Interface;
using AbstractFactory.Model;
using AbstractFactory.Model.AbstractFactory;
using AbstractFactory.Model.Client;
using AbstractFactory.Model.ConcreteFactory;
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
            SmellFuncionario funcionario = new SmellFuncionario(TipoFuncionario.Auxiliar, 2000, "193.260.793-50");
            funcionario.GetBonificacao();
            funcionario.AumentarSalario();
        }

        static void CriarPorAbstractFactory()
        {
            Console.WriteLine("\n~~Abstract Factory!~~\n");

            FuncionarioAbstractFactory auxiliar = new AuxiliarFactory();
            Financeiro financeiro = new Financeiro(auxiliar);
            financeiro.BuscarBonificacao();

            FuncionarioAbstractFactory designer = new DesignerFactory();
            Financeiro financeiro1 = new Financeiro(designer);
            financeiro1.BuscarBonificacao();

            FuncionarioAbstractFactory diretor = new DiretorFactory();
            Financeiro financeiro2 = new Financeiro(diretor);
            financeiro2.BuscarBonificacao();
        }

        static void CriarPorFactory()
        {
            Console.WriteLine("\n~~\"Factory\"!~~\n");

            IFuncionarioFactory func = new FuncionarioFactory();
            var auxiliar = func.CriarFuncionarioF(TipoFuncionario.Auxiliar);
            auxiliar.BuscarBonificacao();

            var designer = func.CriarFuncionarioF(TipoFuncionario.Designer);
            designer.BuscarBonificacao();

            var diretor = func.CriarFuncionarioF(TipoFuncionario.Diretor);
            diretor.BuscarBonificacao();

        }
    }
}
