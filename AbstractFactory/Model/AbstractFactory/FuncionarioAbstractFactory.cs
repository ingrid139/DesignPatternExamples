using AbstractFactory.Model.AbstractProduct;

namespace AbstractFactory.Model.AbstractFactory
{
    public abstract class FuncionarioAbstractFactory
    {
        public abstract Funcionario CriarFuncionario();
        public abstract Bonificacao CriarBonificacao();
    }
}

