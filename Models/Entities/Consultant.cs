namespace LearningAPI1.Models.Entities
{
    public class Consultant
    {
        public Guid Id { get; set; }
        public required string Cpf { get; set; }
        public required string Name { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Email { get; set; }
        public required string Address { get; set; }

        public List<Project> Projects { get; set; } = [];
        public List<RoleRelation> RoleRelations { get; set; } = [];


        public required string CreatedAt;
        public string? UpdatedAt;


    }
}
