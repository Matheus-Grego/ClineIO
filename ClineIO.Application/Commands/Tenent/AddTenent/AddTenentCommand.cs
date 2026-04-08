using ClineIO.Application.Models;
using MediatR;

namespace ClineIO.Application.Commands.Tenent.AddTenent;

public class AddTenentCommand : IRequest<Result>
{
    public string Name { get; set; }
    public string Address1 { get; set; }
    public string? Address2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public Core.Entities.Tenent ToEntity() => new Core.Entities.Tenent(Name, Address1, Address2, City, State, ZipCode);
}