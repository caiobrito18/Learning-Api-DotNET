public enum AreaEnum
{
    Civil,
    Software,
    Mecânica
}
namespace LearningAPI1.Models.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string CostValue { get; set; }
        public required AreaEnum Area { get; set; }

        public List<Consultant> Consultants { get; set; } = [];
        public List<RoleRelation> RoleRelations { get; set; } = [];

        public required string CreatedAt;
        public string UpdatedAt;

    }
}
