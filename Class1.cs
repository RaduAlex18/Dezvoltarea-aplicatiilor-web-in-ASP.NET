using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercitiul_1
{
    internal class Student  
    {
        public  string Nume { get; set; }

        public string Prenume { get; set; }

        public int Varsta { get; set; }

        public string Nationalitate { get; set; }

        public List<Materie> Materii { get; set; }

        public Student(string nume, string prenume, int varsta, string nationalitate) 
        {
            Nume = nume;    
            Prenume = prenume;  
            Varsta = varsta;    
            Nationalitate = nationalitate;
            Materii = new List<Materie>();
        }

        public void Afisare()
        {
            Console.WriteLine($"Student:{Nume} {Prenume}, Varsta:{Varsta}, Nationalitate:{Nationalitate}");

            foreach (Materie materie in Materii)
            {
                Console.WriteLine($"Titlu:{materie.Titlu}, Durata:{materie.Durata}");
            }

            Console.WriteLine();
        }
    }
}