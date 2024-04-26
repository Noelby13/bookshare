using SistemaBookShare.dao;
using SistemaBookShare.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBookShare.negocios
{
    internal class LibroServices
    {
        private DLibro dLibro;

        public LibroServices()
        {
            dLibro = new DLibro();
        }

        public ResultadoOperacion guardarLibro(Libro libro)
        {
            var resultado = new ResultadoOperacion();

            if (!dLibro.guardarLibro(libro))
            {
                resultado.IsExitoso = false;
                resultado.Mensaje = "Error al guardar el libro";
                return resultado;
            }

            resultado.Mensaje = "Libro guardado con éxito";
           resultado.IsExitoso = true;
            return resultado;

        }

        public DataSet listarLibros()
        {
            return dLibro.listarLibros();
        }

        public ResultadoOperacion eliminarLibro(int idLibro)
        {
            var resultado = new ResultadoOperacion();
            if (!dLibro.eliminarLibro(idLibro))
            {
                resultado.IsExitoso = false;
                resultado.Mensaje = "Error al eliminar el libro";
                return resultado;
            }
            resultado.Mensaje = "Libro eliminado con éxito";
            resultado.IsExitoso = true;
            return resultado;
        }

        public ResultadoOperacion actualizarLibro(Libro libro)
        {
            var resultado = new ResultadoOperacion();
            if (!dLibro.actualizarLibro(libro))
            {
                resultado.IsExitoso = false;
                resultado.Mensaje = "Error al actualizar el libro";
                return resultado;
            }
            resultado.Mensaje = "Libro actualizado con éxito";
            resultado.IsExitoso = true;
            return resultado;
        }

    }
}
