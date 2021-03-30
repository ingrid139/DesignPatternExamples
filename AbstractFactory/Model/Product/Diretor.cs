using AbstractFactory.Model.AbstractProduct;
using System;

namespace AbstractFactory.Model.Product
{
    public class Diretor : Funcionario
    {
        private string _name = nameof(Diretor);

        public Diretor() : base(7000)
        {
            Console.WriteLine(string.Format("Funcionário {0} criado", _name));

        }
    }
}

