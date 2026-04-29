namespace ADMIRAL_HOMESTAY
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inpName = new System.Windows.Forms.TextBox();
            this.inpAddress = new System.Windows.Forms.RichTextBox();
            this.inpPhoneNumber = new System.Windows.Forms.TextBox();
            this.inpCarNumber = new System.Windows.Forms.TextBox();
            this.cbIsMalaysian = new System.Windows.Forms.CheckBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.labelNatio = new System.Windows.Forms.Label();
            this.inpNationality = new System.Windows.Forms.TextBox();
            this.inpPassport = new System.Windows.Forms.TextBox();
            this.labelPassport = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ADMIRAL_HOMESTAY.Properties.Resources.banner;
            this.pictureBox1.Location = new System.Drawing.Point(12, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 294);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(374, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(374, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(374, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contact Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(374, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Car Plate Number";
            // 
            // inpName
            // 
            this.inpName.Location = new System.Drawing.Point(514, 120);
            this.inpName.Name = "inpName";
            this.inpName.Size = new System.Drawing.Size(274, 26);
            this.inpName.TabIndex = 6;
            // 
            // inpAddress
            // 
            this.inpAddress.Location = new System.Drawing.Point(514, 167);
            this.inpAddress.Name = "inpAddress";
            this.inpAddress.Size = new System.Drawing.Size(274, 96);
            this.inpAddress.TabIndex = 7;
            this.inpAddress.Text = "";
            // 
            // inpPhoneNumber
            // 
            this.inpPhoneNumber.Location = new System.Drawing.Point(514, 275);
            this.inpPhoneNumber.Name = "inpPhoneNumber";
            this.inpPhoneNumber.Size = new System.Drawing.Size(274, 26);
            this.inpPhoneNumber.TabIndex = 8;
            // 
            // inpCarNumber
            // 
            this.inpCarNumber.Location = new System.Drawing.Point(514, 334);
            this.inpCarNumber.Name = "inpCarNumber";
            this.inpCarNumber.Size = new System.Drawing.Size(274, 26);
            this.inpCarNumber.TabIndex = 9;
            // 
            // cbIsMalaysian
            // 
            this.cbIsMalaysian.AutoSize = true;
            this.cbIsMalaysian.Location = new System.Drawing.Point(818, 117);
            this.cbIsMalaysian.Name = "cbIsMalaysian";
            this.cbIsMalaysian.Size = new System.Drawing.Size(132, 24);
            this.cbIsMalaysian.TabIndex = 10;
            this.cbIsMalaysian.Text = "Non-Malaysian";
            this.cbIsMalaysian.UseVisualStyleBackColor = true;
            this.cbIsMalaysian.CheckedChanged += new System.EventHandler(this.cbIsMalaysian_CheckedChanged);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(813, 401);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(139, 49);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // labelNatio
            // 
            this.labelNatio.AutoSize = true;
            this.labelNatio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNatio.Location = new System.Drawing.Point(814, 167);
            this.labelNatio.Name = "labelNatio";
            this.labelNatio.Size = new System.Drawing.Size(82, 20);
            this.labelNatio.TabIndex = 12;
            this.labelNatio.Text = "Nationality";
            // 
            // inpNationality
            // 
            this.inpNationality.Location = new System.Drawing.Point(818, 190);
            this.inpNationality.Name = "inpNationality";
            this.inpNationality.Size = new System.Drawing.Size(186, 26);
            this.inpNationality.TabIndex = 13;
            // 
            // inpPassport
            // 
            this.inpPassport.Location = new System.Drawing.Point(818, 266);
            this.inpPassport.Name = "inpPassport";
            this.inpPassport.Size = new System.Drawing.Size(186, 26);
            this.inpPassport.TabIndex = 15;
            // 
            // labelPassport
            // 
            this.labelPassport.AutoSize = true;
            this.labelPassport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPassport.Location = new System.Drawing.Point(814, 243);
            this.labelPassport.Name = "labelPassport";
            this.labelPassport.Size = new System.Drawing.Size(72, 20);
            this.labelPassport.TabIndex = 14;
            this.labelPassport.Text = "Passport";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1069, 562);
            this.Controls.Add(this.inpPassport);
            this.Controls.Add(this.labelPassport);
            this.Controls.Add(this.inpNationality);
            this.Controls.Add(this.labelNatio);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.cbIsMalaysian);
            this.Controls.Add(this.inpCarNumber);
            this.Controls.Add(this.inpPhoneNumber);
            this.Controls.Add(this.inpAddress);
            this.Controls.Add(this.inpName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admiral Homestay : Main Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inpName;
        private System.Windows.Forms.RichTextBox inpAddress;
        private System.Windows.Forms.TextBox inpPhoneNumber;
        private System.Windows.Forms.TextBox inpCarNumber;
        private System.Windows.Forms.CheckBox cbIsMalaysian;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label labelNatio;
        private System.Windows.Forms.TextBox inpNationality;
        private System.Windows.Forms.TextBox inpPassport;
        private System.Windows.Forms.Label labelPassport;
    }
}

