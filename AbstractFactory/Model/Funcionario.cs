using AbstractFactory.Extension;
using System;

namespace AbstractFactory.Model
{
    public class Funcionario
    {
        //UglyFactory
        public string _cpf { get; protected set; }
        public double _salario { get; protected set; }
        public TipoFuncionario _tipo { get; set; }

        public Funcionario(TipoFuncionario tipo, double salario, string cpf)
        {
            _tipo = tipo;
            _salario = salario;
            _cpf = cpf;
            Console.WriteLine("Criar Funcionário!!!");
        }

        public double GetBonificacao()
        {
            double bonificacao;
            if (TipoFuncionario.Auxiliar == _tipo)
            {
                bonificacao = _salario * 0.2;
                Console.WriteLine(Enum.GetName(typeof(TipoFuncionario), TipoFuncionario.Auxiliar).mensagemBonificacao(bonificacao));
                return bonificacao;
            }
            if (TipoFuncionario.Designer == _tipo)
            {
                bonificacao = _salario * 0.17;
                Console.WriteLine(Enum.GetName(typeof(TipoFuncionario), TipoFuncionario.Designer).mensagemBonificacao(bonificacao));
                return bonificacao;
            }
            if (TipoFuncionario.Designer == _tipo)
            {
                bonificacao = _salario * 0.5;
                Console.WriteLine(Enum.GetName(typeof(TipoFuncionario), TipoFuncionario.Designer).mensagemBonificacao(bonificacao));
                return bonificacao;
            }
            return 0;
        }

        public void AumentarSalario()
        {
            if (TipoFuncionario.Auxiliar == _tipo)
            {
                _salario *= 1.1;
                Console.WriteLine(Enum.GetName(typeof(TipoFuncionario), TipoFuncionario.Auxiliar).mensagemBonificacao(_salario));
            }
            if (TipoFuncionario.Designer == _tipo)
            {
                _salario *= 1.11;
                Console.WriteLine(Enum.GetName(typeof(TipoFuncionario), TipoFuncionario.Designer).mensagemBonificacao(_salario));
            }
            if (TipoFuncionario.Diretor == _tipo)
            {
                _salario *= 1.15;
                Console.WriteLine(Enum.GetName(typeof(TipoFuncionario), TipoFuncionario.Diretor).mensagemBonificacao(_salario));
            }
        }
    }
}
