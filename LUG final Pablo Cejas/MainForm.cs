using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = "Sistema de Gesti�n de Stock - Men� Principal";
        }

        private void btnGestionProductos_Click(object sender, EventArgs e)
        {
            var formProd = new FormProducto();
            formProd.ShowDialog();
        }
    }
}
