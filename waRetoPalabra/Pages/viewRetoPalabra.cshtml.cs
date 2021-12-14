using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using libRetoPalabra;

namespace waRetoPalabra.Pages
{
    public class viewRetoPalabraModel : PageModel
    {

        [BindProperty(SupportsGet = true)]
        public string txtTextoEvaluar { get; set; }
        [BindProperty(SupportsGet = true)]
        public string txtPalabraBuscar { get; set; }
        [BindProperty(SupportsGet = true)]


        public clsReto oReto { get; set; }

        public async Task OnGetAsync()
        {

            if (!(string.IsNullOrEmpty(txtTextoEvaluar) || string.IsNullOrEmpty(txtPalabraBuscar)))
            {
                oReto = new clsReto();
                oReto.Texto = txtTextoEvaluar;
                oReto.Palabra = txtPalabraBuscar;
                oReto.obtenerDatos();
            }
            else
            {
                oReto.Mensaje = "El texto a evaluar y la palabra a buscar deben estar diligenciados.";
            }


        }

    }


}
