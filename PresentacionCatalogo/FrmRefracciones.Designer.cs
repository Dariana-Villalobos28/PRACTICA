namespace PresentacionCatalogo
{
    partial class FrmRefracciones
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
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnHerramientas = new System.Windows.Forms.Button();
            this.btnRefracciones = new System.Windows.Forms.Button();
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.lblRefracciones = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(53, 351);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(128, 47);
            this.btnAdmin.TabIndex = 7;
            this.btnAdmin.Text = "ADMIN";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnHerramientas
            // 
            this.btnHerramientas.Location = new System.Drawing.Point(16, 285);
            this.btnHerramientas.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.btnHerramientas.Name = "btnHerramientas";
            this.btnHerramientas.Size = new System.Drawing.Size(199, 48);
            this.btnHerramientas.TabIndex = 6;
            this.btnHerramientas.Text = "HERRAMIENTAS";
            this.btnHerramientas.UseVisualStyleBackColor = true;
            // 
            // btnRefracciones
            // 
            this.btnRefracciones.Location = new System.Drawing.Point(16, 217);
            this.btnRefracciones.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.btnRefracciones.Name = "btnRefracciones";
            this.btnRefracciones.Size = new System.Drawing.Size(188, 50);
            this.btnRefracciones.TabIndex = 5;
            this.btnRefracciones.Text = "REFRACCIONES";
            this.btnRefracciones.UseVisualStyleBackColor = true;
            // 
            // dtgDatos
            // 
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Location = new System.Drawing.Point(239, 192);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.Size = new System.Drawing.Size(469, 268);
            this.dtgDatos.TabIndex = 8;
            this.dtgDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDatos_CellContentClick);
            // 
            // lblRefracciones
            // 
            this.lblRefracciones.AutoSize = true;
            this.lblRefracciones.Font = new System.Drawing.Font("Sunday Best", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefracciones.Location = new System.Drawing.Point(299, 23);
            this.lblRefracciones.Name = "lblRefracciones";
            this.lblRefracciones.Size = new System.Drawing.Size(342, 72);
            this.lblRefracciones.TabIndex = 9;
            this.lblRefracciones.Text = "REFRACCIONES";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(239, 134);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(392, 46);
            this.txtBuscar.TabIndex = 10;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(53, 152);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(128, 47);
            this.btnInicio.TabIndex = 4;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(641, 133);
            this.button1.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 47);
            this.button1.TabIndex = 11;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(410, 472);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(154, 47);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(580, 472);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(128, 47);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // FrmRefracciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1370, 749);
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
            this.Font = new System.Drawing.Font("Sunday Best", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.Name = "FrmRefracciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRefracciones";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnHerramientas;
        private System.Windows.Forms.Button btnRefracciones;
        private System.Windows.Forms.DataGridView dtgDatos;
        private System.Windows.Forms.Label lblRefracciones;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}