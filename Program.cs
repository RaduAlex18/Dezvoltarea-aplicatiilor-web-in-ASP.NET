// See https://aka.ms/new-console-template for more information

using exercitiul_1;
///*
///Creati o clasa Student cu nume, prenume, etc si o alta clasa Materie cu titlu, 
///durata (string). Clasa student o sa aibe o Lista de 
///materii: public List<Materie> Materii. Faceti o lista de studenti cu cateva 
///materii si afisati-le.
///*
///


Materie materie1 = new Materie("Mate", "1 ora");
Materie materie2 = new Materie("Info", "3 ore");
Materie materie3 = new Materie("Tic", "2 ore");


Student student1 = new Student("Alex", "Mihai", 12, "Roman");
student1.Materii.Add(materie1);
student1.Materii.Add(materie2);

Student student2 = new Student("Ion", "Constantin", 82, "Francez");
student2.Materii.Add(materie3);
student2.Materii.Add(materie2);

student1.Afisare();
Console.WriteLine();
student2.Afisare();

