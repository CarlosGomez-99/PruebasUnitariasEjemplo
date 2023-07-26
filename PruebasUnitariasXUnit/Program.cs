using PruebasUnitariasXUnit;

Console.WriteLine("Numero 1:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Numero 2:");
int num2 = int.Parse(Console.ReadLine());
var calculadora = new Calculadora();
Console.WriteLine($"Suma: {calculadora.Suma(num1, num2)}");