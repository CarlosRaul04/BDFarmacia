namespace ProyFarmacia_GUI
{
    partial class ProveedorMan01
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.dtgProveedor = new System.Windows.Forms.DataGridView();
            this.cod_prv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raz_soc_prv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dir_prv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruc_prv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rep_ven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(247, 18);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(330, 23);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(1178, 456);
            this.lblRegistros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(63, 26);
            this.lblRegistros.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1091, 457);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Registros:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ingrese iniciales de razon social:";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(1140, 502);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 27);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(1046, 502);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(88, 27);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertar.Location = new System.Drawing.Point(951, 502);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(88, 27);
            this.btnInsertar.TabIndex = 1;
            this.btnInsertar.Text = "Agregar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // dtgProveedor
            // 
            this.dtgProveedor.AllowUserToAddRows = false;
            this.dtgProveedor.AllowUserToDeleteRows = false;
            this.dtgProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_prv,
            this.raz_soc_prv,
            this.dir_prv,
            this.telefono,
            this.ruc_prv,
            this.Rep_ven,
            this.Departamento,
            this.Provincia,
            this.Distrito,
            this.Estado});
            this.dtgProveedor.Location = new System.Drawing.Point(22, 67);
            this.dtgProveedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtgProveedor.Name = "dtgProveedor";
            this.dtgProveedor.ReadOnly = true;
            this.dtgProveedor.RowHeadersVisible = false;
            this.dtgProveedor.RowTemplate.Height = 24;
            this.dtgProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProveedor.Size = new System.Drawing.Size(1217, 380);
            this.dtgProveedor.TabIndex = 9;
            // 
            // cod_prv
            // 
            this.cod_prv.DataPropertyName = "cod_prv";
            this.cod_prv.HeaderText = "Codigo";
            this.cod_prv.Name = "cod_prv";
            this.cod_prv.ReadOnly = true;
            // 
            // raz_soc_prv
            // 
            this.raz_soc_prv.DataPropertyName = "raz_soc_prv";
            this.raz_soc_prv.HeaderText = "RazonSocial";
            this.raz_soc_prv.Name = "raz_soc_prv";
            this.raz_soc_prv.ReadOnly = true;
            // 
            // dir_prv
            // 
            this.dir_prv.DataPropertyName = "dir_prv";
            this.dir_prv.HeaderText = "Direccion";
            this.dir_prv.Name = "dir_prv";
            this.dir_prv.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // ruc_prv
            // 
            this.ruc_prv.DataPropertyName = "ruc_prv";
            this.ruc_prv.HeaderText = "RUC";
            this.ruc_prv.Name = "ruc_prv";
            this.ruc_prv.ReadOnly = true;
            // 
            // Rep_ven
            // 
            this.Rep_ven.DataPropertyName = "Rep_ven";
            this.Rep_ven.HeaderText = "Vendedor";
            this.Rep_ven.Name = "Rep_ven";
            this.Rep_ven.ReadOnly = true;
            // 
            // Departamento
            // 
            this.Departamento.DataPropertyName = "Departamento";
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            // 
            // Provincia
            // 
            this.Provincia.DataPropertyName = "Provincia";
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.Name = "Provincia";
            this.Provincia.ReadOnly = true;
            // 
            // Distrito
            // 
            this.Distrito.DataPropertyName = "Distrito";
            this.Distrito.HeaderText = "Distrito";
            this.Distrito.Name = "Distrito";
            this.Distrito.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // ProveedorMan01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 541);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dtgProveedor);
            this.Name = "ProveedorMan01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Proveedores";
            this.Load += new System.EventHandler(this.ProveedorMan01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtFiltro;
        private Label lblRegistros;
        private Label label2;
        private Label label1;
        private Button btnSalir;
        private Button btnActualizar;
        private Button btnInsertar;
        private DataGridView dtgProveedor;
        private DataGridViewTextBoxColumn cod_prv;
        private DataGridViewTextBoxColumn raz_soc_prv;
        private DataGridViewTextBoxColumn dir_prv;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn ruc_prv;
        private DataGridViewTextBoxColumn Rep_ven;
        private DataGridViewTextBoxColumn Departamento;
        private DataGridViewTextBoxColumn Provincia;
        private DataGridViewTextBoxColumn Distrito;
        private DataGridViewTextBoxColumn Estado;
    }
}