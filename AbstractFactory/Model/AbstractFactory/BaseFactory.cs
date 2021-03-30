namespace AbstractFactory.Model.AbstractFactory
{
    public abstract class BaseFactory
    {
        public string CPF { get; protected set; }
        public double Salario { get; protected set; }

        public BaseFactory(double salario, string cpf)
        {
            Salario = salario;
            CPF = cpf;
        }
        public abstract double GetBonificacao();
        public abstract void AumentarSalario();
    }
}

