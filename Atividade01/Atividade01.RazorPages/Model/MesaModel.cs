using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atividade01.RazorPages.Models {
    public class MesaModel {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? MesaID { get; set; }
        [Required(ErrorMessage ="Número da mesa é obrigatório")]
        public int? NumeroMesa { get; set; }
        [Required(ErrorMessage ="Status da mesa é obrigatório")]
        public bool Ocupada { get; set; }
        [Required(ErrorMessage ="Horário de abertura é obrigatório")]
        public DateTime? HoraAbertura { get; set; }
        public List<AtendimentoModel>? Atendimentos { get; set; }
        public List<GarcomModel>? GarconsAtendentes { get; set; }
    }
}