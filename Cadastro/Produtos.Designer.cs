
namespace Cadastro
{
    partial class Produtos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PrecoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CategoriaIdCbx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PrecoNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Nome";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // PrecoNumericUpDown
            // 
            this.PrecoNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrecoNumericUpDown.DecimalPlaces = 2;
            this.PrecoNumericUpDown.Location = new System.Drawing.Point(12, 41);
            this.PrecoNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PrecoNumericUpDown.Name = "PrecoNumericUpDown";
            this.PrecoNumericUpDown.Size = new System.Drawing.Size(100, 23);
            this.PrecoNumericUpDown.TabIndex = 3;
            // 
            // CategoriaIdCbx
            // 
            this.CategoriaIdCbx.FormattingEnabled = true;
            this.CategoriaIdCbx.Location = new System.Drawing.Point(12, 70);
            this.CategoriaIdCbx.Name = "CategoriaIdCbx";
            this.CategoriaIdCbx.Size = new System.Drawing.Size(100, 23);
            this.CategoriaIdCbx.TabIndex = 4;
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CategoriaIdCbx);
            this.Controls.Add(this.PrecoNumericUpDown);
            this.Controls.Add(this.textBox1);
            this.Name = "Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PrecoNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown PrecoNumericUpDown;
        private System.Windows.Forms.ComboBox CategoriaIdCbx;
    }
}

