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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();

            // dgvProductos
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(12, 12);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(460, 200);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);

            // lblNombre
            this.lblNombre.Location = new System.Drawing.Point(12, 220);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(120, 23);
            this.lblNombre.Text = "Nombre:";

            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(140, 220);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 23);
            this.txtNombre.TabIndex = 1;

            // lblPrecioCompra
            this.lblPrecioCompra.Location = new System.Drawing.Point(12, 250);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(120, 23);
            this.lblPrecioCompra.Text = "Precio Compra:";

            // txtPrecioCompra
            this.txtPrecioCompra.Location = new System.Drawing.Point(140, 250);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(200, 23);
            this.txtPrecioCompra.TabIndex = 2;

            // lblStock
            this.lblStock.Location = new System.Drawing.Point(12, 280);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(120, 23);
            this.lblStock.Text = "Stock:";

            // txtStock
            this.txtStock.Location = new System.Drawing.Point(140, 280);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(200, 23);
            this.txtStock.TabIndex = 3;

            // lblFechaVencimiento
            this.lblFechaVencimiento.Location = new System.Drawing.Point(12, 310);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(120, 23);
            this.lblFechaVencimiento.Text = "Fecha Vencimiento:";

            // dtpFechaVencimiento
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(140, 310);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaVencimiento.TabIndex = 4;

            // btnListar
            this.btnListar.Location = new System.Drawing.Point(370, 220);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(100, 30);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);

            // btnAgregar
            this.btnAgregar.Location = new System.Drawing.Point(370, 260);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 30);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            // btnModificar
            this.btnModificar.Location = new System.Drawing.Point(370, 300);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 30);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);

            // btnEliminar
            this.btnEliminar.Location = new System.Drawing.Point(370, 340);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            // FormProducto
            this.ClientSize = new System.Drawing.Size(484, 390);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.dtpFechaVencimiento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblPrecioCompra);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblFechaVencimiento);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Name = "FormProducto";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}