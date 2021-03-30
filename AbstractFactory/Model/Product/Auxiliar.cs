using AbstractFactory.Model.AbstractProduct;
using System;

namespace AbstractFactory.Model.Product
{
    public class Auxiliar : Funcionario
    {
        private string _name = nameof(Auxiliar);
        public Auxiliar() : base(2000)
        {
            Console.WriteLine(string.Format("Funcionário {0} criado", _name));
        }
    }
}

