using AbstractFactory.Extension;
using AbstractFactory.Model.AbstractFactory;
using System;

namespace AbstractFactory.Model
{
    public class Diretor : BaseFactory
    {
        private string _name = nameof(Diretor);

        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine(string.Format("Funcionário {0} criado", _name));
        }

        public override double GetBonificacao()
        {
            var bonificacao = Salario * 0.5;
            Console.WriteLine(_name.mensagemBonificacao(bonificacao));
            return bonificacao;
        }
        public override void AumentarSalario()
        {
            Salario *= 1.15;
            Console.WriteLine(_name.mensagemAjusteSalarial(Salario));
        }
    }

}
