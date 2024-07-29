
namespace Cadastro
{
    partial class Clientes
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
            this.NomeTbx = new System.Windows.Forms.TextBox();
            this.CpfTbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NomeTbx
            // 
            this.NomeTbx.Location = new System.Drawing.Point(12, 9);
            this.NomeTbx.Name = "NomeTbx";
            this.NomeTbx.PlaceholderText = "Nome";
            this.NomeTbx.Size = new System.Drawing.Size(100, 23);
            this.NomeTbx.TabIndex = 0;
            // 
            // CpfTbx
            // 
            this.CpfTbx.Location = new System.Drawing.Point(12, 51);
            this.CpfTbx.Name = "CpfTbx";
            this.CpfTbx.PlaceholderText = "CPF";
            this.CpfTbx.Size = new System.Drawing.Size(100, 23);
            this.CpfTbx.TabIndex = 1;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CpfTbx);
            this.Controls.Add(this.NomeTbx);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NomeTbx;
        private System.Windows.Forms.TextBox CpfTbx;
    }
}