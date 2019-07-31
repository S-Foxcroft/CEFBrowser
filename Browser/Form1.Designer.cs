namespace Browser
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.titlebar = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Label();
            this.toolbarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Label();
            this.browserContainer = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setAsHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.titlebar.SuspendLayout();
            this.toolbarContainer.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.titlebar.Controls.Add(this.btnMenu);
            this.titlebar.Controls.Add(this.toolbarContainer);
            this.titlebar.Controls.Add(this.btnClose);
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(778, 32);
            this.titlebar.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(714, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(32, 32);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "=";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            this.btnMenu.MouseEnter += new System.EventHandler(this.btnMenu_MouseEnter);
            this.btnMenu.MouseLeave += new System.EventHandler(this.btnMenu_MouseLeave);
            // 
            // toolbarContainer
            // 
            this.toolbarContainer.Controls.Add(this.txtAddress);
            this.toolbarContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolbarContainer.Location = new System.Drawing.Point(0, 0);
            this.toolbarContainer.Margin = new System.Windows.Forms.Padding(0);
            this.toolbarContainer.Name = "toolbarContainer";
            this.toolbarContainer.Size = new System.Drawing.Size(714, 32);
            this.toolbarContainer.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(746, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // browserContainer
            // 
            this.browserContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserContainer.Location = new System.Drawing.Point(0, 32);
            this.browserContainer.Name = "browserContainer";
            this.browserContainer.Size = new System.Drawing.Size(778, 498);
            this.browserContainer.TabIndex = 1;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.menuStrip.DropShadowEnabled = false;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setAsHomeToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.newItemToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.ShowImageMargin = false;
            this.menuStrip.ShowItemToolTips = false;
            this.menuStrip.Size = new System.Drawing.Size(116, 70);
            // 
            // setAsHomeToolStripMenuItem
            // 
            this.setAsHomeToolStripMenuItem.Name = "setAsHomeToolStripMenuItem";
            this.setAsHomeToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.setAsHomeToolStripMenuItem.Text = "Set as Home";
            this.setAsHomeToolStripMenuItem.Click += new System.EventHandler(this.setAsHomeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // newItemToolStripMenuItem
            // 
            this.newItemToolStripMenuItem.Name = "newItemToolStripMenuItem";
            this.newItemToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.newItemToolStripMenuItem.Text = "NewItem,";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(3, 3);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(501, 26);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.Text = "sample text";
            this.txtAddress.WordWrap = false;
            this.txtAddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(778, 530);
            this.Controls.Add(this.browserContainer);
            this.Controls.Add(this.titlebar);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.titlebar.ResumeLayout(false);
            this.toolbarContainer.ResumeLayout(false);
            this.toolbarContainer.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlebar;
        private System.Windows.Forms.FlowLayoutPanel toolbarContainer;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Label btnMenu;
        private System.Windows.Forms.Panel browserContainer;
        private System.Windows.Forms.ContextMenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem setAsHomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newItemToolStripMenuItem;
        private System.Windows.Forms.TextBox txtAddress;
    }
}

