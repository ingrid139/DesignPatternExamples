
namespace AbstractFactory
{
    public interface IFuncionarioFactory
    {
        void CriarFuncionario(TipoFuncionario tipo, string cpf);
    }
}
