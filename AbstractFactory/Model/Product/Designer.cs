using AbstractFactory.Model.AbstractProduct;
using System;

namespace AbstractFactory.Model.Product
{
    public class Designer : Funcionario
    {
        private string _name = nameof(Designer);
        public Designer() : base(3000)
        {
            Console.WriteLine(string.Format("Funcionário {0} criado", _name));
        }
    }
}

