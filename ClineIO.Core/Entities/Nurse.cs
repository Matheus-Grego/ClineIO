namespace ClineIO.Core.Entities;

public class Nurse : Person
{
    protected Nurse() : base() { }
    public Nurse(int documentNumber, string fullname, string email, int phoneNumber, string zipCode) : base(documentNumber, fullname, email, phoneNumber, zipCode)
    {
        
    }

    public decimal salary { get; private set; }
    public TimeOnly StartShift  { get; private set; }
    public TimeOnly EndShift { get; private set; } 
}