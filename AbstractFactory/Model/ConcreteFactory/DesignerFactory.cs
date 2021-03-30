using AbstractFactory.Model.AbstractFactory;
using AbstractFactory.Model.AbstractProduct;
using AbstractFactory.Model.Product;

namespace AbstractFactory.Model.ConcreteFactory
{
    public class DesignerFactory : FuncionarioAbstractFactory
    {
        public override Funcionario CriarFuncionario()
        {
            return new Designer();
        }

        public override Bonificacao CriarBonificacao()
        {
            return new BonificacaoB();
        }
    }
}

