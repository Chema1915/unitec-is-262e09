namespace Application.UnitTest;

using  ApplicationIS262E09;




public class UnitTest1
{
    [Theory]
    [InlineData(3, 9)] //Lado 2 - Perímetro esperado: 9
    [InlineData(4, 12)] //Lado 4 - Perímetro esperado: 12
    [InlineData(5, 15)] //Lado 5 - Perímetro esperado: 15
    public void CalcularPerimetroTriangulo_LadoValido_Correcto(double lado, double expected)
    {
               //Arrange
               //No necesitamos arreglar nada para este caso, ya que no hay dependencias externas.

               //ACT
               //Llamamos al método que queremos probar
                double result = FiguraIS262E09.Perimetro(lado);

                //Assert
                //Verificamos que el resultado sea el esperado
                Assert.Equal(expected, result);

    }

    [Theory]
    [InlineData(3, 3.8971143170299736)] //Lado 3 - Área esperada: 3.8971143170299736
    [InlineData(4, 6.928203230275509)] //Lado 4 - Área esperada: 6.928203230275509
    [InlineData(5, 10.825317547305483)] //Lado 5 - Área esperada: 10.825317547305483
    public void CalcularAreaTriangulo_LadoValido_Correcto(double lado, double expected)
    {
        //Arrange
        //No necesitamos arreglar nada para este caso, ya que no hay dependencias externas.

        //ACT
        //Llamamos al método que queremos probar
        double result = FiguraIS262E09.Area(lado);

        //Assert
        //Verificamos que el resultado sea el esperado
        Assert.Equal(expected, result);
    }   

    [Theory]
    [InlineData(3, 3.1819805153394642)] //Lado 3 - Volumen esperado: 3.1819805153394642
    [InlineData(4, 7.5424723326565077)] //Lado 4 - Volumen esperado: 7.5424723326565077
    [InlineData(5, 14.731391274719742)] //Lado 5 - Volumen esperado: 14.731391274719742
    public void CalcularVolumenTriangulo_LadoValido_Correcto(double lado, double expected)
    {
        //Arrange
        //No necesitamos arreglar nada para este caso, ya que no hay dependencias externas.

        //ACT
        //Llamamos al método que queremos probar
        double result = FiguraIS262E09.Volumen(lado);

        //Assert
        //Verificamos que el resultado sea el esperado
        Assert.Equal(expected, result);
    }
    
}
