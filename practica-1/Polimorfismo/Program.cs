

using Polimorfismo;

Rectangulo rectangulo = new Rectangulo(9.5,13);
Circulo circulo = new Circulo(21);
Triangulo triangulo = new Triangulo(7, 18);


Console.WriteLine($"Área del rectángulo es:{rectangulo.CalcularArea()} ");
Console.WriteLine($"Área del círculo es: {circulo.CalcularArea()}");
Console.WriteLine($"Área del triángulo es: {triangulo.CalcularArea()}");
Console.ReadKey();