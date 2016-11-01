namespace DbInlämningsuppgift1
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
            this.dgwDisplaySearchResult = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPhoneNr = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdAddContact = new System.Windows.Forms.Button();
            this.cmdEditContact = new System.Windows.Forms.Button();
            this.cmdDeleteContact = new System.Windows.Forms.Button();
            this.dgwDisplayContacts = new System.Windows.Forms.DataGridView();
            this.ColumnContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdSaveContactChanges = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDisplaySearchResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDisplayContacts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwDisplaySearchResult
            // 
            this.dgwDisplaySearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDisplaySearchResult.Location = new System.Drawing.Point(14, 390);
            this.dgwDisplaySearchResult.Name = "dgwDisplaySearchResult";
            this.dgwDisplaySearchResult.Size = new System.Drawing.Size(591, 64);
            this.dgwDisplaySearchResult.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(86, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(86, 41);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(236, 20);
            this.txtStreetAddress.TabIndex = 1;
            // 
            // txtZipcode
            // 
            this.txtZipcode.Location = new System.Drawing.Point(86, 67);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(236, 20);
            this.txtZipcode.TabIndex = 2;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(86, 93);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(236, 20);
            this.txtCity.TabIndex = 3;
            // 
            // txtPhoneNr
            // 
            this.txtPhoneNr.Location = new System.Drawing.Point(86, 119);
            this.txtPhoneNr.Name = "txtPhoneNr";
            this.txtPhoneNr.Size = new System.Drawing.Size(236, 20);
            this.txtPhoneNr.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(86, 145);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(236, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(86, 171);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(236, 20);
            this.dtpBirthday.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "StreetAddress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Zipcode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Phonenumber";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Birthday";
            // 
            // cmdAddContact
            // 
            this.cmdAddContact.Location = new System.Drawing.Point(86, 338);
            this.cmdAddContact.Name = "cmdAddContact";
            this.cmdAddContact.Size = new System.Drawing.Size(111, 28);
            this.cmdAddContact.TabIndex = 4;
            this.cmdAddContact.Text = "Add contact";
            this.cmdAddContact.UseVisualStyleBackColor = true;
            this.cmdAddContact.Click += new System.EventHandler(this.cmdAddContact_Click);
            // 
            // cmdEditContact
            // 
            this.cmdEditContact.Location = new System.Drawing.Point(8, 338);
            this.cmdEditContact.Name = "cmdEditContact";
            this.cmdEditContact.Size = new System.Drawing.Size(111, 28);
            this.cmdEditContact.TabIndex = 4;
            this.cmdEditContact.Text = "Edit";
            this.cmdEditContact.UseVisualStyleBackColor = true;
            this.cmdEditContact.Click += new System.EventHandler(this.cmdEditContact_Click);
            // 
            // cmdDeleteContact
            // 
            this.cmdDeleteContact.Location = new System.Drawing.Point(125, 338);
            this.cmdDeleteContact.Name = "cmdDeleteContact";
            this.cmdDeleteContact.Size = new System.Drawing.Size(113, 28);
            this.cmdDeleteContact.TabIndex = 4;
            this.cmdDeleteContact.Text = "Delete";
            this.cmdDeleteContact.UseVisualStyleBackColor = true;
            this.cmdDeleteContact.Click += new System.EventHandler(this.cmdDeleteContact_Click);
            // 
            // dgwDisplayContacts
            // 
            this.dgwDisplayContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDisplayContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnContactName});
            this.dgwDisplayContacts.Location = new System.Drawing.Point(8, 15);
            this.dgwDisplayContacts.Name = "dgwDisplayContacts";
            this.dgwDisplayContacts.RowHeadersVisible = false;
            this.dgwDisplayContacts.Size = new System.Drawing.Size(98, 264);
            this.dgwDisplayContacts.TabIndex = 5;
            this.dgwDisplayContacts.SelectionChanged += new System.EventHandler(this.dgwDisplayContacts_SelectionChanged);
            // 
            // ColumnContactName
            // 
            this.ColumnContactName.HeaderText = "Name";
            this.ColumnContactName.Name = "ColumnContactName";
            // 
            // cmdSaveContactChanges
            // 
            this.cmdSaveContactChanges.Location = new System.Drawing.Point(211, 338);
            this.cmdSaveContactChanges.Name = "cmdSaveContactChanges";
            this.cmdSaveContactChanges.Size = new System.Drawing.Size(111, 28);
            this.cmdSaveContactChanges.TabIndex = 6;
            this.cmdSaveContactChanges.Text = "Save changes";
            this.cmdSaveContactChanges.UseVisualStyleBackColor = true;
            this.cmdSaveContactChanges.Click += new System.EventHandler(this.cmdSaveContactChanges_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdSaveContactChanges);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmdAddContact);
            this.groupBox1.Controls.Add(this.txtStreetAddress);
            this.groupBox1.Controls.Add(this.txtZipcode);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPhoneNr);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpBirthday);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(277, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 372);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearchName);
            this.groupBox2.Controls.Add(this.dgwDisplayContacts);
            this.groupBox2.Controls.Add(this.cmdDeleteContact);
            this.groupBox2.Controls.Add(this.cmdEditContact);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 372);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(8, 312);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(230, 20);
            this.txtSearchName.TabIndex = 6;
            this.txtSearchName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchName_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 466);
            this.Controls.Add(this.dgwDisplaySearchResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwDisplaySearchResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDisplayContacts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwDisplaySearchResult;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPhoneNr;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cmdAddContact;
        private System.Windows.Forms.Button cmdEditContact;
        private System.Windows.Forms.Button cmdDeleteContact;
        private System.Windows.Forms.DataGridView dgwDisplayContacts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContactName;
        private System.Windows.Forms.Button cmdSaveContactChanges;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearchName;
    }
}

