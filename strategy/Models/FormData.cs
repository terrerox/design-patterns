using System;

namespace strategy.Models
{
    public class FormData
    {
        public FormData(
            string matricula, 
            string nombres, 
            string apellidos, 
            DateTime fechaNacimiento, 
            string carrera, 
            string direccion, 
            string telefono, 
            string email
        )
        {
            this.Matricula = matricula;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.FechaNacimiento = fechaNacimiento;
            this.Carrera = carrera;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;

        }
        public string Matricula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Carrera { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}