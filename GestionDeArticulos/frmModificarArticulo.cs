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
using static System.Net.Mime.MediaTypeNames;

namespace GestionDeArticulos
{
    public partial class frmModificarArticulo : Form
    {
        public Articulo articulo;
        private OpenFileDialog archivo = null;

        public frmModificarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            cargarImagen2();
        }

        private void frmModificarArticulo_Load(object sender, EventArgs e)
        {
            NegocioCategorias negocioCategorias = new NegocioCategorias();
            NegocioMarcas negocioMarcas = new NegocioMarcas();

            cboCategoriaArticulo2.DataSource = negocioCategorias.listarCategorias();
            cboCategoriaArticulo2.ValueMember = "Id";
            cboCategoriaArticulo2.DisplayMember = "Descripcion";

            cboMarcaArticulo2.DataSource = negocioMarcas.listarMarcas();
            cboMarcaArticulo2.ValueMember = "Id";
            cboMarcaArticulo2.DisplayMember = "Descripcion";

            cargardatos(articulo);
        }

        /** CARGA DE LOS DATOS DEL ARTÍCULO EN EL PICTUREBOX **/
        private void cargardatos(Articulo articulo)
        {
            NegocioArticulos negocio = new NegocioArticulos();
            List<Articulo> listaArticulos;

            listaArticulos = negocio.listarArticulos();

            lbl_IDarticuloMod.Text = articulo.Id.ToString();
            txtCodArticulo2.Text = articulo.Codigo.ToString();
            txtNombreArticulo2.Text = articulo.Nombre.ToString();
            txtDescripcionArticulo2.Text = articulo.Descripcion.ToString();
            cboMarcaArticulo2.SelectedItem = articulo.Marca.Id.ToString();
            cboCategoriaArticulo2.SelectedItem = articulo.Categoria.Id.ToString();
            txtImagenUrlArticulo2.Text = articulo.ImagenUrl.ToString();
            txtPrecioArticulo2.Text = articulo.Precio.ToString("N2");
        }

        /** BOTÓN MODIFICAR ARTÍCULO **/
        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            AccesoDatos datos = new AccesoDatos();
            NegocioArticulos negocio = new NegocioArticulos();

            try
            {
                if (string.IsNullOrEmpty(txtCodArticulo2.Text) || string.IsNullOrEmpty(txtNombreArticulo2.Text) || string.IsNullOrEmpty(txtDescripcionArticulo2.Text) || string.IsNullOrEmpty(txtPrecioArticulo2.Text) || string.IsNullOrEmpty(txtImagenUrlArticulo2.Text))
                {
                    MessageBox.Show("Complete los campos vacíos.");
                }
                else
                {
                    articulo.Codigo = txtCodArticulo2.Text;
                    articulo.Nombre = txtNombreArticulo2.Text;
                    articulo.Descripcion = txtDescripcionArticulo2.Text;
                    articulo.Marca = (Marca)cboMarcaArticulo2.SelectedItem;
                    articulo.Categoria = (Categoria)cboCategoriaArticulo2.SelectedItem;
                    articulo.ImagenUrl = txtImagenUrlArticulo2.Text;
                    articulo.Precio = Convert.ToDecimal(txtPrecioArticulo2.Text);

                    //guarda la imagen en una carpeta
                    if (archivo != null)
                    {
                        txtImagenUrlArticulo2.Text = archivo.FileName;

                        string ruta = ConfigurationManager.AppSettings["images-folder"];
                        string nombreArchivo = archivo.SafeFileName;

                        if (archivo != null && !(txtImagenUrlArticulo2.Text.ToUpper().Contains("HTTP")))
                        {
                            var result = MessageBox.Show("¿Desea guardar la imagen en la carpeta " + ruta + "?", "Confirm", MessageBoxButtons.YesNo);

                            if (result == DialogResult.Yes)
                            {
                                File.Copy(archivo.FileName, ruta + nombreArchivo);
                                MessageBox.Show("Se guardó la imágen en la carpeta: " + ruta);
                            }
                        }
                    }
                    negocio.modificarArticulo(articulo);
                    MessageBox.Show("Artículo modificado con éxito.");
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

        private void btnModificarImagenArticulo2_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            //permite agregar imagenes con extension especifica
            archivo.Filter = "JPeg Image|*.jpg|PNG Image|*.png";

            //si se le da seleccionar/ok a la seleccion de imagen entra al if...
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagenUrlArticulo2.Text = archivo.FileName;

                cargarImagen(archivo.FileName);
            }
        }

        /** SE MUESTRA LA IMÁGEN DEL ARTÍCULO EN EL PICTUREBOX **/
        private void cargarImagen(string imagen)
        {
            try
            {
                pboModImagen2.Load(imagen);
            }
            catch
            (Exception ex)
            {
                pboModImagen2.Load("https://vmotors.gex.pe/logo/imagen-no-disponible.jpg");
            }
        }

        private void cargarImagen2()
        {
            try
            {
                // imagen nula -> se carga imagen no encontrada: 
                if (articulo.ImagenUrl == null)
                {
                    pboModImagen2.Load("https://vmotors.gex.pe/logo/imagen-no-disponible.jpg");
                }
                // imagen con https -> se carga desde internet:
                else if (articulo.ImagenUrl.Contains("https://"))
                {
                    pboModImagen2.Load(articulo.ImagenUrl);
                }
                else
                {
                    pboModImagen2.Load(articulo.ImagenUrl);
                }
            }
            catch (Exception ex)
            {
                pboModImagen2.Load("https://vmotors.gex.pe/logo/imagen-no-disponible.jpg");
            }
        }
    }
}


