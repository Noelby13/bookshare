using SistemaBookShare.entidades;
using SistemaBookShare.negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBookShare.formularios
{
    public partial class FrmCRUDProducto : Form
    {
        private Libro LibroSelected { get; set;}
        public FrmCRUDProducto()
        {
            InitializeComponent();
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            //valida que solamente se pueda agregar numeros
            if (System.Text.RegularExpressions.Regex.IsMatch(txtStock.Text, "[^0-9]"))
            {
                txtStock.Text = txtStock.Text.Remove(txtStock.Text.Length - 1);
            }

        }

        private void txtStockMin_TextChanged(object sender, EventArgs e)
        {
            //valida que solamente se pueda agregar numeros
            if (System.Text.RegularExpressions.Regex.IsMatch(txtStockMin.Text, "[^0-9]"))
            {
                txtStockMin.Text = txtStockMin.Text.Remove(txtStockMin.Text.Length - 1);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validarCampos())
            {
                return;
            }

            //valida que el stock minimo no sea mayor al stock

            if (Convert.ToInt32(txtStockMin.Text) > Convert.ToInt32(txtStock.Text))
            {
                MessageBox.Show("El stock minimo no puede ser mayor al stock");
                return;
            }

            //valida que el año no sea mayor al año actual
            if (Convert.ToInt32(txtAnio.Text) > DateTime.Now.Year)
            {
                MessageBox.Show("El año no puede ser mayor al año actual");
                return;
            }

            //crea un nuevo libro

            Libro libro = new Libro();
            libro.titulo = txtTitulo.Text;
            libro.autor = obtenerAutor();
            libro.anioPublicacion = anioToDateTime(Convert.ToInt32(txtAnio.Text));
            libro.Stock = Convert.ToInt32(txtStock.Text);
            libro.StockMinimo = Convert.ToInt32(txtStockMin.Text);
            libro.Isbn = txtISBN.Text;
            libro.editorial = cbxEditorial.Text;
            libro.genero = cbxGenero.Text;
            libro.estado = true;

            LibroServices libroServices = new LibroServices();

            var resultado = libroServices.guardarLibro(libro);

            if (!resultado.IsExitoso)
            {
                MessageBox.Show(resultado.Mensaje);
                return;
            }

            MessageBox.Show(resultado.Mensaje);
            loadDataGrid();
            limpiarCampos();

        }

        //crea una funcion que verifique si Existe coautor, si existe que lo agregue a txtAutor pero separado por coma
        private string obtenerAutor()
        {
            string autor = txtAutorPrincipal.Text;
            if (txtCoAutor1.Text != "")
            {
                autor = txtAutorPrincipal.Text + "," + txtCoAutor1.Text;
            }

            if (TxtCoAutor2.Text != "")
            {
                autor = txtAutorPrincipal.Text + "," + txtCoAutor1.Text + "," + TxtCoAutor2.Text;
            }

            return autor;
        }

        private DateTime anioToDateTime(int anio)
        {
            return new DateTime(anio, 1, 1);
        }

        private bool validarCampos()
        {
            bool valid = true;
            if (txtTitulo.Text == "")
            {
                valid = false;
                MessageBox.Show("El campo nombre no puede estar vacio");
                return valid;
            }
            if (txtStock.Text == "")
            {
                valid = false;
                MessageBox.Show("El campo precio no puede estar vacio");
                return valid;
            }
            if (txtStockMin.Text == "")
            {
                valid = false;
                MessageBox.Show("El campo stock no puede estar vacio");
                return valid;

            }
            if (txtAutorPrincipal.Text == "")
            {
                valid = false;
                MessageBox.Show("El campo autor no puede estar vacio");
                return valid;

            }

            return valid;
        }

        private void txtAnio_TextChanged(object sender, EventArgs e)
        {
            //valida que solamente se pueda añadir años de 4 digitos
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAnio.Text, "[^0-9]"))
            {
                txtAnio.Text = txtAnio.Text.Remove(txtAnio.Text.Length - 1);
            }
            if (txtAnio.Text.Length > 4)
            {
                txtAnio.Text = txtAnio.Text.Remove(txtAnio.Text.Length - 1);
            }

        }

        private void FrmCRUDProducto_Load(object sender, EventArgs e)
        {
            loadDataGrid();
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            //borra los campos
            txtTitulo.Text = "";
            txtAutorPrincipal.Text = "";
            txtAnio.Text = "";
            txtStock.Text = "";
            txtStockMin.Text = "";
            txtISBN.Text = "";
            cbxEditorial.Text = "";
            cbxGenero.Text = "";
            txtCoAutor1.Text = "";
            TxtCoAutor2.Text = "";

            btnELiminar.Enabled = false;
            btnActualizar.Enabled = false;
            btnGuardar.Enabled = true;

            LibroSelected = null;

            //elimina la seleccion de la fila
            dgvListaLibro.ClearSelection();

        }

        private void dgvListaLibro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            limpiarCampos();

            //Convierte la fila seleccionada en un objeto libro
            LibroSelected = new Libro();
            LibroSelected.idLibro = Convert.ToInt32(dgvListaLibro.Rows[e.RowIndex].Cells["idLibro"].Value);
            LibroSelected.titulo = dgvListaLibro.Rows[e.RowIndex].Cells["titulo"].Value.ToString();
            LibroSelected.autor = dgvListaLibro.Rows[e.RowIndex].Cells["autor"].Value.ToString();
            LibroSelected.anioPublicacion= (DateTime)dgvListaLibro.Rows[e.RowIndex].Cells["anioPublicacion"].Value;
            LibroSelected.Stock = Convert.ToInt32(dgvListaLibro.Rows[e.RowIndex].Cells["Stock"].Value);
            LibroSelected.StockMinimo = Convert.ToInt32(dgvListaLibro.Rows[e.RowIndex].Cells["StockMinimo"].Value);
            LibroSelected.Isbn = dgvListaLibro.Rows[e.RowIndex].Cells["Isbn"].Value.ToString();
            LibroSelected.editorial = dgvListaLibro.Rows[e.RowIndex].Cells["editorial"].Value.ToString();
            LibroSelected.genero = dgvListaLibro.Rows[e.RowIndex].Cells["genero"].Value.ToString();




            //muestra los datos en los campos
            txtTitulo.Text = LibroSelected.titulo;
            txtAutorPrincipal.Text = LibroSelected.autor;
            txtAnio.Text = LibroSelected.anioPublicacion.Year.ToString();
            txtStock.Text = LibroSelected.Stock.ToString();
            txtStockMin.Text = LibroSelected.StockMinimo.ToString();
            txtISBN.Text = LibroSelected.Isbn;
            cbxEditorial.Text = LibroSelected.editorial;
            cbxGenero.Text = LibroSelected.genero;

            //separa los autores por coma
            string[] autores = LibroSelected.autor.Split(',');
            if (autores.Length > 1)
            {
                txtAutorPrincipal.Text = autores[0];
                txtCoAutor1.Text = autores[1];
                if (autores.Length > 2)
                {
                    TxtCoAutor2.Text = autores[2];
                }
            }
            else
            {
                txtAutorPrincipal.Text = autores[0];
            }

            btnELiminar.Enabled = true;
            btnActualizar.Enabled = true;
            btnGuardar.Enabled = false;


        }

        private void btnELiminar_Click(object sender, EventArgs e)
        {
            //valida que si quiere eliminar el libro seleccionado
            DialogResult dialogResult = MessageBox.Show($"¿Está seguro que desea eliminar el libro {LibroSelected.titulo}?", "Eliminar libro", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                LibroServices libroServices = new LibroServices();
                var resultado = libroServices.eliminarLibro(LibroSelected.idLibro);
               if (!resultado.IsExitoso)
                {
                    MessageBox.Show("Error al eliminar el libro");
                    return;
                }
                MessageBox.Show("Libro eliminado correctamente");
                limpiarCampos();
                loadDataGrid();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //valida que los campos no esten vacios
            if (!validarCampos())
            {
                return;
            }

            //obten los datos de los campos
            Libro libro = new Libro();
            libro.idLibro = LibroSelected.idLibro;
            libro.titulo = txtTitulo.Text;
            libro.autor = obtenerAutor();
            libro.anioPublicacion = anioToDateTime(Convert.ToInt32(txtAnio.Text));

            libro.Stock = Convert.ToInt32(txtStock.Text);
            libro.StockMinimo = Convert.ToInt32(txtStockMin.Text);
            libro.Isbn = txtISBN.Text;
            libro.editorial = cbxEditorial.Text;
            libro.genero = cbxGenero.Text;

            LibroServices libroServices = new LibroServices();
            var resultado = libroServices.actualizarLibro(libro);   
            if (!resultado.IsExitoso)
            {
                MessageBox.Show("Error al actualizar el libro");
                return;
            }
            MessageBox.Show("Libro actualizado correctamente");
            limpiarCampos();
            loadDataGrid();




            

        }
    }
}
