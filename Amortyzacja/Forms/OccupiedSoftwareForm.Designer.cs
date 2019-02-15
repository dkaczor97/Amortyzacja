namespace Amortyzacja.Forms
{
    partial class OccupiedSoftwareForm
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
            this.occupiedSoftware = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lastForm
            // 
            this.lastForm.Location = new System.Drawing.Point(347, 398);
            this.lastForm.Name = "lastForm";
            this.lastForm.Size = new System.Drawing.Size(120, 40);
            this.lastForm.TabIndex = 0;
            this.lastForm.Text = "POWRÓT";
            this.lastForm.UseVisualStyleBackColor = true;
            this.lastForm.Click += new System.EventHandler(this.lastForm_Click);
            // 
            // occupiedSoftware
            // 
            this.occupiedSoftware.Location = new System.Drawing.Point(158, 12);
            this.occupiedSoftware.Name = "occupiedSoftware";
            this.occupiedSoftware.Size = new System.Drawing.Size(520, 350);
            this.occupiedSoftware.TabIndex = 1;
            this.occupiedSoftware.UseCompatibleStateImageBehavior = false;
            // 
            // OccupiedSoftwareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.occupiedSoftware);
            this.Controls.Add(this.lastForm);
            this.Name = "OccupiedSoftwareForm";
            this.Text = "OccupiedSoftwareForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lastForm;
        private System.Windows.Forms.ListView occupiedSoftware;
    }
}