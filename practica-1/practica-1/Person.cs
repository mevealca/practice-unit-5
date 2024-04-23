namespace practica_1
{
    public abstract class Person
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
            Years= CalculateYears();
        }

        public abstract void GetInformationPerson(); 

        public virtual int CalculateYears(){

            DateTime dateNow = DateTime.Now;
            return dateNow.Year-BirthDay.Value.Year;
        }
    }

   


   

}
