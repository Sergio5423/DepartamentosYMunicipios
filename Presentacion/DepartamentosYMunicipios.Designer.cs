namespace Presentacion
{
    partial class DepartamentosYMunicipios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMunicipio = new System.Windows.Forms.RadioButton();
            this.rbDepartamento = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.lstMunicipios = new System.Windows.Forms.ListBox();
            this.lstDepartamentos = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMunicipio);
            this.groupBox1.Controls.Add(this.rbDepartamento);
            this.groupBox1.Location = new System.Drawing.Point(28, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // rbMunicipio
            // 
            this.rbMunicipio.AutoSize = true;
            this.rbMunicipio.Location = new System.Drawing.Point(20, 79);
            this.rbMunicipio.Name = "rbMunicipio";
            this.rbMunicipio.Size = new System.Drawing.Size(70, 17);
            this.rbMunicipio.TabIndex = 1;
            this.rbMunicipio.TabStop = true;
            this.rbMunicipio.Text = "Municipio";
            this.rbMunicipio.UseVisualStyleBackColor = true;
            // 
            // rbDepartamento
            // 
            this.rbDepartamento.AutoSize = true;
            this.rbDepartamento.Location = new System.Drawing.Point(20, 37);
            this.rbDepartamento.Name = "rbDepartamento";
            this.rbDepartamento.Size = new System.Drawing.Size(92, 17);
            this.rbDepartamento.TabIndex = 0;
            this.rbDepartamento.TabStop = true;
            this.rbDepartamento.Text = "Departamento";
            this.rbDepartamento.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnAdicionar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtValor);
            this.groupBox2.Location = new System.Drawing.Point(265, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 135);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entrada";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(133, 97);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(17, 97);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(83, 36);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(125, 20);
            this.txtValor.TabIndex = 0;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnIzquierda);
            this.groupBox3.Controls.Add(this.btnDerecha);
            this.groupBox3.Controls.Add(this.lstMunicipios);
            this.groupBox3.Controls.Add(this.lstDepartamentos);
            this.groupBox3.Location = new System.Drawing.Point(28, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(482, 187);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tablas";
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Location = new System.Drawing.Point(204, 104);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(75, 23);
            this.btnIzquierda.TabIndex = 5;
            this.btnIzquierda.Text = "<< -";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(204, 57);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(75, 23);
            this.btnDerecha.TabIndex = 4;
            this.btnDerecha.Text = "- >>";
            this.btnDerecha.UseVisualStyleBackColor = true;
            // 
            // lstMunicipios
            // 
            this.lstMunicipios.FormattingEnabled = true;
            this.lstMunicipios.Location = new System.Drawing.Point(285, 33);
            this.lstMunicipios.Name = "lstMunicipios";
            this.lstMunicipios.Size = new System.Drawing.Size(178, 134);
            this.lstMunicipios.TabIndex = 1;
            // 
            // lstDepartamentos
            // 
            this.lstDepartamentos.FormattingEnabled = true;
            this.lstDepartamentos.Location = new System.Drawing.Point(20, 33);
            this.lstDepartamentos.Name = "lstDepartamentos";
            this.lstDepartamentos.Size = new System.Drawing.Size(178, 134);
            this.lstDepartamentos.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(232, 449);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 497);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMunicipio;
        private System.Windows.Forms.RadioButton rbDepartamento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.ListBox lstMunicipios;
        private System.Windows.Forms.ListBox lstDepartamentos;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

