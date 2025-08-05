using System;
using System.Windows.Forms;
using Modelo;
using Controladora;
using Repos;

namespace Vista
{
    public partial class MainForm : Form
    {
        private ControladoraProducto controladora;

        public MainForm()
        {
            InitializeComponent();
            var repoProd = new RepositorioProducto();
            controladora = new ControladoraProducto(repoProd);
            CargarDatos();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProducto = new FormProducto();
            formProducto.ShowDialog();
            CargarDatos();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = controladora.ListarProductos();
            dgvProductos.AutoResizeColumns();
        }
    }
}