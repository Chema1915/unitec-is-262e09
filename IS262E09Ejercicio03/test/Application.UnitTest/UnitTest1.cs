namespace Application.UnitTest;

using System.Reflection;
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
    [InlineData(3, 2.598076211353316)] //Lado 3 - Volumen esperado:2.598076211353316
    [InlineData(4, 4.6188021535170058)] //Lado 4 - Volumen esperado: 4.6188021535170058
    [InlineData(5, 7.216878364870321)] //Lado 5 - Volumen esperado: 7.216878364870321
    public void CalcularVolumenTriangulo_LadoValido_Correcto(double lado, double expected)
    {
        //Arrange
        //No necesitamos arreglar nada para este caso, ya que no hay dependencias externas.

        //ACT
        //Llamamos al método que queremos probar
        double altura = FiguraIS262E09.Altura(lado);
        double result = FiguraIS262E09.Volumen(lado,altura);

        //Assert
        //Verificamos que el resultado sea el esperado
        Assert.Equal(expected, result);
    }
    
}
