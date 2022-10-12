namespace PresentacionCatalogo
{
    partial class FrmRegistrar
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.chbMostrar = new System.Windows.Forms.CheckBox();
            this.txtConfContraseña = new System.Windows.Forms.TextBox();
            this.lblConfContraseña = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApeP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApeM = new System.Windows.Forms.TextBox();
            this.txtfdn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPermisos = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(189, 31);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(457, 38);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(51, 31);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(90, 32);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "USUARIO";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(51, 88);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(129, 32);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "CONTRASEÑA";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(189, 88);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(457, 38);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // chbMostrar
            // 
            this.chbMostrar.AutoSize = true;
            this.chbMostrar.Location = new System.Drawing.Point(409, 137);
            this.chbMostrar.Name = "chbMostrar";
            this.chbMostrar.Size = new System.Drawing.Size(237, 36);
            this.chbMostrar.TabIndex = 4;
            this.chbMostrar.Text = "MOSTRAR CONTRASEÑA";
            this.chbMostrar.UseVisualStyleBackColor = true;
            this.chbMostrar.CheckedChanged += new System.EventHandler(this.chbMostrar_CheckedChanged);
            // 
            // txtConfContraseña
            // 
            this.txtConfContraseña.Location = new System.Drawing.Point(290, 189);
            this.txtConfContraseña.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtConfContraseña.Name = "txtConfContraseña";
            this.txtConfContraseña.Size = new System.Drawing.Size(356, 38);
            this.txtConfContraseña.TabIndex = 5;
            this.txtConfContraseña.Enter += new System.EventHandler(this.txtConfContraseña_Enter);
            this.txtConfContraseña.Leave += new System.EventHandler(this.txtConfContraseña_Leave);
            // 
            // lblConfContraseña
            // 
            this.lblConfContraseña.AutoSize = true;
            this.lblConfContraseña.Location = new System.Drawing.Point(51, 189);
            this.lblConfContraseña.Name = "lblConfContraseña";
            this.lblConfContraseña.Size = new System.Drawing.Size(236, 32);
            this.lblConfContraseña.TabIndex = 6;
            this.lblConfContraseña.Text = "CONFIRMAR CONTRASEÑA";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(51, 243);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(84, 32);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(189, 243);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 38);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 289);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "APELLIDO PATERNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 282);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "APELLIDO MATERNO";
            // 
            // txtApeP
            // 
            this.txtApeP.Location = new System.Drawing.Point(57, 322);
            this.txtApeP.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtApeP.Name = "txtApeP";
            this.txtApeP.Size = new System.Drawing.Size(282, 38);
            this.txtApeP.TabIndex = 11;
            this.txtApeP.Enter += new System.EventHandler(this.txtApeP_Enter);
            this.txtApeP.Leave += new System.EventHandler(this.txtApeP_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 387);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "FDN";
            // 
            // txtApeM
            // 
            this.txtApeM.Location = new System.Drawing.Point(371, 322);
            this.txtApeM.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtApeM.Name = "txtApeM";
            this.txtApeM.Size = new System.Drawing.Size(275, 38);
            this.txtApeM.TabIndex = 12;
            this.txtApeM.Enter += new System.EventHandler(this.txtApeM_Enter);
            this.txtApeM.Leave += new System.EventHandler(this.txtApeM_Leave);
            // 
            // txtfdn
            // 
            this.txtfdn.Location = new System.Drawing.Point(123, 384);
            this.txtfdn.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtfdn.Name = "txtfdn";
            this.txtfdn.Size = new System.Drawing.Size(216, 38);
            this.txtfdn.TabIndex = 14;
            this.txtfdn.Enter += new System.EventHandler(this.txtfdn_Enter);
            this.txtfdn.Leave += new System.EventHandler(this.txtfdn_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 451);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "PERMISOS";
            // 
            // txtPermisos
            // 
            this.txtPermisos.Location = new System.Drawing.Point(175, 448);
            this.txtPermisos.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtPermisos.Name = "txtPermisos";
            this.txtPermisos.Size = new System.Drawing.Size(239, 38);
            this.txtPermisos.TabIndex = 16;
            this.txtPermisos.Enter += new System.EventHandler(this.txtPermisos_Enter);
            this.txtPermisos.Leave += new System.EventHandler(this.txtPermisos_Leave);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(508, 383);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(138, 41);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(508, 451);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 41);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(712, 534);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPermisos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtfdn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApeM);
            this.Controls.Add(this.txtApeP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblConfContraseña);
            this.Controls.Add(this.txtConfContraseña);
            this.Controls.Add(this.chbMostrar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Font = new System.Drawing.Font("Sunday Best", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "FrmRegistrar";
            this.Text = "FrmRegistrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.CheckBox chbMostrar;
        private System.Windows.Forms.TextBox txtConfContraseña;
        private System.Windows.Forms.Label lblConfContraseña;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApeP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApeM;
        private System.Windows.Forms.TextBox txtfdn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPermisos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}