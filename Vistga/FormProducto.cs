using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormProducto : Form
    {
        public FormProducto()
        {
            InitializeComponent();
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                var row = dgvProductos.SelectedRows[0];
                txtNombre.Text = row.Cells["Nombre"].Value?.ToString() ?? "";
                txtPrecioCompra.Text = row.Cells["PrecioCompra"].Value?.ToString() ?? "";
                txtStock.Text = row.Cells["Stock"].Value?.ToString() ?? "";
                dtpFechaVencimiento.Value = row.Cells["FechaVencimiento"].Value != null
                    ? Convert.ToDateTime(row.Cells["FechaVencimiento"].Value)
                    : DateTime.Today;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Agregar producto (implementa la lógica aquí)");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modificar producto (implementa la lógica aquí)");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eliminar producto (implementa la lógica aquí)");
        }
    }
}