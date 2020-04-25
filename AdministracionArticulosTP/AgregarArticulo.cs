using Dominio;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionArticulosTP
{
    public partial class AgregarArticulo : Form
    {
        public Articulo articulo = null;
        public AgregarArticulo()
        {
            InitializeComponent();
        }
        public AgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListadoArticulos listadoArticulos = new ListadoArticulos();
            listadoArticulos.Show();
            Dispose();
        }

        private void AgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                ComboMarca.DataSource = marcaNegocio.Listar();
                ComboMarca.ValueMember = "Id";
                ComboMarca.DisplayMember = "Descripcion";
                ComboMarca.SelectedIndex = -1;
                ComboCategoria.DataSource = categoriaNegocio.Listar();
                ComboCategoria.ValueMember = "Id";
                ComboCategoria.DisplayMember = "Descripcion";
                ComboCategoria.SelectedIndex = -1;

                if (articulo != null)
                {
                    Text = "Modificar";
                    btnAgregar.Text = "Modificar";
                    txtCodigo.Text = articulo.Codigo;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtNombre.Text = articulo.Nombre;
                    txtPrecio.Text = articulo.Precio.ToString();
                    txtImagen.Text = articulo.Imagen;
                    if (articulo.Marca != null) { ComboMarca.SelectedValue = articulo.Marca.Id; }
                    if (articulo.Categoria != null) { ComboCategoria.SelectedValue = articulo.Categoria.Id; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            
            try
            {
                if(articulo == null) 
                { 
                    articulo = new Articulo(); 
                }

                articulo.Codigo = txtCodigo.Text.Trim();
                articulo.Nombre = txtNombre.Text.Trim();
                articulo.Descripcion = txtDescripcion.Text.Trim();
                articulo.Marca = (Marca)ComboMarca.SelectedItem;
                articulo.Categoria = (Categoria)ComboCategoria.SelectedItem;
                articulo.Imagen = txtImagen.Text.Trim();
                var precio = txtPrecio.Text.Trim();
                articulo.Precio = Convert.ToDecimal(precio);

                if(articulo.Id != 0) 
                { articuloNegocio.Modificar(articulo); } 
                else
                { articuloNegocio.Agregar(articulo); }

                ListadoArticulos listadoArticulos = new ListadoArticulos();
                listadoArticulos.Show();
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
