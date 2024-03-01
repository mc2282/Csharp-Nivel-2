namespace GestionDeArticulos
{
    partial class frmModificarArticulo
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
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.lblNombreArticulo2 = new System.Windows.Forms.Label();
            this.lblCodigoArticulo2 = new System.Windows.Forms.Label();
            this.lblDescripcion2 = new System.Windows.Forms.Label();
            this.lblMarca2 = new System.Windows.Forms.Label();
            this.lblCategoria2 = new System.Windows.Forms.Label();
            this.lblPrecio2 = new System.Windows.Forms.Label();
            this.lblImagenUrl2 = new System.Windows.Forms.Label();
            this.txtCodArticulo2 = new System.Windows.Forms.TextBox();
            this.txtNombreArticulo2 = new System.Windows.Forms.TextBox();
            this.txtDescripcionArticulo2 = new System.Windows.Forms.TextBox();
            this.cboMarcaArticulo2 = new System.Windows.Forms.ComboBox();
            this.cboCategoriaArticulo2 = new System.Windows.Forms.ComboBox();
            this.txtImagenUrlArticulo2 = new System.Windows.Forms.TextBox();
            this.txtPrecioArticulo2 = new System.Windows.Forms.TextBox();
            this.btnAgregarImagenArticulo2 = new System.Windows.Forms.Button();
            this.pboModImagen2 = new System.Windows.Forms.PictureBox();
            this.lblIdArticulo = new System.Windows.Forms.Label();
            this.lbl_IDarticuloMod = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboModImagen2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarArticulo.Location = new System.Drawing.Point(297, 393);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(172, 40);
            this.btnModificarArticulo.TabIndex = 0;
            this.btnModificarArticulo.Text = "Modificar Articulo";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // lblNombreArticulo2
            // 
            this.lblNombreArticulo2.AutoSize = true;
            this.lblNombreArticulo2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArticulo2.Location = new System.Drawing.Point(25, 101);
            this.lblNombreArticulo2.Name = "lblNombreArticulo2";
            this.lblNombreArticulo2.Size = new System.Drawing.Size(76, 19);
            this.lblNombreArticulo2.TabIndex = 1;
            this.lblNombreArticulo2.Text = "Nombre:";
            // 
            // lblCodigoArticulo2
            // 
            this.lblCodigoArticulo2.AutoSize = true;
            this.lblCodigoArticulo2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoArticulo2.Location = new System.Drawing.Point(25, 60);
            this.lblCodigoArticulo2.Name = "lblCodigoArticulo2";
            this.lblCodigoArticulo2.Size = new System.Drawing.Size(68, 19);
            this.lblCodigoArticulo2.TabIndex = 2;
            this.lblCodigoArticulo2.Text = "Código:";
            // 
            // lblDescripcion2
            // 
            this.lblDescripcion2.AutoSize = true;
            this.lblDescripcion2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion2.Location = new System.Drawing.Point(25, 144);
            this.lblDescripcion2.Name = "lblDescripcion2";
            this.lblDescripcion2.Size = new System.Drawing.Size(100, 19);
            this.lblDescripcion2.TabIndex = 3;
            this.lblDescripcion2.Text = "Descripción:";
            // 
            // lblMarca2
            // 
            this.lblMarca2.AutoSize = true;
            this.lblMarca2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca2.Location = new System.Drawing.Point(25, 225);
            this.lblMarca2.Name = "lblMarca2";
            this.lblMarca2.Size = new System.Drawing.Size(61, 19);
            this.lblMarca2.TabIndex = 4;
            this.lblMarca2.Text = "Marca:";
            // 
            // lblCategoria2
            // 
            this.lblCategoria2.AutoSize = true;
            this.lblCategoria2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria2.Location = new System.Drawing.Point(25, 269);
            this.lblCategoria2.Name = "lblCategoria2";
            this.lblCategoria2.Size = new System.Drawing.Size(88, 19);
            this.lblCategoria2.TabIndex = 5;
            this.lblCategoria2.Text = "Categoria:";
            // 
            // lblPrecio2
            // 
            this.lblPrecio2.AutoSize = true;
            this.lblPrecio2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio2.Location = new System.Drawing.Point(25, 311);
            this.lblPrecio2.Name = "lblPrecio2";
            this.lblPrecio2.Size = new System.Drawing.Size(61, 19);
            this.lblPrecio2.TabIndex = 6;
            this.lblPrecio2.Text = "Precio:";
            // 
            // lblImagenUrl2
            // 
            this.lblImagenUrl2.AutoSize = true;
            this.lblImagenUrl2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagenUrl2.Location = new System.Drawing.Point(25, 355);
            this.lblImagenUrl2.Name = "lblImagenUrl2";
            this.lblImagenUrl2.Size = new System.Drawing.Size(92, 19);
            this.lblImagenUrl2.TabIndex = 7;
            this.lblImagenUrl2.Text = "ImagenUrl:";
            // 
            // txtCodArticulo2
            // 
            this.txtCodArticulo2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodArticulo2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.txtCodArticulo2.Location = new System.Drawing.Point(139, 57);
            this.txtCodArticulo2.Name = "txtCodArticulo2";
            this.txtCodArticulo2.Size = new System.Drawing.Size(321, 26);
            this.txtCodArticulo2.TabIndex = 8;
            // 
            // txtNombreArticulo2
            // 
            this.txtNombreArticulo2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreArticulo2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.txtNombreArticulo2.Location = new System.Drawing.Point(139, 98);
            this.txtNombreArticulo2.Name = "txtNombreArticulo2";
            this.txtNombreArticulo2.Size = new System.Drawing.Size(321, 26);
            this.txtNombreArticulo2.TabIndex = 9;
            // 
            // txtDescripcionArticulo2
            // 
            this.txtDescripcionArticulo2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcionArticulo2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.txtDescripcionArticulo2.Location = new System.Drawing.Point(139, 141);
            this.txtDescripcionArticulo2.Multiline = true;
            this.txtDescripcionArticulo2.Name = "txtDescripcionArticulo2";
            this.txtDescripcionArticulo2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcionArticulo2.Size = new System.Drawing.Size(321, 68);
            this.txtDescripcionArticulo2.TabIndex = 10;
            // 
            // cboMarcaArticulo2
            // 
            this.cboMarcaArticulo2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMarcaArticulo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarcaArticulo2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.cboMarcaArticulo2.FormattingEnabled = true;
            this.cboMarcaArticulo2.Location = new System.Drawing.Point(139, 222);
            this.cboMarcaArticulo2.Name = "cboMarcaArticulo2";
            this.cboMarcaArticulo2.Size = new System.Drawing.Size(321, 27);
            this.cboMarcaArticulo2.TabIndex = 11;
            // 
            // cboCategoriaArticulo2
            // 
            this.cboCategoriaArticulo2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCategoriaArticulo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoriaArticulo2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.cboCategoriaArticulo2.FormattingEnabled = true;
            this.cboCategoriaArticulo2.Location = new System.Drawing.Point(139, 266);
            this.cboCategoriaArticulo2.Name = "cboCategoriaArticulo2";
            this.cboCategoriaArticulo2.Size = new System.Drawing.Size(321, 27);
            this.cboCategoriaArticulo2.TabIndex = 12;
            // 
            // txtImagenUrlArticulo2
            // 
            this.txtImagenUrlArticulo2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImagenUrlArticulo2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.txtImagenUrlArticulo2.Location = new System.Drawing.Point(139, 352);
            this.txtImagenUrlArticulo2.Name = "txtImagenUrlArticulo2";
            this.txtImagenUrlArticulo2.Size = new System.Drawing.Size(482, 26);
            this.txtImagenUrlArticulo2.TabIndex = 13;
            // 
            // txtPrecioArticulo2
            // 
            this.txtPrecioArticulo2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecioArticulo2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.txtPrecioArticulo2.Location = new System.Drawing.Point(139, 308);
            this.txtPrecioArticulo2.Name = "txtPrecioArticulo2";
            this.txtPrecioArticulo2.Size = new System.Drawing.Size(321, 26);
            this.txtPrecioArticulo2.TabIndex = 14;
            // 
            // btnAgregarImagenArticulo2
            // 
            this.btnAgregarImagenArticulo2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.btnAgregarImagenArticulo2.Location = new System.Drawing.Point(636, 351);
            this.btnAgregarImagenArticulo2.Name = "btnAgregarImagenArticulo2";
            this.btnAgregarImagenArticulo2.Size = new System.Drawing.Size(55, 26);
            this.btnAgregarImagenArticulo2.TabIndex = 16;
            this.btnAgregarImagenArticulo2.Text = "+";
            this.btnAgregarImagenArticulo2.UseVisualStyleBackColor = true;
            this.btnAgregarImagenArticulo2.Click += new System.EventHandler(this.btnModificarImagenArticulo2_Click);
            // 
            // pboModImagen2
            // 
            this.pboModImagen2.Location = new System.Drawing.Point(482, 57);
            this.pboModImagen2.Name = "pboModImagen2";
            this.pboModImagen2.Size = new System.Drawing.Size(214, 274);
            this.pboModImagen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboModImagen2.TabIndex = 17;
            this.pboModImagen2.TabStop = false;
            // 
            // lblIdArticulo
            // 
            this.lblIdArticulo.AutoSize = true;
            this.lblIdArticulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdArticulo.Location = new System.Drawing.Point(268, 24);
            this.lblIdArticulo.Name = "lblIdArticulo";
            this.lblIdArticulo.Size = new System.Drawing.Size(113, 19);
            this.lblIdArticulo.TabIndex = 18;
            this.lblIdArticulo.Text = "ID ARTICULO:";
            // 
            // lbl_IDarticuloMod
            // 
            this.lbl_IDarticuloMod.AutoSize = true;
            this.lbl_IDarticuloMod.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDarticuloMod.Location = new System.Drawing.Point(397, 24);
            this.lbl_IDarticuloMod.Name = "lbl_IDarticuloMod";
            this.lbl_IDarticuloMod.Size = new System.Drawing.Size(136, 19);
            this.lbl_IDarticuloMod.TabIndex = 19;
            this.lbl_IDarticuloMod.Text = "lbl_IDarticuloMod";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_IDarticuloMod);
            this.groupBox1.Controls.Add(this.btnAgregarImagenArticulo2);
            this.groupBox1.Controls.Add(this.pboModImagen2);
            this.groupBox1.Controls.Add(this.btnModificarArticulo);
            this.groupBox1.Controls.Add(this.lblIdArticulo);
            this.groupBox1.Controls.Add(this.txtPrecioArticulo2);
            this.groupBox1.Controls.Add(this.cboCategoriaArticulo2);
            this.groupBox1.Controls.Add(this.txtImagenUrlArticulo2);
            this.groupBox1.Controls.Add(this.lblNombreArticulo2);
            this.groupBox1.Controls.Add(this.lblCodigoArticulo2);
            this.groupBox1.Controls.Add(this.cboMarcaArticulo2);
            this.groupBox1.Controls.Add(this.lblDescripcion2);
            this.groupBox1.Controls.Add(this.txtDescripcionArticulo2);
            this.groupBox1.Controls.Add(this.lblMarca2);
            this.groupBox1.Controls.Add(this.txtNombreArticulo2);
            this.groupBox1.Controls.Add(this.lblCategoria2);
            this.groupBox1.Controls.Add(this.txtCodArticulo2);
            this.groupBox1.Controls.Add(this.lblPrecio2);
            this.groupBox1.Controls.Add(this.lblImagenUrl2);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 443);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar Artículo";
            // 
            // frmModificarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 467);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(753, 514);
            this.Name = "frmModificarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Artículo Existente";
            this.Load += new System.EventHandler(this.frmModificarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboModImagen2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Label lblNombreArticulo2;
        private System.Windows.Forms.Label lblCodigoArticulo2;
        private System.Windows.Forms.Label lblDescripcion2;
        private System.Windows.Forms.Label lblMarca2;
        private System.Windows.Forms.Label lblCategoria2;
        private System.Windows.Forms.Label lblPrecio2;
        private System.Windows.Forms.Label lblImagenUrl2;
        private System.Windows.Forms.TextBox txtCodArticulo2;
        private System.Windows.Forms.TextBox txtNombreArticulo2;
        private System.Windows.Forms.TextBox txtDescripcionArticulo2;
        private System.Windows.Forms.ComboBox cboMarcaArticulo2;
        private System.Windows.Forms.ComboBox cboCategoriaArticulo2;
        private System.Windows.Forms.TextBox txtImagenUrlArticulo2;
        private System.Windows.Forms.TextBox txtPrecioArticulo2;
        private System.Windows.Forms.Button btnAgregarImagenArticulo2;
        private System.Windows.Forms.PictureBox pboModImagen2;
        private System.Windows.Forms.Label lblIdArticulo;
        private System.Windows.Forms.Label lbl_IDarticuloMod;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}