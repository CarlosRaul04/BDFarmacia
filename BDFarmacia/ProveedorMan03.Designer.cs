namespace ProyFarmacia_GUI
{
    partial class ProveedorMan03
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
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.mskRuc = new System.Windows.Forms.MaskedTextBox();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.cboDistrito = new System.Windows.Forms.ComboBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lblCod = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtRS = new System.Windows.Forms.TextBox();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtRepVen = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRepVentas = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.chkEstado);
            this.grpDatos.Controls.Add(this.mskRuc);
            this.grpDatos.Controls.Add(this.cboDepartamento);
            this.grpDatos.Controls.Add(this.cboProvincia);
            this.grpDatos.Controls.Add(this.cboDistrito);
            this.grpDatos.Controls.Add(this.btnGrabar);
            this.grpDatos.Controls.Add(this.lblCod);
            this.grpDatos.Controls.Add(this.label9);
            this.grpDatos.Controls.Add(this.Label1);
            this.grpDatos.Controls.Add(this.txtRS);
            this.grpDatos.Controls.Add(this.txtDir);
            this.grpDatos.Controls.Add(this.txtRepVen);
            this.grpDatos.Controls.Add(this.txtTel);
            this.grpDatos.Controls.Add(this.Label2);
            this.grpDatos.Controls.Add(this.label6);
            this.grpDatos.Controls.Add(this.label8);
            this.grpDatos.Controls.Add(this.txtRepVentas);
            this.grpDatos.Controls.Add(this.label7);
            this.grpDatos.Controls.Add(this.label5);
            this.grpDatos.Controls.Add(this.Label3);
            this.grpDatos.Controls.Add(this.Label4);
            this.grpDatos.Controls.Add(this.btnCancelar);
            this.grpDatos.Location = new System.Drawing.Point(13, 4);
            this.grpDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpDatos.Size = new System.Drawing.Size(463, 434);
            this.grpDatos.TabIndex = 2;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(112, 369);
            this.chkEstado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(65, 19);
            this.chkEstado.TabIndex = 9;
            this.chkEstado.Text = "Activo?";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // mskRuc
            // 
            this.mskRuc.Location = new System.Drawing.Point(110, 179);
            this.mskRuc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mskRuc.Mask = "99999999999";
            this.mskRuc.Name = "mskRuc";
            this.mskRuc.Size = new System.Drawing.Size(116, 23);
            this.mskRuc.TabIndex = 4;
            this.mskRuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskRuc_KeyPress);
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(110, 220);
            this.cboDepartamento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(326, 23);
            this.cboDepartamento.TabIndex = 5;
            this.cboDepartamento.SelectionChangeCommitted += new System.EventHandler(this.cboDepartamento_SelectionChangeCommitted);
            // 
            // cboProvincia
            // 
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(110, 257);
            this.cboProvincia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(326, 23);
            this.cboProvincia.TabIndex = 6;
            this.cboProvincia.SelectionChangeCommitted += new System.EventHandler(this.cboProvincia_SelectionChangeCommitted);
            // 
            // cboDistrito
            // 
            this.cboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Location = new System.Drawing.Point(110, 294);
            this.cboDistrito.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboDistrito.MaxDropDownItems = 15;
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(326, 23);
            this.cboDistrito.TabIndex = 7;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(372, 343);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(84, 28);
            this.btnGrabar.TabIndex = 10;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lblCod
            // 
            this.lblCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCod.Location = new System.Drawing.Point(108, 37);
            this.lblCod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(74, 23);
            this.lblCod.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(9, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "Codigo:";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(9, 77);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(75, 18);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "R.Social:";
            // 
            // txtRS
            // 
            this.txtRS.Location = new System.Drawing.Point(110, 77);
            this.txtRS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRS.Name = "txtRS";
            this.txtRS.Size = new System.Drawing.Size(247, 23);
            this.txtRS.TabIndex = 1;
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(110, 113);
            this.txtDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(326, 23);
            this.txtDir.TabIndex = 2;
            // 
            // txtRepVen
            // 
            this.txtRepVen.Location = new System.Drawing.Point(110, 331);
            this.txtRepVen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRepVen.Name = "txtRepVen";
            this.txtRepVen.Size = new System.Drawing.Size(223, 23);
            this.txtRepVen.TabIndex = 8;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(110, 149);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTel.MaxLength = 9;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(96, 23);
            this.txtTel.TabIndex = 3;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(9, 111);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(75, 18);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Departamento:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(9, 369);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "Estado:";
            // 
            // txtRepVentas
            // 
            this.txtRepVentas.Location = new System.Drawing.Point(9, 335);
            this.txtRepVentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtRepVentas.Name = "txtRepVentas";
            this.txtRepVentas.Size = new System.Drawing.Size(93, 21);
            this.txtRepVentas.TabIndex = 20;
            this.txtRepVentas.Text = "Rep. Ventas:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(9, 185);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "RUC:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 257);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Provincia:";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(9, 149);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(75, 18);
            this.Label3.TabIndex = 15;
            this.Label3.Text = "Telefono:";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(9, 294);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(75, 18);
            this.Label4.TabIndex = 19;
            this.Label4.Text = "Distrito:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(372, 380);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 28);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ProveedorMan03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this.grpDatos);
            this.Name = "ProveedorMan03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Proveedor";
            this.Load += new System.EventHandler(this.ProveedorMan03_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal GroupBox grpDatos;
        private CheckBox chkEstado;
        private MaskedTextBox mskRuc;
        private ComboBox cboDepartamento;
        private ComboBox cboProvincia;
        private ComboBox cboDistrito;
        internal Button btnGrabar;
        internal Label lblCod;
        internal Label label9;
        internal Label Label1;
        internal TextBox txtRS;
        internal TextBox txtDir;
        internal TextBox txtRepVen;
        internal TextBox txtTel;
        internal Label Label2;
        internal Label label6;
        internal Label label8;
        internal Label txtRepVentas;
        internal Label label7;
        internal Label label5;
        internal Label Label3;
        internal Label Label4;
        internal Button btnCancelar;
    }
}