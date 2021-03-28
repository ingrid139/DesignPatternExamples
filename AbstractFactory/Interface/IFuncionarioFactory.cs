using AbstractFactory.Model;
using AbstractFactory.Model.AbstractFactory;

namespace AbstractFactory.Interface
{
    public interface IFuncionarioFactory
    {
        BaseFactory CriarFuncionario(TipoFuncionario tipo, string cpf);
    }
}
