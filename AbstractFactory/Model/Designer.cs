﻿using AbstractFactory.Extension;
using AbstractFactory.Model.AbstractFactory;
using System;

namespace AbstractFactory.Model
{
    public class Designer : BaseFactory
    {
        private string _name = nameof(Designer);
        public Designer(string cpf) : base(3000, cpf)
        {
            Console.WriteLine(string.Format("Funcionário {0} criado", _name));
        }
        public override double GetBonificacao()
        {
            var bonificacao = Salario * 0.17;
            Console.WriteLine(_name.mensagemBonificacao(bonificacao));
            return bonificacao;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
            Console.WriteLine(_name.mensagemAjusteSalarial(Salario));
        }

    }

}