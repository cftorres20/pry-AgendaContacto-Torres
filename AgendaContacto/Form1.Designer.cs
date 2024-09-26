namespace AgendaContacto
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
            this.panelGestionContacto = new System.Windows.Forms.Panel();
            this.panelBuscarContacto = new System.Windows.Forms.Panel();
            this.panelExportar = new System.Windows.Forms.Panel();
            this.panelSalir = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelGestionContacto
            // 
            this.panelGestionContacto.BackColor = System.Drawing.Color.Transparent;
            this.panelGestionContacto.BackgroundImage = global::AgendaContacto.Properties.Resources.contacto;
            this.panelGestionContacto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGestionContacto.Location = new System.Drawing.Point(107, 130);
            this.panelGestionContacto.Name = "panelGestionContacto";
            this.panelGestionContacto.Size = new System.Drawing.Size(106, 95);
            this.panelGestionContacto.TabIndex = 0;
          
            this.panelGestionContacto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelGestionContacto_MouseClick);
            this.panelGestionContacto.MouseLeave += new System.EventHandler(this.panelGestionContacto_MouseLeave);
            this.panelGestionContacto.MouseHover += new System.EventHandler(this.panelGestionContacto_MouseHover);
            // 
            // panelBuscarContacto
            // 
            this.panelBuscarContacto.BackColor = System.Drawing.Color.Transparent;
            this.panelBuscarContacto.BackgroundImage = global::AgendaContacto.Properties.Resources.buscar;
            this.panelBuscarContacto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBuscarContacto.Location = new System.Drawing.Point(107, 243);
            this.panelBuscarContacto.Name = "panelBuscarContacto";
            this.panelBuscarContacto.Size = new System.Drawing.Size(106, 95);
            this.panelBuscarContacto.TabIndex = 1;
            this.panelBuscarContacto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelBuscarContacto_MouseClick);
            this.panelBuscarContacto.MouseLeave += new System.EventHandler(this.panelBuscarContacto_MouseLeave);
            this.panelBuscarContacto.MouseHover += new System.EventHandler(this.panelBuscarContacto_MouseHover);
            // 
            // panelExportar
            // 
            this.panelExportar.BackColor = System.Drawing.Color.Transparent;
            this.panelExportar.BackgroundImage = global::AgendaContacto.Properties.Resources.exportar;
            this.panelExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelExportar.Location = new System.Drawing.Point(107, 356);
            this.panelExportar.Name = "panelExportar";
            this.panelExportar.Size = new System.Drawing.Size(106, 98);
            this.panelExportar.TabIndex = 1;
            this.panelExportar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelExportar_MouseClick);
            this.panelExportar.MouseLeave += new System.EventHandler(this.panelExportar_MouseLeave);
            this.panelExportar.MouseHover += new System.EventHandler(this.panelExportar_MouseHover);
            // 
            // panelSalir
            // 
            this.panelSalir.BackColor = System.Drawing.Color.Transparent;
            this.panelSalir.BackgroundImage = global::AgendaContacto.Properties.Resources.cerrar;
            this.panelSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSalir.Location = new System.Drawing.Point(557, 483);
            this.panelSalir.Name = "panelSalir";
            this.panelSalir.Size = new System.Drawing.Size(50, 46);
            this.panelSalir.TabIndex = 1;
            this.panelSalir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelSalir_MouseClick);
            this.panelSalir.MouseLeave += new System.EventHandler(this.panelSalir_MouseLeave);
            this.panelSalir.MouseHover += new System.EventHandler(this.panelSalir_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agenda de Contactos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Exportar Contactos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Buscar Contactos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gestión de Contactos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AgendaContacto.Properties.Resources.notebook_fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(629, 541);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelSalir);
            this.Controls.Add(this.panelBuscarContacto);
            this.Controls.Add(this.panelExportar);
            this.Controls.Add(this.panelGestionContacto);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGestionContacto;
        private System.Windows.Forms.Panel panelBuscarContacto;
        private System.Windows.Forms.Panel panelExportar;
        private System.Windows.Forms.Panel panelSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

