using System.ComponentModel.DataAnnotations;

namespace AppWebNeo.Models
{
    public class ContatoViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }
    }
}
