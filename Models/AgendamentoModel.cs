namespace UbsApi.Models
{
    public class AgendamentoModel
    {
        public int id {  get; set; }
        public string? CpfPaciente { get; set; }
        public string? CrmMedico { get; set; }
        public string? Especialidade { get; set; }
        public DateTime DataEhoraAgendamento { get; set; }
        public string? UbsEndereco { get; set; }
        public string? Triagem { get; set; }
    }
}
