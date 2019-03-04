namespace PoultryManager
{
    partial class Sales
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
            this.tabContro1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnsubmit = new PoultryManager.CircularButton();
            this.comboxSoldItem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.tbSalePrice = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gvedit = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btneditt = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.gbupdate = new System.Windows.Forms.GroupBox();
            this.cbUpdateSoldItem = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbUpdateComment = new System.Windows.Forms.TextBox();
            this.tbUpdatePrice = new System.Windows.Forms.TextBox();
            this.tbUpdateQuantity = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tabContro1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gvedit.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.gbupdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabContro1
            // 
            this.tabContro1.Controls.Add(this.tabPage1);
            this.tabContro1.Controls.Add(this.tabPage2);
            this.tabContro1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContro1.Location = new System.Drawing.Point(0, 0);
            this.tabContro1.Name = "tabContro1";
            this.tabContro1.SelectedIndex = 0;
            this.tabContro1.Size = new System.Drawing.Size(675, 389);
            this.tabContro1.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnsubmit);
            this.tabPage1.Controls.Add(this.comboxSoldItem);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbComment);
            this.tabPage1.Controls.Add(this.tbSalePrice);
            this.tabPage1.Controls.Add(this.tbQuantity);
            this.tabPage1.Controls.Add(this.DateLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(667, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsubmit.FlatAppearance.BorderSize = 0;
            this.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubmit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.Location = new System.Drawing.Point(261, 283);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(106, 42);
            this.btnsubmit.TabIndex = 40;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // comboxSoldItem
            // 
            this.comboxSoldItem.FormattingEnabled = true;
            this.comboxSoldItem.Items.AddRange(new object[] {
            "Select",
            "Eggs",
            "Hens"});
            this.comboxSoldItem.Location = new System.Drawing.Point(380, 79);
            this.comboxSoldItem.Name = "comboxSoldItem";
            this.comboxSoldItem.Size = new System.Drawing.Size(161, 21);
            this.comboxSoldItem.TabIndex = 30;
            this.comboxSoldItem.Text = "Select";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 22);
            this.label4.TabIndex = 34;
            this.label4.Text = "Comment: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(125, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 22);
            this.label6.TabIndex = 35;
            this.label6.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 36;
            this.label3.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 37;
            this.label2.Text = "Sold Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 39;
            this.label1.Text = "Sales Date: ";
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(380, 220);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(161, 33);
            this.tbComment.TabIndex = 33;
            // 
            // tbSalePrice
            // 
            this.tbSalePrice.Location = new System.Drawing.Point(380, 123);
            this.tbSalePrice.Name = "tbSalePrice";
            this.tbSalePrice.Size = new System.Drawing.Size(161, 20);
            this.tbSalePrice.TabIndex = 31;
            this.tbSalePrice.Text = "0";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(380, 163);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(161, 20);
            this.tbQuantity.TabIndex = 32;
            this.tbQuantity.Leave += new System.EventHandler(this.tbQuantity_Leave);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DateLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(380, 38);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(65, 22);
            this.DateLabel.TabIndex = 38;
            this.DateLabel.Text = "label1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gvedit);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(667, 363);
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
            this.gvedit.Size = new System.Drawing.Size(661, 357);
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
            this.label8.Size = new System.Drawing.Size(248, 26);
            this.label8.TabIndex = 11;
            this.label8.Text = "EDIT SALES DETAIL";
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
            this.gbupdate.Controls.Add(this.cbUpdateSoldItem);
            this.gbupdate.Controls.Add(this.label5);
            this.gbupdate.Controls.Add(this.label7);
            this.gbupdate.Controls.Add(this.label10);
            this.gbupdate.Controls.Add(this.label11);
            this.gbupdate.Controls.Add(this.tbUpdateComment);
            this.gbupdate.Controls.Add(this.tbUpdatePrice);
            this.gbupdate.Controls.Add(this.tbUpdateQuantity);
            this.gbupdate.Controls.Add(this.btnUpdate);
            this.gbupdate.Location = new System.Drawing.Point(42, 103);
            this.gbupdate.Name = "gbupdate";
            this.gbupdate.Size = new System.Drawing.Size(504, 257);
            this.gbupdate.TabIndex = 11;
            this.gbupdate.TabStop = false;
            this.gbupdate.Text = "UPDATE";
            // 
            // cbUpdateSoldItem
            // 
            this.cbUpdateSoldItem.FormattingEnabled = true;
            this.cbUpdateSoldItem.Items.AddRange(new object[] {
            "Select",
            "Eggs",
            "Hens"});
            this.cbUpdateSoldItem.Location = new System.Drawing.Point(298, 36);
            this.cbUpdateSoldItem.Name = "cbUpdateSoldItem";
            this.cbUpdateSoldItem.Size = new System.Drawing.Size(161, 24);
            this.cbUpdateSoldItem.TabIndex = 40;
            this.cbUpdateSoldItem.Text = "Select";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 22);
            this.label5.TabIndex = 44;
            this.label5.Text = "Comment: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 22);
            this.label7.TabIndex = 45;
            this.label7.Text = "Price:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 22);
            this.label10.TabIndex = 46;
            this.label10.Text = "Quantity:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(43, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 22);
            this.label11.TabIndex = 47;
            this.label11.Text = "Sold Item";
            // 
            // tbUpdateComment
            // 
            this.tbUpdateComment.Location = new System.Drawing.Point(298, 157);
            this.tbUpdateComment.Multiline = true;
            this.tbUpdateComment.Name = "tbUpdateComment";
            this.tbUpdateComment.Size = new System.Drawing.Size(161, 33);
            this.tbUpdateComment.TabIndex = 43;
            // 
            // tbUpdatePrice
            // 
            this.tbUpdatePrice.Location = new System.Drawing.Point(298, 68);
            this.tbUpdatePrice.Name = "tbUpdatePrice";
            this.tbUpdatePrice.Size = new System.Drawing.Size(161, 23);
            this.tbUpdatePrice.TabIndex = 41;
            this.tbUpdatePrice.Text = "0";
            // 
            // tbUpdateQuantity
            // 
            this.tbUpdateQuantity.Location = new System.Drawing.Point(298, 108);
            this.tbUpdateQuantity.Name = "tbUpdateQuantity";
            this.tbUpdateQuantity.Size = new System.Drawing.Size(161, 23);
            this.tbUpdateQuantity.TabIndex = 42;
            this.tbUpdateQuantity.Leave += new System.EventHandler(this.tbUpdateQuantity_Leave);
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
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabContro1);
            this.Name = "Sales";
            this.Size = new System.Drawing.Size(675, 389);
            this.tabContro1.ResumeLayout(false);
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

        private System.Windows.Forms.TabControl tabContro1;
        private System.Windows.Forms.TabPage tabPage1;
        private CircularButton btnsubmit;
        private System.Windows.Forms.ComboBox comboxSoldItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.TextBox tbSalePrice;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gvedit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btneditt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbupdate;
        private System.Windows.Forms.ComboBox cbUpdateSoldItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbUpdateComment;
        private System.Windows.Forms.TextBox tbUpdatePrice;
        private System.Windows.Forms.TextBox tbUpdateQuantity;
        private System.Windows.Forms.Button btnUpdate;
    }
}
