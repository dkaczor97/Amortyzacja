namespace Amortyzacja.Forms
{
    partial class AssetsForm
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
            this.lastForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lastForm
            // 
            this.lastForm.Location = new System.Drawing.Point(321, 377);
            this.lastForm.Name = "lastForm";
            this.lastForm.Size = new System.Drawing.Size(192, 40);
            this.lastForm.TabIndex = 0;
            this.lastForm.Text = "POPRZEDNIA STRONA";
            this.lastForm.UseVisualStyleBackColor = true;
            this.lastForm.Click += new System.EventHandler(this.lastForm_Click);
            // 
            // AssetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lastForm);
            this.Name = "AssetsForm";
            this.Text = "AssetsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lastForm;
    }
}