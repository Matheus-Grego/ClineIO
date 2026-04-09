using ClineIO.Core.Entities;

namespace ClineIO.Application.Models;

public class MedicalSerivceViewModel
{
    public MedicalSerivceViewModel(string description)
    {
        Description = description;
    }
    public string Description { get; set; }
    
    public static MedicalSerivceViewModel FromEntity(MedicalService medicalService) => new MedicalSerivceViewModel(medicalService.Description);
    
}