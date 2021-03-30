using AbstractFactory.Extension;
using AbstractFactory.Model.AbstractProduct;
using System;

namespace AbstractFactory.Model.Product
{
    public class BonificacaoB : Bonificacao
    {
        private string _name = nameof(BonificacaoB);

        public override void GetBonificacao(Funcionario funcionario)
        {
            var bonificacao = funcionario.Salario * 0.17;
            Console.WriteLine(_name.mensagemBonificacao(bonificacao));
        }
    }
}

