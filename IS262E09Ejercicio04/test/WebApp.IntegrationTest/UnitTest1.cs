namespace WebApp.IntegrationTest;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
public class UnitTest1 : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;
    public UnitTest1(WebApplicationFactory<Program> factory)
    {
    _factory = factory;
    }

    [Fact]
    public async Task Get_PaginasDeLaApp_RetornanStatusCode200()
    {
    // Arrange: Creamos el cliente HTTP virtual
    var client = _factory.CreateClient();
    // Act: Simulamos que un usuario entra a la ruta raíz ("/“)
    var response = await client.GetAsync("/");
    // Assert 1: Verificamos que el servidor haya devuelto un "200 OK"
    response.EnsureSuccessStatusCode();
    Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }


    [Theory]
    [InlineData("/")]
    [InlineData("/About")]
    [InlineData("/Privacy")]
    public async Task Get_PaginasDeLaApp_RetornanStatusCode200YHtml(string url)
    {
    // Arrange: Creamos el cliente HTTP virtual
    var client = _factory.CreateClient();
    // Act: Simulamos que un usuario entra a la ruta raíz ("/“)
    var response = await client.GetAsync(url);
    // Assert 1: Verificamos que el servidor haya devuelto un "200 OK"
    response.EnsureSuccessStatusCode();
    Assert.Equal(HttpStatusCode.OK, response.StatusCode);

    // Assert 2: Verificamos que nos este devolviendo una página HTML
    var contentType = response.Content.Headers.ContentType?.ToString();
    Assert.Equal("text/html; charset=utf-8", contentType);
    }
}
