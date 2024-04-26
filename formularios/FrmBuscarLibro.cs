using SistemaBookShare.entidades;
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
    public partial class FrmBuscarLibro : Form
    {

        //declara una binding list para almacenar los libros
        public BindingList<Libro> libros { get; set; }
        public Libro libroSeleccionado { get; set; }
        public Action refreshData { get; set; }
        private Libro libroPrestar;


        public FrmBuscarLibro(Libro libroPrestar)
        {
            InitializeComponent();
            this.libroPrestar = libroPrestar;

        }

        private void btnELiminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBuscarLibro_Load(object sender, EventArgs e)
        {
            loadDataGrid();
            libros = new BindingList<Libro>();
        }

        private void loadDataGrid()
        {
            LibroServices libroServices = new LibroServices();
            DataSet ds = libroServices.listarLibros();
            dgvListaLibro.DataSource = ds.Tables[0];
            dgvListaLibro.Columns[0].Visible = false;
            //esconde la columna de estado
            dgvListaLibro.Columns["estado"].Visible = false;
            dgvListaLibro.Refresh();

            //que en el campo año solamente se muestre el año
            dgvListaLibro.Columns["anioPublicacion"].DefaultCellStyle.Format = "yyyy";
            dgvListaLibro.Columns["anioPublicacion"].HeaderText = "Año publicación";


        }

        private void dgvListaLibro_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           //valida que no se haya seleccionado el encabezado
            if (e.RowIndex == -1)
            {
                return;
            }

           var LibroSelected = new Libro();
            LibroSelected.idLibro = Convert.ToInt32(dgvListaLibro.Rows[e.RowIndex].Cells["idLibro"].Value);
            LibroSelected.titulo = dgvListaLibro.Rows[e.RowIndex].Cells["titulo"].Value.ToString();
            LibroSelected.autor = dgvListaLibro.Rows[e.RowIndex].Cells["autor"].Value.ToString();
            LibroSelected.anioPublicacion = (DateTime)dgvListaLibro.Rows[e.RowIndex].Cells["anioPublicacion"].Value;
            LibroSelected.Stock = Convert.ToInt32(dgvListaLibro.Rows[e.RowIndex].Cells["Stock"].Value);
            LibroSelected.StockMinimo = Convert.ToInt32(dgvListaLibro.Rows[e.RowIndex].Cells["StockMinimo"].Value);
            LibroSelected.Isbn = dgvListaLibro.Rows[e.RowIndex].Cells["Isbn"].Value.ToString();
            LibroSelected.editorial = dgvListaLibro.Rows[e.RowIndex].Cells["editorial"].Value.ToString();
            LibroSelected.genero = dgvListaLibro.Rows[e.RowIndex].Cells["genero"].Value.ToString();
            libroPrestar = LibroSelected;
            libroSeleccionado = LibroSelected;
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //valida que selecciono un libro
            if (dgvListaLibro.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un libro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show($"Libro seleccionado {libroPrestar.titulo}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshData();

        }
    }
}
