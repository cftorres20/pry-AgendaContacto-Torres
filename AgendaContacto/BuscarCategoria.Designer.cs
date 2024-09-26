namespace AgendaContacto
{
    partial class BuscarCategoria
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
            this.panelVolver = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBuscarCategoria = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBuscarCategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // panelVolver
            // 
            this.panelVolver.BackColor = System.Drawing.Color.Transparent;
            this.panelVolver.BackgroundImage = global::AgendaContacto.Properties.Resources.atras;
            this.panelVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelVolver.Location = new System.Drawing.Point(541, 444);
            this.panelVolver.Name = "panelVolver";
            this.panelVolver.Size = new System.Drawing.Size(50, 46);
            this.panelVolver.TabIndex = 5;
            this.panelVolver.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelVolver_MouseClick);
            this.panelVolver.MouseLeave += new System.EventHandler(this.panelVolver_MouseLeave);
            this.panelVolver.MouseHover += new System.EventHandler(this.panelVolver_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 47);
            this.label1.TabIndex = 6;
            this.label1.Text = "Búsqueda de Contactos";
            // 
            // dgvBuscarCategoria
            // 
            this.dgvBuscarCategoria.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvBuscarCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarCategoria.Location = new System.Drawing.Point(103, 165);
            this.dgvBuscarCategoria.Name = "dgvBuscarCategoria";
            this.dgvBuscarCategoria.Size = new System.Drawing.Size(426, 211);
            this.dgvBuscarCategoria.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 33);
            this.label5.TabIndex = 18;
            this.label5.Text = "Buscar Categoría:";
            // 
            // cmbBuscarCategoria
            // 
            this.cmbBuscarCategoria.BackColor = System.Drawing.Color.Linen;
            this.cmbBuscarCategoria.FormattingEnabled = true;
            this.cmbBuscarCategoria.Location = new System.Drawing.Point(308, 119);
            this.cmbBuscarCategoria.Name = "cmbBuscarCategoria";
            this.cmbBuscarCategoria.Size = new System.Drawing.Size(168, 21);
            this.cmbBuscarCategoria.TabIndex = 19;
            // 
            // BuscarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AgendaContacto.Properties.Resources.notebook_fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(613, 502);
            this.Controls.Add(this.cmbBuscarCategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvBuscarCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelVolver);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBuscarCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBuscarCategoria;
    }
}