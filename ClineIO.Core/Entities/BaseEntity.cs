namespace ClineIO.Core.Entities;

public class BaseEntity
{
    public BaseEntity()
    {
        Id =  Guid.NewGuid();
        CreatedOn = DateTime.Now;
        IsDeleted = false;
    }
    
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public bool IsDeleted { get; set; }
}