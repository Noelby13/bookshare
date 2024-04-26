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
    public partial class FrmSaveBook : Form
    {
        public FrmSaveBook()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
           //cambia la visibilidad del panel pero que se muestre lentamente el cambio
            panelMasActores.Visible = true;


        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtSegundoActor.Text = string.Empty;
            panelMasActores.Visible = false;
        }

        private void flowLayoutPanel1_Resize(object sender, EventArgs e)
        {
            //cambia el tamaño del panel
            flowLayoutPanel1.SuspendLayout();
            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
                if (ctrl is Panel)
                {
                    ctrl.Width = flowLayoutPanel1.Width;
                }
            }
            flowLayoutPanel1.ResumeLayout();
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
