namespace ClineIO.Core.Entities;

public class MedicalService : BaseEntity
{
    public MedicalService(string description)
    {
        Description = description;
    }
    public string Description { get; set; }

    public void DisableMedicalService()
    {
        IsDeleted = true;
    }
}