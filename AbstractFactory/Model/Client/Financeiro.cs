using AbstractFactory.Model.AbstractFactory;
using AbstractFactory.Model.AbstractProduct;

namespace AbstractFactory.Model.Client
{
    public class Financeiro
    {
        //Cria componentes independente das regras

        private Funcionario _Funcionario;
        private Bonificacao _Bonificacao;

        public Financeiro(FuncionarioAbstractFactory factory)
        {
            _Funcionario = factory.CriarFuncionario();
            _Bonificacao = factory.CriarBonificacao();
        }

        public void BuscarBonificacao()
        {
            _Bonificacao.GetBonificacao(_Funcionario);
        }
    }
}

