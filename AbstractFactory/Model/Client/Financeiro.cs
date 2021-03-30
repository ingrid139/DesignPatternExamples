using AbstractFactory.Model.AbstractFactory;
using AbstractFactory.Model.AbstractProduct;

namespace AbstractFactory.Model.Client
{
    public class Financeiro
    {
        private Funcionario _Employee;
        private Bonificacao _Bonificacao;

        public Financeiro(FuncionarioAbstractFactory factory)
        {
            _Employee = factory.CriarFuncionario();
            _Bonificacao = factory.CriarBonificacao();
        }

        public void BuscarBonificacao()
        {
            _Bonificacao.GetBonificacao(_Employee);
        }
    }
}

