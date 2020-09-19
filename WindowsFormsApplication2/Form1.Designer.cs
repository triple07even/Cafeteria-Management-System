namespace WindowsFormsApplication2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lock_btn = new System.Windows.Forms.Button();
            this.softwareOwner = new System.Windows.Forms.Label();
            this.settingBtn = new System.Windows.Forms.Button();
            this.manageBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.homeBtn = new System.Windows.Forms.Button();
            this.signupBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(152)))), ((int)(((byte)(177)))));
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 25);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMinimize.Image = global::WindowsFormsApplication2.Properties.Resources.minimize_1_;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.Location = new System.Drawing.Point(922, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 24);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Image = global::WindowsFormsApplication2.Properties.Resources.power;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(960, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 24);
            this.btnClose.TabIndex = 5;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btn_Close);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(157)))));
            this.sidePanel.Location = new System.Drawing.Point(134, 302);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(10, 49);
            this.sidePanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.sidePanel);
            this.panel2.Controls.Add(this.lock_btn);
            this.panel2.Controls.Add(this.softwareOwner);
            this.panel2.Controls.Add(this.settingBtn);
            this.panel2.Controls.Add(this.manageBtn);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.homeBtn);
            this.panel2.Controls.Add(this.signupBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 595);
            this.panel2.TabIndex = 1;
            // 
            // lock_btn
            // 
            this.lock_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lock_btn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lock_btn.FlatAppearance.BorderSize = 0;
            this.lock_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lock_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lock_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lock_btn.Image = global::WindowsFormsApplication2.Properties.Resources.locked;
            this.lock_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lock_btn.Location = new System.Drawing.Point(35, 442);
            this.lock_btn.Name = "lock_btn";
            this.lock_btn.Size = new System.Drawing.Size(63, 61);
            this.lock_btn.TabIndex = 5;
            this.lock_btn.Text = "LOCK";
            this.lock_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lock_btn.UseVisualStyleBackColor = true;
            this.lock_btn.Click += new System.EventHandler(this.unlock_btn_Click);
            // 
            // softwareOwner
            // 
            this.softwareOwner.AutoSize = true;
            this.softwareOwner.Location = new System.Drawing.Point(32, 566);
            this.softwareOwner.Name = "softwareOwner";
            this.softwareOwner.Size = new System.Drawing.Size(0, 13);
            this.softwareOwner.TabIndex = 3;
            // 
            // settingBtn
            // 
            this.settingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.settingBtn.FlatAppearance.BorderSize = 0;
            this.settingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.settingBtn.Image = global::WindowsFormsApplication2.Properties.Resources.settings_1_;
            this.settingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingBtn.Location = new System.Drawing.Point(0, 355);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(143, 49);
            this.settingBtn.TabIndex = 5;
            this.settingBtn.Text = "Setting";
            this.settingBtn.UseVisualStyleBackColor = true;
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // manageBtn
            // 
            this.manageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.manageBtn.FlatAppearance.BorderSize = 0;
            this.manageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.manageBtn.Image = global::WindowsFormsApplication2.Properties.Resources.verification_of_delivery_list_clipboard_symbol;
            this.manageBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageBtn.Location = new System.Drawing.Point(0, 300);
            this.manageBtn.Name = "manageBtn";
            this.manageBtn.Size = new System.Drawing.Size(143, 49);
            this.manageBtn.TabIndex = 5;
            this.manageBtn.Text = "Activities";
            this.manageBtn.UseVisualStyleBackColor = true;
            this.manageBtn.Click += new System.EventHandler(this.manageBtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(152)))), ((int)(((byte)(177)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(3, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(136, 122);
            this.panel4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Food Collection ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::WindowsFormsApplication2.Properties.Resources.food;
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.meal_3_;
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // homeBtn
            // 
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.homeBtn.Image = global::WindowsFormsApplication2.Properties.Resources.spaguetti;
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(0, 190);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(143, 49);
            this.homeBtn.TabIndex = 4;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // signupBtn
            // 
            this.signupBtn.FlatAppearance.BorderSize = 0;
            this.signupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.signupBtn.Image = global::WindowsFormsApplication2.Properties.Resources.add;
            this.signupBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signupBtn.Location = new System.Drawing.Point(0, 245);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(143, 49);
            this.signupBtn.TabIndex = 3;
            this.signupBtn.Text = "Sign Up && Manage";
            this.signupBtn.UseVisualStyleBackColor = true;
            this.signupBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(143, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 595);
            this.panel3.TabIndex = 2;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Food Manager";
            this.notifyIcon.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 595);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food Collection Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private SignUp signUp1;
        private System.Windows.Forms.Button settingBtn;
        private System.Windows.Forms.Button manageBtn;
        private Activities manage1;
        private collection collection1;
        private Settings settings1;
        private System.Windows.Forms.Button lock_btn;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label softwareOwner;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMinimize;
    }
}

