namespace WindowsFormsApplication1
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
            this.lbfirstname = new System.Windows.Forms.Label();
            this.lblastname = new System.Windows.Forms.Label();
            this.lbmobilename = new System.Windows.Forms.Label();
            this.lbemailid = new System.Windows.Forms.Label();
            this.lbstatus = new System.Windows.Forms.Label();
            this.tbfirstname = new System.Windows.Forms.TextBox();
            this.tblastname = new System.Windows.Forms.TextBox();
            this.tbmobilenumber = new System.Windows.Forms.TextBox();
            this.tbemailid = new System.Windows.Forms.TextBox();
            this.btmnew = new System.Windows.Forms.Button();
            this.btminsert = new System.Windows.Forms.Button();
            this.btmupdate = new System.Windows.Forms.Button();
            this.btmdelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbstatus = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbfirstname
            // 
            this.lbfirstname.AutoSize = true;
            this.lbfirstname.Location = new System.Drawing.Point(124, 66);
            this.lbfirstname.Name = "lbfirstname";
            this.lbfirstname.Size = new System.Drawing.Size(76, 17);
            this.lbfirstname.TabIndex = 1;
            this.lbfirstname.Text = "First Name";
            // 
            // lblastname
            // 
            this.lblastname.AutoSize = true;
            this.lblastname.Location = new System.Drawing.Point(124, 136);
            this.lblastname.Name = "lblastname";
            this.lblastname.Size = new System.Drawing.Size(76, 17);
            this.lblastname.TabIndex = 2;
            this.lblastname.Text = "Last Name";
            // 
            // lbmobilename
            // 
            this.lbmobilename.AutoSize = true;
            this.lbmobilename.Location = new System.Drawing.Point(124, 201);
            this.lbmobilename.Name = "lbmobilename";
            this.lbmobilename.Size = new System.Drawing.Size(103, 17);
            this.lbmobilename.TabIndex = 3;
            this.lbmobilename.Text = "Mobile Number";
            // 
            // lbemailid
            // 
            this.lbemailid.AutoSize = true;
            this.lbemailid.Location = new System.Drawing.Point(124, 246);
            this.lbemailid.Name = "lbemailid";
            this.lbemailid.Size = new System.Drawing.Size(57, 17);
            this.lbemailid.TabIndex = 4;
            this.lbemailid.Text = "Email Id";
            // 
            // lbstatus
            // 
            this.lbstatus.AutoSize = true;
            this.lbstatus.Location = new System.Drawing.Point(124, 301);
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(48, 17);
            this.lbstatus.TabIndex = 5;
            this.lbstatus.Text = "Status";
            // 
            // tbfirstname
            // 
            this.tbfirstname.Location = new System.Drawing.Point(386, 61);
            this.tbfirstname.Name = "tbfirstname";
            this.tbfirstname.Size = new System.Drawing.Size(303, 22);
            this.tbfirstname.TabIndex = 6;
            this.tbfirstname.TextChanged += new System.EventHandler(this.tbfirstname_TextChanged);
            // 
            // tblastname
            // 
            this.tblastname.Location = new System.Drawing.Point(387, 136);
            this.tblastname.Name = "tblastname";
            this.tblastname.Size = new System.Drawing.Size(302, 22);
            this.tblastname.TabIndex = 7;
            // 
            // tbmobilenumber
            // 
            this.tbmobilenumber.Location = new System.Drawing.Point(387, 186);
            this.tbmobilenumber.Name = "tbmobilenumber";
            this.tbmobilenumber.Size = new System.Drawing.Size(303, 22);
            this.tbmobilenumber.TabIndex = 8;
            // 
            // tbemailid
            // 
            this.tbemailid.Location = new System.Drawing.Point(386, 241);
            this.tbemailid.Name = "tbemailid";
            this.tbemailid.Size = new System.Drawing.Size(301, 22);
            this.tbemailid.TabIndex = 9;
            // 
            // btmnew
            // 
            this.btmnew.Location = new System.Drawing.Point(783, 66);
            this.btmnew.Name = "btmnew";
            this.btmnew.Size = new System.Drawing.Size(141, 33);
            this.btmnew.TabIndex = 10;
            this.btmnew.Text = "New";
            this.btmnew.UseVisualStyleBackColor = true;
            this.btmnew.Click += new System.EventHandler(this.btmnew_Click);
            // 
            // btminsert
            // 
            this.btminsert.Location = new System.Drawing.Point(783, 121);
            this.btminsert.Name = "btminsert";
            this.btminsert.Size = new System.Drawing.Size(141, 32);
            this.btminsert.TabIndex = 11;
            this.btminsert.Text = "Insert";
            this.btminsert.UseVisualStyleBackColor = true;
            // 
            // btmupdate
            // 
            this.btmupdate.Location = new System.Drawing.Point(783, 176);
            this.btmupdate.Name = "btmupdate";
            this.btmupdate.Size = new System.Drawing.Size(141, 32);
            this.btmupdate.TabIndex = 12;
            this.btmupdate.Text = "Update";
            this.btmupdate.UseVisualStyleBackColor = true;
            // 
            // btmdelete
            // 
            this.btmdelete.Location = new System.Drawing.Point(783, 230);
            this.btmdelete.Name = "btmdelete";
            this.btmdelete.Size = new System.Drawing.Size(141, 33);
            this.btmdelete.TabIndex = 13;
            this.btmdelete.Text = "Delete";
            this.btmdelete.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(471, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Phone Directory";
            // 
            // cbstatus
            // 
            this.cbstatus.AllowDrop = true;
            this.cbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbstatus.FormattingEnabled = true;
            this.cbstatus.Items.AddRange(new object[] {
            "Work",
            "Home",
            "Business",
            "Office"});
            this.cbstatus.Location = new System.Drawing.Point(387, 298);
            this.cbstatus.Name = "cbstatus";
            this.cbstatus.Size = new System.Drawing.Size(298, 24);
            this.cbstatus.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(269, 353);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(545, 135);
            this.dataGridView1.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "First Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Last Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mobile Number";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Email Id";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Status";
            this.Column5.Name = "Column5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 500);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbstatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btmdelete);
            this.Controls.Add(this.btmupdate);
            this.Controls.Add(this.btminsert);
            this.Controls.Add(this.btmnew);
            this.Controls.Add(this.tbemailid);
            this.Controls.Add(this.tbmobilenumber);
            this.Controls.Add(this.tblastname);
            this.Controls.Add(this.tbfirstname);
            this.Controls.Add(this.lbstatus);
            this.Controls.Add(this.lbemailid);
            this.Controls.Add(this.lbmobilename);
            this.Controls.Add(this.lblastname);
            this.Controls.Add(this.lbfirstname);
            this.Name = "Form1";
            this.Text = "My Phone Directory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbfirstname;
        private System.Windows.Forms.Label lblastname;
        private System.Windows.Forms.Label lbmobilename;
        private System.Windows.Forms.Label lbemailid;
        private System.Windows.Forms.Label lbstatus;
        private System.Windows.Forms.TextBox tbfirstname;
        private System.Windows.Forms.TextBox tblastname;
        private System.Windows.Forms.TextBox tbmobilenumber;
        private System.Windows.Forms.TextBox tbemailid;
        private System.Windows.Forms.Button btmnew;
        private System.Windows.Forms.Button btminsert;
        private System.Windows.Forms.Button btmupdate;
        private System.Windows.Forms.Button btmdelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbstatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

