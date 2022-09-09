using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Taller.App.Front.Pages
{
    public class LoginModel : PageModel
    {
        
        public string tituoLogin {get; set;}= "Ingresa Correo";
       
        public void OnGet()
        {
        }
    }
}
