﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBookShare.entidades
{
    public class Usuario
    {
        // * Definicion de atributos *
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string NombreUsuario { get; set; }
        public string Pw { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int Estado { get; set; }

        // * Definicion de constructores *
        // Constructor vacio
        public Usuario()
        {
        }

        // Constructor con parametros
        public Usuario(int idUsuario, string nombre, string nombreUsuario, string pw, DateTime fechaCreacion, int estado)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            NombreUsuario = nombreUsuario;
            Pw = pw;
            FechaCreacion = fechaCreacion;
            Estado = estado;
        }
    }
}
