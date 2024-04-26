using SistemaBookShare.entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBookShare.formularios
{
    public partial class FrmGestionPrestamo : Form
    {
        //declara una binding del tipo Prestamo

        BindingList<Prestamo> prestamos = new BindingList<Prestamo>();
        BindingList<Estudiante> estudiantes = new BindingList<Estudiante>();
        BindingList<Libro> libros;
        private Libro libroPrestar;


        public FrmGestionPrestamo()
        {
            InitializeComponent();
            libros = new BindingList<Libro>();
            libroPrestar = new Libro();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //valida que solamente se pueda ingresar numeros
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtBuscar.Text, "^[0-9]*$"))
            {
                txtBuscar.Text = string.Empty;
            }

            //suma la cantidad de dias y muestralo en dtFechaD
            if (txtBuscar.Text != "")
            {
                int dias = Convert.ToInt32(txtBuscar.Text);
                dtFechaDevolucion.Value = dtFechaPrestamo.Value.AddDays(dias);
            }
        }

        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            FrmBuscarEstudiante frmBuscarEstudiante = new FrmBuscarEstudiante();
            frmBuscarEstudiante.ShowDialog();
        }

        private void FrmGestionPrestamo_Load(object sender, EventArgs e)
        {

        }

        private void defineData()
        {
            if (estudiantes.Count >0)
            {
                txtCarnetEstudiante.Text = estudiantes[0].idEstudiante.ToString() + "-" + estudiantes[0].Nombre.ToString();
            }

            if (libros.Count> 0)
            {
                txtLibro.Text = libros[0].titulo.ToString() + "\n" + libros[0].autor.ToString() + "\n" + libros[0].editorial.ToString() + "\n" + libros[0].anioPublicacion.ToString() + "\n";
            }

            dtFechaPrestamo.Value = DateTime.Now;
        }

        private void defineData2()
        {
            if (libroPrestar.idLibro != 0)
            {
                txtLibro.Text = libroPrestar.titulo.ToString() + "\n" + libroPrestar.autor.ToString() + "\n" + libroPrestar.editorial.ToString() + "\n" + libroPrestar.anioPublicacion.ToString() + "\n";
            }
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            FrmBuscarLibro frmBuscarLibro = new FrmBuscarLibro(libroPrestar);
            frmBuscarLibro.refreshData = defineData2;
            frmBuscarLibro.libros = libros;

        frmBuscarLibro.ShowDialog();
            defineData2();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarCampos()
        {
            libros.Clear();
            estudiantes.Clear();

            btnActualizar.Enabled = false;
            btnELiminar.Enabled = false;
            btnGuardar.Enabled = true;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
