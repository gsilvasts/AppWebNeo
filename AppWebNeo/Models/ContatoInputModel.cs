using System.ComponentModel.DataAnnotations;

namespace AppWebNeo.Models
{
    public class ContatoInputModel
    {
     
        public int Id { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessage ="Informe seu nome!", AllowEmptyStrings =false)]
        public string Nome { get; set; }
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Informe seu e-mail!", AllowEmptyStrings = false)]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido!")]
        public string Email { get; set; }
        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "O campo telefone é obrigatório!", AllowEmptyStrings = false)]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Entre com um número válido de telefone!")]
        public string Telefone { get; set; }
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "Informe sua cidade!", AllowEmptyStrings = false)]
        public string Cidade { get; set; }
    }
}
