namespace practica_1
{
    public class Person
    {
        public string? Name { get; set; }
        public string? Country { get; set; }
        public int? Years { get; set; }
        public DateTime? BirthDay {get; set;}

        public Person (string? name, string? country, DateTime birthDay)
        {
            Name = name;
            Country = country;
            BirthDay = birthDay;
        }

        public void GetInformationPerson() {

            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Country: {Country}");
            Console.WriteLine($"Años: {Years}");

        }

        public int CalculateYears(DateTime? date){

            DateTime dateNow = DateTime.Now;
            return dateNow.Year-date.Value.Year;
        }
    }

    public class student : Person
    {
     

        public string Career { get; set; }
        public string Enrollment { get; set; }

        public student(string? name, string? country, DateTime birthDay, string career,string enrollment) : base(name, country, birthDay)
        {
            Career = career;
            Enrollment = enrollment;
        }

        public void GetInformationStudent()
        {

            Console.WriteLine($"Nombre: {Name}");
            Console.WriteLine($"Ciudad: {Country}");
            Console.WriteLine($"Años: {Years}");
            Console.WriteLine($"Carrera: {Career}");
            Console.WriteLine($"Matricula {Enrollment}");

        }

    }
}
