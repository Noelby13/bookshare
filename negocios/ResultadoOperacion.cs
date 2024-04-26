﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBookShare.negocios
{
    internal class ResultadoOperacion
    {
        private Boolean isExitoso;
        private String mensaje;

        public ResultadoOperacion()
        {

        }

        public ResultadoOperacion(bool isExitoso, string mensaje)
        {
            this.isExitoso = isExitoso;
            this.mensaje = mensaje;
        }

        public bool IsExitoso { get => isExitoso; set => isExitoso = value; }
        public string Mensaje { get => mensaje; set => mensaje = value; }
    }
}
