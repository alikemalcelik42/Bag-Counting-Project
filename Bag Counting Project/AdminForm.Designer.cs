namespace Bag_Counting_Project
{
    partial class AdminForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.thresholdValueLbl = new System.Windows.Forms.Label();
            this.minAreaLbl = new System.Windows.Forms.Label();
            this.minAreaNum = new System.Windows.Forms.NumericUpDown();
            this.saveBtn = new System.Windows.Forms.Button();
            this.loadSettingsBtn = new System.Windows.Forms.Button();
            this.setSourceBtn = new System.Windows.Forms.Button();
            this.maxHeightLbl = new System.Windows.Forms.Label();
            this.maxHeightNum = new System.Windows.Forms.NumericUpDown();
            this.thresholdValueCountBoxLbl = new System.Windows.Forms.Label();
            this.distanceOfBoxesLbl = new System.Windows.Forms.Label();
            this.distanceOfBoxesNum = new System.Windows.Forms.NumericUpDown();
            this.thresholdValueNum = new System.Windows.Forms.NumericUpDown();
            this.thresholdValueCountBoxNum = new System.Windows.Forms.NumericUpDown();
            this.bagHeightLblShow = new System.Windows.Forms.Label();
            this.bagWidthLblShow = new System.Windows.Forms.Label();
            this.bagHeightLbl = new System.Windows.Forms.Label();
            this.bagWidthLbl = new System.Windows.Forms.Label();
            this.sectionPictureBox = new System.Windows.Forms.PictureBox();
            this.maskPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minAreaNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxHeightNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceOfBoxesNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdValueNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdValueCountBoxNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(417, 426);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // thresholdValueLbl
            // 
            this.thresholdValueLbl.AutoSize = true;
            this.thresholdValueLbl.Location = new System.Drawing.Point(1295, 79);
            this.thresholdValueLbl.Name = "thresholdValueLbl";
            this.thresholdValueLbl.Size = new System.Drawing.Size(79, 20);
            this.thresholdValueLbl.TabIndex = 0;
            this.thresholdValueLbl.Text = "Eşik Değer";
            // 
            // minAreaLbl
            // 
            this.minAreaLbl.AutoSize = true;
            this.minAreaLbl.Location = new System.Drawing.Point(1295, 185);
            this.minAreaLbl.Name = "minAreaLbl";
            this.minAreaLbl.Size = new System.Drawing.Size(106, 20);
            this.minAreaLbl.TabIndex = 0;
            this.minAreaLbl.Text = "Minimum Alan";
            // 
            // minAreaNum
            // 
            this.minAreaNum.Location = new System.Drawing.Point(1295, 208);
            this.minAreaNum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.minAreaNum.Name = "minAreaNum";
            this.minAreaNum.Size = new System.Drawing.Size(229, 27);
            this.minAreaNum.TabIndex = 5;
            this.minAreaNum.ValueChanged += new System.EventHandler(this.minAreaNum_ValueChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(1295, 12);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(229, 29);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Kaydet";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // loadSettingsBtn
            // 
            this.loadSettingsBtn.Location = new System.Drawing.Point(1295, 47);
            this.loadSettingsBtn.Name = "loadSettingsBtn";
            this.loadSettingsBtn.Size = new System.Drawing.Size(229, 29);
            this.loadSettingsBtn.TabIndex = 2;
            this.loadSettingsBtn.Text = "Ayarları Geri Yükle";
            this.loadSettingsBtn.UseVisualStyleBackColor = true;
            this.loadSettingsBtn.Click += new System.EventHandler(this.loadSettingsBtn_Click);
            // 
            // setSourceBtn
            // 
            this.setSourceBtn.Location = new System.Drawing.Point(1295, 347);
            this.setSourceBtn.Name = "setSourceBtn";
            this.setSourceBtn.Size = new System.Drawing.Size(229, 29);
            this.setSourceBtn.TabIndex = 8;
            this.setSourceBtn.Text = "Kaynak Seç";
            this.setSourceBtn.UseVisualStyleBackColor = true;
            this.setSourceBtn.Click += new System.EventHandler(this.setSourceBtn_Click);
            // 
            // maxHeightLbl
            // 
            this.maxHeightLbl.AutoSize = true;
            this.maxHeightLbl.Location = new System.Drawing.Point(1295, 238);
            this.maxHeightLbl.Name = "maxHeightLbl";
            this.maxHeightLbl.Size = new System.Drawing.Size(138, 20);
            this.maxHeightLbl.TabIndex = 0;
            this.maxHeightLbl.Text = "Maximum Yükseklik";
            // 
            // maxHeightNum
            // 
            this.maxHeightNum.Location = new System.Drawing.Point(1295, 261);
            this.maxHeightNum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.maxHeightNum.Name = "maxHeightNum";
            this.maxHeightNum.Size = new System.Drawing.Size(229, 27);
            this.maxHeightNum.TabIndex = 6;
            this.maxHeightNum.ValueChanged += new System.EventHandler(this.maxHeightNum_ValueChanged);
            // 
            // thresholdValueCountBoxLbl
            // 
            this.thresholdValueCountBoxLbl.AutoSize = true;
            this.thresholdValueCountBoxLbl.Location = new System.Drawing.Point(1295, 132);
            this.thresholdValueCountBoxLbl.Name = "thresholdValueCountBoxLbl";
            this.thresholdValueCountBoxLbl.Size = new System.Drawing.Size(171, 20);
            this.thresholdValueCountBoxLbl.TabIndex = 0;
            this.thresholdValueCountBoxLbl.Text = "Sayım Kutusu Eşik Değer";
            // 
            // distanceOfBoxesLbl
            // 
            this.distanceOfBoxesLbl.AutoSize = true;
            this.distanceOfBoxesLbl.Location = new System.Drawing.Point(1295, 291);
            this.distanceOfBoxesLbl.Name = "distanceOfBoxesLbl";
            this.distanceOfBoxesLbl.Size = new System.Drawing.Size(192, 20);
            this.distanceOfBoxesLbl.TabIndex = 0;
            this.distanceOfBoxesLbl.Text = "Sayım Kutuları Arası Uzaklık";
            // 
            // distanceOfBoxesNum
            // 
            this.distanceOfBoxesNum.Location = new System.Drawing.Point(1295, 314);
            this.distanceOfBoxesNum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.distanceOfBoxesNum.Name = "distanceOfBoxesNum";
            this.distanceOfBoxesNum.Size = new System.Drawing.Size(229, 27);
            this.distanceOfBoxesNum.TabIndex = 7;
            this.distanceOfBoxesNum.ValueChanged += new System.EventHandler(this.distanceOfBoxesNum_ValueChanged);
            // 
            // thresholdValueNum
            // 
            this.thresholdValueNum.Location = new System.Drawing.Point(1295, 102);
            this.thresholdValueNum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.thresholdValueNum.Name = "thresholdValueNum";
            this.thresholdValueNum.Size = new System.Drawing.Size(229, 27);
            this.thresholdValueNum.TabIndex = 3;
            this.thresholdValueNum.ValueChanged += new System.EventHandler(this.thresholdValueNum_ValueChanged);
            // 
            // thresholdValueCountBoxNum
            // 
            this.thresholdValueCountBoxNum.Location = new System.Drawing.Point(1295, 155);
            this.thresholdValueCountBoxNum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.thresholdValueCountBoxNum.Name = "thresholdValueCountBoxNum";
            this.thresholdValueCountBoxNum.Size = new System.Drawing.Size(229, 27);
            this.thresholdValueCountBoxNum.TabIndex = 4;
            this.thresholdValueCountBoxNum.ValueChanged += new System.EventHandler(this.thresholdValueCountBoxNum_ValueChanged);
            // 
            // bagHeightLblShow
            // 
            this.bagHeightLblShow.AutoSize = true;
            this.bagHeightLblShow.Location = new System.Drawing.Point(1295, 388);
            this.bagHeightLblShow.Name = "bagHeightLblShow";
            this.bagHeightLblShow.Size = new System.Drawing.Size(82, 20);
            this.bagHeightLblShow.TabIndex = 9;
            this.bagHeightLblShow.Text = "Çuval Boyu";
            // 
            // bagWidthLblShow
            // 
            this.bagWidthLblShow.AutoSize = true;
            this.bagWidthLblShow.Location = new System.Drawing.Point(1305, 408);
            this.bagWidthLblShow.Name = "bagWidthLblShow";
            this.bagWidthLblShow.Size = new System.Drawing.Size(69, 20);
            this.bagWidthLblShow.TabIndex = 9;
            this.bagWidthLblShow.Text = "Çuval Eni";
            // 
            // bagHeightLbl
            // 
            this.bagHeightLbl.AutoSize = true;
            this.bagHeightLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bagHeightLbl.Location = new System.Drawing.Point(1380, 388);
            this.bagHeightLbl.Name = "bagHeightLbl";
            this.bagHeightLbl.Size = new System.Drawing.Size(15, 20);
            this.bagHeightLbl.TabIndex = 10;
            this.bagHeightLbl.Text = "_";
            // 
            // bagWidthLbl
            // 
            this.bagWidthLbl.AutoSize = true;
            this.bagWidthLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bagWidthLbl.Location = new System.Drawing.Point(1380, 408);
            this.bagWidthLbl.Name = "bagWidthLbl";
            this.bagWidthLbl.Size = new System.Drawing.Size(15, 20);
            this.bagWidthLbl.TabIndex = 10;
            this.bagWidthLbl.Text = "_";
            // 
            // sectionPictureBox
            // 
            this.sectionPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sectionPictureBox.Location = new System.Drawing.Point(435, 12);
            this.sectionPictureBox.Name = "sectionPictureBox";
            this.sectionPictureBox.Size = new System.Drawing.Size(417, 426);
            this.sectionPictureBox.TabIndex = 11;
            this.sectionPictureBox.TabStop = false;
            // 
            // maskPictureBox
            // 
            this.maskPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskPictureBox.Location = new System.Drawing.Point(858, 12);
            this.maskPictureBox.Name = "maskPictureBox";
            this.maskPictureBox.Size = new System.Drawing.Size(417, 426);
            this.maskPictureBox.TabIndex = 12;
            this.maskPictureBox.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 442);
            this.Controls.Add(this.maskPictureBox);
            this.Controls.Add(this.sectionPictureBox);
            this.Controls.Add(this.bagWidthLbl);
            this.Controls.Add(this.bagHeightLbl);
            this.Controls.Add(this.bagWidthLblShow);
            this.Controls.Add(this.bagHeightLblShow);
            this.Controls.Add(this.loadSettingsBtn);
            this.Controls.Add(this.setSourceBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.distanceOfBoxesNum);
            this.Controls.Add(this.maxHeightNum);
            this.Controls.Add(this.distanceOfBoxesLbl);
            this.Controls.Add(this.maxHeightLbl);
            this.Controls.Add(this.thresholdValueCountBoxNum);
            this.Controls.Add(this.thresholdValueNum);
            this.Controls.Add(this.minAreaNum);
            this.Controls.Add(this.minAreaLbl);
            this.Controls.Add(this.thresholdValueCountBoxLbl);
            this.Controls.Add(this.thresholdValueLbl);
            this.Controls.Add(this.pictureBox);
            this.Name = "AdminForm";
            this.Text = "NSP 2 - Yönetici";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minAreaNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxHeightNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceOfBoxesNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdValueNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdValueCountBoxNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox;
        private Label thresholdValueLbl;
        private Label minAreaLbl;
        private NumericUpDown minAreaNum;
        private Button saveBtn;
        private Button loadSettingsBtn;
        private Button setSourceBtn;
        private Label maxHeightLbl;
        private NumericUpDown maxHeightNum;
        private Label thresholdValueCountBoxLbl;
        private Label distanceOfBoxesLbl;
        private NumericUpDown distanceOfBoxesNum;
        private NumericUpDown thresholdValueNum;
        private NumericUpDown thresholdValueCountBoxNum;
        private Label bagHeightLblShow;
        private Label bagWidthLblShow;
        private Label bagHeightLbl;
        private Label bagWidthLbl;
        private PictureBox sectionPictureBox;
        private PictureBox maskPictureBox;
    }
}