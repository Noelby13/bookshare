namespace SistemaBookShare.formularios
{
    partial class FrmGestionPrestamo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionPrestamo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPrestamo = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEliminarLibro = new SistemaBookShare.CustomControls.RoundedButton();
            this.btnAgregarEstudiante = new SistemaBookShare.CustomControls.RoundedButton();
            this.btnEliminarEstudiante = new SistemaBookShare.CustomControls.RoundedButton();
            this.btnAgregarLibro = new SistemaBookShare.CustomControls.RoundedButton();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnELiminar = new SistemaBookShare.CustomControls.RoundedButton();
            this.btnActualizar = new SistemaBookShare.CustomControls.RoundedButton();
            this.btnGuardar = new SistemaBookShare.CustomControls.RoundedButton();
            this.btnLimpiar = new SistemaBookShare.CustomControls.RoundedButton();
            this.txtCarnetEstudiante = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1443, 566);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            this.groupBox2.Controls.Add(this.dgvPrestamo);
            this.groupBox2.Controls.Add(this.txtBuscar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(615, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(828, 566);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ultimos Prestamos";
            // 
            // dgvPrestamo
            // 
            this.dgvPrestamo.AllowUserToAddRows = false;
            this.dgvPrestamo.AllowUserToDeleteRows = false;
            this.dgvPrestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrestamo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamo.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamo.GridColor = System.Drawing.SystemColors.Control;
            this.dgvPrestamo.Location = new System.Drawing.Point(5, 63);
            this.dgvPrestamo.MultiSelect = false;
            this.dgvPrestamo.Name = "dgvPrestamo";
            this.dgvPrestamo.ReadOnly = true;
            this.dgvPrestamo.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(173)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(161)))));
            this.dgvPrestamo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPrestamo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamo.Size = new System.Drawing.Size(817, 499);
            this.dgvPrestamo.TabIndex = 15;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Location = new System.Drawing.Point(5, 27);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(819, 26);
            this.txtBuscar.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtFechaDevolucion);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtFechaPrestamo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnEliminarLibro);
            this.groupBox1.Controls.Add(this.btnAgregarEstudiante);
            this.groupBox1.Controls.Add(this.btnEliminarEstudiante);
            this.groupBox1.Controls.Add(this.btnAgregarLibro);
            this.groupBox1.Controls.Add(this.txtLibro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnELiminar);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.txtCarnetEstudiante);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(615, 566);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del prestamo";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.textBox1.Location = new System.Drawing.Point(157, 136);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 25);
            this.textBox1.TabIndex = 71;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(40, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "Dias a prestar";
            // 
            // dtFechaDevolucion
            // 
            this.dtFechaDevolucion.Enabled = false;
            this.dtFechaDevolucion.Location = new System.Drawing.Point(157, 180);
            this.dtFechaDevolucion.Name = "dtFechaDevolucion";
            this.dtFechaDevolucion.Size = new System.Drawing.Size(219, 26);
            this.dtFechaDevolucion.TabIndex = 69;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(17, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 20);
            this.label10.TabIndex = 68;
            this.label10.Text = "Fecha Devolucion";
            // 
            // dtFechaPrestamo
            // 
            this.dtFechaPrestamo.Enabled = false;
            this.dtFechaPrestamo.Location = new System.Drawing.Point(161, 238);
            this.dtFechaPrestamo.Name = "dtFechaPrestamo";
            this.dtFechaPrestamo.Size = new System.Drawing.Size(219, 26);
            this.dtFechaPrestamo.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(22, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 66;
            this.label8.Text = "Fecha Prestamo";
            // 
            // btnEliminarLibro
            // 
            this.btnEliminarLibro.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarLibro.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnEliminarLibro.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminarLibro.BorderRadius = 20;
            this.btnEliminarLibro.BorderSize = 0;
            this.btnEliminarLibro.FlatAppearance.BorderSize = 0;
            this.btnEliminarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarLibro.ForeColor = System.Drawing.Color.Transparent;
            this.btnEliminarLibro.Image = global::SistemaBookShare.Properties.Resources.iconDelete24;
            this.btnEliminarLibro.Location = new System.Drawing.Point(420, 65);
            this.btnEliminarLibro.Name = "btnEliminarLibro";
            this.btnEliminarLibro.Size = new System.Drawing.Size(37, 35);
            this.btnEliminarLibro.TabIndex = 65;
            this.btnEliminarLibro.TextColor = System.Drawing.Color.Transparent;
            this.btnEliminarLibro.UseVisualStyleBackColor = false;
            this.btnEliminarLibro.Visible = false;
            // 
            // btnAgregarEstudiante
            // 
            this.btnAgregarEstudiante.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarEstudiante.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAgregarEstudiante.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregarEstudiante.BorderRadius = 20;
            this.btnAgregarEstudiante.BorderSize = 0;
            this.btnAgregarEstudiante.FlatAppearance.BorderSize = 0;
            this.btnAgregarEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEstudiante.ForeColor = System.Drawing.Color.Transparent;
            this.btnAgregarEstudiante.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarEstudiante.Image")));
            this.btnAgregarEstudiante.Location = new System.Drawing.Point(381, 26);
            this.btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            this.btnAgregarEstudiante.Size = new System.Drawing.Size(37, 35);
            this.btnAgregarEstudiante.TabIndex = 64;
            this.btnAgregarEstudiante.TextColor = System.Drawing.Color.Transparent;
            this.btnAgregarEstudiante.UseVisualStyleBackColor = false;
            this.btnAgregarEstudiante.Click += new System.EventHandler(this.btnAgregarEstudiante_Click);
            // 
            // btnEliminarEstudiante
            // 
            this.btnEliminarEstudiante.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarEstudiante.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnEliminarEstudiante.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminarEstudiante.BorderRadius = 20;
            this.btnEliminarEstudiante.BorderSize = 0;
            this.btnEliminarEstudiante.FlatAppearance.BorderSize = 0;
            this.btnEliminarEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEstudiante.ForeColor = System.Drawing.Color.Transparent;
            this.btnEliminarEstudiante.Image = global::SistemaBookShare.Properties.Resources.iconDelete24;
            this.btnEliminarEstudiante.Location = new System.Drawing.Point(420, 26);
            this.btnEliminarEstudiante.Name = "btnEliminarEstudiante";
            this.btnEliminarEstudiante.Size = new System.Drawing.Size(37, 35);
            this.btnEliminarEstudiante.TabIndex = 63;
            this.btnEliminarEstudiante.TextColor = System.Drawing.Color.Transparent;
            this.btnEliminarEstudiante.UseVisualStyleBackColor = false;
            this.btnEliminarEstudiante.Visible = false;
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarLibro.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAgregarLibro.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregarLibro.BorderRadius = 20;
            this.btnAgregarLibro.BorderSize = 0;
            this.btnAgregarLibro.FlatAppearance.BorderSize = 0;
            this.btnAgregarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarLibro.ForeColor = System.Drawing.Color.Transparent;
            this.btnAgregarLibro.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarLibro.Image")));
            this.btnAgregarLibro.Location = new System.Drawing.Point(381, 65);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(37, 35);
            this.btnAgregarLibro.TabIndex = 62;
            this.btnAgregarLibro.TextColor = System.Drawing.Color.Transparent;
            this.btnAgregarLibro.UseVisualStyleBackColor = false;
            this.btnAgregarLibro.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // txtLibro
            // 
            this.txtLibro.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.txtLibro.Location = new System.Drawing.Point(157, 65);
            this.txtLibro.Margin = new System.Windows.Forms.Padding(2);
            this.txtLibro.Multiline = true;
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.ReadOnly = true;
            this.txtLibro.Size = new System.Drawing.Size(219, 54);
            this.txtLibro.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(104, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Libro";
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
            this.btnELiminar.Location = new System.Drawing.Point(477, 290);
            this.btnELiminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnELiminar.Name = "btnELiminar";
            this.btnELiminar.Size = new System.Drawing.Size(100, 38);
            this.btnELiminar.TabIndex = 36;
            this.btnELiminar.Text = "Eliminar";
            this.btnELiminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnELiminar.TextColor = System.Drawing.Color.Black;
            this.btnELiminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnELiminar.UseVisualStyleBackColor = false;
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
            this.btnActualizar.Location = new System.Drawing.Point(365, 290);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 38);
            this.btnActualizar.TabIndex = 35;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.TextColor = System.Drawing.Color.Black;
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = false;
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
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(261, 290);
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
            this.btnLimpiar.Location = new System.Drawing.Point(157, 290);
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
            // txtCarnetEstudiante
            // 
            this.txtCarnetEstudiante.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.txtCarnetEstudiante.Location = new System.Drawing.Point(157, 32);
            this.txtCarnetEstudiante.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarnetEstudiante.Name = "txtCarnetEstudiante";
            this.txtCarnetEstudiante.Size = new System.Drawing.Size(219, 25);
            this.txtCarnetEstudiante.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(12, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Carnet estudiante";
            // 
            // FrmGestionPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 566);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGestionPrestamo";
            this.Text = "FrmGestionPrestamo";
            this.Load += new System.EventHandler(this.FrmGestionPrestamo_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPrestamo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFechaDevolucion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtFechaPrestamo;
        private System.Windows.Forms.Label label8;
        private CustomControls.RoundedButton btnEliminarLibro;
        private CustomControls.RoundedButton btnAgregarEstudiante;
        private CustomControls.RoundedButton btnEliminarEstudiante;
        private CustomControls.RoundedButton btnAgregarLibro;
        private System.Windows.Forms.TextBox txtLibro;
        private System.Windows.Forms.Label label1;
        private CustomControls.RoundedButton btnELiminar;
        private CustomControls.RoundedButton btnActualizar;
        private CustomControls.RoundedButton btnGuardar;
        private CustomControls.RoundedButton btnLimpiar;
        private System.Windows.Forms.TextBox txtCarnetEstudiante;
        private System.Windows.Forms.Label label6;
    }
}