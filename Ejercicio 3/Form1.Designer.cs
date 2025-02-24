﻿using System.Windows.Forms;
using System;

namespace Ejercicio_3
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
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtVenta = new System.Windows.Forms.TextBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblVenta = new System.Windows.Forms.Label();
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            this.btnMostrarReporte = new System.Windows.Forms.Button();
            this.lstReporte = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(12, 28);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(100, 22);
            this.txtVendedor.TabIndex = 1;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(140, 28);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(100, 22);
            this.txtProducto.TabIndex = 2;
            // 
            // txtVenta
            // 
            this.txtVenta.Location = new System.Drawing.Point(284, 28);
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.Size = new System.Drawing.Size(100, 22);
            this.txtVenta.TabIndex = 3;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(12, 9);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(67, 16);
            this.lblVendedor.TabIndex = 4;
            this.lblVendedor.Text = "Vendedor";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(159, 9);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(61, 16);
            this.lblProducto.TabIndex = 5;
            this.lblProducto.Text = "Producto";
            // 
            // lblVenta
            // 
            this.lblVenta.AutoSize = true;
            this.lblVenta.Location = new System.Drawing.Point(285, 9);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(99, 16);
            this.lblVenta.TabIndex = 6;
            this.lblVenta.Text = "Monto de venta";
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregarVenta.Location = new System.Drawing.Point(59, 85);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(53, 38);
            this.btnAgregarVenta.TabIndex = 7;
            this.btnAgregarVenta.UseVisualStyleBackColor = false;
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // btnMostrarReporte
            // 
            this.btnMostrarReporte.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMostrarReporte.Location = new System.Drawing.Point(257, 85);
            this.btnMostrarReporte.Name = "btnMostrarReporte";
            this.btnMostrarReporte.Size = new System.Drawing.Size(56, 38);
            this.btnMostrarReporte.TabIndex = 8;
            this.btnMostrarReporte.UseVisualStyleBackColor = false;
            this.btnMostrarReporte.Click += new System.EventHandler(this.btnMostrarReporte_Click);
            // 
            // lstReporte
            // 
            this.lstReporte.FormattingEnabled = true;
            this.lstReporte.ItemHeight = 16;
            this.lstReporte.Location = new System.Drawing.Point(24, 129);
            this.lstReporte.Name = "lstReporte";
            this.lstReporte.Size = new System.Drawing.Size(340, 292);
            this.lstReporte.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Agregar Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mostrar Reporte";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstReporte);
            this.Controls.Add(this.btnMostrarReporte);
            this.Controls.Add(this.btnAgregarVenta);
            this.Controls.Add(this.lblVenta);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.txtVenta);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtVendedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Resumen de Ventas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtVenta;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblVenta;
        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.Button btnMostrarReporte;
        private System.Windows.Forms.ListBox lstReporte;
        private Label label1;
        private Label label2;
    }
}