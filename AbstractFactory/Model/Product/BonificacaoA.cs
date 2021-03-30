using AbstractFactory.Extension;
using AbstractFactory.Model.AbstractProduct;
using System;

namespace AbstractFactory.Model.Product
{
    public class BonificacaoA : Bonificacao
    {
        private string _name = nameof(BonificacaoA);

        public override void GetBonificacao(Funcionario funcionario)
        {
            var bonificacao = funcionario.Salario * 0.2;
            Console.WriteLine(_name.mensagemBonificacao(bonificacao));
        }
    }
}

