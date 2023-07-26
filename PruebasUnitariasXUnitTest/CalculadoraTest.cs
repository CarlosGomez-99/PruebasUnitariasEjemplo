using PruebasUnitariasXUnit;

namespace PruebasUnitariasXUnitTest
{
    public class CalculadoraTest
    {
        [Fact]
        public void SumSuccess()
        {
            //Arrange
            var calculator = new Calculadora();
            //Act
            var result = calculator.Suma(2, 2);
            //Assert
            Assert.Equal(4, result);
        }
        [Fact]
        public void SumError()
        {
            var calculator = new Calculadora();
            var result = calculator.Suma(1, 1);
            Assert.NotEqual(3, result);
        }
        [Fact]
        public void DivisionSuccess()
        {
            var calculator = new Calculadora();
            var result = calculator.Division(4, 2);
            Assert.Equal(2, result);
        }
        [Fact]
        public void DivisionError()
        {
            try
            {
                var calculator = new Calculadora();
                var result = calculator.Division(4, 0);
                Assert.Fail("No debio llegar a este punto.");
            }
            catch (Exception ex)
            {
                Assert.True(ex.Message.Equals("No se puede dividir entre cero"));
            }
        }
    }
}