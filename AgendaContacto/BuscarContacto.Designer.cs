namespace AgendaContacto
{
    partial class BuscarContacto
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
            this.panelVolver = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtNombre = new System.Windows.Forms.RadioButton();
            this.rbtTelefono = new System.Windows.Forms.RadioButton();
            this.rbtEmail = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDatoBuscado = new System.Windows.Forms.TextBox();
            this.treeViewContactos = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "Búsqueda de Contacto";
            // 
            // panelVolver
            // 
            this.panelVolver.BackColor = System.Drawing.Color.Transparent;
            this.panelVolver.BackgroundImage = global::AgendaContacto.Properties.Resources.atras;
            this.panelVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelVolver.Location = new System.Drawing.Point(637, 521);
            this.panelVolver.Name = "panelVolver";
            this.panelVolver.Size = new System.Drawing.Size(50, 46);
            this.panelVolver.TabIndex = 4;
            this.panelVolver.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelVolver_MouseClick);
            this.panelVolver.MouseLeave += new System.EventHandler(this.panelVolver_MouseLeave);
            this.panelVolver.MouseHover += new System.EventHandler(this.panelSalir_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 33);
            this.label4.TabIndex = 10;
            this.label4.Text = "Teléfono";
            // 
            // rbtNombre
            // 
            this.rbtNombre.AutoSize = true;
            this.rbtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtNombre.Location = new System.Drawing.Point(207, 137);
            this.rbtNombre.Name = "rbtNombre";
            this.rbtNombre.Size = new System.Drawing.Size(14, 13);
            this.rbtNombre.TabIndex = 11;
            this.rbtNombre.TabStop = true;
            this.rbtNombre.UseVisualStyleBackColor = true;
            // 
            // rbtTelefono
            // 
            this.rbtTelefono.AutoSize = true;
            this.rbtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTelefono.Location = new System.Drawing.Point(364, 137);
            this.rbtTelefono.Name = "rbtTelefono";
            this.rbtTelefono.Size = new System.Drawing.Size(14, 13);
            this.rbtTelefono.TabIndex = 12;
            this.rbtTelefono.TabStop = true;
            this.rbtTelefono.UseVisualStyleBackColor = true;
            // 
            // rbtEmail
            // 
            this.rbtEmail.AutoSize = true;
            this.rbtEmail.BackColor = System.Drawing.Color.Linen;
            this.rbtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtEmail.Location = new System.Drawing.Point(503, 137);
            this.rbtEmail.Name = "rbtEmail";
            this.rbtEmail.Size = new System.Drawing.Size(14, 13);
            this.rbtEmail.TabIndex = 13;
            this.rbtEmail.TabStop = true;
            this.rbtEmail.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 33);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ingrese Dato:";
            // 
            // txtDatoBuscado
            // 
            this.txtDatoBuscado.BackColor = System.Drawing.Color.Linen;
            this.txtDatoBuscado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatoBuscado.Location = new System.Drawing.Point(258, 177);
            this.txtDatoBuscado.Name = "txtDatoBuscado";
            this.txtDatoBuscado.Size = new System.Drawing.Size(168, 22);
            this.txtDatoBuscado.TabIndex = 15;
            // 
            // treeViewContactos
            // 
            this.treeViewContactos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewContactos.Location = new System.Drawing.Point(186, 224);
            this.treeViewContactos.Name = "treeViewContactos";
            this.treeViewContactos.Size = new System.Drawing.Size(343, 205);
            this.treeViewContactos.TabIndex = 17;
            // 
            // BuscarContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AgendaContacto.Properties.Resources.notebook_fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(699, 579);
            this.Controls.Add(this.treeViewContactos);
            this.Controls.Add(this.txtDatoBuscado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbtEmail);
            this.Controls.Add(this.rbtTelefono);
            this.Controls.Add(this.rbtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelVolver);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarContacto";
            this.Load += new System.EventHandler(this.BuscarContacto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelVolver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtNombre;
        private System.Windows.Forms.RadioButton rbtTelefono;
        private System.Windows.Forms.RadioButton rbtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDatoBuscado;
        private System.Windows.Forms.TreeView treeViewContactos;
    }
}