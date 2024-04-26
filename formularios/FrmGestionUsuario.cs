using SistemaBookShare.negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBookShare.formularios
{
    public partial class FrmGestionUsuario : Form
    {
        public FrmGestionUsuario()
        {
            InitializeComponent();
        }

        private void FrmGestionUsuario_Load(object sender, EventArgs e)
        {
            loadDataGrid();
        }

        private void loadDataGrid()
        {
            EstudianteServices estudiantes = new EstudianteServices();
            dgvListaEstudiante.DataSource = estudiantes.listarEstudiante().Tables[0];
            //oculta la columna de id
            dgvListaEstudiante.Columns[0].Visible = false;
            dgvListaEstudiante.Refresh();


        }
    }
}
