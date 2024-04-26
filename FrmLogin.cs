using SistemaBookShare.dao;
using SistemaBookShare.entidades;
using SistemaBookShare.formularios;
using SistemaBookShare.store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBookShare
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            Color campoInactivo = Color.FromArgb(144, 148, 165);

            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }

            if (txtContra.Text == "")
            {
                txtContra.UseSystemPasswordChar = false;
                txtContra.Text = "Contraseña";
                txtContra.ForeColor = Color.FromArgb(144, 148, 165);

            }
        }

        private void txtContra_Click(object sender, EventArgs e)
        {
            if (txtContra.Text == "Contraseña")
            {
                txtContra.Text = "";
                txtContra.UseSystemPasswordChar = true;
                txtContra.ForeColor = Color.Black;
            }

            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.FromArgb(144, 148, 165);
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() == "Usuario" || txtContra.Text.Trim() == "Contraseña")
            {
                MessageBox.Show("Ingresa tus datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DUsuario loginUsuario = new DUsuario();

            if (!loginUsuario.validarCredenciales(txtUser.Text.Trim(), txtContra.Text.Trim()))
            {
                MessageBox.Show("Nombre de usuario o clave invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Text = "Usuario";
                txtContra.Text = "Contraseña";
                return;
            }


            Usuario user = loginUsuario.ObtenerUsuarioPorNombreUsuario(txtUser.Text.Trim());
            GlobalData.usuario = user;


            
         
            // Si todo es correcto, mostrar el formulario principal
            FrmPrincipal frm = new FrmPrincipal();
            frm.Show();
            this.Hide();
        }


        private void chkContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chkContraseña.Checked == true)
            {
                txtContra.UseSystemPasswordChar = false;
            }
            else
            {
                txtContra.UseSystemPasswordChar = true;
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
