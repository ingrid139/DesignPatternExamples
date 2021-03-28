using System;

namespace AbstractFactory
{
    public class Diretor : BaseFactory
    {
        private string _name = nameof(Diretor);

        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine(string.Format("Funcionário {0} criado", nameof(Diretor)));
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
