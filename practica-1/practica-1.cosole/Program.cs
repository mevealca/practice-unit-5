using practica_1;
Console.WriteLine("Estudiantes");
Console.WriteLine(" ");
student student = new student("Miguel Eve", "Dominicano", new DateTime(1992, 02, 10), "Ingeniero en Sistema", "itla-012532-1");
student.GetInformationPerson();

Console.WriteLine(" ");
Console.WriteLine("Instructores");
Console.WriteLine(" ");
Instructor instructor = new Instructor("Francis Ramirez", "Dominicano", new DateTime(1985, 02, 10), "Ingeniero en Sistema", 100000);
instructor.GetInformationPerson();

var years= instructor.CalculateYears();
Console.WriteLine($"Años: {years}");
Console.ReadLine();