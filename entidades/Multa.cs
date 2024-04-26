using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBookShare.entidades
{
    internal class Multa
    {
        public int idMulta { get; set; }

        public int idPrestamo { get; set; }

        public DateTime fechaMulta { get; set; }

        public float cantidad { get; set; }

        public string descripcion { get; set; }

        public Multa()
        {
            
        }

        public Multa(int idMulta, int idPrestamo, DateTime fechaMulta, float cantidad, string descripcion)
        {
            this.idMulta = idMulta;
            this.idPrestamo = idPrestamo;
            this.fechaMulta = fechaMulta;
            this.cantidad = cantidad;
            this.descripcion = descripcion;
        }
    }
}
