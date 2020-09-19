using System;

namespace WindowsFormsApplication2
{
    partial class SignUp
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
            this.components = new System.ComponentModel.Container();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOtherNames = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textMass = new System.Windows.Forms.TextBox();
            this.boxDepartment = new System.Windows.Forms.ComboBox();
            this.txtMatricNumber = new System.Windows.Forms.TextBox();
            this.maindataGridView = new System.Windows.Forms.DataGridView();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchoolId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manHuntPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.philiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.philiTicketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainDataBaseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.foodManagerMainDataSet1 = new WindowsFormsApplication2.FoodManagerMainDataSet1();
            this.mainDataBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodManagerDataSet2 = new WindowsFormsApplication2.FoodManagerDataSet2();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.uidSignup = new System.Windows.Forms.Button();
            this.bxSex = new System.Windows.Forms.ComboBox();
            this.camCapture = new System.Windows.Forms.Button();
            this.boxPayment = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addTicket = new System.Windows.Forms.CheckBox();
            this.downGrade = new System.Windows.Forms.Button();
            this.signUpBox = new System.Windows.Forms.ComboBox();
            this.upGrade = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioFalse = new System.Windows.Forms.RadioButton();
            this.radioTrue = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fromTxt = new System.Windows.Forms.TextBox();
            this.ToTxt = new System.Windows.Forms.TextBox();
            this.sendTicket = new System.Windows.Forms.TextBox();
            this.transferBtn = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mainDataBaseTableAdapter = new WindowsFormsApplication2.FoodManagerDataSet2TableAdapters.MainDataBaseTableAdapter();
            this.mainDataBaseTableAdapter1 = new WindowsFormsApplication2.FoodManagerMainDataSet1TableAdapters.MainDataBaseTableAdapter();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.days_enrolled_txtbox = new System.Windows.Forms.TextBox();
            this.rb_2meals = new System.Windows.Forms.RadioButton();
            this.rb_3meals = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.maindataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataBaseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodManagerMainDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataBaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodManagerDataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(67, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(84, 20);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Other Names";
            // 
            // txtOtherNames
            // 
            this.txtOtherNames.Location = new System.Drawing.Point(100, 36);
            this.txtOtherNames.Name = "txtOtherNames";
            this.txtOtherNames.Size = new System.Drawing.Size(94, 20);
            this.txtOtherNames.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sex";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Matric Number";
            // 
            // textMass
            // 
            this.textMass.Location = new System.Drawing.Point(54, 21);
            this.textMass.Name = "textMass";
            this.textMass.Size = new System.Drawing.Size(35, 20);
            this.textMass.TabIndex = 8;
            // 
            // boxDepartment
            // 
            this.boxDepartment.FormattingEnabled = true;
            this.boxDepartment.Items.AddRange(new object[] {
            "Computer Science",
            "Biochemistry",
            "Industrial Chemistry",
            "Microbiology",
            "Mathematics",
            "Religious Studies",
            "History",
            "English",
            "Political Science",
            "Bussiness Administration",
            "Economic",
            "Accounting",
            "Law"});
            this.boxDepartment.Location = new System.Drawing.Point(100, 134);
            this.boxDepartment.Name = "boxDepartment";
            this.boxDepartment.Size = new System.Drawing.Size(100, 21);
            this.boxDepartment.TabIndex = 10;
            // 
            // txtMatricNumber
            // 
            this.txtMatricNumber.Location = new System.Drawing.Point(100, 100);
            this.txtMatricNumber.Name = "txtMatricNumber";
            this.txtMatricNumber.Size = new System.Drawing.Size(100, 20);
            this.txtMatricNumber.TabIndex = 11;
            // 
            // maindataGridView
            // 
            this.maindataGridView.AutoGenerateColumns = false;
            this.maindataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maindataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SName,
            this.OName,
            this.Image,
            this.courseDataGridViewTextBoxColumn,
            this.uIDDataGridViewTextBoxColumn,
            this.paymentDataGridViewTextBoxColumn,
            this.SchoolId,
            this.iDMainDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.manHuntPDataGridViewTextBoxColumn,
            this.philiDataGridViewTextBoxColumn,
            this.philiTicketDataGridViewTextBoxColumn});
            this.maindataGridView.DataSource = this.mainDataBaseBindingSource1;
            this.maindataGridView.Location = new System.Drawing.Point(11, 248);
            this.maindataGridView.Name = "maindataGridView";
            this.maindataGridView.RowTemplate.Height = 50;
            this.maindataGridView.Size = new System.Drawing.Size(944, 270);
            this.maindataGridView.TabIndex = 12;
            this.maindataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maindataGridView_KeyPress);
            // 
            // SName
            // 
            this.SName.DataPropertyName = "SName";
            this.SName.HeaderText = "Surname";
            this.SName.Name = "SName";
            // 
            // OName
            // 
            this.OName.DataPropertyName = "OName";
            this.OName.HeaderText = "Other Names";
            this.OName.Name = "OName";
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Image";
            this.Image.Name = "Image";
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            // 
            // uIDDataGridViewTextBoxColumn
            // 
            this.uIDDataGridViewTextBoxColumn.DataPropertyName = "UID";
            this.uIDDataGridViewTextBoxColumn.HeaderText = "UID";
            this.uIDDataGridViewTextBoxColumn.Name = "uIDDataGridViewTextBoxColumn";
            // 
            // paymentDataGridViewTextBoxColumn
            // 
            this.paymentDataGridViewTextBoxColumn.DataPropertyName = "Payment";
            this.paymentDataGridViewTextBoxColumn.HeaderText = "Payment";
            this.paymentDataGridViewTextBoxColumn.Name = "paymentDataGridViewTextBoxColumn";
            // 
            // SchoolId
            // 
            this.SchoolId.DataPropertyName = "SchoolId";
            this.SchoolId.HeaderText = "SchoolId";
            this.SchoolId.Name = "SchoolId";
            // 
            // iDMainDataGridViewTextBoxColumn
            // 
            this.iDMainDataGridViewTextBoxColumn.DataPropertyName = "IDMain";
            this.iDMainDataGridViewTextBoxColumn.HeaderText = "Ticket";
            this.iDMainDataGridViewTextBoxColumn.Name = "iDMainDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // manHuntPDataGridViewTextBoxColumn
            // 
            this.manHuntPDataGridViewTextBoxColumn.DataPropertyName = "ManHuntP";
            this.manHuntPDataGridViewTextBoxColumn.HeaderText = "Wanted";
            this.manHuntPDataGridViewTextBoxColumn.Name = "manHuntPDataGridViewTextBoxColumn";
            // 
            // philiDataGridViewTextBoxColumn
            // 
            this.philiDataGridViewTextBoxColumn.DataPropertyName = "Phili";
            this.philiDataGridViewTextBoxColumn.HeaderText = "Philanthrophist";
            this.philiDataGridViewTextBoxColumn.Name = "philiDataGridViewTextBoxColumn";
            // 
            // philiTicketDataGridViewTextBoxColumn
            // 
            this.philiTicketDataGridViewTextBoxColumn.DataPropertyName = "PhiliTicket";
            this.philiTicketDataGridViewTextBoxColumn.HeaderText = "Extra Ticket";
            this.philiTicketDataGridViewTextBoxColumn.Name = "philiTicketDataGridViewTextBoxColumn";
            // 
            // mainDataBaseBindingSource1
            // 
            this.mainDataBaseBindingSource1.DataMember = "MainDataBase";
            this.mainDataBaseBindingSource1.DataSource = this.foodManagerMainDataSet1;
            // 
            // foodManagerMainDataSet1
            // 
            this.foodManagerMainDataSet1.DataSetName = "FoodManagerMainDataSet1";
            this.foodManagerMainDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainDataBaseBindingSource
            // 
            this.mainDataBaseBindingSource.DataMember = "MainDataBase";
            this.mainDataBaseBindingSource.DataSource = this.foodManagerDataSet2;
            // 
            // foodManagerDataSet2
            // 
            this.foodManagerDataSet2.DataSetName = "FoodManagerDataSet2";
            this.foodManagerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(100, 172);
            this.txtUID.Name = "txtUID";
            this.txtUID.ReadOnly = true;
            this.txtUID.Size = new System.Drawing.Size(100, 20);
            this.txtUID.TabIndex = 14;
            this.txtUID.TextChanged += new System.EventHandler(this.txtUID_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Unique Card ID";
            // 
            // uidSignup
            // 
            this.uidSignup.Location = new System.Drawing.Point(262, 171);
            this.uidSignup.Name = "uidSignup";
            this.uidSignup.Size = new System.Drawing.Size(44, 23);
            this.uidSignup.TabIndex = 15;
            this.uidSignup.Text = "Scan";
            this.uidSignup.UseVisualStyleBackColor = true;
            this.uidSignup.Click += new System.EventHandler(this.uidSignup_Click);
            // 
            // bxSex
            // 
            this.bxSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.bxSex.Location = new System.Drawing.Point(100, 69);
            this.bxSex.Name = "bxSex";
            this.bxSex.Size = new System.Drawing.Size(100, 21);
            this.bxSex.TabIndex = 17;
            // 
            // camCapture
            // 
            this.camCapture.Location = new System.Drawing.Point(325, 142);
            this.camCapture.Name = "camCapture";
            this.camCapture.Size = new System.Drawing.Size(62, 23);
            this.camCapture.TabIndex = 18;
            this.camCapture.Text = "Capture";
            this.camCapture.UseVisualStyleBackColor = true;
            this.camCapture.Click += new System.EventHandler(this.camCapture_Click);
            // 
            // boxPayment
            // 
            this.boxPayment.FormattingEnabled = true;
            this.boxPayment.Items.AddRange(new object[] {
            "Full",
            "Half"});
            this.boxPayment.Location = new System.Drawing.Point(100, 200);
            this.boxPayment.Name = "boxPayment";
            this.boxPayment.Size = new System.Drawing.Size(100, 21);
            this.boxPayment.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ticket Payment";
            // 
            // addTicket
            // 
            this.addTicket.AutoSize = true;
            this.addTicket.Location = new System.Drawing.Point(206, 202);
            this.addTicket.Name = "addTicket";
            this.addTicket.Size = new System.Drawing.Size(78, 17);
            this.addTicket.TabIndex = 21;
            this.addTicket.Text = "Add Ticket";
            this.addTicket.UseVisualStyleBackColor = true;
            // 
            // downGrade
            // 
            this.downGrade.Location = new System.Drawing.Point(6, 19);
            this.downGrade.Name = "downGrade";
            this.downGrade.Size = new System.Drawing.Size(43, 25);
            this.downGrade.TabIndex = 22;
            this.downGrade.Text = "Down";
            this.downGrade.UseVisualStyleBackColor = true;
            this.downGrade.Click += new System.EventHandler(this.downGrade_Click_1);
            // 
            // signUpBox
            // 
            this.signUpBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.signUpBox.FormattingEnabled = true;
            this.signUpBox.Location = new System.Drawing.Point(206, 172);
            this.signUpBox.Name = "signUpBox";
            this.signUpBox.Size = new System.Drawing.Size(50, 21);
            this.signUpBox.TabIndex = 19;
            this.signUpBox.TextChanged += new System.EventHandler(this.signUpBox_TextChanged);
            // 
            // upGrade
            // 
            this.upGrade.Location = new System.Drawing.Point(95, 19);
            this.upGrade.Name = "upGrade";
            this.upGrade.Size = new System.Drawing.Size(43, 23);
            this.upGrade.TabIndex = 22;
            this.upGrade.Text = "Up";
            this.upGrade.UseVisualStyleBackColor = true;
            this.upGrade.Click += new System.EventHandler(this.upGrade_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textMass);
            this.groupBox1.Controls.Add(this.upGrade);
            this.groupBox1.Controls.Add(this.downGrade);
            this.groupBox1.Location = new System.Drawing.Point(438, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 55);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mass Update";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(703, 202);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(57, 23);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(766, 202);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(57, 23);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(829, 202);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(57, 23);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.radioFalse);
            this.groupBox2.Controls.Add(this.radioTrue);
            this.groupBox2.Location = new System.Drawing.Point(438, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 45);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flag";
            // 
            // radioFalse
            // 
            this.radioFalse.AutoSize = true;
            this.radioFalse.Location = new System.Drawing.Point(56, 20);
            this.radioFalse.Name = "radioFalse";
            this.radioFalse.Size = new System.Drawing.Size(50, 17);
            this.radioFalse.TabIndex = 1;
            this.radioFalse.TabStop = true;
            this.radioFalse.Text = "False";
            this.radioFalse.UseVisualStyleBackColor = true;
            // 
            // radioTrue
            // 
            this.radioTrue.AutoSize = true;
            this.radioTrue.Location = new System.Drawing.Point(7, 20);
            this.radioTrue.Name = "radioTrue";
            this.radioTrue.Size = new System.Drawing.Size(47, 17);
            this.radioTrue.TabIndex = 0;
            this.radioTrue.TabStop = true;
            this.radioTrue.Text = "True";
            this.radioTrue.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.fromTxt);
            this.groupBox3.Controls.Add(this.ToTxt);
            this.groupBox3.Controls.Add(this.sendTicket);
            this.groupBox3.Controls.Add(this.transferBtn);
            this.groupBox3.Location = new System.Drawing.Point(616, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 78);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ticket Transfer";
            // 
            // fromTxt
            // 
            this.fromTxt.Location = new System.Drawing.Point(6, 21);
            this.fromTxt.Name = "fromTxt";
            this.fromTxt.Size = new System.Drawing.Size(52, 20);
            this.fromTxt.TabIndex = 10;
            this.fromTxt.TextChanged += new System.EventHandler(this.fromTxt_TextChanged);
            // 
            // ToTxt
            // 
            this.ToTxt.Location = new System.Drawing.Point(106, 21);
            this.ToTxt.Name = "ToTxt";
            this.ToTxt.Size = new System.Drawing.Size(50, 20);
            this.ToTxt.TabIndex = 9;
            this.ToTxt.TextChanged += new System.EventHandler(this.ToTxt_TextChanged);
            // 
            // sendTicket
            // 
            this.sendTicket.Location = new System.Drawing.Point(64, 21);
            this.sendTicket.Name = "sendTicket";
            this.sendTicket.Size = new System.Drawing.Size(32, 20);
            this.sendTicket.TabIndex = 8;
            // 
            // transferBtn
            // 
            this.transferBtn.Location = new System.Drawing.Point(6, 49);
            this.transferBtn.Name = "transferBtn";
            this.transferBtn.Size = new System.Drawing.Size(150, 23);
            this.transferBtn.TabIndex = 15;
            this.transferBtn.Text = "Transfer";
            this.transferBtn.UseVisualStyleBackColor = true;
            this.transferBtn.Click += new System.EventHandler(this.transferBtn_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(408, 204);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(163, 20);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(361, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Search";
            // 
            // mainDataBaseTableAdapter
            // 
            this.mainDataBaseTableAdapter.ClearBeforeFill = true;
            // 
            // mainDataBaseTableAdapter1
            // 
            this.mainDataBaseTableAdapter1.ClearBeforeFill = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(577, 202);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(57, 23);
            this.btnNew.TabIndex = 24;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(640, 202);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(57, 23);
            this.btnRegister.TabIndex = 24;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(206, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.rb_3meals);
            this.groupBox4.Controls.Add(this.rb_2meals);
            this.groupBox4.Controls.Add(this.days_enrolled_txtbox);
            this.groupBox4.Location = new System.Drawing.Point(438, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(177, 56);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ticket";
            // 
            // days_enrolled_txtbox
            // 
            this.days_enrolled_txtbox.Location = new System.Drawing.Point(86, 30);
            this.days_enrolled_txtbox.Name = "days_enrolled_txtbox";
            this.days_enrolled_txtbox.Size = new System.Drawing.Size(52, 20);
            this.days_enrolled_txtbox.TabIndex = 10;
            this.days_enrolled_txtbox.Text = "100";
            this.days_enrolled_txtbox.TextChanged += new System.EventHandler(this.fromTxt_TextChanged);
            // 
            // rb_2meals
            // 
            this.rb_2meals.AutoSize = true;
            this.rb_2meals.Location = new System.Drawing.Point(7, 11);
            this.rb_2meals.Name = "rb_2meals";
            this.rb_2meals.Size = new System.Drawing.Size(77, 17);
            this.rb_2meals.TabIndex = 11;
            this.rb_2meals.TabStop = true;
            this.rb_2meals.Text = "Two Meals";
            this.rb_2meals.UseVisualStyleBackColor = true;
            // 
            // rb_3meals
            // 
            this.rb_3meals.AutoSize = true;
            this.rb_3meals.Location = new System.Drawing.Point(82, 12);
            this.rb_3meals.Name = "rb_3meals";
            this.rb_3meals.Size = new System.Drawing.Size(84, 17);
            this.rb_3meals.TabIndex = 11;
            this.rb_3meals.TabStop = true;
            this.rb_3meals.Text = "Three Meals";
            this.rb_3meals.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Days Enrolled";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addTicket);
            this.Controls.Add(this.signUpBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.boxPayment);
            this.Controls.Add(this.camCapture);
            this.Controls.Add(this.bxSex);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uidSignup);
            this.Controls.Add(this.txtUID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maindataGridView);
            this.Controls.Add(this.txtMatricNumber);
            this.Controls.Add(this.boxDepartment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOtherNames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "SignUp";
            this.Size = new System.Drawing.Size(1009, 521);
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.Enter += new System.EventHandler(this.SignUp_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.maindataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataBaseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodManagerMainDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataBaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodManagerDataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOtherNames;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textMass;
        private System.Windows.Forms.ComboBox boxDepartment;
        private System.Windows.Forms.TextBox txtMatricNumber;
        private System.Windows.Forms.DataGridView maindataGridView;
        private System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button uidSignup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox bxSex;
        private System.Windows.Forms.Button camCapture;
        private System.Windows.Forms.ComboBox boxPayment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox addTicket;
        private System.Windows.Forms.Button downGrade;
        private System.Windows.Forms.ComboBox signUpBox;
        private System.Windows.Forms.Button upGrade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioFalse;
        private System.Windows.Forms.RadioButton radioTrue;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox fromTxt;
        private System.Windows.Forms.TextBox ToTxt;
        private System.Windows.Forms.TextBox sendTicket;
        private System.Windows.Forms.Button transferBtn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource mainDataBaseBindingSource;
        private FoodManagerDataSet2 foodManagerDataSet2;
        private FoodManagerDataSet2TableAdapters.MainDataBaseTableAdapter mainDataBaseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OName;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchoolId;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manHuntPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn philiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn philiTicketDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mainDataBaseBindingSource1;
        private FoodManagerMainDataSet1 foodManagerMainDataSet1;
        private FoodManagerMainDataSet1TableAdapters.MainDataBaseTableAdapter mainDataBaseTableAdapter1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_3meals;
        private System.Windows.Forms.RadioButton rb_2meals;
        private System.Windows.Forms.TextBox days_enrolled_txtbox;
    }
}
