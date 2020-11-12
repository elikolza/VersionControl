namespace nyolcadik_tok4cz
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
            this.lblNext = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.Button();
            this.bb = new System.Windows.Forms.Button();
            this.cb = new System.Windows.Forms.Button();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
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
    }
}

