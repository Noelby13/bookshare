using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBookShare.entidades
{
    internal class Estudiante
    {
        public int idEstudiante { get; set; }
        public string carnet { get; set; }
        public string Nombre { get; set; }

        public Estudiante()
        {
        }
        public Estudiante(int idEstudiante, string carnet, string nombre)
        {
            this.idEstudiante = idEstudiante;
            this.carnet = carnet;
            Nombre = nombre;
        }

    }
}
