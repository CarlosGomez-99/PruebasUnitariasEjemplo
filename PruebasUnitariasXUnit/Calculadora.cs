namespace PruebasUnitariasXUnit;
public class Calculadora
{
    public int Suma(int num1, int num2)
    {
        return num1 + num2;
    }
    public int Division(int num1, int num2)
    {
        if (num2 == 0)
        {
            throw new Exception("No se puede dividir entre cero");
        }
        return num1 / num2;
    }
}
