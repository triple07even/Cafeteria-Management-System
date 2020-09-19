namespace WindowsFormsApplication2
{
    partial class Activities
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
            this.activitydataGridView = new System.Windows.Forms.DataGridView();
            this.activitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodManagerMainDataSet = new WindowsFormsApplication2.FoodManagerMainDataSet();
            this.activitiesTableAdapter = new WindowsFormsApplication2.FoodManagerMainDataSetTableAdapters.ActivitiesTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.sort_date = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.foodManagerDataSet3 = new WindowsFormsApplication2.FoodManagerDataSet3();
            this.activitiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.activitiesTableAdapter1 = new WindowsFormsApplication2.FoodManagerDataSet3TableAdapters.ActivitiesTableAdapter();
            this.snDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.activitydataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodManagerMainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodManagerDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // activitydataGridView
            // 
            this.activitydataGridView.AutoGenerateColumns = false;
            this.activitydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activitydataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snDataGridViewTextBoxColumn,
            this.schoolIdDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.activitydataGridView.DataSource = this.activitiesBindingSource1;
            this.activitydataGridView.Location = new System.Drawing.Point(213, 41);
            this.activitydataGridView.Name = "activitydataGridView";
            this.activitydataGridView.Size = new System.Drawing.Size(753, 461);
            this.activitydataGridView.TabIndex = 0;
            this.activitydataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.activitydataGridView_CellContentClick);
            // 
            // activitiesBindingSource
            // 
            this.activitiesBindingSource.DataMember = "Activities";
            this.activitiesBindingSource.DataSource = this.foodManagerMainDataSet;
            // 
            // foodManagerMainDataSet
            // 
            this.foodManagerMainDataSet.DataSetName = "FoodManagerMainDataSet";
            this.foodManagerMainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // activitiesTableAdapter
            // 
            this.activitiesTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(371, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // sort_date
            // 
            this.sort_date.Location = new System.Drawing.Point(577, 15);
            this.sort_date.Name = "sort_date";
            this.sort_date.Size = new System.Drawing.Size(75, 23);
            this.sort_date.TabIndex = 2;
            this.sort_date.Text = "Sort Date";
            this.sort_date.UseVisualStyleBackColor = true;
            this.sort_date.Click += new System.EventHandler(this.sort_date_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search";
            // 
            // foodManagerDataSet3
            // 
            this.foodManagerDataSet3.DataSetName = "FoodManagerDataSet3";
            this.foodManagerDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // activitiesBindingSource1
            // 
            this.activitiesBindingSource1.DataMember = "Activities";
            this.activitiesBindingSource1.DataSource = this.foodManagerDataSet3;
            // 
            // activitiesTableAdapter1
            // 
            this.activitiesTableAdapter1.ClearBeforeFill = true;
            // 
            // snDataGridViewTextBoxColumn
            // 
            this.snDataGridViewTextBoxColumn.DataPropertyName = "s/n";
            this.snDataGridViewTextBoxColumn.HeaderText = "s/n";
            this.snDataGridViewTextBoxColumn.Name = "snDataGridViewTextBoxColumn";
            this.snDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // schoolIdDataGridViewTextBoxColumn
            // 
            this.schoolIdDataGridViewTextBoxColumn.DataPropertyName = "SchoolId";
            this.schoolIdDataGridViewTextBoxColumn.HeaderText = "School Id";
            this.schoolIdDataGridViewTextBoxColumn.Name = "schoolIdDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 300;
            // 
            // Activities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sort_date);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.activitydataGridView);
            this.Name = "Activities";
            this.Size = new System.Drawing.Size(985, 534);
            ((System.ComponentModel.ISupportInitialize)(this.activitydataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodManagerMainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodManagerDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView activitydataGridView;
        private System.Windows.Forms.BindingSource activitiesBindingSource;
        private FoodManagerMainDataSet foodManagerMainDataSet;
        private FoodManagerMainDataSetTableAdapters.ActivitiesTableAdapter activitiesTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button sort_date;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource activitiesBindingSource1;
        private FoodManagerDataSet3 foodManagerDataSet3;
        private FoodManagerDataSet3TableAdapters.ActivitiesTableAdapter activitiesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}
