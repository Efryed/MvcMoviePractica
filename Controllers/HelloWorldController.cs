using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller{
        // 
        // GET: /HelloWorld/
        public string Index(){
            return "Esta es mi accion por defecto";
        }

        // 
        // GET: /HelloWorld/Welcome/
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int numTimes = 1){
            // Protege de entradas maliciosas tales como codigo JS 
            return HtmlEncoder.Default.Encode($"Hola {name}, NumTimes is: {numTimes}");
        }
    }
}
