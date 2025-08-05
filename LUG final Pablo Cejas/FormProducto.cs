using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUG_final_Pablo_Cejas
{
    public partial class FormProducto : Form
    {
        private ControladoraProducto controladora;

        public FormProducto()
        {
            InitializeComponent();
            var repoProd = new RepositorioProducto();
            controladora = new ControladoraProducto(repoProd);
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = controladora.ListarProductos().ToList();
            dgvProductos.AutoResizeColumns();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var producto = new Producto
                {
                    Nombre = txtNombre.Text,
                    PrecioCompra = decimal.Parse(txtPrecioCompra.Text),
                    Stock = int.Parse(txtStock.Text),
                    FechaVencimiento = dtpFechaVencimiento.Value
                };
                controladora.AltaProducto(producto);
                CargarDatos();
                MessageBox.Show("Producto agregado con éxito.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.CurrentRow == null) return;

                var producto = dgvProductos.CurrentRow.DataBoundItem as Producto;
                if (producto == null) return;

                producto.Nombre = txtNombre.Text;
                producto.PrecioCompra = decimal.Parse(txtPrecioCompra.Text);
                producto.Stock = int.Parse(txtStock.Text);
                producto.FechaVencimiento = dtpFechaVencimiento.Value;

                controladora.ModificarProducto(producto);
                CargarDatos();
                MessageBox.Show("Producto modificado con éxito.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.CurrentRow == null) return;

                var producto = dgvProductos.CurrentRow.DataBoundItem as Producto;
                if (producto == null) return;

                controladora.BajaProducto(producto.Id);
                CargarDatos();
                MessageBox.Show("Producto eliminado (baja lógica) con éxito.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null) return;
            var producto = dgvProductos.CurrentRow.DataBoundItem as Producto;
            if (producto == null) return;

            txtNombre.Text = producto.Nombre;
            txtPrecioCompra.Text = producto.PrecioCompra.ToString();
            txtStock.Text = producto.Stock.ToString();
            dtpFechaVencimiento.Value = producto.FechaVencimiento;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPrecioCompra.Clear();
            txtStock.Clear();
            dtpFechaVencimiento.Value = DateTime.Today;
        }
    }
}
