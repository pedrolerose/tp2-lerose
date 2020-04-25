using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Dominio;
using Service;

namespace AdministracionArticulosTP
{
    public partial class ListadoArticulos : Form
    {
        private List<Articulo> lista;
        public ListadoArticulos()
        {
            InitializeComponent();
        }

        private void GridListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ListadoArticulos_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        public void Cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                lista = negocio.Listar();
                dgvListadoArticulos.DataSource = lista;
                dgvListadoArticulos.Columns[7].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
            AgregarArticulo modificarArticulo = new AgregarArticulo(seleccionado);
            modificarArticulo.Show();
            Dispose();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            seleccionado = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
            negocio.Eliminar(seleccionado.Id);
            Cargar();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AgregarArticulo agregarArticulo = new AgregarArticulo();
            agregarArticulo.Show();
            Dispose();
        }

        private void Filtrar(List<Articulo> parametro)
        {
            List<Articulo> listaFiltrada;
            try
            {
                if (txtBusqueda.Text == "")
                {
                    listaFiltrada = parametro;
                }
                else
                {
                    listaFiltrada = parametro.FindAll(c => c.Nombre.ToLower().Contains(txtBusqueda.Text.ToLower()));
                }
                dgvListadoArticulos.DataSource = listaFiltrada;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            Filtrar(lista);
        }

        private void dgvListadoArticulos_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Articulo seleccionado;
                seleccionado = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;

                Imagenes.Load(seleccionado.Imagen);
            }
            catch (Exception ex)
            {
                Imagenes.Load(@"C:\Users\Tape\Desktop\Pe\2do Año\1er Cuatrimestre\Programacion 3\TP2_Lerose\AdministracionArticulosTP\NoImage.jpg");
            }
        }

    }
}
