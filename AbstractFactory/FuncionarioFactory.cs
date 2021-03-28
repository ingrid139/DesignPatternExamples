using System.ComponentModel;

namespace AbstractFactory
{
    public class FuncionarioFactory : IFuncionarioFactory
    {
        public void CriarFuncionario(TipoFuncionario tipo, string cpf)
        {
            switch (tipo)
            {
                case TipoFuncionario.Auxiliar:
                    new Auxiliar(cpf);
                    break;
                case TipoFuncionario.Designer:
                    new Designer(cpf);
                    break;
                case TipoFuncionario.Diretor:
                    new Diretor(cpf);
                    break;
                default:
                    throw new InvalidEnumArgumentException(cpf);
            }
        }
    }
}
