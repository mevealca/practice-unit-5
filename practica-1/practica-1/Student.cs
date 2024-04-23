using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1
{
    public class student : Person
    {
        public string Career { get; set; }
        public string Enrollment { get; set; }

        public student(string? name, string? country, DateTime birthDay, string career, string enrollment) : base(name, country, birthDay)
        {
            Career = career;
            Enrollment = enrollment;
        }

        public override void GetInformationPerson()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Country: {Country}");
            Console.WriteLine($"Años: {Years}");
            Console.WriteLine($"Carrera: {Career}");
            Console.WriteLine($"Matricula {Enrollment}");
        }
    }
}
