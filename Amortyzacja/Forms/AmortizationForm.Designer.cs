namespace Amortyzacja.Forms
{
    partial class AmortizationForm
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
            this.serialNumber = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lastForm
            // 
            this.lastForm.Location = new System.Drawing.Point(464, 398);
            this.lastForm.Name = "lastForm";
            this.lastForm.Size = new System.Drawing.Size(120, 40);
            this.lastForm.TabIndex = 0;
            this.lastForm.Text = "POWRÓT";
            this.lastForm.UseVisualStyleBackColor = true;
            this.lastForm.Click += new System.EventHandler(this.lastForm_Click);
            // 
            // serialNumber
            // 
            this.serialNumber.Location = new System.Drawing.Point(195, 370);
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.Size = new System.Drawing.Size(150, 22);
            this.serialNumber.TabIndex = 1;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(448, 370);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(150, 22);
            this.year.TabIndex = 2;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(211, 398);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(120, 40);
            this.pass.TabIndex = 3;
            this.pass.Text = "ZATWIERDŹ";
            this.pass.UseVisualStyleBackColor = true;
            this.pass.Click += new System.EventHandler(this.pass_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(195, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(403, 296);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // AmortizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.year);
            this.Controls.Add(this.serialNumber);
            this.Controls.Add(this.lastForm);
            this.Name = "AmortizationForm";
            this.Text = "AmortizationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lastForm;
        private System.Windows.Forms.TextBox serialNumber;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Button pass;
        private System.Windows.Forms.ListView listView1;
    }
}