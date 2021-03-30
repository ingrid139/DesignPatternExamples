using AbstractFactory.Model;
using AbstractFactory.Model.AbstractFactory;
using AbstractFactory.Model.Client;

namespace AbstractFactory.Interface
{
    public interface IFuncionarioFactory
    {
        Financeiro CriarFuncionarioF(TipoFuncionario tipo);
    }
}
