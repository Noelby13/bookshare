namespace SistemaBookShare.formularios
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.tableLayoutBackGround = new System.Windows.Forms.TableLayoutPanel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelShowData = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrestamo = new System.Windows.Forms.Button();
            this.btnLibro = new System.Windows.Forms.Button();
            this.btnDevoluciones = new System.Windows.Forms.Button();
            this.btnMulta = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.panelExitButton = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tableLayoutBackGround.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutMenu.SuspendLayout();
            this.panelExitButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutBackGround
            // 
            this.tableLayoutBackGround.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutBackGround.ColumnCount = 1;
            this.tableLayoutBackGround.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1281F));
            this.tableLayoutBackGround.Controls.Add(this.panelSuperior, 0, 0);
            this.tableLayoutBackGround.Controls.Add(this.panelShowData, 0, 2);
            this.tableLayoutBackGround.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutBackGround.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutBackGround.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutBackGround.Name = "tableLayoutBackGround";
            this.tableLayoutBackGround.RowCount = 3;
            this.tableLayoutBackGround.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutBackGround.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutBackGround.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutBackGround.Size = new System.Drawing.Size(1281, 590);
            this.tableLayoutBackGround.TabIndex = 1;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(80)))), ((int)(((byte)(33)))));
            this.panelSuperior.Controls.Add(this.label1);
            this.panelSuperior.Controls.Add(this.lblNombreCompleto);
            this.panelSuperior.Controls.Add(this.pictureBox1);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1281, 80);
            this.panelSuperior.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(924, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Te damos la Bienvenida: ";
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompleto.ForeColor = System.Drawing.Color.White;
            this.lblNombreCompleto.Location = new System.Drawing.Point(1094, 19);
            this.lblNombreCompleto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(65, 20);
            this.lblNombreCompleto.TabIndex = 5;
            this.lblNombreCompleto.Text = "Nombre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaBookShare.Properties.Resources.logoHorizontal;
            this.pictureBox1.Location = new System.Drawing.Point(10, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelShowData
            // 
            this.panelShowData.BackColor = System.Drawing.Color.White;
            this.panelShowData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShowData.Location = new System.Drawing.Point(0, 132);
            this.panelShowData.Margin = new System.Windows.Forms.Padding(0);
            this.panelShowData.Name = "panelShowData";
            this.panelShowData.Size = new System.Drawing.Size(1281, 458);
            this.panelShowData.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.11765F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.882353F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutMenu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelExitButton, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 81);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1281, 50);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutMenu
            // 
            this.flowLayoutMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            this.flowLayoutMenu.Controls.Add(this.btnPrestamo);
            this.flowLayoutMenu.Controls.Add(this.btnLibro);
            this.flowLayoutMenu.Controls.Add(this.btnDevoluciones);
            this.flowLayoutMenu.Controls.Add(this.btnMulta);
            this.flowLayoutMenu.Controls.Add(this.btnUsuario);
            this.flowLayoutMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutMenu.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutMenu.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutMenu.Name = "flowLayoutMenu";
            this.flowLayoutMenu.Size = new System.Drawing.Size(1154, 50);
            this.flowLayoutMenu.TabIndex = 3;
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.AutoSize = true;
            this.btnPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamo.Image = global::SistemaBookShare.Properties.Resources.iconLending32;
            this.btnPrestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrestamo.Location = new System.Drawing.Point(10, 3);
            this.btnPrestamo.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Size = new System.Drawing.Size(136, 38);
            this.btnPrestamo.TabIndex = 0;
            this.btnPrestamo.Text = "Prestamos";
            this.btnPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrestamo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrestamo.UseVisualStyleBackColor = true;
            this.btnPrestamo.Click += new System.EventHandler(this.btnPrestamo_Click);
            // 
            // btnLibro
            // 
            this.btnLibro.AutoSize = true;
            this.btnLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibro.Image = global::SistemaBookShare.Properties.Resources.iconBook32;
            this.btnLibro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibro.Location = new System.Drawing.Point(152, 3);
            this.btnLibro.Name = "btnLibro";
            this.btnLibro.Size = new System.Drawing.Size(108, 38);
            this.btnLibro.TabIndex = 3;
            this.btnLibro.Text = "Libros";
            this.btnLibro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLibro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLibro.UseVisualStyleBackColor = true;
            this.btnLibro.Click += new System.EventHandler(this.btnLibro_Click);
            // 
            // btnDevoluciones
            // 
            this.btnDevoluciones.AutoSize = true;
            this.btnDevoluciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevoluciones.Image = global::SistemaBookShare.Properties.Resources.iconReturn32;
            this.btnDevoluciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevoluciones.Location = new System.Drawing.Point(266, 3);
            this.btnDevoluciones.Name = "btnDevoluciones";
            this.btnDevoluciones.Size = new System.Drawing.Size(158, 38);
            this.btnDevoluciones.TabIndex = 1;
            this.btnDevoluciones.Text = "Devoluciones";
            this.btnDevoluciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDevoluciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDevoluciones.UseVisualStyleBackColor = true;
            this.btnDevoluciones.Click += new System.EventHandler(this.btnDevoluciones_Click);
            // 
            // btnMulta
            // 
            this.btnMulta.AutoSize = true;
            this.btnMulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulta.Image = global::SistemaBookShare.Properties.Resources.iconMulta32;
            this.btnMulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMulta.Location = new System.Drawing.Point(430, 3);
            this.btnMulta.Name = "btnMulta";
            this.btnMulta.Size = new System.Drawing.Size(108, 38);
            this.btnMulta.TabIndex = 2;
            this.btnMulta.Text = "Multas";
            this.btnMulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMulta.UseVisualStyleBackColor = true;
            // 
            // btnUsuario
            // 
            this.btnUsuario.AutoSize = true;
            this.btnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.Image = global::SistemaBookShare.Properties.Resources.iconUsuario32;
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(544, 3);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(138, 38);
            this.btnUsuario.TabIndex = 4;
            this.btnUsuario.Text = "Estudiante";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // panelExitButton
            // 
            this.panelExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            this.panelExitButton.Controls.Add(this.btnCerrar);
            this.panelExitButton.Location = new System.Drawing.Point(1154, 0);
            this.panelExitButton.Margin = new System.Windows.Forms.Padding(0);
            this.panelExitButton.Name = "panelExitButton";
            this.panelExitButton.Size = new System.Drawing.Size(127, 50);
            this.panelExitButton.TabIndex = 4;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = global::SistemaBookShare.Properties.Resources.iconClose32;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(9, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(108, 38);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1281, 590);
            this.Controls.Add(this.tableLayoutBackGround);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.tableLayoutBackGround.ResumeLayout(false);
            this.tableLayoutBackGround.PerformLayout();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutMenu.ResumeLayout(false);
            this.flowLayoutMenu.PerformLayout();
            this.panelExitButton.ResumeLayout(false);
            this.panelExitButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutBackGround;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelShowData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutMenu;
        private System.Windows.Forms.Button btnPrestamo;
        private System.Windows.Forms.Button btnDevoluciones;
        private System.Windows.Forms.Button btnMulta;
        private System.Windows.Forms.Panel panelExitButton;
        private System.Windows.Forms.Button btnLibro;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreCompleto;
    }
}