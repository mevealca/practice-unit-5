using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1
{
    public class Instructor : Person
    {

        public string Career { get; }
        public double Salary { get; set; }

        public Instructor(string? name, string? country, DateTime birthDay, string career, double salary) : base(name, country, birthDay)
        {
            Career = career;
            Salary = salary;
        }
        public override void GetInformationPerson()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Country: {Country}");
            Console.WriteLine($"Carrera: {Career}");
            Console.WriteLine($"Salary: {Salary:C0}");
        }
        public override int CalculateYears()
        {
            return (DateTime.Now.Year - BirthDay.Value.Year) - 1;
        }
    }
}
