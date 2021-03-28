using AbstractFactory.Model;

namespace AbstractFactory.Interface
{
    public interface IFuncionarioFactory
    {
        void CriarFuncionario(TipoFuncionario tipo, string cpf);
    }
}
