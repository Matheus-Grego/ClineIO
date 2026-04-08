using ClineIO.Core.Entities;

namespace ClineIO.Core.Repositories;

public interface IPatientRepository : IBaseRepository<Patient>
{
    Task<Patient?> GetPatientByPatientPhoneNumber(string patientNumber);
    Task<Patient?> GetPatientByEmail(string patientEmail);
   
}