namespace WindowsFormsApp1
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evento1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reloj1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxRotura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PProxRotura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxFinReparacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuestoFinReparacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatrullasDisponibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcPatrullasDisponibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PromPatrullasDisponibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TMaxPRota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantReparaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcTReparaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTReparaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TtallerOcioso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColaMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID1,
            this.Evento1,
            this.Reloj1,
            this.ProxRotura,
            this.PProxRotura,
            this.ProxFinReparacion,
            this.PuestoFinReparacion,
            this.Cola1,
            this.PatrullasDisponibles,
            this.AcPatrullasDisponibles,
            this.PromPatrullasDisponibles,
            this.TMaxPRota,
            this.CantReparaciones,
            this.AcTReparaciones,
            this.PTReparaciones,
            this.TtallerOcioso,
            this.ColaMax});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(862, 518);
            this.dataGridView.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(12, 536);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1513, 398);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView3
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView3.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView3.Location = new System.Drawing.Point(880, 12);
            this.dataGridView3.Name = "dataGridView3";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView3.Size = new System.Drawing.Size(645, 518);
            this.dataGridView3.TabIndex = 3;
            // 
            // id
            // 
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.Width = 39;
            // 
            // ID1
            // 
            this.ID1.HeaderText = "#";
            this.ID1.Name = "ID1";
            this.ID1.Width = 39;
            // 
            // Evento1
            // 
            this.Evento1.HeaderText = "Evento";
            this.Evento1.Name = "Evento1";
            this.Evento1.Width = 66;
            // 
            // Reloj1
            // 
            this.Reloj1.HeaderText = "Reloj (días)";
            this.Reloj1.Name = "Reloj1";
            this.Reloj1.Width = 86;
            // 
            // ProxRotura
            // 
            this.ProxRotura.HeaderText = "Prox Rotura";
            this.ProxRotura.Name = "ProxRotura";
            this.ProxRotura.Width = 88;
            // 
            // PProxRotura
            // 
            this.PProxRotura.HeaderText = "Patrulla Prox Rotura";
            this.PProxRotura.Name = "PProxRotura";
            this.PProxRotura.Width = 115;
            // 
            // ProxFinReparacion
            // 
            this.ProxFinReparacion.HeaderText = "Prox Fin Reparacion";
            this.ProxFinReparacion.Name = "ProxFinReparacion";
            this.ProxFinReparacion.Width = 117;
            // 
            // PuestoFinReparacion
            // 
            this.PuestoFinReparacion.HeaderText = "Puesto Fin Reparacion";
            this.PuestoFinReparacion.Name = "PuestoFinReparacion";
            this.PuestoFinReparacion.Width = 128;
            // 
            // Cola1
            // 
            this.Cola1.HeaderText = "Cola";
            this.Cola1.Name = "Cola1";
            this.Cola1.Width = 53;
            // 
            // PatrullasDisponibles
            // 
            this.PatrullasDisponibles.HeaderText = "Patrullas disponibles";
            this.PatrullasDisponibles.Name = "PatrullasDisponibles";
            this.PatrullasDisponibles.Width = 116;
            // 
            // AcPatrullasDisponibles
            // 
            this.AcPatrullasDisponibles.HeaderText = "Ac Patrullas disponibles";
            this.AcPatrullasDisponibles.Name = "AcPatrullasDisponibles";
            this.AcPatrullasDisponibles.Width = 131;
            // 
            // PromPatrullasDisponibles
            // 
            this.PromPatrullasDisponibles.HeaderText = "Prom Patrullas Disponibles";
            this.PromPatrullasDisponibles.Name = "PromPatrullasDisponibles";
            this.PromPatrullasDisponibles.Width = 142;
            // 
            // TMaxPRota
            // 
            this.TMaxPRota.HeaderText = "T máx patrulla rota";
            this.TMaxPRota.Name = "TMaxPRota";
            this.TMaxPRota.Width = 93;
            // 
            // CantReparaciones
            // 
            this.CantReparaciones.HeaderText = "Cant reparaciones";
            this.CantReparaciones.Name = "CantReparaciones";
            this.CantReparaciones.Width = 108;
            // 
            // AcTReparaciones
            // 
            this.AcTReparaciones.HeaderText = "(Ac) T. reparaciones";
            this.AcTReparaciones.Name = "AcTReparaciones";
            this.AcTReparaciones.Width = 117;
            // 
            // PTReparaciones
            // 
            this.PTReparaciones.HeaderText = "Promedio T. Reparacion";
            this.PTReparaciones.Name = "PTReparaciones";
            this.PTReparaciones.Width = 134;
            // 
            // TtallerOcioso
            // 
            this.TtallerOcioso.HeaderText = "T. Taller Ocioso";
            this.TtallerOcioso.Name = "TtallerOcioso";
            this.TtallerOcioso.Width = 98;
            // 
            // ColaMax
            // 
            this.ColaMax.HeaderText = "Cola máxima";
            this.ColaMax.Name = "ColaMax";
            this.ColaMax.Width = 84;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 946);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 268 - Final SIM 22/07/20";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evento1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reloj1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxRotura;
        private System.Windows.Forms.DataGridViewTextBoxColumn PProxRotura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxFinReparacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuestoFinReparacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatrullasDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcPatrullasDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn PromPatrullasDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn TMaxPRota;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantReparaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcTReparaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTReparaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn TtallerOcioso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColaMax;
    }
}