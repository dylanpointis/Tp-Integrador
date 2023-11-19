
namespace TP_Integrador
{
    partial class frmInicio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConsultarVentas = new System.Windows.Forms.Button();
            this.btnReclamos = new System.Windows.Forms.Button();
            this.btnAdministrarUsuarios = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnProgramarEnvios = new System.Windows.Forms.Button();
            this.btnVerEnvio = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 54);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sistema supermercado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(762, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnConsultarVentas);
            this.panel2.Controls.Add(this.btnReclamos);
            this.panel2.Controls.Add(this.btnAdministrarUsuarios);
            this.panel2.Controls.Add(this.btnProveedores);
            this.panel2.Controls.Add(this.btnProductos);
            this.panel2.Controls.Add(this.btnProgramarEnvios);
            this.panel2.Controls.Add(this.btnVerEnvio);
            this.panel2.Controls.Add(this.btnComprar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1134, 63);
            this.panel2.TabIndex = 0;
            // 
            // btnConsultarVentas
            // 
            this.btnConsultarVentas.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConsultarVentas.Location = new System.Drawing.Point(644, 0);
            this.btnConsultarVentas.Name = "btnConsultarVentas";
            this.btnConsultarVentas.Size = new System.Drawing.Size(92, 63);
            this.btnConsultarVentas.TabIndex = 12;
            this.btnConsultarVentas.Text = "Consultar ventas";
            this.btnConsultarVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarVentas.UseVisualStyleBackColor = true;
            this.btnConsultarVentas.Click += new System.EventHandler(this.btnConsultarVentas_Click);
            // 
            // btnReclamos
            // 
            this.btnReclamos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReclamos.Location = new System.Drawing.Point(552, 0);
            this.btnReclamos.Name = "btnReclamos";
            this.btnReclamos.Size = new System.Drawing.Size(92, 63);
            this.btnReclamos.TabIndex = 11;
            this.btnReclamos.Text = "Reclamos";
            this.btnReclamos.UseVisualStyleBackColor = true;
            this.btnReclamos.Click += new System.EventHandler(this.btnReclamos_Click_1);
            // 
            // btnAdministrarUsuarios
            // 
            this.btnAdministrarUsuarios.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdministrarUsuarios.Location = new System.Drawing.Point(460, 0);
            this.btnAdministrarUsuarios.Name = "btnAdministrarUsuarios";
            this.btnAdministrarUsuarios.Size = new System.Drawing.Size(92, 63);
            this.btnAdministrarUsuarios.TabIndex = 10;
            this.btnAdministrarUsuarios.Text = "Administrar usuarios";
            this.btnAdministrarUsuarios.UseVisualStyleBackColor = true;
            this.btnAdministrarUsuarios.Click += new System.EventHandler(this.btnAdministrarUsuarios_Click_1);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProveedores.Location = new System.Drawing.Point(368, 0);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(92, 63);
            this.btnProveedores.TabIndex = 9;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProductos.Location = new System.Drawing.Point(276, 0);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(92, 63);
            this.btnProductos.TabIndex = 8;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click_1);
            // 
            // btnProgramarEnvios
            // 
            this.btnProgramarEnvios.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProgramarEnvios.Location = new System.Drawing.Point(184, 0);
            this.btnProgramarEnvios.Name = "btnProgramarEnvios";
            this.btnProgramarEnvios.Size = new System.Drawing.Size(92, 63);
            this.btnProgramarEnvios.TabIndex = 7;
            this.btnProgramarEnvios.Text = "Programar envíos";
            this.btnProgramarEnvios.UseVisualStyleBackColor = true;
            this.btnProgramarEnvios.Click += new System.EventHandler(this.btnProgramarEnvios_Click_1);
            // 
            // btnVerEnvio
            // 
            this.btnVerEnvio.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVerEnvio.Location = new System.Drawing.Point(92, 0);
            this.btnVerEnvio.Name = "btnVerEnvio";
            this.btnVerEnvio.Size = new System.Drawing.Size(92, 63);
            this.btnVerEnvio.TabIndex = 2;
            this.btnVerEnvio.Text = "Ver envio";
            this.btnVerEnvio.UseVisualStyleBackColor = true;
            this.btnVerEnvio.Click += new System.EventHandler(this.btnVerEnvio_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnComprar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnComprar.Location = new System.Drawing.Point(0, 0);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(92, 63);
            this.btnComprar.TabIndex = 1;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click_1);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 601);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProgramarEnvios;
        private System.Windows.Forms.Button btnVerEnvio;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnConsultarVentas;
        private System.Windows.Forms.Button btnReclamos;
        private System.Windows.Forms.Button btnAdministrarUsuarios;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Label label3;
    }
}