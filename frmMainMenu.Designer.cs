﻿namespace NBA_Tickets_Retail
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.picMainMenu = new System.Windows.Forms.PictureBox();
            this.seatTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSeatTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSeatTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTeamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyRevenueAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenu)).BeginInit();
            this.mnuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMainMenu
            // 
            this.picMainMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMainMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.picMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("picMainMenu.Image")));
            this.picMainMenu.Location = new System.Drawing.Point(0, 25);
            this.picMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.picMainMenu.Name = "picMainMenu";
            this.picMainMenu.Size = new System.Drawing.Size(719, 344);
            this.picMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMainMenu.TabIndex = 0;
            this.picMainMenu.TabStop = false;
            // 
            // seatTypeToolStripMenuItem
            // 
            this.seatTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSeatTypeToolStripMenuItem,
            this.updateSeatTypeToolStripMenuItem});
            this.seatTypeToolStripMenuItem.Font = new System.Drawing.Font("Caladea", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatTypeToolStripMenuItem.Name = "seatTypeToolStripMenuItem";
            this.seatTypeToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.seatTypeToolStripMenuItem.Text = "Seats";
            // 
            // addSeatTypeToolStripMenuItem
            // 
            this.addSeatTypeToolStripMenuItem.Name = "addSeatTypeToolStripMenuItem";
            this.addSeatTypeToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.addSeatTypeToolStripMenuItem.Text = "Add Seat Type";
            this.addSeatTypeToolStripMenuItem.Click += new System.EventHandler(this.addSeatTypeToolStripMenuItem_Click);
            // 
            // updateSeatTypeToolStripMenuItem
            // 
            this.updateSeatTypeToolStripMenuItem.Name = "updateSeatTypeToolStripMenuItem";
            this.updateSeatTypeToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.updateSeatTypeToolStripMenuItem.Text = "Update Seat Type";
            this.updateSeatTypeToolStripMenuItem.Click += new System.EventHandler(this.updateSeatTypeToolStripMenuItem_Click);
            // 
            // matchesToolStripMenuItem
            // 
            this.matchesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTeamsToolStripMenuItem,
            this.scheduleMatchToolStripMenuItem});
            this.matchesToolStripMenuItem.Font = new System.Drawing.Font("Caladea", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchesToolStripMenuItem.Name = "matchesToolStripMenuItem";
            this.matchesToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.matchesToolStripMenuItem.Text = "Matches";
            // 
            // addTeamsToolStripMenuItem
            // 
            this.addTeamsToolStripMenuItem.Name = "addTeamsToolStripMenuItem";
            this.addTeamsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addTeamsToolStripMenuItem.Text = "Add Teams";
            this.addTeamsToolStripMenuItem.Click += new System.EventHandler(this.addTeamToolStripMenuItem_Click);
            // 
            // scheduleMatchToolStripMenuItem
            // 
            this.scheduleMatchToolStripMenuItem.Name = "scheduleMatchToolStripMenuItem";
            this.scheduleMatchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.scheduleMatchToolStripMenuItem.Text = "Schedule Match";
            this.scheduleMatchToolStripMenuItem.Click += new System.EventHandler(this.scheduleMatchToolStripMenuItem_Click);
            // 
            // ticketsToolStripMenuItem
            // 
            this.ticketsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processSalesToolStripMenuItem,
            this.returnTicketsToolStripMenuItem});
            this.ticketsToolStripMenuItem.Font = new System.Drawing.Font("Caladea", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            this.ticketsToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.ticketsToolStripMenuItem.Text = "Sales";
            // 
            // processSalesToolStripMenuItem
            // 
            this.processSalesToolStripMenuItem.Name = "processSalesToolStripMenuItem";
            this.processSalesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.processSalesToolStripMenuItem.Text = "Process Sales";
            this.processSalesToolStripMenuItem.Click += new System.EventHandler(this.processSaleToolStripMenuItem_Click);
            // 
            // returnTicketsToolStripMenuItem
            // 
            this.returnTicketsToolStripMenuItem.Name = "returnTicketsToolStripMenuItem";
            this.returnTicketsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.returnTicketsToolStripMenuItem.Text = "Return Sale";
            this.returnTicketsToolStripMenuItem.Click += new System.EventHandler(this.returnSaleToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yearlyRevenueAnalysisToolStripMenuItem,
            this.seatsToolStripMenuItem});
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("Caladea", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.adminToolStripMenuItem.Text = " Admin";
            // 
            // yearlyRevenueAnalysisToolStripMenuItem
            // 
            this.yearlyRevenueAnalysisToolStripMenuItem.Name = "yearlyRevenueAnalysisToolStripMenuItem";
            this.yearlyRevenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.yearlyRevenueAnalysisToolStripMenuItem.Text = "Seasonal Sales Analysis";
            this.yearlyRevenueAnalysisToolStripMenuItem.Click += new System.EventHandler(this.seasonalSalesAnalysisToolStripMenuItem_Click);
            // 
            // seatsToolStripMenuItem
            // 
            this.seatsToolStripMenuItem.Name = "seatsToolStripMenuItem";
            this.seatsToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.seatsToolStripMenuItem.Text = "Popularity Analysis";
            this.seatsToolStripMenuItem.Click += new System.EventHandler(this.popularityAnalysisToolStripMenuItem_Click);
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seatTypeToolStripMenuItem,
            this.matchesToolStripMenuItem,
            this.ticketsToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuMainMenu.Size = new System.Drawing.Size(719, 25);
            this.mnuMainMenu.TabIndex = 1;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 369);
            this.Controls.Add(this.picMainMenu);
            this.Controls.Add(this.mnuMainMenu);
            this.Font = new System.Drawing.Font("Caladea", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMainMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Tickets Retail - [Main Menu]";
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenu)).EndInit();
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMainMenu;
        private System.Windows.Forms.ToolStripMenuItem seatTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem addSeatTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSeatTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleMatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearlyRevenueAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTeamsToolStripMenuItem;
    }
}

