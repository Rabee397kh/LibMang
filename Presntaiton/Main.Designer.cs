namespace LibMang.Presntaiton
{
    partial class Main
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
            this.RightPanel = new System.Windows.Forms.Panel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.miniBtn = new System.Windows.Forms.Button();
            this.maxiBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.titlePanel.SuspendLayout();
            this.HomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(762, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(212, 671);
            this.RightPanel.TabIndex = 0;
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.label1);
            this.titlePanel.Controls.Add(this.miniBtn);
            this.titlePanel.Controls.Add(this.maxiBtn);
            this.titlePanel.Controls.Add(this.closeBtn);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(762, 70);
            this.titlePanel.TabIndex = 1;
            // 
            // HomePanel
            // 
            this.HomePanel.Controls.Add(this.MainPanel);
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanel.Location = new System.Drawing.Point(0, 70);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(762, 601);
            this.HomePanel.TabIndex = 2;
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(762, 601);
            this.MainPanel.TabIndex = 0;
            // 
            // miniBtn
            // 
            this.miniBtn.BackgroundImage = global::LibMang.Properties.Resources.minimize;
            this.miniBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.miniBtn.Location = new System.Drawing.Point(62, 11);
            this.miniBtn.Name = "miniBtn";
            this.miniBtn.Size = new System.Drawing.Size(44, 49);
            this.miniBtn.TabIndex = 2;
            this.miniBtn.UseVisualStyleBackColor = true;
            this.miniBtn.Click += new System.EventHandler(this.miniBtn_Click);
            // 
            // maxiBtn
            // 
            this.maxiBtn.BackgroundImage = global::LibMang.Properties.Resources.maximize;
            this.maxiBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.maxiBtn.Location = new System.Drawing.Point(112, 11);
            this.maxiBtn.Name = "maxiBtn";
            this.maxiBtn.Size = new System.Drawing.Size(44, 49);
            this.maxiBtn.TabIndex = 1;
            this.maxiBtn.UseVisualStyleBackColor = true;
            this.maxiBtn.Click += new System.EventHandler(this.maxiBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackgroundImage = global::LibMang.Properties.Resources.close;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBtn.Location = new System.Drawing.Point(12, 11);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(44, 49);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 671);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.RightPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.HomePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button miniBtn;
        private System.Windows.Forms.Button maxiBtn;
        private System.Windows.Forms.Label label1;
    }
}