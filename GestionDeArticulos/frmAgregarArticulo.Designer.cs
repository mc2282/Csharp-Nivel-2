namespace GestionDeArticulos
{
    partial class frmAgregarArticulo
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
            this.btnAgregarNuevoArticulo = new System.Windows.Forms.Button();
            this.lblNombreArticulo = new System.Windows.Forms.Label();
            this.lblCodigoArticulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblImagenUrl = new System.Windows.Forms.Label();
            this.txtCodArticulo = new System.Windows.Forms.TextBox();
            this.txtNombreArticulo = new System.Windows.Forms.TextBox();
            this.txtDescripcionArticulo = new System.Windows.Forms.TextBox();
            this.cboMarcaArticulo = new System.Windows.Forms.ComboBox();
            this.cboCategoriaArticulo = new System.Windows.Forms.ComboBox();
            this.txtImagenUrlArticulo = new System.Windows.Forms.TextBox();
            this.txtPrecioArticulo = new System.Windows.Forms.TextBox();
            this.btnAgregarImagenArticulo = new System.Windows.Forms.Button();
            this.pboAgregarImagen = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboAgregarImagen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarNuevoArticulo
            // 
            this.btnAgregarNuevoArticulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.btnAgregarNuevoArticulo.Location = new System.Drawing.Point(282, 380);
            this.btnAgregarNuevoArticulo.Name = "btnAgregarNuevoArticulo";
            this.btnAgregarNuevoArticulo.Size = new System.Drawing.Size(172, 40);
            this.btnAgregarNuevoArticulo.TabIndex = 0;
            this.btnAgregarNuevoArticulo.Text = "Agregar Articulo";
            this.btnAgregarNuevoArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarNuevoArticulo.Click += new System.EventHandler(this.btnAgregarNuevoArticulo_Click);
            // 
            // lblNombreArticulo
            // 
            this.lblNombreArticulo.AutoSize = true;
            this.lblNombreArticulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.lblNombreArticulo.Location = new System.Drawing.Point(20, 104);
            this.lblNombreArticulo.Name = "lblNombreArticulo";
            this.lblNombreArticulo.Size = new System.Drawing.Size(69, 19);
            this.lblNombreArticulo.TabIndex = 1;
            this.lblNombreArticulo.Text = "Nombre";
            // 
            // lblCodigoArticulo
            // 
            this.lblCodigoArticulo.AutoSize = true;
            this.lblCodigoArticulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.lblCodigoArticulo.Location = new System.Drawing.Point(20, 65);
            this.lblCodigoArticulo.Name = "lblCodigoArticulo";
            this.lblCodigoArticulo.Size = new System.Drawing.Size(61, 19);
            this.lblCodigoArticulo.TabIndex = 2;
            this.lblCodigoArticulo.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(22, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descripción";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.lblMarca.Location = new System.Drawing.Point(22, 186);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(54, 19);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.lblCategoria.Location = new System.Drawing.Point(22, 227);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(81, 19);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.lblPrecio.Location = new System.Drawing.Point(22, 268);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(54, 19);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio";
            // 
            // lblImagenUrl
            // 
            this.lblImagenUrl.AutoSize = true;
            this.lblImagenUrl.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.lblImagenUrl.Location = new System.Drawing.Point(21, 312);
            this.lblImagenUrl.Name = "lblImagenUrl";
            this.lblImagenUrl.Size = new System.Drawing.Size(85, 19);
            this.lblImagenUrl.TabIndex = 7;
            this.lblImagenUrl.Text = "ImagenUrl";
            // 
            // txtCodArticulo
            // 
            this.txtCodArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodArticulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.txtCodArticulo.Location = new System.Drawing.Point(140, 62);
            this.txtCodArticulo.Name = "txtCodArticulo";
            this.txtCodArticulo.Size = new System.Drawing.Size(259, 26);
            this.txtCodArticulo.TabIndex = 8;
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreArticulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.txtNombreArticulo.Location = new System.Drawing.Point(140, 97);
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.Size = new System.Drawing.Size(259, 26);
            this.txtNombreArticulo.TabIndex = 9;
            // 
            // txtDescripcionArticulo
            // 
            this.txtDescripcionArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcionArticulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.txtDescripcionArticulo.Location = new System.Drawing.Point(140, 138);
            this.txtDescripcionArticulo.Name = "txtDescripcionArticulo";
            this.txtDescripcionArticulo.Size = new System.Drawing.Size(259, 26);
            this.txtDescripcionArticulo.TabIndex = 10;
            // 
            // cboMarcaArticulo
            // 
            this.cboMarcaArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMarcaArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarcaArticulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.cboMarcaArticulo.FormattingEnabled = true;
            this.cboMarcaArticulo.Location = new System.Drawing.Point(140, 178);
            this.cboMarcaArticulo.Name = "cboMarcaArticulo";
            this.cboMarcaArticulo.Size = new System.Drawing.Size(259, 27);
            this.cboMarcaArticulo.TabIndex = 11;
            // 
            // cboCategoriaArticulo
            // 
            this.cboCategoriaArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCategoriaArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoriaArticulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.cboCategoriaArticulo.FormattingEnabled = true;
            this.cboCategoriaArticulo.Location = new System.Drawing.Point(140, 222);
            this.cboCategoriaArticulo.Name = "cboCategoriaArticulo";
            this.cboCategoriaArticulo.Size = new System.Drawing.Size(259, 27);
            this.cboCategoriaArticulo.TabIndex = 12;
            // 
            // txtImagenUrlArticulo
            // 
            this.txtImagenUrlArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImagenUrlArticulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.txtImagenUrlArticulo.Location = new System.Drawing.Point(140, 309);
            this.txtImagenUrlArticulo.Name = "txtImagenUrlArticulo";
            this.txtImagenUrlArticulo.Size = new System.Drawing.Size(496, 26);
            this.txtImagenUrlArticulo.TabIndex = 13;
            // 
            // txtPrecioArticulo
            // 
            this.txtPrecioArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecioArticulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.txtPrecioArticulo.Location = new System.Drawing.Point(140, 261);
            this.txtPrecioArticulo.Name = "txtPrecioArticulo";
            this.txtPrecioArticulo.Size = new System.Drawing.Size(259, 26);
            this.txtPrecioArticulo.TabIndex = 14;
            // 
            // btnAgregarImagenArticulo
            // 
            this.btnAgregarImagenArticulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.btnAgregarImagenArticulo.Location = new System.Drawing.Point(642, 308);
            this.btnAgregarImagenArticulo.Name = "btnAgregarImagenArticulo";
            this.btnAgregarImagenArticulo.Size = new System.Drawing.Size(63, 27);
            this.btnAgregarImagenArticulo.TabIndex = 16;
            this.btnAgregarImagenArticulo.Text = "+";
            this.btnAgregarImagenArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarImagenArticulo.Click += new System.EventHandler(this.btnAgregarImagenArticulo_Click);
            // 
            // pboAgregarImagen
            // 
            this.pboAgregarImagen.Location = new System.Drawing.Point(418, 38);
            this.pboAgregarImagen.Name = "pboAgregarImagen";
            this.pboAgregarImagen.Size = new System.Drawing.Size(272, 249);
            this.pboAgregarImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboAgregarImagen.TabIndex = 17;
            this.pboAgregarImagen.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodArticulo);
            this.groupBox1.Controls.Add(this.btnAgregarNuevoArticulo);
            this.groupBox1.Controls.Add(this.pboAgregarImagen);
            this.groupBox1.Controls.Add(this.lblNombreArticulo);
            this.groupBox1.Controls.Add(this.txtPrecioArticulo);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.btnAgregarImagenArticulo);
            this.groupBox1.Controls.Add(this.lblCodigoArticulo);
            this.groupBox1.Controls.Add(this.txtNombreArticulo);
            this.groupBox1.Controls.Add(this.txtImagenUrlArticulo);
            this.groupBox1.Controls.Add(this.cboCategoriaArticulo);
            this.groupBox1.Controls.Add(this.txtDescripcionArticulo);
            this.groupBox1.Controls.Add(this.lblImagenUrl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboMarcaArticulo);
            this.groupBox1.Controls.Add(this.lblCategoria);
            this.groupBox1.Controls.Add(this.lblMarca);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 443);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Artículo";
            // 
            // frmAgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 467);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(753, 514);
            this.Name = "frmAgregarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Nuevo Articulo";
            this.Load += new System.EventHandler(this.frmAgregarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboAgregarImagen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarNuevoArticulo;
        private System.Windows.Forms.Label lblNombreArticulo;
        private System.Windows.Forms.Label lblCodigoArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblImagenUrl;
        private System.Windows.Forms.TextBox txtCodArticulo;
        private System.Windows.Forms.TextBox txtNombreArticulo;
        private System.Windows.Forms.TextBox txtDescripcionArticulo;
        private System.Windows.Forms.ComboBox cboMarcaArticulo;
        private System.Windows.Forms.ComboBox cboCategoriaArticulo;
        private System.Windows.Forms.TextBox txtImagenUrlArticulo;
        private System.Windows.Forms.TextBox txtPrecioArticulo;
        private System.Windows.Forms.Button btnAgregarImagenArticulo;
        private System.Windows.Forms.PictureBox pboAgregarImagen;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}