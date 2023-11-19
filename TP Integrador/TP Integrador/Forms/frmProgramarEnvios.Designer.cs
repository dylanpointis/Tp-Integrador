namespace TP_Integrador.Forms
{
    partial class frmProgramarEnvios
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
            this.grillaEnvios = new System.Windows.Forms.DataGridView();
            this.btnProgramarEnvio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grillaLogistica = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEnvios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaLogistica)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaEnvios
            // 
            this.grillaEnvios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaEnvios.Location = new System.Drawing.Point(12, 56);
            this.grillaEnvios.Name = "grillaEnvios";
            this.grillaEnvios.Size = new System.Drawing.Size(706, 289);
            this.grillaEnvios.TabIndex = 0;
            // 
            // btnProgramarEnvio
            // 
            this.btnProgramarEnvio.Location = new System.Drawing.Point(12, 410);
            this.btnProgramarEnvio.Name = "btnProgramarEnvio";
            this.btnProgramarEnvio.Size = new System.Drawing.Size(115, 27);
            this.btnProgramarEnvio.TabIndex = 1;
            this.btnProgramarEnvio.Text = "Programar envío";
            this.btnProgramarEnvio.UseVisualStyleBackColor = true;
            this.btnProgramarEnvio.Click += new System.EventHandler(this.btnProgramarEnvio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(747, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Logistica";
            // 
            // grillaLogistica
            // 
            this.grillaLogistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaLogistica.Location = new System.Drawing.Point(751, 56);
            this.grillaLogistica.Name = "grillaLogistica";
            this.grillaLogistica.Size = new System.Drawing.Size(313, 289);
            this.grillaLogistica.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Envios";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 384);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // frmProgramarEnvios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 470);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grillaLogistica);
            this.Controls.Add(this.btnProgramarEnvio);
            this.Controls.Add(this.grillaEnvios);
            this.Name = "frmProgramarEnvios";
            this.Text = "frmProgramarEnvios";
            this.Load += new System.EventHandler(this.frmProgramarEnvios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaEnvios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaLogistica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaEnvios;
        private System.Windows.Forms.Button btnProgramarEnvio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grillaLogistica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}