namespace Bag_Counting_Project
{
    partial class UserForm
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
            this.finishRecordingBtn = new System.Windows.Forms.Button();
            this.startRecordBtn = new System.Windows.Forms.Button();
            this.openSettingsBtn = new System.Windows.Forms.Button();
            this.loadSettingsBtn = new System.Windows.Forms.Button();
            this.fullVersionLbl = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.countLblShow = new System.Windows.Forms.Label();
            this.totalCountLblShow = new System.Windows.Forms.Label();
            this.countLbl = new System.Windows.Forms.Label();
            this.totalCountLbl = new System.Windows.Forms.Label();
            this.aimCountNum = new System.Windows.Forms.NumericUpDown();
            this.aimCountBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aimCountNum)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(417, 426);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // finishRecordingBtn
            // 
            this.finishRecordingBtn.Location = new System.Drawing.Point(435, 47);
            this.finishRecordingBtn.Name = "finishRecordingBtn";
            this.finishRecordingBtn.Size = new System.Drawing.Size(210, 29);
            this.finishRecordingBtn.TabIndex = 2;
            this.finishRecordingBtn.Text = "Kaydı Bitir";
            this.finishRecordingBtn.UseVisualStyleBackColor = true;
            this.finishRecordingBtn.Click += new System.EventHandler(this.finishRecordingBtn_Click);
            // 
            // startRecordBtn
            // 
            this.startRecordBtn.Location = new System.Drawing.Point(435, 12);
            this.startRecordBtn.Name = "startRecordBtn";
            this.startRecordBtn.Size = new System.Drawing.Size(210, 29);
            this.startRecordBtn.TabIndex = 1;
            this.startRecordBtn.Text = "Kayda Başla";
            this.startRecordBtn.UseVisualStyleBackColor = true;
            this.startRecordBtn.Click += new System.EventHandler(this.startRecordBtn_Click);
            // 
            // openSettingsBtn
            // 
            this.openSettingsBtn.Location = new System.Drawing.Point(435, 82);
            this.openSettingsBtn.Name = "openSettingsBtn";
            this.openSettingsBtn.Size = new System.Drawing.Size(210, 29);
            this.openSettingsBtn.TabIndex = 3;
            this.openSettingsBtn.Text = "Ayarları Aç";
            this.openSettingsBtn.UseVisualStyleBackColor = true;
            this.openSettingsBtn.Click += new System.EventHandler(this.openSettingsBtn_Click);
            // 
            // loadSettingsBtn
            // 
            this.loadSettingsBtn.Location = new System.Drawing.Point(435, 117);
            this.loadSettingsBtn.Name = "loadSettingsBtn";
            this.loadSettingsBtn.Size = new System.Drawing.Size(210, 29);
            this.loadSettingsBtn.TabIndex = 4;
            this.loadSettingsBtn.Text = "Ayarları Yükle";
            this.loadSettingsBtn.UseVisualStyleBackColor = true;
            this.loadSettingsBtn.Click += new System.EventHandler(this.loadSettingsBtn_Click);
            // 
            // fullVersionLbl
            // 
            this.fullVersionLbl.AutoSize = true;
            this.fullVersionLbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fullVersionLbl.Location = new System.Drawing.Point(435, 413);
            this.fullVersionLbl.Name = "fullVersionLbl";
            this.fullVersionLbl.Size = new System.Drawing.Size(122, 25);
            this.fullVersionLbl.TabIndex = 8;
            this.fullVersionLbl.Text = "Demo Sürüm";
            this.fullVersionLbl.Click += new System.EventHandler(this.fullVersionLbl_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(435, 152);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(210, 29);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "Sıfırla";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // countLblShow
            // 
            this.countLblShow.AutoSize = true;
            this.countLblShow.Location = new System.Drawing.Point(435, 252);
            this.countLblShow.Name = "countLblShow";
            this.countLblShow.Size = new System.Drawing.Size(49, 20);
            this.countLblShow.TabIndex = 0;
            this.countLblShow.Text = "Sayım";
            // 
            // totalCountLblShow
            // 
            this.totalCountLblShow.AutoSize = true;
            this.totalCountLblShow.Location = new System.Drawing.Point(435, 272);
            this.totalCountLblShow.Name = "totalCountLblShow";
            this.totalCountLblShow.Size = new System.Drawing.Size(103, 20);
            this.totalCountLblShow.TabIndex = 0;
            this.totalCountLblShow.Text = "Toplam Sayım";
            // 
            // countLbl
            // 
            this.countLbl.AutoSize = true;
            this.countLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.countLbl.Location = new System.Drawing.Point(489, 252);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(15, 20);
            this.countLbl.TabIndex = 0;
            this.countLbl.Text = "_";
            // 
            // totalCountLbl
            // 
            this.totalCountLbl.AutoSize = true;
            this.totalCountLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalCountLbl.Location = new System.Drawing.Point(544, 272);
            this.totalCountLbl.Name = "totalCountLbl";
            this.totalCountLbl.Size = new System.Drawing.Size(15, 20);
            this.totalCountLbl.TabIndex = 0;
            this.totalCountLbl.Text = "_";
            // 
            // aimCountNum
            // 
            this.aimCountNum.Location = new System.Drawing.Point(435, 187);
            this.aimCountNum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.aimCountNum.Name = "aimCountNum";
            this.aimCountNum.Size = new System.Drawing.Size(210, 27);
            this.aimCountNum.TabIndex = 6;
            // 
            // aimCountBtn
            // 
            this.aimCountBtn.Location = new System.Drawing.Point(435, 220);
            this.aimCountBtn.Name = "aimCountBtn";
            this.aimCountBtn.Size = new System.Drawing.Size(210, 29);
            this.aimCountBtn.TabIndex = 7;
            this.aimCountBtn.Text = "Hedef Sayım Kaydet";
            this.aimCountBtn.UseVisualStyleBackColor = true;
            this.aimCountBtn.Click += new System.EventHandler(this.aimCountBtn_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 443);
            this.Controls.Add(this.aimCountBtn);
            this.Controls.Add(this.aimCountNum);
            this.Controls.Add(this.totalCountLblShow);
            this.Controls.Add(this.totalCountLbl);
            this.Controls.Add(this.countLbl);
            this.Controls.Add(this.countLblShow);
            this.Controls.Add(this.fullVersionLbl);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.loadSettingsBtn);
            this.Controls.Add(this.openSettingsBtn);
            this.Controls.Add(this.finishRecordingBtn);
            this.Controls.Add(this.startRecordBtn);
            this.Controls.Add(this.pictureBox);
            this.Name = "UserForm";
            this.Text = "NSP 2 - Kullanıcı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aimCountNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox;
        private Button finishRecordingBtn;
        private Button startRecordBtn;
        private Button openSettingsBtn;
        private Button loadSettingsBtn;
        private Label fullVersionLbl;
        private Button resetBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label countLbl;
        private Label totalCountLbl;
        private Label aimCountLbl;
        private NumericUpDown aimCountNum;
        private Button aimCountBtn;
        private Label countLblShow;
        private Label totalCountLblShow;
    }
}