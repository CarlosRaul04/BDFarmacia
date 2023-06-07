namespace ProyFarmacia_GUI
{
    partial class EmpleadoMan02
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
            this.mskcel = new System.Windows.Forms.MaskedTextBox();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.cboDistrito = new System.Windows.Forms.ComboBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.grpDatos.Controls.Add(this.mskcel);
            this.grpDatos.Controls.Add(this.cboDepartamento);
            this.grpDatos.Controls.Add(this.cboProvincia);
            this.grpDatos.Controls.Add(this.cboDistrito);
            this.grpDatos.Controls.Add(this.btnGrabar);
            this.grpDatos.Controls.Add(this.Label1);
            this.grpDatos.Controls.Add(this.txtNom);
            this.grpDatos.Controls.Add(this.txtApe);
            this.grpDatos.Controls.Add(this.txtDir);
            this.grpDatos.Controls.Add(this.txtdni);
            this.grpDatos.Controls.Add(this.Label2);
            this.grpDatos.Controls.Add(this.label6);
            this.grpDatos.Controls.Add(this.label8);
            this.grpDatos.Controls.Add(this.label9);
            this.grpDatos.Controls.Add(this.label7);
            this.grpDatos.Controls.Add(this.label5);
            this.grpDatos.Controls.Add(this.Label3);
            this.grpDatos.Controls.Add(this.Label4);
            this.grpDatos.Controls.Add(this.btnCancelar);
            this.grpDatos.Location = new System.Drawing.Point(13, 12);
            this.grpDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpDatos.Size = new System.Drawing.Size(463, 426);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(110, 328);
            this.chkEstado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(65, 19);
            this.chkEstado.TabIndex = 9;
            this.chkEstado.Text = "Activo?";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // mskcel
            // 
            this.mskcel.Location = new System.Drawing.Point(110, 100);
            this.mskcel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mskcel.Mask = "999999999";
            this.mskcel.Name = "mskcel";
            this.mskcel.Size = new System.Drawing.Size(116, 23);
            this.mskcel.TabIndex = 3;
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(110, 206);
            this.cboDepartamento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(326, 23);
            this.cboDepartamento.TabIndex = 6;
            this.cboDepartamento.SelectionChangeCommitted += new System.EventHandler(this.cboDepartamento_SelectionChangeCommitted);
            // 
            // cboProvincia
            // 
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(110, 243);
            this.cboProvincia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(326, 23);
            this.cboProvincia.TabIndex = 7;
            this.cboProvincia.SelectionChangeCommitted += new System.EventHandler(this.cboProvincia_SelectionChangeCommitted);
            // 
            // cboDistrito
            // 
            this.cboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Location = new System.Drawing.Point(110, 280);
            this.cboDistrito.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(326, 23);
            this.cboDistrito.TabIndex = 8;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(352, 328);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(84, 28);
            this.btnGrabar.TabIndex = 10;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(9, 29);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(75, 18);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Nombre:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(110, 29);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(116, 23);
            this.txtNom.TabIndex = 1;
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(110, 65);
            this.txtApe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(116, 23);
            this.txtApe.TabIndex = 2;
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(110, 168);
            this.txtDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(247, 23);
            this.txtDir.TabIndex = 5;
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(110, 133);
            this.txtdni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtdni.MaxLength = 8;
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(96, 23);
            this.txtdni.TabIndex = 4;
            this.txtdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdni_KeyPress);
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(9, 65);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(75, 18);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Apellido:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Departamento:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(9, 328);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(9, 173);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Dirección";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(9, 138);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "DNI:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 243);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Provincia:";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(9, 103);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(75, 18);
            this.Label3.TabIndex = 13;
            this.Label3.Text = "Celular:";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(9, 280);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(75, 18);
            this.Label4.TabIndex = 18;
            this.Label4.Text = "Distrito:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(352, 365);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 28);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // EmpleadoMan02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.grpDatos);
            this.Name = "EmpleadoMan02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insertar Empleado";
            this.Load += new System.EventHandler(this.EmpleadoMan02_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal GroupBox grpDatos;
        private CheckBox chkEstado;
        private MaskedTextBox mskcel;
        private ComboBox cboDepartamento;
        private ComboBox cboProvincia;
        private ComboBox cboDistrito;
        internal Button btnGrabar;
        internal Label Label1;
        internal TextBox txtNom;
        internal TextBox txtApe;
        internal TextBox txtdni;
        internal Label Label2;
        internal Label label6;
        internal Label label8;
        internal Label label7;
        internal Label label5;
        internal Label Label3;
        internal Label Label4;
        internal Button btnCancelar;
        internal TextBox txtDir;
        internal Label label9;
    }
}