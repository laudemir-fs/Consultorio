using System.Diagnostics;
using ClosedXML.Excel;
using OfficeOpenXml;

public class PacienteService : IPacienteService
{
    private readonly IPacienteRepository _pacienteRepository;
    private readonly ITooltipsRepository _tooltipsRepository;

    public PacienteService(IPacienteRepository pacienteRepository, ITooltipsRepository tooltipsRepository)
    {
        _pacienteRepository = pacienteRepository;
        _tooltipsRepository = tooltipsRepository;
    }

    public async Task<object> ListAll()
    {
        var tooltipId = 1;
        var pacientes = await _pacienteRepository.ListAll();

        foreach (var paciente in pacientes)
        {
            paciente.Data = paciente.DataNascimento.ToString("dd-MM-yyyy");
        }

        var legenda = await _tooltipsRepository.ListAll();
        var tooltips = legenda.Where(t => t.Id == tooltipId);

        var result = new
        {
            result = pacientes.Select(p => new
            {
                pacienteID = p.PacienteID,
                nome = p.Nome,
                cpf = p.CPF,
                dataNascimento = p.DataNascimento,
                sexo = p.Sexo,
                telefone = p.Telefone,
                email = p.Email,
                data = p.DataNascimento.ToString("dd-MM-yyyy")
            }).ToList(),
            Tooltips = tooltips.Select(t => new
            {
                tooltip = t.Tooltip
            }).ToList()
        };

        return result;
    }

    public async Task<byte[]> ExportToExcelBytes()
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        
        var pacientes = await _pacienteRepository.ListAll();
        
        using (var memoryStream = new MemoryStream())
        using (var workbook = new XLWorkbook())
        {
            
            var worksheet = workbook.Worksheets.Add("Planilha");

            worksheet.Cell(1, 1).Value = "PacienteID";
            worksheet.Cell(1, 2).Value = "Nome";
            worksheet.Cell(1, 3).Value = "CPF";
            worksheet.Cell(1, 4).Value = "Data de Nascimento";
            worksheet.Cell(1, 5).Value = "Sexo";
            worksheet.Cell(1, 6).Value = "Telefone";
            worksheet.Cell(1, 7).Value = "Email";
            worksheet.Cell(1, 8).Value = "Data Formatada";

            int row = 2;
            foreach (var paciente in pacientes)
            {
                worksheet.Cell(row, 1).Value = paciente.PacienteID;
                worksheet.Cell(row, 2).Value = paciente.Nome;
                worksheet.Cell(row, 3).Value = paciente.CPF;
                worksheet.Cell(row, 4).Value = paciente.DataNascimento;
                worksheet.Cell(row, 5).Value = paciente.Sexo;
                worksheet.Cell(row, 6).Value = paciente.Telefone;
                worksheet.Cell(row, 7).Value = paciente.Email;
                worksheet.Cell(row, 8).Value = paciente.Data;
                row++;
            }

            workbook.SaveAs(memoryStream);
            //workbook.SaveAs(@"C:\temp\testeExcel.xlsx");
            
            
            return memoryStream.ToArray();
        }
    }

        public async Task Inserir(PacienteInsert paciente)
        {
            await _pacienteRepository.InserirPaciente(paciente);
        }

    
}