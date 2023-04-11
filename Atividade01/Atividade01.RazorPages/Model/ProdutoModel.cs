
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atividade01.RazorPages.Models {
    public class ProdutoModel {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? ProdutoID { get; set; }
        [Required(ErrorMessage ="Nome é obrigatório")]
        public string? Nome { get; set; }
        [Required(ErrorMessage ="Descrição é obrigatório")]
        public string? Descricao { get; set; }
        [Required(ErrorMessage ="Preço é obrigatório")]
        public decimal? Preco { get; set; }
        [Required(ErrorMessage ="Categoria é obrigatório")]
        public CategoriaModel? Categoria { get; set; }
    }
}
