using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBookShare.entidades
{
    public class Libro
    {
        public int idLibro { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public int Stock { get; set; }
        public int StockMinimo { get; set; }
        public string Isbn { get; set; }
        public DateTime anioPublicacion { get; set; }
        public string editorial { get; set; }
        public string genero { get; set; }
        public bool estado { get; set; }

        public Libro()
        {
        }

        public Libro(int idLibro, string titulo, string autor, int stock, int stockMinimo, string isbn, DateTime anioPublicacion, string editorial, string genero, bool estado)
        {
            this.idLibro = idLibro;
            this.titulo = titulo;
            this.autor = autor;
            Stock = stock;
            StockMinimo = stockMinimo;
            Isbn = isbn;
            this.anioPublicacion = anioPublicacion;
            this.editorial = editorial;
            this.genero = genero;
            this.estado = estado;
        }


    }


}
