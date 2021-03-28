using System.ComponentModel.DataAnnotations;

namespace AbstractFactory.Model
{
    public enum TipoFuncionario
    {
        [Display(Name = "Auxiliar")]
        Auxiliar,

        [Display(Name = "Designer")]
        Designer,

        [Display(Name = "Diretor")]
        Diretor
    }
}
