namespace Amortyzacja.Forms
{
    partial class RegisterSoftwareForm
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
            this.serialNumber = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialNumber
            // 
            this.serialNumber.Location = new System.Drawing.Point(341, 254);
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.Size = new System.Drawing.Size(150, 22);
            this.serialNumber.TabIndex = 0;
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(241, 313);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(163, 47);
            this.register.TabIndex = 1;
            this.register.Text = "ZAREJESTRUJ";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(428, 313);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(149, 47);
            this.back.TabIndex = 2;
            this.back.Text = "POWRÓT";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // RegisterSoftwareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.register);
            this.Controls.Add(this.serialNumber);
            this.Name = "RegisterSoftwareForm";
            this.Text = "RegisterSoftware";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serialNumber;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button back;
    }
}