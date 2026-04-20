using ClineIO.Application.Models;
using MediatR;

namespace ClineIO.Application.Commands.Tenent.DeleteTenent;

public class DeleteTenentCommand : IRequest<Result>
{
    public DeleteTenentCommand(Guid id)
    {
        Id = id;
    }
    public Guid Id { get; set; }
}