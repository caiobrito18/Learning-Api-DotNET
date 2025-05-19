namespace LearningAPI1.Models
{
    public class ConsultantDto
    {
        public required string Cpf { get; set; }
        public required string Name { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Email { get; set; }
        public required string Address { get; set; }

        public string? UpdatedAt { get; set; }
    }
}
