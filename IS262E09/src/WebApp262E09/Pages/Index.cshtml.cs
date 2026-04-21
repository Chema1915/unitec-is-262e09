using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using   ApplicationIS262E09; // Importamos el espacio de nombres donde está nuestro "cerebro"
namespace WebApp262E09.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public double? Lado { get; set; } 

    public double? AreaResultado { get; set; }

    public void OnPost()
    {
        if (Lado.HasValue)
        {
            // Usamos el "cerebro" para hacer el cálculo
            AreaResultado = Figura262E09.Area(Lado.Value);
        }
    }
}