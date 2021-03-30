namespace AbstractFactory.Model.AbstractProduct
{
    public abstract class Funcionario
    {
        public double Salario { get; protected set; }

        public Funcionario(double salario)
        {
            Salario = salario;
        }
    }
}

