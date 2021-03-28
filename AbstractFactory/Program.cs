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
            Console.WriteLine("Abstract Factory!\n");

            Auxiliar funcionario1 = new Auxiliar("98764563");
            funcionario1.GetBonificacao();
            funcionario1.AumentarSalario();

            Designer funcionario2 = new Designer("65896598");
            funcionario2.GetBonificacao();
            funcionario2.AumentarSalario();

            Diretor funcionario3 = new Diretor("32165497");
            funcionario3.GetBonificacao();
            funcionario3.AumentarSalario();

            IFuncionarioFactory func = new FuncionarioFactory();
            func.CriarFuncionario(TipoFuncionario.Auxiliar, "123456");

            Console.ReadKey();
        }
    }
}
