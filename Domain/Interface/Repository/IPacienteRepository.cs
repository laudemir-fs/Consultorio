using Microsoft.AspNetCore.Mvc;

public interface IPacienteRepository
{
    Task <IList<Paciente>> ListAll();
    //Task<Paciente> GetPaciente(int id);
    Task InserirPaciente(PacienteInsert paciente);
    //Task UpdatePaciente(Paciente paciente);
    //Task DeletePaciente(int id);
}