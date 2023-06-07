namespace ProyFarmacia_GUI
{
    partial class EmpleadoMan03
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
            this.lblCod = new System.Windows.Forms.Label();
            this.mskcel = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboDistrito = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.chkEstado);
            this.grpDatos.Controls.Add(this.lblCod);
            this.grpDatos.Controls.Add(this.mskcel);
            this.grpDatos.Controls.Add(this.label9);
            this.grpDatos.Controls.Add(this.cboDepartamento);
            this.grpDatos.Controls.Add(this.Label1);
            this.grpDatos.Controls.Add(this.cboProvincia);
            this.grpDatos.Controls.Add(this.btnCancelar);
            this.grpDatos.Controls.Add(this.cboDistrito);
            this.grpDatos.Controls.Add(this.label10);
            this.grpDatos.Controls.Add(this.btnGrabar);
            this.grpDatos.Controls.Add(this.label4);
            this.grpDatos.Controls.Add(this.label5);
            this.grpDatos.Controls.Add(this.txtNom);
            this.grpDatos.Controls.Add(this.label7);
            this.grpDatos.Controls.Add(this.txtApe);
            this.grpDatos.Controls.Add(this.label3);
            this.grpDatos.Controls.Add(this.txtDir);
            this.grpDatos.Controls.Add(this.label8);
            this.grpDatos.Controls.Add(this.txtdni);
            this.grpDatos.Controls.Add(this.label6);
            this.grpDatos.Controls.Add(this.Label2);
            this.grpDatos.Location = new System.Drawing.Point(13, 12);
            this.grpDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpDatos.Size = new System.Drawing.Size(463, 444);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            this.grpDatos.Enter += new System.EventHandler(this.grpDatos_Enter);
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(110, 368);
            this.chkEstado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(65, 19);
            this.chkEstado.TabIndex = 10;
            this.chkEstado.Text = "Activo?";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // lblCod
            // 
            this.lblCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCod.Location = new System.Drawing.Point(108, 37);
            this.lblCod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(74, 23);
            this.lblCod.TabIndex = 1;
            // 
            // mskcel
            // 
            this.mskcel.Location = new System.Drawing.Point(110, 146);
            this.mskcel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mskcel.Mask = "999999999";
            this.mskcel.Name = "mskcel";
            this.mskcel.Size = new System.Drawing.Size(116, 23);
            this.mskcel.TabIndex = 4;
            this.mskcel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskcel_KeyPress);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(9, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Codigo:";
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(110, 252);
            this.cboDepartamento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(326, 23);
            this.cboDepartamento.TabIndex = 7;
            this.cboDepartamento.SelectionChangeCommitted += new System.EventHandler(this.cboDepartamento_SelectionChangeCommitted);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(9, 75);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(75, 18);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Nombre:";
            // 
            // cboProvincia
            // 
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(110, 289);
            this.cboProvincia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(326, 23);
            this.cboProvincia.TabIndex = 8;
            this.cboProvincia.SelectionChangeCommitted += new System.EventHandler(this.cboProvincia_SelectionChangeCommitted);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(352, 405);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 28);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboDistrito
            // 
            this.cboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Location = new System.Drawing.Point(110, 326);
            this.cboDistrito.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(326, 23);
            this.cboDistrito.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(9, 326);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "Distrito:";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(352, 368);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(84, 28);
            this.btnGrabar.TabIndex = 11;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Celular:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 289);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Provincia:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(110, 75);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(116, 23);
            this.txtNom.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(9, 184);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "DNI:";
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(110, 111);
            this.txtApe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(116, 23);
            this.txtApe.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Dirección";
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(110, 214);
            this.txtDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(247, 23);
            this.txtDir.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(9, 369);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Estado:";
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(110, 179);
            this.txtdni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtdni.MaxLength = 8;
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(96, 23);
            this.txtdni.TabIndex = 5;
            this.txtdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdni_KeyPress);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Departamento:";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(9, 111);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(75, 18);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "Apellido:";
            // 
            // EmpleadoMan03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 468);
            this.Controls.Add(this.grpDatos);
            this.Name = "EmpleadoMan03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Empleado";
            this.Load += new System.EventHandler(this.EmpleadoMan03_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal GroupBox grpDatos;
        internal Label lblCod;
        internal Label label9;
        private MaskedTextBox mskcel;
        private ComboBox cboDepartamento;
        internal Label Label1;
        private ComboBox cboProvincia;
        internal Button btnCancelar;
        private ComboBox cboDistrito;
        internal Label label10;
        internal Button btnGrabar;
        internal Label label4;
        internal Label label5;
        internal TextBox txtNom;
        internal Label label7;
        internal TextBox txtApe;
        internal Label label3;
        internal TextBox txtDir;
        internal TextBox txtdni;
        internal Label label6;
        internal Label Label2;
        private CheckBox chkEstado;
        internal Label label8;
    }
}