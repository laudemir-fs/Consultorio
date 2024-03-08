namespace Consultorio.Domain.Models
{
    public class Exame
    {
    public int ExameID { get; set; }
    public string Nome { get; set; }
    public string Observacoes { get; set; }
    public int TipoExameID { get; set; }
    }
}