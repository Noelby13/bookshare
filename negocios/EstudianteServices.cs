using SistemaBookShare.dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBookShare.negocios
{
    internal class EstudianteServices
    {

        public EstudianteServices() { }

        public DataSet listarEstudiante()
        {
            return new DEstudiante().ListarEstudiante();
        }
    }
}
