using AbstractFactory.Extension;
using System;

namespace AbstractFactory.Model
{
    public class SmellFuncionario
    {
        //Ugly
        public string _cpf { get; set; }
        public double _salario { get; set; }
        public TipoFuncionario _tipo { get; set; }

        public SmellFuncionario(TipoFuncionario tipo, double salario, string cpf)
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
            if (TipoFuncionario.Diretor == _tipo)
            {
                bonificacao = _salario * 0.5;
                Console.WriteLine(Enum.GetName(typeof(TipoFuncionario), TipoFuncionario.Diretor).mensagemBonificacao(bonificacao));
                return bonificacao;
            }
            //.....
            return 0;
        }

        public void AumentarSalario()
        {
            if (TipoFuncionario.Auxiliar == _tipo)
            {
                _salario *= 1.1;
                Console.WriteLine(Enum.GetName(typeof(TipoFuncionario), TipoFuncionario.Auxiliar).mensagemAjusteSalarial(_salario));
            }
            if (TipoFuncionario.Designer == _tipo)
            {
                _salario *= 1.11;
                Console.WriteLine(Enum.GetName(typeof(TipoFuncionario), TipoFuncionario.Designer).mensagemAjusteSalarial(_salario));
            }
            if (TipoFuncionario.Diretor == _tipo)
            {
                _salario *= 1.15;
                Console.WriteLine(Enum.GetName(typeof(TipoFuncionario), TipoFuncionario.Diretor).mensagemAjusteSalarial(_salario));
            }
            //....
        }
    }
}
