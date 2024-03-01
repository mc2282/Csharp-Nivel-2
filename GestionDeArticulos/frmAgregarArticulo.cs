using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using System.Drawing.Text;

namespace GestionDeArticulos
{
    public partial class frmAgregarArticulo : Form
    {
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

        private OpenFileDialog archivo = null;
        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            NegocioCategorias negocioCategorias = new NegocioCategorias();
            NegocioMarcas negocioMarcas = new NegocioMarcas();

            cboCategoriaArticulo.DataSource = negocioCategorias.listarCategorias();
            cboCategoriaArticulo.ValueMember = "Id";
            cboCategoriaArticulo.DisplayMember = "Descripcion";

            cboMarcaArticulo.DataSource = negocioMarcas.listarMarcas();
            cboMarcaArticulo.ValueMember = "Id";
            cboMarcaArticulo.DisplayMember = "Descripcion";
        }

        /** BOTÓN AGREGAR NUEVO ARTÍCULO **/
        private void btnAgregarNuevoArticulo_Click(object sender, EventArgs e)
        {
            AccesoDatos datos = new AccesoDatos();
            NegocioArticulos negocio = new NegocioArticulos();

            try
            {
                if (string.IsNullOrEmpty(txtCodArticulo.Text) || string.IsNullOrEmpty(txtNombreArticulo.Text) || string.IsNullOrEmpty(txtDescripcionArticulo.Text) || string.IsNullOrEmpty(txtPrecioArticulo.Text) || string.IsNullOrEmpty(txtImagenUrlArticulo.Text))
                {
                    MessageBox.Show("Complete los campos vacíos.");
                }
                else
                {
                    Articulo nuevoArticulo = new Articulo();
                    nuevoArticulo.Codigo = txtCodArticulo.Text;
                    nuevoArticulo.Nombre = txtNombreArticulo.Text;
                    nuevoArticulo.Descripcion = txtDescripcionArticulo.Text;
                    nuevoArticulo.Marca = (Marca)cboMarcaArticulo.SelectedItem;
                    nuevoArticulo.Categoria = (Categoria)cboCategoriaArticulo.SelectedItem;
                    nuevoArticulo.ImagenUrl = txtImagenUrlArticulo.Text;
                    nuevoArticulo.Precio = Convert.ToDecimal(txtPrecioArticulo.Text);

                    //guardo la imagen en una carpeta
                    if (archivo != null)
                    {
                        txtImagenUrlArticulo.Text = archivo.FileName;

                        string ruta = ConfigurationManager.AppSettings["images-folder"];
                        string nombreArchivo = archivo.SafeFileName;

                        if (archivo != null && !(txtImagenUrlArticulo.Text.ToUpper().Contains("HTTP")))
                        {
                            var result = MessageBox.Show("¿Desea guardar la imagen en la carpeta " + ruta + "?", "Confirm", MessageBoxButtons.YesNo);

                            if (result == DialogResult.Yes)
                            {
                                File.Copy(archivo.FileName, ruta + nombreArchivo);
                                MessageBox.Show("Se guardó la imágen en la carpeta: " + ruta);
                            }
                            
                            cargarImagen(archivo.FileName);
                        }
                    }
                    negocio.agregarArticulo(nuevoArticulo);
                    MessageBox.Show("Artículo agregado con éxito.");
                    Close();
                }
            }

            catch (FormatException ex)
            {
                MessageBox.Show("Ingresar un precio correcto.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                datos.desconectar_DB();
            }
        }

        /** BOTÓN AGREGAR IMAGEN **/
        private void btnAgregarImagenArticulo_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "JPeg Image|*.jpg|PNG Image|*.png";

            //si se le da seleccionar/ok a la seleccion de imagen entra al if...
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                //el campo de la url se completa con la ruta
                txtImagenUrlArticulo.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }

        // carga la imagen en el picturebox
        private void cargarImagen(string imagen)
        {
            try
            {
                pboAgregarImagen.Load(imagen);
            }
            catch 
            (Exception)
            {
                pboAgregarImagen.Load("https://vmotors.gex.pe/logo/imagen-no-disponible.jpg");
            }
        }
    }
}


