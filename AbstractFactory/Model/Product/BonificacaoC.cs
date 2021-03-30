using AbstractFactory.Extension;
using AbstractFactory.Model.AbstractProduct;
using System;

namespace AbstractFactory.Model.Product
{
    public class BonificacaoC : Bonificacao
    {
        private string _name = nameof(BonificacaoC);

        public override void GetBonificacao(Funcionario funcionario)
        {
            var bonificacao = funcionario.Salario * 0.5;
            Console.WriteLine(_name.mensagemBonificacao(bonificacao));
        }
    }
}

