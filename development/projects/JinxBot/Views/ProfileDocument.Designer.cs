﻿namespace JinxBot.Views
{
    partial class ProfileDocument
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
            this.dock = new JinxBot.Controls.Docking.DockPanel();
            this.SuspendLayout();
            // 
            // dock
            // 
            this.dock.ActiveAutoHideContent = null;
            this.dock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dock.DocumentStyle = JinxBot.Controls.Docking.DocumentStyle.DockingWindow;
            this.dock.Location = new System.Drawing.Point(0, 0);
            this.dock.Name = "dock";
            this.dock.Size = new System.Drawing.Size(609, 381);
            this.dock.TabIndex = 0;
            // 
            // ProfileDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 381);
            this.CloseButton = false;
            this.Controls.Add(this.dock);
            this.Name = "ProfileDocument";
            this.TabText = "ProfileDocument";
            this.Text = "ProfileDocument";
            this.ResumeLayout(false);

        }

        #endregion

        private JinxBot.Controls.Docking.DockPanel dock;
    }
}