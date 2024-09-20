namespace Ejercicio_1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstConteoSumas;
        private System.Windows.Forms.Button btnLanzarDados;
        private System.Windows.Forms.Label lblDado1;
        private System.Windows.Forms.Label lblDado2;
        private System.Windows.Forms.Label lblSuma;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            } 
            
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstConteoSumas = new System.Windows.Forms.ListBox();
            this.btnLanzarDados = new System.Windows.Forms.Button();
            this.lblDado1 = new System.Windows.Forms.Label();
            this.lblDado2 = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstConteoSumas
            // 
            this.lstConteoSumas.FormattingEnabled = true;
            this.lstConteoSumas.ItemHeight = 16;
            this.lstConteoSumas.Location = new System.Drawing.Point(377, 24);
            this.lstConteoSumas.Name = "lstConteoSumas";
            this.lstConteoSumas.Size = new System.Drawing.Size(208, 340);
            this.lstConteoSumas.TabIndex = 1;
            // 
            // btnLanzarDados
            // 
            this.btnLanzarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLanzarDados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLanzarDados.Location = new System.Drawing.Point(51, 157);
            this.btnLanzarDados.Margin = new System.Windows.Forms.Padding(4);
            this.btnLanzarDados.Name = "btnLanzarDados";
            this.btnLanzarDados.Size = new System.Drawing.Size(90, 37);
            this.btnLanzarDados.TabIndex = 2;
            this.btnLanzarDados.UseVisualStyleBackColor = true;
            this.btnLanzarDados.Click += new System.EventHandler(this.btnLanzarDados_Click);
            // 
            // lblDado1
            // 
            this.lblDado1.AutoSize = true;
            this.lblDado1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDado1.Location = new System.Drawing.Point(27, 35);
            this.lblDado1.Name = "lblDado1";
            this.lblDado1.Size = new System.Drawing.Size(86, 26);
            this.lblDado1.TabIndex = 3;
            this.lblDado1.Text = "Dado 1: ";
            // 
            // lblDado2
            // 
            this.lblDado2.AutoSize = true;
            this.lblDado2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDado2.Location = new System.Drawing.Point(135, 37);
            this.lblDado2.Name = "lblDado2";
            this.lblDado2.Size = new System.Drawing.Size(86, 26);
            this.lblDado2.TabIndex = 4;
            this.lblDado2.Text = "Dado 2: ";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma.Location = new System.Drawing.Point(12, 278);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(106, 23);
            this.lblSuma.TabIndex = 5;
            this.lblSuma.Text = "Resultado: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lanzar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(651, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.lblDado2);
            this.Controls.Add(this.lblDado1);
            this.Controls.Add(this.btnLanzarDados);
            this.Controls.Add(this.lstConteoSumas);
            this.Name = "Form1";
            this.Text = "Simulador de Dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
    }
}