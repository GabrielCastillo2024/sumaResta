namespace Ejercicio_2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.rdoSmoking = new System.Windows.Forms.RadioButton();
            this.rdoNonSmoking = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblBoardingPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elige un lugar:\r\n";
            // 
            // rdoSmoking
            // 
            this.rdoSmoking.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.rdoSmoking.AutoSize = true;
            this.rdoSmoking.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSmoking.Location = new System.Drawing.Point(28, 72);
            this.rdoSmoking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoSmoking.Name = "rdoSmoking";
            this.rdoSmoking.Size = new System.Drawing.Size(78, 24);
            this.rdoSmoking.TabIndex = 1;
            this.rdoSmoking.TabStop = true;
            this.rdoSmoking.Text = "Fumar";
            this.rdoSmoking.UseVisualStyleBackColor = true;
            // 
            // rdoNonSmoking
            // 
            this.rdoNonSmoking.AutoSize = true;
            this.rdoNonSmoking.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNonSmoking.Location = new System.Drawing.Point(149, 72);
            this.rdoNonSmoking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoNonSmoking.Name = "rdoNonSmoking";
            this.rdoNonSmoking.Size = new System.Drawing.Size(103, 24);
            this.rdoNonSmoking.TabIndex = 2;
            this.rdoNonSmoking.TabStop = true;
            this.rdoNonSmoking.Text = "No Fumar";
            this.rdoNonSmoking.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(77, 126);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 30);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Asignar Asiento";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblBoardingPass
            // 
            this.lblBoardingPass.AutoSize = true;
            this.lblBoardingPass.Location = new System.Drawing.Point(51, 204);
            this.lblBoardingPass.Name = "lblBoardingPass";
            this.lblBoardingPass.Size = new System.Drawing.Size(0, 16);
            this.lblBoardingPass.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 270);
            this.Controls.Add(this.lblBoardingPass);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rdoNonSmoking);
            this.Controls.Add(this.rdoSmoking);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Elegir Asiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoSmoking;
        private System.Windows.Forms.RadioButton rdoNonSmoking;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblBoardingPass;
    }
}