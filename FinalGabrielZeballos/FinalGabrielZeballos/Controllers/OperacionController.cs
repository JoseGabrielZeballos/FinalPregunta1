using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace FinalGabrielZeballos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacionController : ControllerBase
    {
        [HttpGet]
        public string Ejercicio1(int numero)
        {
            string frase = "";
            if (numero < 0)
            { frase = "ERROR"; }
            if (numero == 0)
            { frase = "Realizado por Gabriel "; }
            if (numero > 0)
            { frase = "https://image.freepik.com/vector-gratis/numeros-cartel-imagen_1639-6453.jpg"; }
            return frase;


        }
    }
}
    
