using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atividade01.RazorPages.Models {
    public class GarcomModel {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? GarcomID { get; set; }
    [Required(ErrorMessage ="Nome é obrigatório")]
    public string? Nome { get; set; }
    [Required(ErrorMessage ="Sobrenome é obrigatório")]
    public string? Sobrenome { get; set; }
    [Required(ErrorMessage ="Número de identificação é obrigatório")]
    public int NumeroIdentificacao { get; set; }
    [Required(ErrorMessage ="Número de telefone é obrigatório")]
    public string? NumeroTelefone { get; set; }
    public List<AtendimentoModel>? Atendimentos { get; set; }
    }
}