using System;
using System.Windows.Forms;

namespace StudentsFinanceSystem
{
    partial class Expenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expenses));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ENameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExpamountTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ExpcatTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ExpdescTb = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ExpdateTb = new System.Windows.Forms.DateTimePicker();
            this.expenseTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financeDbDataSet = new StudentsFinanceSystem.FinanceDbDataSet();
            this.expenseTblTableAdapter = new StudentsFinanceSystem.FinanceDbDataSetTableAdapters.ExpenseTblTableAdapter();
            this.ExpenseList = new System.Windows.Forms.DataGridView();
            this.expIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expAmtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expCatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(63, 870);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(12, 796);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(43, 52);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(7, 496);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 43);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 284);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 387);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(199)))), ((int)(((byte)(89)))));
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(63, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1317, 88);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(21, 9);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(64, 69);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(136, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(570, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "Student\'s Financial Management System";
            // 
            // ENameTb
            // 
            this.ENameTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(13)))), ((int)(((byte)(18)))));
            this.ENameTb.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ENameTb.ForeColor = System.Drawing.Color.White;
            this.ENameTb.Location = new System.Drawing.Point(119, 265);
            this.ENameTb.Name = "ENameTb";
            this.ENameTb.Size = new System.Drawing.Size(211, 32);
            this.ENameTb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(114, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Expense Name";
            // 
            // ExpamountTb
            // 
            this.ExpamountTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(13)))), ((int)(((byte)(18)))));
            this.ExpamountTb.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpamountTb.ForeColor = System.Drawing.Color.White;
            this.ExpamountTb.Location = new System.Drawing.Point(119, 363);
            this.ExpamountTb.Name = "ExpamountTb";
            this.ExpamountTb.Size = new System.Drawing.Size(211, 32);
            this.ExpamountTb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(114, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Expense Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(114, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Expense Category";
            // 
            // ExpcatTb
            // 
            this.ExpcatTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(13)))), ((int)(((byte)(18)))));
            this.ExpcatTb.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpcatTb.ForeColor = System.Drawing.Color.White;
            this.ExpcatTb.Location = new System.Drawing.Point(119, 463);
            this.ExpcatTb.Name = "ExpcatTb";
            this.ExpcatTb.Size = new System.Drawing.Size(211, 32);
            this.ExpcatTb.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(114, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Expense Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(114, 627);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Expense Description";
            // 
            // ExpdescTb
            // 
            this.ExpdescTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(13)))), ((int)(((byte)(18)))));
            this.ExpdescTb.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpdescTb.ForeColor = System.Drawing.Color.White;
            this.ExpdescTb.Location = new System.Drawing.Point(119, 665);
            this.ExpdescTb.Name = "ExpdescTb";
            this.ExpdescTb.Size = new System.Drawing.Size(211, 32);
            this.ExpdescTb.TabIndex = 10;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(199)))), ((int)(((byte)(89)))));
            this.addbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(199)))), ((int)(((byte)(89)))));
            this.addbtn.FlatAppearance.BorderSize = 0;
            this.addbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(75, 717);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(150, 46);
            this.addbtn.TabIndex = 12;
            this.addbtn.Text = "Add Expense";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click_1);
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(199)))), ((int)(((byte)(89)))));
            this.editbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(199)))), ((int)(((byte)(89)))));
            this.editbtn.FlatAppearance.BorderSize = 0;
            this.editbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.Location = new System.Drawing.Point(237, 717);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(152, 46);
            this.editbtn.TabIndex = 13;
            this.editbtn.Text = "Edit Expense";
            this.editbtn.UseVisualStyleBackColor = false;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(199)))), ((int)(((byte)(89)))));
            this.deletebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(199)))), ((int)(((byte)(89)))));
            this.deletebtn.FlatAppearance.BorderSize = 0;
            this.deletebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(146, 780);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(175, 46);
            this.deletebtn.TabIndex = 14;
            this.deletebtn.Text = "Delete Expense";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(178, 118);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(77, 81);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(811, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 26);
            this.label7.TabIndex = 17;
            this.label7.Text = "Expense List";
            // 
            // ExpdateTb
            // 
            this.ExpdateTb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExpdateTb.Location = new System.Drawing.Point(119, 566);
            this.ExpdateTb.Name = "ExpdateTb";
            this.ExpdateTb.Size = new System.Drawing.Size(211, 31);
            this.ExpdateTb.TabIndex = 19;
            // 
            // expenseTblBindingSource
            // 
            this.expenseTblBindingSource.DataMember = "ExpenseTbl";
            this.expenseTblBindingSource.DataSource = this.financeDbDataSet;
            // 
            // financeDbDataSet
            // 
            this.financeDbDataSet.DataSetName = "FinanceDbDataSet";
            this.financeDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expenseTblTableAdapter
            // 
            this.expenseTblTableAdapter.ClearBeforeFill = true;
            // 
            // ExpenseList
            // 
            this.ExpenseList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpenseList.AutoGenerateColumns = false;
            this.ExpenseList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ExpenseList.BackgroundColor = System.Drawing.Color.Sienna;
            this.ExpenseList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpenseList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ExpenseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpenseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.expIdDataGridViewTextBoxColumn,
            this.expNameDataGridViewTextBoxColumn,
            this.expAmtDataGridViewTextBoxColumn,
            this.expCatDataGridViewTextBoxColumn,
            this.expDateDataGridViewTextBoxColumn,
            this.expDescDataGridViewTextBoxColumn});
            this.ExpenseList.DataSource = this.expenseTblBindingSource;
            this.ExpenseList.Location = new System.Drawing.Point(448, 173);
            this.ExpenseList.Name = "ExpenseList";
            this.ExpenseList.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpenseList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ExpenseList.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Purple;
            this.ExpenseList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ExpenseList.RowTemplate.Height = 24;
            this.ExpenseList.Size = new System.Drawing.Size(896, 622);
            this.ExpenseList.TabIndex = 20;
            this.ExpenseList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExpenseList_BtClick);
            // 
            // expIdDataGridViewTextBoxColumn
            // 
            this.expIdDataGridViewTextBoxColumn.DataPropertyName = "ExpId";
            this.expIdDataGridViewTextBoxColumn.HeaderText = "ExpId";
            this.expIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expIdDataGridViewTextBoxColumn.Name = "expIdDataGridViewTextBoxColumn";
            this.expIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expNameDataGridViewTextBoxColumn
            // 
            this.expNameDataGridViewTextBoxColumn.DataPropertyName = "ExpName";
            this.expNameDataGridViewTextBoxColumn.HeaderText = "ExpName";
            this.expNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expNameDataGridViewTextBoxColumn.Name = "expNameDataGridViewTextBoxColumn";
            this.expNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expAmtDataGridViewTextBoxColumn
            // 
            this.expAmtDataGridViewTextBoxColumn.DataPropertyName = "ExpAmt";
            this.expAmtDataGridViewTextBoxColumn.HeaderText = "ExpAmt";
            this.expAmtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expAmtDataGridViewTextBoxColumn.Name = "expAmtDataGridViewTextBoxColumn";
            this.expAmtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expCatDataGridViewTextBoxColumn
            // 
            this.expCatDataGridViewTextBoxColumn.DataPropertyName = "ExpCat";
            this.expCatDataGridViewTextBoxColumn.HeaderText = "ExpCat";
            this.expCatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expCatDataGridViewTextBoxColumn.Name = "expCatDataGridViewTextBoxColumn";
            this.expCatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expDateDataGridViewTextBoxColumn
            // 
            this.expDateDataGridViewTextBoxColumn.DataPropertyName = "ExpDate";
            this.expDateDataGridViewTextBoxColumn.HeaderText = "ExpDate";
            this.expDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expDateDataGridViewTextBoxColumn.Name = "expDateDataGridViewTextBoxColumn";
            this.expDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expDescDataGridViewTextBoxColumn
            // 
            this.expDescDataGridViewTextBoxColumn.DataPropertyName = "ExpDesc";
            this.expDescDataGridViewTextBoxColumn.HeaderText = "ExpDesc";
            this.expDescDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expDescDataGridViewTextBoxColumn.Name = "expDescDataGridViewTextBoxColumn";
            this.expDescDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(13)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1380, 870);
            this.Controls.Add(this.ExpenseList);
            this.Controls.Add(this.ExpdateTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ExpdescTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExpcatTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExpamountTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ENameTb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Expenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ExpenseList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Expense List");
        }
        

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ENameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ExpamountTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ExpcatTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ExpdescTb;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker ExpdateTb;
        private FinanceDbDataSet financeDbDataSet;
        private System.Windows.Forms.BindingSource expenseTblBindingSource;
        private FinanceDbDataSetTableAdapters.ExpenseTblTableAdapter expenseTblTableAdapter;
        private DataGridView ExpenseList;
        private DataGridViewTextBoxColumn expIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expAmtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expCatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expDescDataGridViewTextBoxColumn;
    }
}