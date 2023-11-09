using Lab4_23.Models.Base;

namespace Lab4_23.Models.One_to_Many_my_example_
{
    public class tabel2 : BaseEntity
    {
        public string User2 { get; set; }

        public int age2 { get; set; }

        public tabel1 tabel1 { get; set; } 
        public Guid tabel1ID { get; set; }
    }
}

