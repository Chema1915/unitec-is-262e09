namespace WebApp.E2ETests;

using System.Threading.Tasks;
using Microsoft.Playwright.Xunit;
using Xunit;

public class E2EPruebas : PageTest
{
    [Fact]
    public async Task CalcularArea_RobotEscribe5_ServidorDevuelve25()
    {
        // 1. Navegar a la aplicación (Asegúrate de que el puerto coincida con el tuyo, usualmente 5000 o 5001)
        await Page.GotoAsync("http://localhost:5226"); 

        // 2. Escribir el número 5 en el input
        await Page.FillAsync("#input-lado", "5");
        
        // 3. Hacer clic en el botón y esperar a que la página recargue
        await Page.ClickAsync("#btn-calcular");

        // 4. Localizar el elemento HTML del resultado
        var locatorResultado = Page.Locator("#resultado");
        
        // 5. Leer el texto y verificar que la capa Application haya devuelto 25
        var textoResultado = await locatorResultado.InnerTextAsync();
        Assert.Equal("25", textoResultado);
    }
}