using AbstractFactory.Interface;
using AbstractFactory.Model;
using AbstractFactory.Model.AbstractFactory;
using System.ComponentModel;

namespace AbstractFactory.Factory
{
    public class FuncionarioFactory : IFuncionarioFactory
    {
        public BaseFactory CriarFuncionario(TipoFuncionario tipo, string cpf)
        {
            switch (tipo)
            {
                case TipoFuncionario.Auxiliar:
                    return new Auxiliar(cpf);
                case TipoFuncionario.Designer:
                    return new Designer(cpf);
                case TipoFuncionario.Diretor:
                    return new Diretor (cpf);
                default:
                    throw new InvalidEnumArgumentException(cpf);
            }
        }
    }
}
