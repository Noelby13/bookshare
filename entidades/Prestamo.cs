using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBookShare.entidades
{
    internal class Prestamo
    {
        public int idPrestamo { get; set; }

        public int idUsuario { get; set; }

        public int idLibro { get; set; }

        public DateTime fechaPrestamo { get; set; }

        public DateTime fechaDevolucionEstimada { get; set;}

        public Prestamo()
        {
            
        }
        public Prestamo(int idPrestamo, int idUsuario, int idLibro, DateTime fechaPrestamo, DateTime fechaDevolucionEstimada)
        {
            this.idPrestamo = idPrestamo;
            this.idUsuario = idUsuario;
            this.idLibro = idLibro;
            this.fechaPrestamo = fechaPrestamo;
            this.fechaDevolucionEstimada = fechaDevolucionEstimada;
        }
    }
}
