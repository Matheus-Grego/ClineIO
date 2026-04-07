namespace ClineIO.Core.Entities;

public class Tenent : BaseEntity
{
    public Tenent() : base()
    {
        
    } 
    public string Name { get; set; }
    public string Address1 { get; set; }
    public string? Address2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    
    public List<TenentProfessional> TenentProfessionals { get; set; } = [];
}