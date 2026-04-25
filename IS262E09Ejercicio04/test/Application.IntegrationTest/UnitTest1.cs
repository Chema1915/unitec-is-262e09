namespace Application.IntegrationTest;
using  ApplicationIS262E09;
public class UnitTest1
{
    [Theory]
    [InlineData(3, 3.375)] //Lado 3 - Volumen esperado: 3.375
    [InlineData(4,  7.9999999999999991)] //Lado 4 - Volumen esperado: 7.999
    public void CalcularVolumen_IntegrandoAreaTriangulo_Correcto(double lado, double expected)
    {
        //Arrange - Setup
        // oobtenemos el área del triángulo utilizando el método de la clase FiguraIS262E09
        double area = FiguraIS262E09.Area(lado);
        //ACT - Perform 
        double altura = FiguraIS262E09.Altura(lado); // Altura fija para la prueba
        //Calculamos el volumen utilizando el área obtenida y la altura proporcionada
        double actual = FiguraIS262E09.Volumen(area, altura);

        //Assert
        //Verificamos que el resultado sea el esperado
        Assert.Equal(expected, actual);
    }
}
