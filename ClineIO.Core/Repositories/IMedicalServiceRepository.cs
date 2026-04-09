using ClineIO.Core.Entities;

namespace ClineIO.Core.Repositories;

public interface IMedicalServiceRepository : IBaseRepository<MedicalService>
{
    Task<List<MedicalService>> GetAll();
}