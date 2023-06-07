namespace ProyFarmacia_GUI
{
    partial class ProductoMan01
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.cod_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.des_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pre_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoP = new System.Windows.Forms.DataGridViewImageColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(215, 17);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(314, 23);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lblRegistros
            // 
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(958, 415);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(84, 22);
            this.lblRegistros.TabIndex = 9;
            this.lblRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(879, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Registros:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ingrese filtro por descripcion:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(945, 460);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(97, 32);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(828, 460);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(97, 32);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(712, 460);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 32);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtgDatos
            // 
            this.dtgDatos.AllowUserToAddRows = false;
            this.dtgDatos.AllowUserToDeleteRows = false;
            this.dtgDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_pro,
            this.des_pro,
            this.TipoProducto,
            this.pre_pro,
            this.stock,
            this.UnidadMedida,
            this.fotoP,
            this.Estado});
            this.dtgDatos.Location = new System.Drawing.Point(12, 58);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.ReadOnly = true;
            this.dtgDatos.RowHeadersVisible = false;
            this.dtgDatos.RowTemplate.Height = 25;
            this.dtgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDatos.Size = new System.Drawing.Size(1030, 340);
            this.dtgDatos.TabIndex = 8;
            this.dtgDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDatos_CellContentClick);
            // 
            // cod_pro
            // 
            this.cod_pro.DataPropertyName = "cod_pro";
            this.cod_pro.HeaderText = "Codigo";
            this.cod_pro.Name = "cod_pro";
            this.cod_pro.ReadOnly = true;
            // 
            // des_pro
            // 
            this.des_pro.DataPropertyName = "des_pro";
            this.des_pro.HeaderText = "Descripcion";
            this.des_pro.Name = "des_pro";
            this.des_pro.ReadOnly = true;
            // 
            // TipoProducto
            // 
            this.TipoProducto.DataPropertyName = "TipoProducto";
            this.TipoProducto.HeaderText = "TipoProducto";
            this.TipoProducto.Name = "TipoProducto";
            this.TipoProducto.ReadOnly = true;
            // 
            // pre_pro
            // 
            this.pre_pro.DataPropertyName = "pre_pro";
            this.pre_pro.HeaderText = "Precio";
            this.pre_pro.Name = "pre_pro";
            this.pre_pro.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.DataPropertyName = "stock";
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // UnidadMedida
            // 
            this.UnidadMedida.DataPropertyName = "UnidadMedida";
            this.UnidadMedida.HeaderText = "UnidadMedida";
            this.UnidadMedida.Name = "UnidadMedida";
            this.UnidadMedida.ReadOnly = true;
            // 
            // fotoP
            // 
            this.fotoP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fotoP.DataPropertyName = "fotoP";
            this.fotoP.HeaderText = "Imagen";
            this.fotoP.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.fotoP.Name = "fotoP";
            this.fotoP.ReadOnly = true;
            this.fotoP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "cod_pro";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "DESCRIPCION";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "pre_pro";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // ProductoMan01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 507);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgDatos);
            this.Name = "ProductoMan01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Productos";
            this.Load += new System.EventHandler(this.ProductoMan01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtFiltro;
        private Label lblRegistros;
        private Label label2;
        private Label label1;
        private Button btnCerrar;
        private Button btnActualizar;
        private Button btnAgregar;
        private DataGridView dtgDatos;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn cod_pro;
        private DataGridViewTextBoxColumn des_pro;
        private DataGridViewTextBoxColumn TipoProducto;
        private DataGridViewTextBoxColumn pre_pro;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn UnidadMedida;
        private DataGridViewImageColumn fotoP;
        private DataGridViewTextBoxColumn Estado;
    }
}