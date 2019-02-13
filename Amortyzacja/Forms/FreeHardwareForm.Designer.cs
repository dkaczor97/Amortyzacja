namespace Amortyzacja.Forms
{
    partial class FreeHardwareForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lastForm
            // 
            this.lastForm.Location = new System.Drawing.Point(357, 330);
            this.lastForm.Name = "lastForm";
            this.lastForm.Size = new System.Drawing.Size(118, 49);
            this.lastForm.TabIndex = 0;
            this.lastForm.Text = "POWRÓT";
            this.lastForm.UseVisualStyleBackColor = true;
            this.lastForm.Click += new System.EventHandler(this.lastForm_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(239, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(317, 264);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FreeHardwareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lastForm);
            this.Name = "FreeHardwareForm";
            this.Text = "FreeHardwareForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lastForm;
        private System.Windows.Forms.ListView listView1;
    }
}