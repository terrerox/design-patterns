using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using strategy.Models;
using System.IO;
using strategy.Services;

namespace strategy.Controllers
{
    public class FormController : Controller
    {
        private Context context = null;
        private readonly ILogger<FormController> _logger;

        public FormController(ILogger<FormController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Formulario()
        {
            return View();
        }
        public IActionResult Resultados()
        {
            FormData datos = new FormData(
                Request.Form["matricula"],
                Request.Form["nombre"],
                Request.Form["apellido"],
                DateTime.Parse(Request.Form["fechaNacimiento"]),
                Request.Form["carrera"],
                Request.Form["telefono"],
                Request.Form["direccion"],
                Request.Form["email"]
            );
            string formato = Request.Form["formato"];
            GetEstrategia(formato);
            context.Ejecutar(datos);
            ViewData["formato"] = Request.Form["formato"];
            List<FormData> datosLista = context.Leer();
        
            return View(datosLista);
        }

        // helpers

        private void GetEstrategia (string tipo) 
        {
            switch (tipo)
            {
                case "excel": 
                    ExcelService excelService = new ExcelService();
                    context = new Context(excelService);
                    break;
                case "json":
                    JsonService jsonService = new JsonService();
                    context = new Context(jsonService);
                    break;
                case "txt":
                    TxtService txtService = new TxtService();
                    context = new Context(txtService);
                    break;
                default:
                    Console.WriteLine("OPCION INCORRECTA!!!");
                    break;                      
            }
        }
    }
}