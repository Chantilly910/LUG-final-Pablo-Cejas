namespace Vista
{
    partial class FormProducto
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblFechaVencimiento;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvProductos = new DataGridView();
            txtNombre = new TextBox();
            txtPrecioCompra = new TextBox();
            txtStock = new TextBox();
            dtpFechaVencimiento = new DateTimePicker();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            lblNombre = new Label();
            lblPrecioCompra = new Label();
            lblStock = new Label();
            lblFechaVencimiento = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 12);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(560, 200);
            dgvProductos.TabIndex = 0;
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(186, 233);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(186, 263);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(200, 27);
            txtPrecioCompra.TabIndex = 2;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(186, 293);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(200, 27);
            txtStock.TabIndex = 3;
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Format = DateTimePickerFormat.Short;
            dtpFechaVencimiento.Location = new Point(186, 323);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(200, 27);
            dtpFechaVencimiento.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(472, 240);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 30);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(472, 280);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 30);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(472, 320);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 30);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(40, 233);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre";
            // 
            // lblPrecioCompra
            // 
            lblPrecioCompra.AutoSize = true;
            lblPrecioCompra.Location = new Point(40, 263);
            lblPrecioCompra.Name = "lblPrecioCompra";
            lblPrecioCompra.Size = new Size(107, 20);
            lblPrecioCompra.TabIndex = 9;
            lblPrecioCompra.Text = "Precio Compra";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(40, 293);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(45, 20);
            lblStock.TabIndex = 10;
            lblStock.Text = "Stock";
            // 
            // lblFechaVencimiento
            // 
            lblFechaVencimiento.AutoSize = true;
            lblFechaVencimiento.Location = new Point(40, 325);
            lblFechaVencimiento.Name = "lblFechaVencimiento";
            lblFechaVencimiento.Size = new Size(133, 20);
            lblFechaVencimiento.TabIndex = 11;
            lblFechaVencimiento.Text = "Fecha Vencimiento";
            // 
            // FormProducto
            // 
            ClientSize = new Size(701, 446);
            Controls.Add(lblFechaVencimiento);
            Controls.Add(lblStock);
            Controls.Add(lblPrecioCompra);
            Controls.Add(lblNombre);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dtpFechaVencimiento);
            Controls.Add(txtStock);
            Controls.Add(txtPrecioCompra);
            Controls.Add(txtNombre);
            Controls.Add(dgvProductos);
            Name = "FormProducto";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}