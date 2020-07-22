namespace WindowsFormsApp1
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
            this.iniciarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadPatrullas = new System.Windows.Forms.TextBox();
            this.txtCapacidadTaller = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDiasEntreServicios = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrimeraRoturaInf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrimeraRoturaSup = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTReparacionSup = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTReparacionInf = new System.Windows.Forms.TextBox();
            this.txtCantDiasASimular = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCantidadIteraciones = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiaInicio = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // iniciarButton
            // 
            this.iniciarButton.Location = new System.Drawing.Point(754, 494);
            this.iniciarButton.Name = "iniciarButton";
            this.iniciarButton.Size = new System.Drawing.Size(120, 38);
            this.iniciarButton.TabIndex = 0;
            this.iniciarButton.Text = "Iniciar";
            this.iniciarButton.UseVisualStyleBackColor = true;
            this.iniciarButton.Click += new System.EventHandler(this.iniciarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de patrullas:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCantidadPatrullas
            // 
            this.txtCantidadPatrullas.Location = new System.Drawing.Point(144, 26);
            this.txtCantidadPatrullas.Name = "txtCantidadPatrullas";
            this.txtCantidadPatrullas.Size = new System.Drawing.Size(101, 20);
            this.txtCantidadPatrullas.TabIndex = 2;
            this.txtCantidadPatrullas.Text = "120";
            this.txtCantidadPatrullas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCapacidadTaller
            // 
            this.txtCapacidadTaller.Location = new System.Drawing.Point(144, 72);
            this.txtCapacidadTaller.Name = "txtCapacidadTaller";
            this.txtCapacidadTaller.Size = new System.Drawing.Size(101, 20);
            this.txtCapacidadTaller.TabIndex = 4;
            this.txtCapacidadTaller.Text = "8";
            this.txtCapacidadTaller.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCapacidadTaller.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Capacidad del taller:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reiniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDiasEntreServicios
            // 
            this.txtDiasEntreServicios.Location = new System.Drawing.Point(144, 119);
            this.txtDiasEntreServicios.Name = "txtDiasEntreServicios";
            this.txtDiasEntreServicios.Size = new System.Drawing.Size(101, 20);
            this.txtDiasEntreServicios.TabIndex = 7;
            this.txtDiasEntreServicios.Text = "20";
            this.txtDiasEntreServicios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Días entre servicios:";
            // 
            // txtPrimeraRoturaInf
            // 
            this.txtPrimeraRoturaInf.Location = new System.Drawing.Point(169, 203);
            this.txtPrimeraRoturaInf.Name = "txtPrimeraRoturaInf";
            this.txtPrimeraRoturaInf.Size = new System.Drawing.Size(37, 20);
            this.txtPrimeraRoturaInf.TabIndex = 9;
            this.txtPrimeraRoturaInf.Text = "1";
            this.txtPrimeraRoturaInf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Primera rotura:                  U (";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = ";";
            // 
            // txtPrimeraRoturaSup
            // 
            this.txtPrimeraRoturaSup.Location = new System.Drawing.Point(228, 203);
            this.txtPrimeraRoturaSup.Name = "txtPrimeraRoturaSup";
            this.txtPrimeraRoturaSup.Size = new System.Drawing.Size(37, 20);
            this.txtPrimeraRoturaSup.TabIndex = 11;
            this.txtPrimeraRoturaSup.Text = "20";
            this.txtPrimeraRoturaSup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = ")";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tiempo de reparación:      U (";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = ")";
            // 
            // txtTReparacionSup
            // 
            this.txtTReparacionSup.Location = new System.Drawing.Point(228, 163);
            this.txtTReparacionSup.Name = "txtTReparacionSup";
            this.txtTReparacionSup.Size = new System.Drawing.Size(37, 20);
            this.txtTReparacionSup.TabIndex = 16;
            this.txtTReparacionSup.Text = "4";
            this.txtTReparacionSup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(212, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = ";";
            // 
            // txtTReparacionInf
            // 
            this.txtTReparacionInf.Location = new System.Drawing.Point(166, 163);
            this.txtTReparacionInf.Name = "txtTReparacionInf";
            this.txtTReparacionInf.Size = new System.Drawing.Size(37, 20);
            this.txtTReparacionInf.TabIndex = 14;
            this.txtTReparacionInf.Text = "1";
            this.txtTReparacionInf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCantDiasASimular
            // 
            this.txtCantDiasASimular.Location = new System.Drawing.Point(559, 23);
            this.txtCantDiasASimular.Name = "txtCantDiasASimular";
            this.txtCantDiasASimular.Size = new System.Drawing.Size(101, 20);
            this.txtCantDiasASimular.TabIndex = 19;
            this.txtCantDiasASimular.Text = "10";
            this.txtCantDiasASimular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(364, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Días a simular:";
            // 
            // txtCantidadIteraciones
            // 
            this.txtCantidadIteraciones.Location = new System.Drawing.Point(559, 65);
            this.txtCantidadIteraciones.Name = "txtCantidadIteraciones";
            this.txtCantidadIteraciones.Size = new System.Drawing.Size(101, 20);
            this.txtCantidadIteraciones.TabIndex = 21;
            this.txtCantidadIteraciones.Text = "10";
            this.txtCantidadIteraciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(364, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Cantidad de iteraciones a mostrar:";
            // 
            // txtDiaInicio
            // 
            this.txtDiaInicio.Location = new System.Drawing.Point(559, 112);
            this.txtDiaInicio.Name = "txtDiaInicio";
            this.txtDiaInicio.Size = new System.Drawing.Size(101, 20);
            this.txtDiaInicio.TabIndex = 23;
            this.txtDiaInicio.Text = "0";
            this.txtDiaInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(364, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Día inicio:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(367, 206);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(202, 17);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Mostrar todas las patrullas (más lento)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 544);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtDiaInicio);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCantidadIteraciones);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCantDiasASimular);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTReparacionSup);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTReparacionInf);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrimeraRoturaSup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrimeraRoturaInf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDiasEntreServicios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCapacidadTaller);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantidadPatrullas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iniciarButton);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 268 - Final SIM 22/07/20";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button iniciarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidadPatrullas;
        private System.Windows.Forms.TextBox txtCapacidadTaller;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDiasEntreServicios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrimeraRoturaInf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrimeraRoturaSup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTReparacionSup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTReparacionInf;
        private System.Windows.Forms.TextBox txtCantDiasASimular;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCantidadIteraciones;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDiaInicio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

