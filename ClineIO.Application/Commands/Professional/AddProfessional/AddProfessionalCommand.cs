using System.Text.Json.Serialization;
using ClineIO.Application.Models;
using MediatR;

namespace ClineIO.Application.Commands.Professional.AddProfessional;

public class AddProfessionalCommand : IRequest<Result>
{
    public string FullName { get; set; }
    public string DocumentNumber { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string ZipCode { get; set; }
    public string Credential { get; set; }
    public string Password { get; set; }

    [JsonIgnore]
    public Core.Entities.Professional ToEntity =>
        new(DocumentNumber, FullName, Email, PhoneNumber, ZipCode, Password, Credential);
}