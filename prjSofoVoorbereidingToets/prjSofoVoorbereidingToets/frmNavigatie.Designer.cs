﻿namespace prjSofoVoorbereidingToets
{
    partial class frmNavigatie
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
            this.btnHoofdstuk3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHoofdstuk3
            // 
            this.btnHoofdstuk3.Location = new System.Drawing.Point(13, 13);
            this.btnHoofdstuk3.Name = "btnHoofdstuk3";
            this.btnHoofdstuk3.Size = new System.Drawing.Size(132, 57);
            this.btnHoofdstuk3.TabIndex = 0;
            this.btnHoofdstuk3.Text = "Hoofdstuk 3";
            this.btnHoofdstuk3.UseVisualStyleBackColor = true;
            this.btnHoofdstuk3.Click += new System.EventHandler(this.btnHoofdstuk3_Click);
            // 
            // frmNavigatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHoofdstuk3);
            this.Name = "frmNavigatie";
            this.Text = "Navigatie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHoofdstuk3;
    }
}

