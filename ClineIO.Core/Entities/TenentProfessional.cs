using System.Text.Json.Nodes;

namespace ClineIO.Core.Entities;

public class TenentProfessional : BaseEntity
{
    public Guid TenentId { get; private set; }
    public Guid ProfessionalId { get; private set; }
    public Professional Professional { get; private set; }
    public Tenent Tenent { get; private set; }
    public JsonArray WorkScale { get; private set; }}