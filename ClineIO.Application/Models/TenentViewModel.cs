using ClineIO.Core.Entities;

namespace ClineIO.Application.Models;

public class TenentViewModel
{
    public string Name { get; set; }
    public string Address1 { get; set; }
    public string? Address2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public static TenentViewModel FromEntity(Tenent entity) =>
        new TenentViewModel
        {
            Name = entity.Name,
            Address1 = entity.Address1,
            Address2 = entity.Address2,
            City = entity.City,
            State = entity.State,
            ZipCode = entity.ZipCode
        };

}