namespace Vista
{
    partial class FormProducto
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
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
            btnListar = new Button();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            txtNombre = new TextBox();
            txtPrecioCompra = new TextBox();
            txtStock = new TextBox();
            dtpFechaVencimiento = new DateTimePicker();
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
            dgvProductos.Size = new Size(671, 200);
            dgvProductos.TabIndex = 0;
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(583, 218);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(100, 30);
            btnListar.TabIndex = 5;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(583, 258);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 30);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(583, 298);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 30);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(583, 338);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 30);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(140, 220);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(378, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(140, 250);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(378, 27);
            txtPrecioCompra.TabIndex = 2;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(140, 280);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(378, 27);
            txtStock.TabIndex = 3;
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Location = new Point(140, 310);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(378, 27);
            dtpFechaVencimiento.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(12, 220);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(120, 23);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre:";
            // 
            // lblPrecioCompra
            // 
            lblPrecioCompra.Location = new Point(12, 250);
            lblPrecioCompra.Name = "lblPrecioCompra";
            lblPrecioCompra.Size = new Size(120, 23);
            lblPrecioCompra.TabIndex = 6;
            lblPrecioCompra.Text = "Precio Compra:";
            // 
            // lblStock
            // 
            lblStock.Location = new Point(12, 280);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(120, 23);
            lblStock.TabIndex = 7;
            lblStock.Text = "Stock:";
            // 
            // lblFechaVencimiento
            // 
            lblFechaVencimiento.Location = new Point(12, 310);
            lblFechaVencimiento.Name = "lblFechaVencimiento";
            lblFechaVencimiento.Size = new Size(120, 23);
            lblFechaVencimiento.TabIndex = 8;
            lblFechaVencimiento.Text = "Fecha Vencimiento:";
            // 
            // FormProducto
            // 
            ClientSize = new Size(770, 450);
            Controls.Add(dgvProductos);
            Controls.Add(txtNombre);
            Controls.Add(txtPrecioCompra);
            Controls.Add(txtStock);
            Controls.Add(dtpFechaVencimiento);
            Controls.Add(lblNombre);
            Controls.Add(lblPrecioCompra);
            Controls.Add(lblStock);
            Controls.Add(lblFechaVencimiento);
            Controls.Add(btnListar);
            Controls.Add(btnAgregar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Name = "FormProducto";
            Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}