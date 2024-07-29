
namespace Cadastro
{
    partial class Categorias
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
            this.CategoriaTbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CategoriaTbx
            // 
            this.CategoriaTbx.Location = new System.Drawing.Point(12, 25);
            this.CategoriaTbx.Name = "CategoriaTbx";
            this.CategoriaTbx.PlaceholderText = "Categoria";
            this.CategoriaTbx.Size = new System.Drawing.Size(100, 23);
            this.CategoriaTbx.TabIndex = 0;
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CategoriaTbx);
            this.Name = "Categorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CategoriaTbx;
    }
}