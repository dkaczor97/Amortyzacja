﻿namespace Amortyzacja.Forms
{
    partial class AddWorkerForm
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
            this.loadFile = new System.Windows.Forms.Button();
            this.lastForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadFile
            // 
            this.loadFile.Location = new System.Drawing.Point(235, 352);
            this.loadFile.Name = "loadFile";
            this.loadFile.Size = new System.Drawing.Size(130, 40);
            this.loadFile.TabIndex = 0;
            this.loadFile.Text = "WCZYTAJ PLIK";
            this.loadFile.UseVisualStyleBackColor = true;
            this.loadFile.Click += new System.EventHandler(this.loadFile_Click);
            // 
            // lastForm
            // 
            this.lastForm.Location = new System.Drawing.Point(482, 352);
            this.lastForm.Name = "lastForm";
            this.lastForm.Size = new System.Drawing.Size(130, 40);
            this.lastForm.TabIndex = 1;
            this.lastForm.Text = "POWRÓT";
            this.lastForm.UseVisualStyleBackColor = true;
            this.lastForm.Click += new System.EventHandler(this.lastForm_Click);
            // 
            // AddWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lastForm);
            this.Controls.Add(this.loadFile);
            this.Name = "AddWorkerForm";
            this.Text = "AddWorkerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadFile;
        private System.Windows.Forms.Button lastForm;
    }
}