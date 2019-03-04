namespace PoultryManager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSave = new PoultryManager.CircularButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbdescription = new System.Windows.Forms.TextBox();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gvedit = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btneditt = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.gbupdate = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbUpdateExpDescription = new System.Windows.Forms.TextBox();
            this.tbUpdateCater = new System.Windows.Forms.TextBox();
            this.tbUpdateExpAmt = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gvedit.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.gbupdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(675, 377);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbdescription);
            this.tabPage1.Controls.Add(this.tbCategory);
            this.tabPage1.Controls.Add(this.tbAmount);
            this.tabPage1.Controls.Add(this.DateLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(667, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Expenses";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(292, 254);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 42);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.Leave += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 22);
            this.label4.TabIndex = 42;
            this.label4.Text = "Expense Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(142, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 22);
            this.label6.TabIndex = 43;
            this.label6.Text = "Expense Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 44;
            this.label2.Text = "Category: \r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 46;
            this.label1.Text = "Date: ";
            // 
            // tbdescription
            // 
            this.tbdescription.Location = new System.Drawing.Point(363, 182);
            this.tbdescription.Multiline = true;
            this.tbdescription.Name = "tbdescription";
            this.tbdescription.Size = new System.Drawing.Size(161, 33);
            this.tbdescription.TabIndex = 41;
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(363, 100);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(161, 20);
            this.tbCategory.TabIndex = 39;
            this.tbCategory.Leave += new System.EventHandler(this.tbCategory_Leave);
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(363, 140);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(161, 20);
            this.tbAmount.TabIndex = 40;
            this.tbAmount.Text = "0";
            this.tbAmount.Leave += new System.EventHandler(this.tbAmount_Leave);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DateLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(402, 55);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(65, 22);
            this.DateLabel.TabIndex = 45;
            this.DateLabel.Text = "label1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gvedit);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(667, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update expense";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gvedit
            // 
            this.gvedit.Controls.Add(this.label8);
            this.gvedit.Controls.Add(this.gbSearch);
            this.gvedit.Controls.Add(this.gbupdate);
            this.gvedit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvedit.Location = new System.Drawing.Point(3, 3);
            this.gvedit.Name = "gvedit";
            this.gvedit.Size = new System.Drawing.Size(661, 345);
            this.gvedit.TabIndex = 13;
            this.gvedit.TabStop = false;
            this.gvedit.Text = "EDIT DETAILS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(217, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(297, 26);
            this.label8.TabIndex = 11;
            this.label8.Text = "EDIT EXPENSES DETAIL";
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.dateTimePicker1);
            this.gbSearch.Controls.Add(this.btneditt);
            this.gbSearch.Controls.Add(this.label9);
            this.gbSearch.Location = new System.Drawing.Point(42, 29);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(504, 78);
            this.gbSearch.TabIndex = 13;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search Records";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(218, 11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // btneditt
            // 
            this.btneditt.Location = new System.Drawing.Point(287, 47);
            this.btneditt.Name = "btneditt";
            this.btneditt.Size = new System.Drawing.Size(77, 27);
            this.btneditt.TabIndex = 14;
            this.btneditt.Text = "EDIT";
            this.btneditt.UseVisualStyleBackColor = true;
            this.btneditt.Click += new System.EventHandler(this.btneditt_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "DATE :";
            // 
            // gbupdate
            // 
            this.gbupdate.Controls.Add(this.label3);
            this.gbupdate.Controls.Add(this.label5);
            this.gbupdate.Controls.Add(this.label7);
            this.gbupdate.Controls.Add(this.tbUpdateExpDescription);
            this.gbupdate.Controls.Add(this.tbUpdateCater);
            this.gbupdate.Controls.Add(this.tbUpdateExpAmt);
            this.gbupdate.Controls.Add(this.btnUpdate);
            this.gbupdate.Location = new System.Drawing.Point(42, 103);
            this.gbupdate.Name = "gbupdate";
            this.gbupdate.Size = new System.Drawing.Size(504, 242);
            this.gbupdate.TabIndex = 11;
            this.gbupdate.TabStop = false;
            this.gbupdate.Text = "UPDATE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 22);
            this.label3.TabIndex = 48;
            this.label3.Text = "Expense Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 22);
            this.label5.TabIndex = 49;
            this.label5.Text = "Expense Amount:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 22);
            this.label7.TabIndex = 50;
            this.label7.Text = "Category: \r\n";
            // 
            // tbUpdateExpDescription
            // 
            this.tbUpdateExpDescription.Location = new System.Drawing.Point(282, 155);
            this.tbUpdateExpDescription.Multiline = true;
            this.tbUpdateExpDescription.Name = "tbUpdateExpDescription";
            this.tbUpdateExpDescription.Size = new System.Drawing.Size(161, 33);
            this.tbUpdateExpDescription.TabIndex = 47;
            // 
            // tbUpdateCater
            // 
            this.tbUpdateCater.Location = new System.Drawing.Point(282, 73);
            this.tbUpdateCater.Name = "tbUpdateCater";
            this.tbUpdateCater.Size = new System.Drawing.Size(161, 23);
            this.tbUpdateCater.TabIndex = 45;
            // 
            // tbUpdateExpAmt
            // 
            this.tbUpdateExpAmt.Location = new System.Drawing.Point(282, 113);
            this.tbUpdateExpAmt.Name = "tbUpdateExpAmt";
            this.tbUpdateExpAmt.Size = new System.Drawing.Size(161, 23);
            this.tbUpdateExpAmt.TabIndex = 46;
            this.tbUpdateExpAmt.Text = "0";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(180, 214);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(146, 22);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Expenses";
            this.Size = new System.Drawing.Size(675, 377);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.gvedit.ResumeLayout(false);
            this.gvedit.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbupdate.ResumeLayout(false);
            this.gbupdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private CircularButton btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbdescription;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gvedit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btneditt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbupdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbUpdateExpDescription;
        private System.Windows.Forms.TextBox tbUpdateCater;
        private System.Windows.Forms.TextBox tbUpdateExpAmt;
        private System.Windows.Forms.Button btnUpdate;
    }
}
