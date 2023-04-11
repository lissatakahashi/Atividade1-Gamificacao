using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atividade01.RazorPages.Models {
        public class CategoriaModel {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? CategoriaID { get; set; }
        [Required(ErrorMessage ="Nome é obrigatório")]
        public string? Nome { get; set; }
        [Required(ErrorMessage ="Descrição é obrigatória")]
        public string? Descricao { get; set; }
        [Required(ErrorMessage ="Mesa atendida é obrigatório")]
        public List<ProdutoModel>? Produtos { get; set; }
    }

}