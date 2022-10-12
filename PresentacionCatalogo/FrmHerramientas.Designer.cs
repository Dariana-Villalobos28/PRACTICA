namespace PresentacionCatalogo
{
    partial class FrmHerramientas
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblRefracciones = new System.Windows.Forms.Label();
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnHerramientas = new System.Windows.Forms.Button();
            this.btnRefracciones = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Sunday Best", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(574, 457);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(128, 47);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Sunday Best", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(404, 457);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(154, 47);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sunday Best", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(635, 118);
            this.button1.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 47);
            this.button1.TabIndex = 21;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Sunday Best", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(233, 119);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(392, 46);
            this.txtBuscar.TabIndex = 20;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblRefracciones
            // 
            this.lblRefracciones.AutoSize = true;
            this.lblRefracciones.Font = new System.Drawing.Font("Sunday Best", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefracciones.Location = new System.Drawing.Point(293, 8);
            this.lblRefracciones.Name = "lblRefracciones";
            this.lblRefracciones.Size = new System.Drawing.Size(349, 72);
            this.lblRefracciones.TabIndex = 19;
            this.lblRefracciones.Text = "HERRAMIENTAS";
            // 
            // dtgDatos
            // 
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Location = new System.Drawing.Point(233, 177);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.Size = new System.Drawing.Size(469, 268);
            this.dtgDatos.TabIndex = 18;
            this.dtgDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDatos_CellContentClick);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Sunday Best", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(47, 336);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(128, 47);
            this.btnAdmin.TabIndex = 17;
            this.btnAdmin.Text = "ADMIN";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnHerramientas
            // 
            this.btnHerramientas.Font = new System.Drawing.Font("Sunday Best", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHerramientas.Location = new System.Drawing.Point(10, 270);
            this.btnHerramientas.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.btnHerramientas.Name = "btnHerramientas";
            this.btnHerramientas.Size = new System.Drawing.Size(199, 48);
            this.btnHerramientas.TabIndex = 16;
            this.btnHerramientas.Text = "HERRAMIENTAS";
            this.btnHerramientas.UseVisualStyleBackColor = true;
            // 
            // btnRefracciones
            // 
            this.btnRefracciones.Font = new System.Drawing.Font("Sunday Best", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefracciones.Location = new System.Drawing.Point(10, 202);
            this.btnRefracciones.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.btnRefracciones.Name = "btnRefracciones";
            this.btnRefracciones.Size = new System.Drawing.Size(188, 50);
            this.btnRefracciones.TabIndex = 15;
            this.btnRefracciones.Text = "REFRACCIONES";
            this.btnRefracciones.UseVisualStyleBackColor = true;
            // 
            // btnInicio
            // 
            this.btnInicio.Font = new System.Drawing.Font("Sunday Best", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(47, 137);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(128, 47);
            this.btnInicio.TabIndex = 14;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.UseVisualStyleBackColor = true;
            // 
            // FrmHerramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(728, 522);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblRefracciones);
            this.Controls.Add(this.dtgDatos);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnHerramientas);
            this.Controls.Add(this.btnRefracciones);
            this.Controls.Add(this.btnInicio);
            this.Name = "FrmHerramientas";
            this.Text = "FrmHerramientas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblRefracciones;
        private System.Windows.Forms.DataGridView dtgDatos;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnHerramientas;
        private System.Windows.Forms.Button btnRefracciones;
        private System.Windows.Forms.Button btnInicio;
    }
}