using ClineIO.Core.Entities;

namespace ClineIO.Core.Repositories;

public interface IProfessionalRepository : IBaseRepository<Professional>
{
    Task<Professional?> GetProfessionalByPhone(string patientNumber);
    Task<Professional?> GetProfessionalByEmail(string patientEmail);
    Task<Professional?> GetProfessionalByCredential(string credentialNumber);

}