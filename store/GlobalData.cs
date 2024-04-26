using SistemaBookShare.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBookShare.store
{
    internal class GlobalData
    {
        //crea un usuario global para almacenar el usuario que se loguea
        public static Usuario usuario { get; set;}
    }
}
