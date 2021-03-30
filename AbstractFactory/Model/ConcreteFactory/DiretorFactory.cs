using AbstractFactory.Model.AbstractFactory;
using AbstractFactory.Model.AbstractProduct;
using AbstractFactory.Model.Product;

namespace AbstractFactory.Model.ConcreteFactory
{
    public class DiretorFactory : FuncionarioAbstractFactory
    {
        public override Funcionario CriarFuncionario()
        {
            return new Diretor();
        }

        public override Bonificacao CriarBonificacao()
        {
            return new BonificacaoC();
        }
    }
}

