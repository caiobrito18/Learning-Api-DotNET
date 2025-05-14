public enum RoleName
{
    Gerente,
    Tecnico,
    Financeiro
}
namespace LearningAPI1.Models.Entities
{
    public class RoleRelation
    {
        public Guid ConsultantId;
        public int ProjectId;
        public RoleName Role;
        public required string CreatedAt;
        public string UpdatedAt;
    }
}
