﻿
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerConsultas = new System.Windows.Forms.Button();
            this.btnReclamos = new System.Windows.Forms.Button();
            this.btnEnvios = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnVerConsultas);
            this.panel1.Controls.Add(this.btnReclamos);
            this.panel1.Controls.Add(this.btnEnvios);
            this.panel1.Controls.Add(this.btnComprar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 70);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(595, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // btnVerConsultas
            // 
            this.btnVerConsultas.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVerConsultas.Location = new System.Drawing.Point(276, 0);
            this.btnVerConsultas.Name = "btnVerConsultas";
            this.btnVerConsultas.Size = new System.Drawing.Size(92, 70);
            this.btnVerConsultas.TabIndex = 3;
            this.btnVerConsultas.Text = "Consultar ventas";
            this.btnVerConsultas.UseVisualStyleBackColor = true;
            this.btnVerConsultas.Click += new System.EventHandler(this.btnVerConsultas_Click);
            // 
            // btnReclamos
            // 
            this.btnReclamos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReclamos.Location = new System.Drawing.Point(184, 0);
            this.btnReclamos.Name = "btnReclamos";
            this.btnReclamos.Size = new System.Drawing.Size(92, 70);
            this.btnReclamos.TabIndex = 2;
            this.btnReclamos.Text = "Reclamos";
            this.btnReclamos.UseVisualStyleBackColor = true;
            this.btnReclamos.Click += new System.EventHandler(this.btnReclamos_Click);
            // 
            // btnEnvios
            // 
            this.btnEnvios.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEnvios.Location = new System.Drawing.Point(92, 0);
            this.btnEnvios.Name = "btnEnvios";
            this.btnEnvios.Size = new System.Drawing.Size(92, 70);
            this.btnEnvios.TabIndex = 1;
            this.btnEnvios.Text = "Ver envio";
            this.btnEnvios.UseVisualStyleBackColor = true;
            this.btnEnvios.Click += new System.EventHandler(this.btnEnvios_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnComprar.Location = new System.Drawing.Point(0, 0);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(92, 70);
            this.btnComprar.TabIndex = 0;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 488);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReclamos;
        private System.Windows.Forms.Button btnEnvios;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerConsultas;
    }
}