using AbstractFactory.Interface;
using AbstractFactory.Model;
using AbstractFactory.Model.Client;
using AbstractFactory.Model.ConcreteFactory;
using System.ComponentModel;

namespace AbstractFactory.Factory
{
    //espécie de factory, mas mais simples pq cria a intancia com base numa decisão
    public class FuncionarioFactory : IFuncionarioFactory
    {
        public Financeiro CriarFuncionarioF(TipoFuncionario tipo)
        {
            switch (tipo)
            {
                case TipoFuncionario.Auxiliar:
                    return new Financeiro(new AuxiliarFactory());
                case TipoFuncionario.Designer:
                    return new Financeiro(new DesignerFactory());
                case TipoFuncionario.Diretor:
                    return new Financeiro(new DiretorFactory());
                default:
                    throw new InvalidEnumArgumentException();
            }
        }
    }
}
