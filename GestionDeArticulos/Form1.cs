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
using System.IO;
using System.Globalization;

namespace GestionDeArticulos
{
    public partial class Form1 : Form
    {
        private List<Articulo> listaArticulos;
        public Form1()
        {
            InitializeComponent();
            cargarCamposFiltro();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }   
        }

        /** BOTÓN AGREGAR **/
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                frmAgregarArticulo nuevoArticulo = new frmAgregarArticulo();
                nuevoArticulo.ShowDialog();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                actualizar();
            }
        }

        /** BOTÓN MODIFICAR **/
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
            Articulo artSeleccionado = new Articulo();
            artSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmModificarArticulo ventanaModificar = new frmModificarArticulo(artSeleccionado);
            ventanaModificar.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                actualizar();
            }
        }

        /** BOTÓN ELIMINAR **/
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            NegocioArticulos negocio = new NegocioArticulos();
            Articulo artSeleccionado = new Articulo();
            try
            {
                artSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                var result = MessageBox.Show("¿Está seguro que desea eliminar el artículo " + artSeleccionado.Codigo + "?", "Confirm", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    negocio.eliminarArticulo(artSeleccionado);
                    MessageBox.Show("El artículo fue eliminado.");
                }
                else
                { 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                actualizar();
            }
        }

        /** BOTÓN DETALLE **/
        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Articulo artSeleccionado = new Articulo();
            frmDetalleArticulo form2 = new frmDetalleArticulo();
            try { 
            if (artSeleccionado != null)
            {
                artSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            }
            else
            {
                MessageBox.Show("Seleccione una fila.");
            }
                form2.articuloSelec = artSeleccionado;
                form2.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        /** ACTUALIZA LA DATAGRIDVIEW **/
        private void actualizar() 
        {
            try
            {
                NegocioArticulos metodos = new NegocioArticulos();

                listaArticulos = metodos.listarArticulos();
                dgvArticulos.DataSource = listaArticulos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        /** BÚSQUEDA RÁPIDA **/
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtBuscar.Text;

            if (filtro.Length >= 3)
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
        }

        /** BÚSQUEDA AVANZADA **/
        private void btnFiltro2_Click(object sender, EventArgs e)
        {
            NegocioArticulos negocio = new NegocioArticulos();
            try
            {//si no hay campo seleccionado...
                if (cboCampo.SelectedIndex > -1 )       
                {
                    string campo = cboCampo.SelectedItem.ToString();
                    //si no hay criterio seleccionado...
                    if (cboCriterio.SelectedIndex > -1)
                    {
                    string criterio = cboCriterio.SelectedItem.ToString();
                    
                    string filtro = txtFiltro2.Text.ToString();

                    //si el input filtro esta vacío...
                    if (filtro == "")
                    {
                        MessageBox.Show("Ingrese un filtro.");
                    }
                    //método filtrar devuelve una lista con los criterios filtrados
                    dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un criterio.");
                    }
                }
                else
                {
                MessageBox.Show("Seleccione un campo.");
                }
            }
            
            catch (Exception)
            {
                MessageBox.Show("Ingrese un precio correcto.");
            }
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string campo = cboCampo.SelectedItem.ToString();

            if (campo == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }
        private void cargarCamposFiltro()
        {
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Codigo");
            cboCampo.Items.Add("Descripcion");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoria");
            cboCampo.Items.Add("Precio");
        }

        //Formato de las celdas de la columna 7 para el precio
        private void dgvArticulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 7 || e.ColumnIndex == 7)
            {
                e.CellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-AR");
                e.CellStyle.Format = String.Format("c");
            }
        }
    }
}



