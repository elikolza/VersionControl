﻿namespace nyolcadik_tok4cz
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.colorb = new System.Windows.Forms.Button();
            this.lblNext = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.Button();
            this.bb = new System.Windows.Forms.Button();
            this.cb = new System.Windows.Forms.Button();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.colorp1 = new System.Windows.Forms.Button();
            this.colorp2 = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.colorp2);
            this.mainPanel.Controls.Add(this.colorp1);
            this.mainPanel.Controls.Add(this.colorb);
            this.mainPanel.Controls.Add(this.lblNext);
            this.mainPanel.Controls.Add(this.pb);
            this.mainPanel.Controls.Add(this.bb);
            this.mainPanel.Controls.Add(this.cb);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 450);
            this.mainPanel.TabIndex = 0;
            // 
            // colorb
            // 
            this.colorb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.colorb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colorb.Location = new System.Drawing.Point(161, 105);
            this.colorb.Name = "colorb";
            this.colorb.Size = new System.Drawing.Size(80, 26);
            this.colorb.TabIndex = 4;
            this.colorb.UseVisualStyleBackColor = false;
            this.colorb.Click += new System.EventHandler(this.colorb_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(421, 38);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(103, 20);
            this.lblNext.TabIndex = 3;
            this.lblNext.Text = "Coming Next:";
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(263, 38);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(111, 61);
            this.pb.TabIndex = 2;
            this.pb.Text = "PRESENT";
            this.pb.UseVisualStyleBackColor = true;
            // 
            // bb
            // 
            this.bb.Location = new System.Drawing.Point(146, 38);
            this.bb.Name = "bb";
            this.bb.Size = new System.Drawing.Size(111, 61);
            this.bb.TabIndex = 1;
            this.bb.Text = "BALL";
            this.bb.UseVisualStyleBackColor = true;
            this.bb.Click += new System.EventHandler(this.bb_Click);
            // 
            // cb
            // 
            this.cb.Location = new System.Drawing.Point(29, 38);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(111, 61);
            this.cb.TabIndex = 0;
            this.cb.Text = "CAR";
            this.cb.UseVisualStyleBackColor = true;
            this.cb.Click += new System.EventHandler(this.cb_Click);
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // colorp1
            // 
            this.colorp1.BackColor = System.Drawing.Color.Red;
            this.colorp1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colorp1.Location = new System.Drawing.Point(282, 105);
            this.colorp1.Name = "colorp1";
            this.colorp1.Size = new System.Drawing.Size(80, 26);
            this.colorp1.TabIndex = 5;
            this.colorp1.UseVisualStyleBackColor = false;
            // 
            // colorp2
            // 
            this.colorp2.BackColor = System.Drawing.Color.Green;
            this.colorp2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colorp2.Location = new System.Drawing.Point(282, 137);
            this.colorp2.Name = "colorp2";
            this.colorp2.Size = new System.Drawing.Size(80, 26);
            this.colorp2.TabIndex = 6;
            this.colorp2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button pb;
        private System.Windows.Forms.Button bb;
        private System.Windows.Forms.Button cb;
        private System.Windows.Forms.Button colorb;
        private System.Windows.Forms.Button colorp2;
        private System.Windows.Forms.Button colorp1;
    }
}

