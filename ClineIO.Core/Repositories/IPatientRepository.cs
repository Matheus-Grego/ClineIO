using ClineIO.Core.Entities;

namespace ClineIO.Core.Repositories;

public interface IPatientRepository
{
    Task<List<Patient>> GetAllPatients(int pageNumber, int pageSize);
    Task<Patient> GetPatientById(Guid patientId);
    Task<Patient> GetPatientByPatientNumber(int patientNumber);
    Task<Patient> GetPatientsByEmail(string patientEmail);
    Task AddPatient(Patient patient);
    Task UpdatePatient(Patient patient);
}