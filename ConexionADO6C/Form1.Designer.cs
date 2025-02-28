namespace ConexionADO6C
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.chbContrato = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbCP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbEstado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbCiudad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbFiltro = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(35, 422);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 41;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // chbContrato
            // 
            this.chbContrato.AutoSize = true;
            this.chbContrato.Location = new System.Drawing.Point(103, 381);
            this.chbContrato.Name = "chbContrato";
            this.chbContrato.Size = new System.Drawing.Size(66, 17);
            this.chbContrato.TabIndex = 40;
            this.chbContrato.Text = "Contrato";
            this.chbContrato.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Código Postal";
            // 
            // txbCP
            // 
            this.txbCP.Location = new System.Drawing.Point(103, 343);
            this.txbCP.Name = "txbCP";
            this.txbCP.Size = new System.Drawing.Size(123, 20);
            this.txbCP.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Estado";
            // 
            // txbEstado
            // 
            this.txbEstado.Location = new System.Drawing.Point(103, 305);
            this.txbEstado.Name = "txbEstado";
            this.txbEstado.Size = new System.Drawing.Size(123, 20);
            this.txbEstado.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Ciudad";
            // 
            // txbCiudad
            // 
            this.txbCiudad.Location = new System.Drawing.Point(103, 269);
            this.txbCiudad.Name = "txbCiudad";
            this.txbCiudad.Size = new System.Drawing.Size(123, 20);
            this.txbCiudad.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Dirección";
            // 
            // txbDireccion
            // 
            this.txbDireccion.Location = new System.Drawing.Point(103, 231);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(123, 20);
            this.txbDireccion.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Telefono";
            // 
            // txbTelefono
            // 
            this.txbTelefono.Location = new System.Drawing.Point(103, 194);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(123, 20);
            this.txbTelefono.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Apellido";
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(103, 156);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(123, 20);
            this.txbApellido.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nombre";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(103, 120);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(123, 20);
            this.txbNombre.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Id Autor";
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(103, 82);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(123, 20);
            this.txbId.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Filtro";
            // 
            // txbFiltro
            // 
            this.txbFiltro.Location = new System.Drawing.Point(171, 6);
            this.txbFiltro.Name = "txbFiltro";
            this.txbFiltro.Size = new System.Drawing.Size(222, 20);
            this.txbFiltro.TabIndex = 22;
            this.txbFiltro.TextChanged += new System.EventHandler(this.txbFiltro_TextChanged);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(312, 45);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(476, 327);
            this.dgvDatos.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.chbContrato);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbCP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbEstado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbCiudad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbDireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbFiltro);
            this.Controls.Add(this.dgvDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.CheckBox chbContrato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbCP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbCiudad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbFiltro;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}

