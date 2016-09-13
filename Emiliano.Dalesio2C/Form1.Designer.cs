namespace Emiliano.Dalesio2C
{
    partial class Form1
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
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtNum01 = new System.Windows.Forms.TextBox();
            this.txtNum02 = new System.Windows.Forms.TextBox();
            this.cboxOp = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(13, 31);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 0;
            // 
            // txtNum01
            // 
            this.txtNum01.Location = new System.Drawing.Point(16, 88);
            this.txtNum01.Name = "txtNum01";
            this.txtNum01.Size = new System.Drawing.Size(90, 20);
            this.txtNum01.TabIndex = 1;
            // 
            // txtNum02
            // 
            this.txtNum02.Location = new System.Drawing.Point(254, 88);
            this.txtNum02.Name = "txtNum02";
            this.txtNum02.Size = new System.Drawing.Size(90, 20);
            this.txtNum02.TabIndex = 2;
            // 
            // cboxOp
            // 
            this.cboxOp.FormattingEnabled = true;
            this.cboxOp.Location = new System.Drawing.Point(158, 88);
            this.cboxOp.Name = "cboxOp";
            this.cboxOp.Size = new System.Drawing.Size(55, 21);
            this.cboxOp.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(61, 177);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(85, 50);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "CC";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(259, 177);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(85, 50);
            this.btnResultado.TabIndex = 5;
            this.btnResultado.Text = "=";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 268);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cboxOp);
            this.Controls.Add(this.txtNum02);
            this.Controls.Add(this.txtNum01);
            this.Controls.Add(this.lblResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtNum01;
        private System.Windows.Forms.TextBox txtNum02;
        private System.Windows.Forms.ComboBox cboxOp;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnResultado;
    }
}

