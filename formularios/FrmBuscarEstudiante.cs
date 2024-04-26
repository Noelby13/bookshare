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
    public partial class FrmBuscarEstudiante : Form
    {
        public FrmBuscarEstudiante()
        {
            InitializeComponent();
        }

        private void btnELiminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBuscarEstudiante_Load(object sender, EventArgs e)
        {

        }
    }
}
