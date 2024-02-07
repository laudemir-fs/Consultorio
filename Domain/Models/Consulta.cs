namespace Consultorio.Domain.Models
{
    public class Consulta
    {
    public int ConsultaID { get; set; }
    public int PacienteID { get; set; }
    public int ExameID { get; set; }
    public DateTime DataHora { get; set; }
    public string Protocolo { get; set; }
    }
}