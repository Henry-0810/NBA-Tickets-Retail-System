﻿
namespace NBA_Tickets_Retail
{
    partial class frmCheckAvailability
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckAvailability));
            this.btnCAback = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCAback
            // 
            this.btnCAback.BackColor = System.Drawing.SystemColors.Menu;
            this.btnCAback.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCAback.Location = new System.Drawing.Point(1, 1);
            this.btnCAback.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCAback.Name = "btnCAback";
            this.btnCAback.Size = new System.Drawing.Size(57, 26);
            this.btnCAback.TabIndex = 18;
            this.btnCAback.Text = "Back";
            this.btnCAback.UseVisualStyleBackColor = false;
            this.btnCAback.Click += new System.EventHandler(this.btnCAback_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(33, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 39);
            this.label6.TabIndex = 24;
            this.label6.Text = "Check Availability";
            // 
            // frmCheckAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCAback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCheckAvailability";
            this.Text = "NBA Tickets Retail - [Tickets] - [Check Availability]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCAback;
        private System.Windows.Forms.Label label6;
    }
}