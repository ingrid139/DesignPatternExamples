using AbstractFactory.Model.AbstractFactory;
using AbstractFactory.Model.AbstractProduct;
using AbstractFactory.Model.Product;

namespace AbstractFactory.Model.ConcreteFactory
{
    public class AuxiliarFactory : FuncionarioAbstractFactory
    {
        public override Funcionario CriarFuncionario()
        {
            return new Auxiliar();
        }

        public override Bonificacao CriarBonificacao()
        {
            return new BonificacaoA();
        }
    }
}

