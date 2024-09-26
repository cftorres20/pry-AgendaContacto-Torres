namespace AgendaContacto
{
    partial class Busquedas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelBuscarPorDatos = new System.Windows.Forms.Panel();
            this.panelBuscarCategoria = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelVolver = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 47);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar Contacto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(260, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 33);
            this.label5.TabIndex = 15;
            this.label5.Text = "Buscar por";
            // 
            // panelBuscarPorDatos
            // 
            this.panelBuscarPorDatos.BackColor = System.Drawing.Color.Transparent;
            this.panelBuscarPorDatos.BackgroundImage = global::AgendaContacto.Properties.Resources.contacto;
            this.panelBuscarPorDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBuscarPorDatos.Location = new System.Drawing.Point(123, 118);
            this.panelBuscarPorDatos.Name = "panelBuscarPorDatos";
            this.panelBuscarPorDatos.Size = new System.Drawing.Size(110, 110);
            this.panelBuscarPorDatos.TabIndex = 16;
            this.panelBuscarPorDatos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelBuscarPorDatos_MouseClick);
            this.panelBuscarPorDatos.MouseLeave += new System.EventHandler(this.panelBuscarPorDatos_MouseLeave);
            this.panelBuscarPorDatos.MouseHover += new System.EventHandler(this.panelBuscarPorDatos_MouseHover);
            // 
            // panelBuscarCategoria
            // 
            this.panelBuscarCategoria.BackColor = System.Drawing.Color.Transparent;
            this.panelBuscarCategoria.BackgroundImage = global::AgendaContacto.Properties.Resources.BuscarCate;
            this.panelBuscarCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBuscarCategoria.Location = new System.Drawing.Point(123, 261);
            this.panelBuscarCategoria.Name = "panelBuscarCategoria";
            this.panelBuscarCategoria.Size = new System.Drawing.Size(110, 89);
            this.panelBuscarCategoria.TabIndex = 17;
            this.panelBuscarCategoria.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelBuscarCategoria_MouseClick);
            this.panelBuscarCategoria.MouseLeave += new System.EventHandler(this.panelBuscarCategoria_MouseLeave);
            this.panelBuscarCategoria.MouseHover += new System.EventHandler(this.panelBuscarCategoria_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 33);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre/Email/Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(260, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 33);
            this.label4.TabIndex = 19;
            this.label4.Text = "Buscar por Categoría";
            // 
            // panelVolver
            // 
            this.panelVolver.BackColor = System.Drawing.Color.Transparent;
            this.panelVolver.BackgroundImage = global::AgendaContacto.Properties.Resources.atras;
            this.panelVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelVolver.Location = new System.Drawing.Point(526, 405);
            this.panelVolver.Name = "panelVolver";
            this.panelVolver.Size = new System.Drawing.Size(50, 46);
            this.panelVolver.TabIndex = 20;
            this.panelVolver.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelVolver_MouseClick);
            this.panelVolver.MouseLeave += new System.EventHandler(this.panelVolver_MouseLeave);
            this.panelVolver.MouseHover += new System.EventHandler(this.panelVolver_MouseHover);
            // 
            // Busquedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AgendaContacto.Properties.Resources.notebook_fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(597, 463);
            this.Controls.Add(this.panelVolver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelBuscarCategoria);
            this.Controls.Add(this.panelBuscarPorDatos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Busquedas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busquedas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelBuscarPorDatos;
        private System.Windows.Forms.Panel panelBuscarCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelVolver;
    }
}