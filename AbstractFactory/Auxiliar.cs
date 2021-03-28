using System;

namespace AbstractFactory
{
    public class Auxiliar : BaseFactory
    {
        private string _name = nameof(Diretor);

        public Auxiliar(string cpf) : base(2000, cpf)
        {
            Console.WriteLine(string.Format("Funcionário {0} criado", nameof(Auxiliar)));
        }
        public override double GetBonificacao()
        {
            var bonificacao = Salario * 0.2;
            Console.WriteLine(_name.mensagemBonificacao(bonificacao));
            return bonificacao;
        }
        public override void AumentarSalario()
        {
            Salario *= 1.1;
            Console.WriteLine(_name.mensagemAjusteSalarial(Salario));
        }
    }

}
