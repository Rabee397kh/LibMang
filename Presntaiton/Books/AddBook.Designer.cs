namespace LibMang.Presntaiton.Books
{
    partial class AddBook
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
            BunifuAnimatorNS.Animation animation7 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bookPriceNu = new System.Windows.Forms.NumericUpDown();
            this.categoryCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.authorTxt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.bookNameTxt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addCoverLink = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bookRating = new Bunifu.Framework.UI.BunifuRating();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addBookBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.title = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPriceNu)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bookPriceNu);
            this.groupBox1.Controls.Add(this.categoryCombo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.authorTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bookNameTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.bunifuTransition1.SetDecoration(this.groupBox1, BunifuAnimatorNS.DecorationType.None);
            this.groupBox1.Location = new System.Drawing.Point(12, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 562);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Important Information";
            // 
            // bookPriceNu
            // 
            this.bunifuTransition1.SetDecoration(this.bookPriceNu, BunifuAnimatorNS.DecorationType.None);
            this.bookPriceNu.Location = new System.Drawing.Point(137, 373);
            this.bookPriceNu.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.bookPriceNu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bookPriceNu.Name = "bookPriceNu";
            this.bookPriceNu.Size = new System.Drawing.Size(247, 30);
            this.bookPriceNu.TabIndex = 8;
            this.bookPriceNu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // categoryCombo
            // 
            this.bunifuTransition1.SetDecoration(this.categoryCombo, BunifuAnimatorNS.DecorationType.None);
            this.categoryCombo.FormattingEnabled = true;
            this.categoryCombo.Location = new System.Drawing.Point(137, 278);
            this.categoryCombo.Name = "categoryCombo";
            this.categoryCombo.Size = new System.Drawing.Size(247, 33);
            this.categoryCombo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Location = new System.Drawing.Point(15, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Location = new System.Drawing.Point(15, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Category";
            // 
            // authorTxt
            // 
            this.authorTxt.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuTransition1.SetDecoration(this.authorTxt, BunifuAnimatorNS.DecorationType.None);
            this.authorTxt.Location = new System.Drawing.Point(137, 161);
            this.authorTxt.Name = "authorTxt";
            this.authorTxt.Size = new System.Drawing.Size(247, 30);
            this.authorTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Location = new System.Drawing.Point(15, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author";
            // 
            // bookNameTxt
            // 
            this.bookNameTxt.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuTransition1.SetDecoration(this.bookNameTxt, BunifuAnimatorNS.DecorationType.None);
            this.bookNameTxt.Location = new System.Drawing.Point(137, 56);
            this.bookNameTxt.Name = "bookNameTxt";
            this.bookNameTxt.Size = new System.Drawing.Size(247, 30);
            this.bookNameTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Location = new System.Drawing.Point(15, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addCoverLink);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.bookRating);
            this.groupBox2.Controls.Add(this.bunifuDatepicker1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.bunifuTransition1.SetDecoration(this.groupBox2, BunifuAnimatorNS.DecorationType.None);
            this.groupBox2.Location = new System.Drawing.Point(510, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 562);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Secondary";
            // 
            // addCoverLink
            // 
            this.addCoverLink.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.addCoverLink, BunifuAnimatorNS.DecorationType.None);
            this.addCoverLink.LinkColor = System.Drawing.Color.SeaGreen;
            this.addCoverLink.Location = new System.Drawing.Point(247, 479);
            this.addCoverLink.Name = "addCoverLink";
            this.addCoverLink.Size = new System.Drawing.Size(106, 25);
            this.addCoverLink.TabIndex = 11;
            this.addCoverLink.TabStop = true;
            this.addCoverLink.Text = "Add Cover";
            this.addCoverLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addCoverLink_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(135, 249);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // bookRating
            // 
            this.bookRating.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bookRating, BunifuAnimatorNS.DecorationType.None);
            this.bookRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookRating.ForeColor = System.Drawing.Color.SeaGreen;
            this.bookRating.Location = new System.Drawing.Point(135, 141);
            this.bookRating.Margin = new System.Windows.Forms.Padding(6);
            this.bookRating.Name = "bookRating";
            this.bookRating.Size = new System.Drawing.Size(331, 62);
            this.bookRating.TabIndex = 9;
            this.bookRating.Value = 0;
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuTransition1.SetDecoration(this.bunifuDatepicker1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuDatepicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(135, 56);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(331, 44);
            this.bunifuDatepicker1.TabIndex = 8;
            this.bunifuDatepicker1.Value = new System.DateTime(2026, 6, 23, 19, 6, 28, 446);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Location = new System.Drawing.Point(4, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cover";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Location = new System.Drawing.Point(6, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ratinng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.label8.Location = new System.Drawing.Point(4, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Publish Date";
            // 
            // addBookBtn
            // 
            this.addBookBtn.ActiveBorderThickness = 1;
            this.addBookBtn.ActiveCornerRadius = 20;
            this.addBookBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.addBookBtn.ActiveForecolor = System.Drawing.Color.White;
            this.addBookBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.addBookBtn.BackColor = System.Drawing.Color.White;
            this.addBookBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addBookBtn.BackgroundImage")));
            this.addBookBtn.ButtonText = "Add";
            this.addBookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.addBookBtn, BunifuAnimatorNS.DecorationType.None);
            this.addBookBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.addBookBtn.IdleBorderThickness = 1;
            this.addBookBtn.IdleCornerRadius = 20;
            this.addBookBtn.IdleFillColor = System.Drawing.Color.White;
            this.addBookBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.addBookBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.addBookBtn.Location = new System.Drawing.Point(421, 767);
            this.addBookBtn.Margin = new System.Windows.Forms.Padding(5);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(181, 41);
            this.addBookBtn.TabIndex = 9;
            this.addBookBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.title, BunifuAnimatorNS.DecorationType.None);
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.SeaGreen;
            this.title.Location = new System.Drawing.Point(407, 26);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(123, 29);
            this.title.TabIndex = 8;
            this.title.Text = "Add Book";
            // 
            // closeBtn
            // 
            this.closeBtn.BackgroundImage = global::LibMang.Properties.Resources.close;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.closeBtn, BunifuAnimatorNS.DecorationType.None);
            this.closeBtn.Location = new System.Drawing.Point(2, -3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(44, 49);
            this.closeBtn.TabIndex = 10;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.bunifuTransition1.Cursor = null;
            animation7.AnimateOnlyDifferences = true;
            animation7.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.BlindCoeff")));
            animation7.LeafCoeff = 0F;
            animation7.MaxTime = 1F;
            animation7.MinTime = 0F;
            animation7.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicCoeff")));
            animation7.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicShift")));
            animation7.MosaicSize = 0;
            animation7.Padding = new System.Windows.Forms.Padding(0);
            animation7.RotateCoeff = 0F;
            animation7.RotateLimit = 0F;
            animation7.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.ScaleCoeff")));
            animation7.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.SlideCoeff")));
            animation7.TimeCoeff = 0F;
            animation7.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation7;
            this.bunifuTransition1.MaxAnimationTime = 5000;
            this.bunifuTransition1.TimeStep = 0.05F;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 822);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.title);
            this.Controls.Add(this.addBookBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPriceNu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bookNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categoryCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox authorTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuRating bookRating;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 addBookBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.NumericUpDown bookPriceNu;
        private System.Windows.Forms.LinkLabel addCoverLink;
        private System.Windows.Forms.Button closeBtn;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
    }
}