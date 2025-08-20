//namespace WindowsFormsApplication4
//{
//    partial class Form1
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.components = new System.ComponentModel.Container();
//            this.groupBox1 = new System.Windows.Forms.GroupBox();
//            this.textBox4 = new System.Windows.Forms.TextBox();
//            this.pATIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
//            this.breast_CancerDataSet = new WindowsFormsApplication4.Breast_CancerDataSet();
//            this.textBox3 = new System.Windows.Forms.TextBox();
//            this.textBox2 = new System.Windows.Forms.TextBox();
//            this.textBox1 = new System.Windows.Forms.TextBox();
//            this.button8 = new System.Windows.Forms.Button();
//            this.label4 = new System.Windows.Forms.Label();
//            this.button7 = new System.Windows.Forms.Button();
//            this.button6 = new System.Windows.Forms.Button();
//            this.button5 = new System.Windows.Forms.Button();
//            this.button4 = new System.Windows.Forms.Button();
//            this.button3 = new System.Windows.Forms.Button();
//            this.button2 = new System.Windows.Forms.Button();
//            this.button1 = new System.Windows.Forms.Button();
//            this.label3 = new System.Windows.Forms.Label();
//            this.label2 = new System.Windows.Forms.Label();
//            this.label1 = new System.Windows.Forms.Label();
//            this.dataGridView1 = new System.Windows.Forms.DataGridView();
//            this.patientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.raceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.familyHistoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.pATIENT_TableAdapter = new WindowsFormsApplication4.Breast_CancerDataSetTableAdapters.PATIENT_TableAdapter();
//            this.groupBox1.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.breast_CancerDataSet)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // groupBox1
//            // 
//            this.groupBox1.Controls.Add(this.textBox4);
//            this.groupBox1.Controls.Add(this.textBox3);
//            this.groupBox1.Controls.Add(this.textBox2);
//            this.groupBox1.Controls.Add(this.textBox1);
//            this.groupBox1.Controls.Add(this.button8);
//            this.groupBox1.Controls.Add(this.label4);
//            this.groupBox1.Controls.Add(this.button7);
//            this.groupBox1.Controls.Add(this.button6);
//            this.groupBox1.Controls.Add(this.button5);
//            this.groupBox1.Controls.Add(this.button4);
//            this.groupBox1.Controls.Add(this.button3);
//            this.groupBox1.Controls.Add(this.button2);
//            this.groupBox1.Controls.Add(this.button1);
//            this.groupBox1.Controls.Add(this.label3);
//            this.groupBox1.Controls.Add(this.label2);
//            this.groupBox1.Controls.Add(this.label1);
//            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.groupBox1.Location = new System.Drawing.Point(12, 12);
//            this.groupBox1.Name = "groupBox1";
//            this.groupBox1.Size = new System.Drawing.Size(540, 428);
//            this.groupBox1.TabIndex = 0;
//            this.groupBox1.TabStop = false;
//            this.groupBox1.Text = "Patient Table";
//            // 
//            // textBox4
//            // 
//            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource, "Race", true));
//            this.textBox4.Location = new System.Drawing.Point(194, 138);
//            this.textBox4.Multiline = true;
//            this.textBox4.Name = "textBox4";
//            this.textBox4.Size = new System.Drawing.Size(229, 29);
//            this.textBox4.TabIndex = 17;
//            // 
//            // pATIENTBindingSource
//            // 
//            this.pATIENTBindingSource.DataMember = "PATIENT$";
//            this.pATIENTBindingSource.DataSource = this.breast_CancerDataSet;
//            // 
//            // breast_CancerDataSet
//            // 
//            this.breast_CancerDataSet.DataSetName = "Breast_CancerDataSet";
//            this.breast_CancerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
//            // 
//            // textBox3
//            // 
//            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource, "Address", true));
//            this.textBox3.Location = new System.Drawing.Point(194, 241);
//            this.textBox3.Multiline = true;
//            this.textBox3.Name = "textBox3";
//            this.textBox3.Size = new System.Drawing.Size(229, 29);
//            this.textBox3.TabIndex = 16;
//            // 
//            // textBox2
//            // 
//            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource, "Family_History", true));
//            this.textBox2.Location = new System.Drawing.Point(194, 190);
//            this.textBox2.Multiline = true;
//            this.textBox2.Name = "textBox2";
//            this.textBox2.Size = new System.Drawing.Size(229, 29);
//            this.textBox2.TabIndex = 15;
//            // 
//            // textBox1
//            // 
//            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource, "Patient_id", true));
//            this.textBox1.Location = new System.Drawing.Point(194, 85);
//            this.textBox1.Multiline = true;
//            this.textBox1.Name = "textBox1";
//            this.textBox1.Size = new System.Drawing.Size(229, 29);
//            this.textBox1.TabIndex = 14;
//            // 
//            // button8
//            // 
//            this.button8.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.button8.Location = new System.Drawing.Point(392, 371);
//            this.button8.Name = "button8";
//            this.button8.Size = new System.Drawing.Size(112, 37);
//            this.button8.TabIndex = 13;
//            this.button8.Text = "Next";
//            this.button8.UseVisualStyleBackColor = true;
//            // 
//            // label4
//            // 
//            this.label4.AutoSize = true;
//            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label4.Location = new System.Drawing.Point(16, 241);
//            this.label4.Name = "label4";
//            this.label4.Size = new System.Drawing.Size(102, 29);
//            this.label4.TabIndex = 3;
//            this.label4.Text = "Address\r\n";
//            // 
//            // button7
//            // 
//            this.button7.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.button7.Location = new System.Drawing.Point(265, 371);
//            this.button7.Name = "button7";
//            this.button7.Size = new System.Drawing.Size(112, 37);
//            this.button7.TabIndex = 12;
//            this.button7.Text = "Previous";
//            this.button7.UseVisualStyleBackColor = true;
//            // 
//            // button6
//            // 
//            this.button6.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.button6.Location = new System.Drawing.Point(138, 371);
//            this.button6.Name = "button6";
//            this.button6.Size = new System.Drawing.Size(112, 37);
//            this.button6.TabIndex = 11;
//            this.button6.Text = "Last";
//            this.button6.UseVisualStyleBackColor = true;
//            // 
//            // button5
//            // 
//            this.button5.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.button5.Location = new System.Drawing.Point(19, 371);
//            this.button5.Name = "button5";
//            this.button5.Size = new System.Drawing.Size(112, 37);
//            this.button5.TabIndex = 10;
//            this.button5.Text = "First";
//            this.button5.UseVisualStyleBackColor = true;
//            // 
//            // button4
//            // 
//            this.button4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.button4.Location = new System.Drawing.Point(392, 316);
//            this.button4.Name = "button4";
//            this.button4.Size = new System.Drawing.Size(112, 37);
//            this.button4.TabIndex = 9;
//            this.button4.Text = "Close";
//            this.button4.UseVisualStyleBackColor = true;
//            // 
//            // button3
//            // 
//            this.button3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.button3.Location = new System.Drawing.Point(265, 316);
//            this.button3.Name = "button3";
//            this.button3.Size = new System.Drawing.Size(112, 37);
//            this.button3.TabIndex = 8;
//            this.button3.Text = "Delete";
//            this.button3.UseVisualStyleBackColor = true;
//            // 
//            // button2
//            // 
//            this.button2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.button2.Location = new System.Drawing.Point(138, 316);
//            this.button2.Name = "button2";
//            this.button2.Size = new System.Drawing.Size(112, 37);
//            this.button2.TabIndex = 7;
//            this.button2.Text = "Save";
//            this.button2.UseVisualStyleBackColor = true;
//            this.button2.Click += new System.EventHandler(this.button2_Click);
//            // 
//            // button1
//            // 
//            this.button1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.button1.Location = new System.Drawing.Point(19, 316);
//            this.button1.Name = "button1";
//            this.button1.Size = new System.Drawing.Size(112, 37);
//            this.button1.TabIndex = 6;
//            this.button1.Text = "Add new";
//            this.button1.UseVisualStyleBackColor = true;
//            this.button1.Click += new System.EventHandler(this.button1_Click);
//            // 
//            // label3
//            // 
//            this.label3.AutoSize = true;
//            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label3.Location = new System.Drawing.Point(14, 190);
//            this.label3.Name = "label3";
//            this.label3.Size = new System.Drawing.Size(164, 29);
//            this.label3.TabIndex = 2;
//            this.label3.Text = "Family History";
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label2.Location = new System.Drawing.Point(16, 138);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(69, 29);
//            this.label2.TabIndex = 1;
//            this.label2.Text = "Race\r\n";
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label1.Location = new System.Drawing.Point(14, 85);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(116, 29);
//            this.label1.TabIndex = 0;
//            this.label1.Text = "Patient ID";
//            // 
//            // dataGridView1
//            // 
//            this.dataGridView1.AllowUserToOrderColumns = true;
//            this.dataGridView1.AutoGenerateColumns = false;
//            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
//            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
//            this.patientidDataGridViewTextBoxColumn,
//            this.raceDataGridViewTextBoxColumn,
//            this.familyHistoryDataGridViewTextBoxColumn,
//            this.addressDataGridViewTextBoxColumn});
//            this.dataGridView1.DataSource = this.pATIENTBindingSource;
//            this.dataGridView1.Location = new System.Drawing.Point(534, 56);
//            this.dataGridView1.Name = "dataGridView1";
//            this.dataGridView1.RowTemplate.Height = 24;
//            this.dataGridView1.Size = new System.Drawing.Size(611, 275);
//            this.dataGridView1.TabIndex = 18;
//            // 
//            // patientidDataGridViewTextBoxColumn
//            // 
//            this.patientidDataGridViewTextBoxColumn.DataPropertyName = "Patient_id";
//            this.patientidDataGridViewTextBoxColumn.HeaderText = "Patient_id";
//            this.patientidDataGridViewTextBoxColumn.Name = "patientidDataGridViewTextBoxColumn";
//            // 
//            // raceDataGridViewTextBoxColumn
//            // 
//            this.raceDataGridViewTextBoxColumn.DataPropertyName = "Race";
//            this.raceDataGridViewTextBoxColumn.HeaderText = "Race";
//            this.raceDataGridViewTextBoxColumn.Name = "raceDataGridViewTextBoxColumn";
//            // 
//            // familyHistoryDataGridViewTextBoxColumn
//            // 
//            this.familyHistoryDataGridViewTextBoxColumn.DataPropertyName = "Family_History";
//            this.familyHistoryDataGridViewTextBoxColumn.HeaderText = "Family_History";
//            this.familyHistoryDataGridViewTextBoxColumn.Name = "familyHistoryDataGridViewTextBoxColumn";
//            // 
//            // addressDataGridViewTextBoxColumn
//            // 
//            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
//            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
//            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
//            // 
//            // pATIENT_TableAdapter
//            // 
//            this.pATIENT_TableAdapter.ClearBeforeFill = true;
//            // 
//            // Form1
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
//            this.ClientSize = new System.Drawing.Size(1333, 613);
//            this.Controls.Add(this.dataGridView1);
//            this.Controls.Add(this.groupBox1);
//            this.Name = "Form1";
//            this.Text = "Form1";
//            this.Load += new System.EventHandler(this.Form1_Load);
//            this.groupBox1.ResumeLayout(false);
//            this.groupBox1.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.breast_CancerDataSet)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
//            this.ResumeLayout(false);

//        }

//        #endregion

//        private System.Windows.Forms.GroupBox groupBox1;
//        private System.Windows.Forms.Label label3;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.Label label4;
//        private System.Windows.Forms.Button button8;
//        private System.Windows.Forms.Button button7;
//        private System.Windows.Forms.Button button6;
//        private System.Windows.Forms.Button button5;
//        private System.Windows.Forms.Button button4;
//        private System.Windows.Forms.Button button3;
//        private System.Windows.Forms.Button button2;
//        private System.Windows.Forms.Button button1;
//        private System.Windows.Forms.TextBox textBox4;
//        private System.Windows.Forms.TextBox textBox3;
//        private System.Windows.Forms.TextBox textBox2;
//        private System.Windows.Forms.TextBox textBox1;
//        private System.Windows.Forms.DataGridView dataGridView1;
//        private Breast_CancerDataSet breast_CancerDataSet;
//        private System.Windows.Forms.BindingSource pATIENTBindingSource;
//        private Breast_CancerDataSetTableAdapters.PATIENT_TableAdapter pATIENT_TableAdapter;
//        private System.Windows.Forms.DataGridViewTextBoxColumn patientidDataGridViewTextBoxColumn;
//        private System.Windows.Forms.DataGridViewTextBoxColumn raceDataGridViewTextBoxColumn;
//        private System.Windows.Forms.DataGridViewTextBoxColumn familyHistoryDataGridViewTextBoxColumn;
//        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
//    }
//}
namespace WindowsFormsApplication4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pATIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.breast_CancerDataSet = new WindowsFormsApplication4.Breast_CancerDataSet();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyHistoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENT_TableAdapter = new WindowsFormsApplication4.Breast_CancerDataSetTableAdapters.PATIENT_TableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breast_CancerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 428);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Table";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource, "Race", true));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(194, 138);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(229, 29);
            this.textBox4.TabIndex = 17;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // pATIENTBindingSource
            // 
            this.pATIENTBindingSource.DataMember = "PATIENT$";
            this.pATIENTBindingSource.DataSource = this.breast_CancerDataSet;
            // 
            // breast_CancerDataSet
            // 
            this.breast_CancerDataSet.DataSetName = "Breast_CancerDataSet";
            this.breast_CancerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource, "Address", true));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(194, 241);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(229, 29);
            this.textBox3.TabIndex = 16;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource, "Family_History", true));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(194, 190);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(229, 29);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource, "Patient_id", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(194, 85);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 29);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(392, 371);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(112, 37);
            this.button8.TabIndex = 13;
            this.button8.Text = "Next";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(265, 371);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(112, 37);
            this.button7.TabIndex = 12;
            this.button7.Text = "Previous";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(138, 371);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 37);
            this.button6.TabIndex = 11;
            this.button6.Text = "Last";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(11, 371);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 37);
            this.button5.TabIndex = 10;
            this.button5.Text = "First";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(267, 305);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 37);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(140, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Family History";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Race";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientidDataGridViewTextBoxColumn,
            this.raceDataGridViewTextBoxColumn,
            this.familyHistoryDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pATIENTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(570, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(444, 428);
            this.dataGridView1.TabIndex = 1;
            // 
            // patientidDataGridViewTextBoxColumn
            // 
            this.patientidDataGridViewTextBoxColumn.DataPropertyName = "Patient_id";
            this.patientidDataGridViewTextBoxColumn.HeaderText = "Patient ID";
            this.patientidDataGridViewTextBoxColumn.Name = "patientidDataGridViewTextBoxColumn";
            // 
            // raceDataGridViewTextBoxColumn
            // 
            this.raceDataGridViewTextBoxColumn.DataPropertyName = "Race";
            this.raceDataGridViewTextBoxColumn.HeaderText = "Race";
            this.raceDataGridViewTextBoxColumn.Name = "raceDataGridViewTextBoxColumn";
            // 
            // familyHistoryDataGridViewTextBoxColumn
            // 
            this.familyHistoryDataGridViewTextBoxColumn.DataPropertyName = "Family_History";
            this.familyHistoryDataGridViewTextBoxColumn.HeaderText = "Family History";
            this.familyHistoryDataGridViewTextBoxColumn.Name = "familyHistoryDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // pATIENT_TableAdapter
            // 
            this.pATIENT_TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1026, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breast_CancerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyHistoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pATIENTBindingSource;
        private Breast_CancerDataSet breast_CancerDataSet;
        private Breast_CancerDataSetTableAdapters.PATIENT_TableAdapter pATIENT_TableAdapter;
    }
}

