using Lab4_23.Models.Base;

namespace Lab4_23.Models.One_to_Many_my_example_
{
    public class tabel1 : BaseEntity
    {
        public string? User1 { get; set; }

        public int age1 { get; set; }


        public ICollection<tabel2>? tabels2 { get; set; }
    }
}


