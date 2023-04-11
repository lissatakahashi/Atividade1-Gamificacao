using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atividade01.RazorPages.Models {
   public class Atendimento {
    [Key] // Chave primária
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? AtendimentoID { get; set; }
    [Required(ErrorMessage ="Mesa atendida é obrigatório")]
    public MesaModel? MesaAtendida { get; set; }
    [Required(ErrorMessage ="Garçom responsável é obrigatório")]
    public GarcomModel? GarconResponsavel { get; set; }
    [Required(ErrorMessage ="Horário do pedido é obrigatório")]
    public DateTime HoraPedido { get; set; }
    public List<Produto>? ProdutosSolicitados { get; set; }
}
}