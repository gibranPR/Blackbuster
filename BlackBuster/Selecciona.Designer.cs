﻿namespace BlackBuster
{
    partial class Selecciona
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblAux = new System.Windows.Forms.Label();
            this.cmbAux = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(100, 149);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblAux
            // 
            this.lblAux.Location = new System.Drawing.Point(12, 9);
            this.lblAux.Name = "lblAux";
            this.lblAux.Size = new System.Drawing.Size(260, 48);
            this.lblAux.TabIndex = 1;
            this.lblAux.Text = "asdasdasda";
            this.lblAux.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbAux
            // 
            this.cmbAux.FormattingEnabled = true;
            this.cmbAux.Location = new System.Drawing.Point(77, 90);
            this.cmbAux.Name = "cmbAux";
            this.cmbAux.Size = new System.Drawing.Size(121, 21);
            this.cmbAux.TabIndex = 2;
            // 
            // Selecciona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cmbAux);
            this.Controls.Add(this.lblAux);
            this.Controls.Add(this.btnGenerar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Selecciona";
            this.ShowIcon = false;
            this.Text = "Selecciona";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblAux;
        private System.Windows.Forms.ComboBox cmbAux;
    }
}