namespace Bag_Counting_Project
{
    partial class LicenceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenceForm));
            this.idLabel = new System.Windows.Forms.Label();
            this.idValueLbl = new System.Windows.Forms.Label();
            this.keyLbl = new System.Windows.Forms.Label();
            this.keyTxt = new System.Windows.Forms.TextBox();
            this.saveKeyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(14, 9);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(106, 21);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID Numaranız";
            // 
            // idValueLbl
            // 
            this.idValueLbl.AutoSize = true;
            this.idValueLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.idValueLbl.Location = new System.Drawing.Point(14, 30);
            this.idValueLbl.Name = "idValueLbl";
            this.idValueLbl.Size = new System.Drawing.Size(15, 20);
            this.idValueLbl.TabIndex = 1;
            this.idValueLbl.Text = "_";
            // 
            // keyLbl
            // 
            this.keyLbl.AutoSize = true;
            this.keyLbl.Location = new System.Drawing.Point(14, 76);
            this.keyLbl.Name = "keyLbl";
            this.keyLbl.Size = new System.Drawing.Size(118, 21);
            this.keyLbl.TabIndex = 0;
            this.keyLbl.Text = "Anahtarı Giriniz";
            // 
            // keyTxt
            // 
            this.keyTxt.Location = new System.Drawing.Point(14, 100);
            this.keyTxt.Name = "keyTxt";
            this.keyTxt.Size = new System.Drawing.Size(299, 29);
            this.keyTxt.TabIndex = 2;
            // 
            // saveKeyBtn
            // 
            this.saveKeyBtn.Location = new System.Drawing.Point(14, 134);
            this.saveKeyBtn.Name = "saveKeyBtn";
            this.saveKeyBtn.Size = new System.Drawing.Size(299, 30);
            this.saveKeyBtn.TabIndex = 3;
            this.saveKeyBtn.Text = "Kaydet";
            this.saveKeyBtn.UseVisualStyleBackColor = true;
            this.saveKeyBtn.Click += new System.EventHandler(this.saveKeyBtn_Click);
            // 
            // LicenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 174);
            this.Controls.Add(this.saveKeyBtn);
            this.Controls.Add(this.keyTxt);
            this.Controls.Add(this.idValueLbl);
            this.Controls.Add(this.keyLbl);
            this.Controls.Add(this.idLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LicenceForm";
            this.Text = "NSP 2 - Lisans";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label idLabel;
        private Label idValueLbl;
        private Label keyLbl;
        private TextBox keyTxt;
        private Button saveKeyBtn;
    }
}