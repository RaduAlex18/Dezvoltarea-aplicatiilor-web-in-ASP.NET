using Lab4_23.Models.Base;

namespace Lab4_23.Models
{
    public class Cars : BaseEntity
    {
        public string? Name { get; set; }
        public int Year { get; set; }
        public int Km { get; set; }
        public string? Color { get; set; }
    }
}
