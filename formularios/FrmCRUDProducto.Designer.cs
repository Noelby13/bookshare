namespace SistemaBookShare.formularios
{
    partial class FrmCRUDProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListaLibro = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxEditorial = new System.Windows.Forms.ComboBox();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.txtStockMin = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.TxtCoAutor2 = new System.Windows.Forms.TextBox();
            this.txtCoAutor1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtAutorPrincipal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnELiminar = new SistemaBookShare.CustomControls.RoundedButton();
            this.btnActualizar = new SistemaBookShare.CustomControls.RoundedButton();
            this.btnGuardar = new SistemaBookShare.CustomControls.RoundedButton();
            this.btnLimpiar = new SistemaBookShare.CustomControls.RoundedButton();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaLibro)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 800);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            this.groupBox2.Controls.Add(this.dgvListaLibro);
            this.groupBox2.Controls.Add(this.txtBuscar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(615, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(667, 800);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar libro";
            // 
            // dgvListaLibro
            // 
            this.dgvListaLibro.AllowUserToAddRows = false;
            this.dgvListaLibro.AllowUserToDeleteRows = false;
            this.dgvListaLibro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaLibro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaLibro.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaLibro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaLibro.GridColor = System.Drawing.SystemColors.Control;
            this.dgvListaLibro.Location = new System.Drawing.Point(5, 63);
            this.dgvListaLibro.MultiSelect = false;
            this.dgvListaLibro.Name = "dgvListaLibro";
            this.dgvListaLibro.ReadOnly = true;
            this.dgvListaLibro.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(173)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(161)))));
            this.dgvListaLibro.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaLibro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaLibro.Size = new System.Drawing.Size(656, 733);
            this.dgvListaLibro.TabIndex = 15;
            this.dgvListaLibro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaLibro_CellClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Location = new System.Drawing.Point(5, 27);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(658, 26);
            this.txtBuscar.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            this.groupBox1.Controls.Add(this.cbxEditorial);
            this.groupBox1.Controls.Add(this.cbxGenero);
            this.groupBox1.Controls.Add(this.txtStockMin);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.TxtCoAutor2);
            this.groupBox1.Controls.Add(this.txtCoAutor1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtAnio);
            this.groupBox1.Controls.Add(this.txtISBN);
            this.groupBox1.Controls.Add(this.txtAutorPrincipal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnELiminar);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(615, 800);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del libro";
            // 
            // cbxEditorial
            // 
            this.cbxEditorial.FormattingEnabled = true;
            this.cbxEditorial.Items.AddRange(new object[] {
            "Hispamer",
            "Grupo Editorial Planeta (Argentina)",
            "Grupo Santillana (México)",
            "Editorial Sudamericana (Argentina)",
            "Ediciones SM (Argentina, México, Colombia)",
            "Fondo de Cultura Económica (México)",
            "Penguin Random House Grupo Editorial (Argentina, México, Colombia)",
            "Grupo Editorial Norma (Colombia)",
            "Grupo Editorial Océano (México)",
            "Editorial Anagrama (Argentina)",
            "Ediciones Altea (México)"});
            this.cbxEditorial.Location = new System.Drawing.Point(407, 149);
            this.cbxEditorial.Name = "cbxEditorial";
            this.cbxEditorial.Size = new System.Drawing.Size(190, 28);
            this.cbxEditorial.TabIndex = 61;
            // 
            // cbxGenero
            // 
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Items.AddRange(new object[] {
            "Novela contemporánea",
            "Ciencia ficción",
            "Misterio",
            "Terror",
            "Romance",
            "Fantasía épica",
            "Poesía",
            "Literatura histórica",
            "Thriller psicológico",
            "Literatura infantil",
            "Drama",
            "Aventura",
            "Ensayo",
            "Biografía",
            "Ciencia popular"});
            this.cbxGenero.Location = new System.Drawing.Point(138, 150);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(190, 28);
            this.cbxGenero.TabIndex = 60;
            // 
            // txtStockMin
            // 
            this.txtStockMin.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.txtStockMin.Location = new System.Drawing.Point(419, 243);
            this.txtStockMin.Margin = new System.Windows.Forms.Padding(2);
            this.txtStockMin.Name = "txtStockMin";
            this.txtStockMin.Size = new System.Drawing.Size(78, 25);
            this.txtStockMin.TabIndex = 59;
            this.txtStockMin.TextChanged += new System.EventHandler(this.txtStockMin_TextChanged);
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.txtStock.Location = new System.Drawing.Point(138, 243);
            this.txtStock.Margin = new System.Windows.Forms.Padding(2);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(78, 25);
            this.txtStock.TabIndex = 58;
            this.txtStock.TextChanged += new System.EventHandler(this.txtStock_TextChanged);
            // 
            // TxtCoAutor2
            // 
            this.TxtCoAutor2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.TxtCoAutor2.Location = new System.Drawing.Point(384, 109);
            this.TxtCoAutor2.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCoAutor2.Name = "TxtCoAutor2";
            this.TxtCoAutor2.Size = new System.Drawing.Size(213, 25);
            this.TxtCoAutor2.TabIndex = 55;
            // 
            // txtCoAutor1
            // 
            this.txtCoAutor1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.txtCoAutor1.Location = new System.Drawing.Point(138, 109);
            this.txtCoAutor1.Margin = new System.Windows.Forms.Padding(2);
            this.txtCoAutor1.Name = "txtCoAutor1";
            this.txtCoAutor1.Size = new System.Drawing.Size(213, 25);
            this.txtCoAutor1.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(44, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 20);
            this.label12.TabIndex = 53;
            this.label12.Text = "Coautores:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(298, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 49;
            this.label9.Text = "Stock Mínimo:";
            // 
            // txtAnio
            // 
            this.txtAnio.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.txtAnio.Location = new System.Drawing.Point(138, 198);
            this.txtAnio.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(179, 25);
            this.txtAnio.TabIndex = 47;
            this.txtAnio.TextChanged += new System.EventHandler(this.txtAnio_TextChanged);
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.txtISBN.Location = new System.Drawing.Point(418, 198);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(2);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(179, 25);
            this.txtISBN.TabIndex = 45;
            // 
            // txtAutorPrincipal
            // 
            this.txtAutorPrincipal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.txtAutorPrincipal.Location = new System.Drawing.Point(138, 71);
            this.txtAutorPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.txtAutorPrincipal.Name = "txtAutorPrincipal";
            this.txtAutorPrincipal.Size = new System.Drawing.Size(458, 25);
            this.txtAutorPrincipal.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(49, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "Género:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(334, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Editorial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(7, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Año Publicación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(352, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "ISBN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(75, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Stock:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(77, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Autor:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.txtTitulo.Location = new System.Drawing.Point(137, 29);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(460, 25);
            this.txtTitulo.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(76, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Título:";
            // 
            // btnELiminar
            // 
            this.btnELiminar.BackColor = System.Drawing.Color.Transparent;
            this.btnELiminar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnELiminar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(80)))), ((int)(((byte)(33)))));
            this.btnELiminar.BorderRadius = 10;
            this.btnELiminar.BorderSize = 2;
            this.btnELiminar.Enabled = false;
            this.btnELiminar.FlatAppearance.BorderSize = 0;
            this.btnELiminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnELiminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnELiminar.ForeColor = System.Drawing.Color.Black;
            this.btnELiminar.Image = global::SistemaBookShare.Properties.Resources.iconDelete24;
            this.btnELiminar.Location = new System.Drawing.Point(496, 313);
            this.btnELiminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnELiminar.Name = "btnELiminar";
            this.btnELiminar.Size = new System.Drawing.Size(100, 38);
            this.btnELiminar.TabIndex = 36;
            this.btnELiminar.Text = "Eliminar";
            this.btnELiminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnELiminar.TextColor = System.Drawing.Color.Black;
            this.btnELiminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnELiminar.UseVisualStyleBackColor = false;
            this.btnELiminar.Click += new System.EventHandler(this.btnELiminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnActualizar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(80)))), ((int)(((byte)(33)))));
            this.btnActualizar.BorderRadius = 10;
            this.btnActualizar.BorderSize = 2;
            this.btnActualizar.Enabled = false;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Image = global::SistemaBookShare.Properties.Resources.icondUpdate24;
            this.btnActualizar.Location = new System.Drawing.Point(384, 313);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 38);
            this.btnActualizar.TabIndex = 35;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.TextColor = System.Drawing.Color.Black;
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(80)))), ((int)(((byte)(33)))));
            this.btnGuardar.BorderRadius = 10;
            this.btnGuardar.BorderSize = 2;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Image = global::SistemaBookShare.Properties.Resources.iconAdd24;
            this.btnGuardar.Location = new System.Drawing.Point(280, 313);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 38);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextColor = System.Drawing.Color.Black;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(80)))), ((int)(((byte)(33)))));
            this.btnLimpiar.BorderRadius = 10;
            this.btnLimpiar.BorderSize = 2;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Image = global::SistemaBookShare.Properties.Resources.iconClean24;
            this.btnLimpiar.Location = new System.Drawing.Point(160, 313);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 38);
            this.btnLimpiar.TabIndex = 33;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextColor = System.Drawing.Color.Black;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmCRUDProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 800);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCRUDProducto";
            this.Text = "FrmCRUDProducto";
            this.Load += new System.EventHandler(this.FrmCRUDProducto_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaLibro)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStockMin;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtCoAutor1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtAutorPrincipal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RoundedButton btnELiminar;
        private CustomControls.RoundedButton btnActualizar;
        private CustomControls.RoundedButton btnGuardar;
        private CustomControls.RoundedButton btnLimpiar;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvListaLibro;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox TxtCoAutor2;
        private System.Windows.Forms.ComboBox cbxEditorial;
        private System.Windows.Forms.ComboBox cbxGenero;
    }
}