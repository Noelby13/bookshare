using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBookShare.entidades
{
    internal class Devolucion
    {
        public int IdDevolucion { get; set; }
        public int IdPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public string Observaciones { get; set; }


        public Devolucion()
        {
        }

        public Devolucion(int idDevolucion, int idPrestamo, DateTime fechaDevolucion, string observaciones)
        {
            IdDevolucion = idDevolucion;
            IdPrestamo = idPrestamo;
            FechaDevolucion = fechaDevolucion;
            Observaciones = observaciones;
        }

    }
}
