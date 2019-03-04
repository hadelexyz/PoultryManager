namespace PoultryManager
{
    partial class Egg_Collection
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new PoultryManager.CircularButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.tbBadEggs = new System.Windows.Forms.TextBox();
            this.tbCollected = new System.Windows.Forms.TextBox();
            this.lblGoodEggs = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gvedit = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btneditt = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.gbupdate = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbUpdatedCollected = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(667, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Egg Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbComment);
            this.groupBox1.Controls.Add(this.tbBadEggs);
            this.groupBox1.Controls.Add(this.tbCollected);
            this.groupBox1.Controls.Add(this.lblGoodEggs);
            this.groupBox1.Controls.Add(this.DateLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 345);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Egg_Collection";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(273, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 42);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Comment: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Good Eggs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bad Eggs:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Collected Eggs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Collection Date: ";
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(259, 205);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(161, 33);
            this.tbComment.TabIndex = 4;
            // 
            // tbBadEggs
            // 
            this.tbBadEggs.Location = new System.Drawing.Point(259, 148);
            this.tbBadEggs.Name = "tbBadEggs";
            this.tbBadEggs.Size = new System.Drawing.Size(161, 20);
            this.tbBadEggs.TabIndex = 3;
            this.tbBadEggs.Text = "0";
            this.tbBadEggs.Leave += new System.EventHandler(this.tbBadEggs_Leave);
            // 
            // tbCollected
            // 
            this.tbCollected.Location = new System.Drawing.Point(259, 65);
            this.tbCollected.Name = "tbCollected";
            this.tbCollected.Size = new System.Drawing.Size(161, 20);
            this.tbCollected.TabIndex = 1;
            this.tbCollected.Text = "0";
            this.tbCollected.Leave += new System.EventHandler(this.tbCollected_Leave);
            // 
            // lblGoodEggs
            // 
            this.lblGoodEggs.AutoSize = true;
            this.lblGoodEggs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGoodEggs.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoodEggs.Location = new System.Drawing.Point(298, 107);
            this.lblGoodEggs.Name = "lblGoodEggs";
            this.lblGoodEggs.Size = new System.Drawing.Size(65, 22);
            this.lblGoodEggs.TabIndex = 2;
            this.lblGoodEggs.Text = "label1";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DateLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(298, 23);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(65, 22);
            this.DateLabel.TabIndex = 0;
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
            this.tabPage2.Text = "Update Details";
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
            this.gvedit.TabIndex = 12;
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
            this.label8.Size = new System.Drawing.Size(221, 26);
            this.label8.TabIndex = 11;
            this.label8.Text = "EDIT EGG DETAIL";
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
            this.btneditt.Click += new System.EventHandler(this.btneditt_Click);
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
            this.gbupdate.Controls.Add(this.label11);
            this.gbupdate.Controls.Add(this.tbUpdatedCollected);
            this.gbupdate.Controls.Add(this.btnUpdate);
            this.gbupdate.Location = new System.Drawing.Point(42, 103);
            this.gbupdate.Name = "gbupdate";
            this.gbupdate.Size = new System.Drawing.Size(504, 242);
            this.gbupdate.TabIndex = 11;
            this.gbupdate.TabStop = false;
            this.gbupdate.Text = "UPDATE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(80, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 22);
            this.label11.TabIndex = 18;
            this.label11.Text = "Collected Eggs";
            // 
            // tbUpdatedCollected
            // 
            this.tbUpdatedCollected.Location = new System.Drawing.Point(257, 78);
            this.tbUpdatedCollected.Name = "tbUpdatedCollected";
            this.tbUpdatedCollected.Size = new System.Drawing.Size(161, 23);
            this.tbUpdatedCollected.TabIndex = 11;
            this.tbUpdatedCollected.Text = "0";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(180, 179);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(141, 22);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Egg_Collection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Egg_Collection";
            this.Size = new System.Drawing.Size(675, 377);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private CircularButton btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.TextBox tbBadEggs;
        private System.Windows.Forms.TextBox tbCollected;
        private System.Windows.Forms.Label lblGoodEggs;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gvedit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btneditt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbupdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbUpdatedCollected;
        private System.Windows.Forms.Button btnUpdate;
    }
}
