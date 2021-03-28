namespace AbstractFactory.Extension
{
    public static class MyStringExtensions
    {
        public static string mensagemBonificacao(this string funcionario, double valor)
        {
            return string.Format("A bonificação do {0} é de: R${1}", funcionario, valor.ToString());
        }

        public static string mensagemAjusteSalarial(this string funcionario, double valor)
        {
            return string.Format("O salário ajustado do {0} é: R${1} \n", funcionario, valor.ToString());
        }
    }
}
