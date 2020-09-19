namespace WindowsFormsApplication2
{
    partial class Settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_nwString = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.conText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_collegeText = new System.Windows.Forms.RadioButton();
            this.collegeText = new System.Windows.Forms.TextBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.days_enrolled_txtbox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnImgChange = new System.Windows.Forms.Button();
            this.imageTxt = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.uidOutlet2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.t2_btn = new System.Windows.Forms.Button();
            this.label40 = new System.Windows.Forms.Label();
            this.statusLabel2 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.IdLabel2 = new System.Windows.Forms.Label();
            this.nameLabel2 = new System.Windows.Forms.Label();
            this.count2 = new System.Windows.Forms.Label();
            this.connectTwo = new System.Windows.Forms.Button();
            this.portBox2 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_nwString);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.conText);
            this.groupBox1.Location = new System.Drawing.Point(46, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 68);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection String";
            // 
            // rb_nwString
            // 
            this.rb_nwString.AutoSize = true;
            this.rb_nwString.Location = new System.Drawing.Point(6, 40);
            this.rb_nwString.Name = "rb_nwString";
            this.rb_nwString.Size = new System.Drawing.Size(77, 17);
            this.rb_nwString.TabIndex = 2;
            this.rb_nwString.TabStop = true;
            this.rb_nwString.Text = "New String";
            this.rb_nwString.UseVisualStyleBackColor = true;
            this.rb_nwString.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Default";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // conText
            // 
            this.conText.Location = new System.Drawing.Point(89, 40);
            this.conText.Name = "conText";
            this.conText.Size = new System.Drawing.Size(128, 20);
            this.conText.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_collegeText);
            this.groupBox2.Controls.Add(this.collegeText);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Location = new System.Drawing.Point(46, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 68);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Institution Name";
            // 
            // rb_collegeText
            // 
            this.rb_collegeText.AutoSize = true;
            this.rb_collegeText.Location = new System.Drawing.Point(7, 42);
            this.rb_collegeText.Name = "rb_collegeText";
            this.rb_collegeText.Size = new System.Drawing.Size(78, 17);
            this.rb_collegeText.TabIndex = 5;
            this.rb_collegeText.TabStop = true;
            this.rb_collegeText.Text = "New Name";
            this.rb_collegeText.UseVisualStyleBackColor = true;
            this.rb_collegeText.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // collegeText
            // 
            this.collegeText.Location = new System.Drawing.Point(90, 39);
            this.collegeText.Name = "collegeText";
            this.collegeText.Size = new System.Drawing.Size(128, 20);
            this.collegeText.TabIndex = 3;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(7, 19);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(59, 17);
            this.radioButton6.TabIndex = 4;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Default";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Location = new System.Drawing.Point(46, 288);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 139);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Server Names";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.days_enrolled_txtbox);
            this.groupBox4.Location = new System.Drawing.Point(285, 140);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(185, 68);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Meals Setting";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Days Enrolled";
            // 
            // days_enrolled_txtbox
            // 
            this.days_enrolled_txtbox.Location = new System.Drawing.Point(89, 39);
            this.days_enrolled_txtbox.Name = "days_enrolled_txtbox";
            this.days_enrolled_txtbox.Size = new System.Drawing.Size(79, 20);
            this.days_enrolled_txtbox.TabIndex = 3;
            this.days_enrolled_txtbox.Text = "100";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnImgChange);
            this.groupBox5.Controls.Add(this.imageTxt);
            this.groupBox5.Location = new System.Drawing.Point(46, 214);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(424, 75);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Institution Image";
            // 
            // btnImgChange
            // 
            this.btnImgChange.Location = new System.Drawing.Point(343, 45);
            this.btnImgChange.Name = "btnImgChange";
            this.btnImgChange.Size = new System.Drawing.Size(75, 23);
            this.btnImgChange.TabIndex = 1;
            this.btnImgChange.Text = "Change";
            this.btnImgChange.UseVisualStyleBackColor = true;
            this.btnImgChange.Click += new System.EventHandler(this.btnImgChange_Click);
            // 
            // imageTxt
            // 
            this.imageTxt.Enabled = false;
            this.imageTxt.Location = new System.Drawing.Point(7, 19);
            this.imageTxt.Name = "imageTxt";
            this.imageTxt.ReadOnly = true;
            this.imageTxt.Size = new System.Drawing.Size(411, 20);
            this.imageTxt.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(808, 502);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 42);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.uidOutlet2);
            this.groupBox6.Controls.Add(this.pictureBox2);
            this.groupBox6.Controls.Add(this.t2_btn);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label40);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.statusLabel2);
            this.groupBox6.Controls.Add(this.label39);
            this.groupBox6.Controls.Add(this.label38);
            this.groupBox6.Controls.Add(this.IdLabel2);
            this.groupBox6.Controls.Add(this.nameLabel2);
            this.groupBox6.Controls.Add(this.count2);
            this.groupBox6.Controls.Add(this.connectTwo);
            this.groupBox6.Controls.Add(this.portBox2);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Location = new System.Drawing.Point(496, 66);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(322, 187);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Check Patron";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 16);
            this.label14.TabIndex = 16;
            this.label14.Text = "UID";
            // 
            // uidOutlet2
            // 
            this.uidOutlet2.Enabled = false;
            this.uidOutlet2.Location = new System.Drawing.Point(41, 88);
            this.uidOutlet2.Name = "uidOutlet2";
            this.uidOutlet2.Size = new System.Drawing.Size(93, 20);
            this.uidOutlet2.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.InitialImage = global::WindowsFormsApplication2.Properties.Resources.food__2_;
            this.pictureBox2.Location = new System.Drawing.Point(175, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 164);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // t2_btn
            // 
            this.t2_btn.Location = new System.Drawing.Point(8, 127);
            this.t2_btn.Name = "t2_btn";
            this.t2_btn.Size = new System.Drawing.Size(47, 50);
            this.t2_btn.TabIndex = 11;
            this.t2_btn.Text = "Test Client";
            this.t2_btn.UseVisualStyleBackColor = true;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(9, 50);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(48, 16);
            this.label40.TabIndex = 10;
            this.label40.Text = "Status:";
            // 
            // statusLabel2
            // 
            this.statusLabel2.AutoSize = true;
            this.statusLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel2.Location = new System.Drawing.Point(57, 50);
            this.statusLabel2.Name = "statusLabel2";
            this.statusLabel2.Size = new System.Drawing.Size(26, 16);
            this.statusLabel2.TabIndex = 10;
            this.statusLabel2.Text = "- - -";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(9, 34);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(47, 16);
            this.label39.TabIndex = 9;
            this.label39.Text = "Matric:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(9, 18);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(48, 16);
            this.label38.TabIndex = 8;
            this.label38.Text = "Name:";
            // 
            // IdLabel2
            // 
            this.IdLabel2.AutoSize = true;
            this.IdLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel2.Location = new System.Drawing.Point(57, 34);
            this.IdLabel2.Name = "IdLabel2";
            this.IdLabel2.Size = new System.Drawing.Size(26, 16);
            this.IdLabel2.TabIndex = 9;
            this.IdLabel2.Text = "- - -";
            // 
            // nameLabel2
            // 
            this.nameLabel2.AutoSize = true;
            this.nameLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel2.Location = new System.Drawing.Point(57, 18);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(26, 16);
            this.nameLabel2.TabIndex = 8;
            this.nameLabel2.Text = "- - -";
            // 
            // count2
            // 
            this.count2.AutoSize = true;
            this.count2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count2.Location = new System.Drawing.Point(7, 108);
            this.count2.Name = "count2";
            this.count2.Size = new System.Drawing.Size(63, 16);
            this.count2.TabIndex = 7;
            this.count2.Text = "Count: 0";
            // 
            // connectTwo
            // 
            this.connectTwo.Location = new System.Drawing.Point(61, 154);
            this.connectTwo.Name = "connectTwo";
            this.connectTwo.Size = new System.Drawing.Size(72, 23);
            this.connectTwo.TabIndex = 2;
            this.connectTwo.Text = "Connect";
            this.connectTwo.UseVisualStyleBackColor = true;
            // 
            // portBox2
            // 
            this.portBox2.FormattingEnabled = true;
            this.portBox2.Location = new System.Drawing.Point(76, 129);
            this.portBox2.Name = "portBox2";
            this.portBox2.Size = new System.Drawing.Size(58, 21);
            this.portBox2.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(53, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "- - -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ticket:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(985, 561);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_nwString;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox conText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_collegeText;
        private System.Windows.Forms.TextBox collegeText;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox days_enrolled_txtbox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnImgChange;
        private System.Windows.Forms.TextBox imageTxt;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox uidOutlet2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button t2_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statusLabel2;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label IdLabel2;
        private System.Windows.Forms.Label nameLabel2;
        private System.Windows.Forms.Label count2;
        private System.Windows.Forms.Button connectTwo;
        private System.Windows.Forms.ComboBox portBox2;
        private System.Windows.Forms.Label label17;
    }
}
