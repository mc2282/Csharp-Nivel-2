using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace GestionDeArticulos
{
    public partial class frmDetalleArticulo : Form
    {
        public Articulo articuloSelec { get; set; }
        public frmDetalleArticulo()
        {
            InitializeComponent();
        }

        private void frmDetalleArticulo_Load(object sender, EventArgs e)
        {
            verDetalleArticulos();
        }
        
        private void verDetalleArticulos()
        {
            txtCatDetalleArt.Text = articuloSelec.Categoria.Descripcion;
            txtMarcaDetalleArt.Text = articuloSelec.Marca.Descripcion;

            txtIdDetalleArt.Text = articuloSelec.Id.ToString();
            txtCodDetalleArt.Text = articuloSelec.Codigo;
            txtNombreDetalleArt.Text = articuloSelec.Nombre;
            //txtMarcaDetalleArt.Text = articuloSelec.Marca.Id.ToString();
            //txtCatDetalleArt.Text = articuloSelec.Categoria.Id.ToString();

            txtPrecioDetalleArt.Text = "$ " + articuloSelec.Precio.ToString("N");
            txtDescripcionDetalleArt.Text = articuloSelec.Descripcion;
            txtImagenUrlDetalleArt.Text = articuloSelec.ImagenUrl;

            cargarImagen2();
        }

        /** CARGA DE LA IMÁGEN DEL ARTÍCULO EN EL PICTUREBOX **/
        public void cargarImagen2()
        {
            try
            {
                // imagen nula -> se carga imagen no encontrada: 
                if (articuloSelec.ImagenUrl == null)
                {
                    pboImagenUrlDetalle.Load("https://vmotors.gex.pe/logo/imagen-no-disponible.jpg");
                }
                // imagen con https -> se carga desde internet:
                else if (articuloSelec.ImagenUrl.Contains("https://"))
                {
                    pboImagenUrlDetalle.Load(articuloSelec.ImagenUrl);
                }
                else
                {
                    pboImagenUrlDetalle.Load(articuloSelec.ImagenUrl);
                }
            }
            catch (Exception)
            {
                pboImagenUrlDetalle.Load("https://vmotors.gex.pe/logo/imagen-no-disponible.jpg");
            }
        }
    }
}


