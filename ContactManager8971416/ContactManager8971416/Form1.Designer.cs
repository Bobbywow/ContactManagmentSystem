namespace ContactManager8971416
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
            this.DgVContacts = new System.Windows.Forms.DataGridView();
            this.rdPersonalContact = new System.Windows.Forms.RadioButton();
            this.rdBusinessContact = new System.Windows.Forms.RadioButton();
            this.ContactgroupBox = new System.Windows.Forms.GroupBox();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbUserPass = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbUserPass = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.ContactsDGPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbPersonalContact = new System.Windows.Forms.TextBox();
            this.btPcontact = new System.Windows.Forms.Button();
            this.lbPcontact = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgVContacts)).BeginInit();
            this.ContactgroupBox.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.ContactsDGPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgVContacts
            // 
            this.DgVContacts.AccessibleName = "";
            this.DgVContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgVContacts.Location = new System.Drawing.Point(31, 96);
            this.DgVContacts.Name = "DgVContacts";
            this.DgVContacts.Size = new System.Drawing.Size(449, 150);
            this.DgVContacts.TabIndex = 0;
            // 
            // rdPersonalContact
            // 
            this.rdPersonalContact.AccessibleName = "";
            this.rdPersonalContact.AutoSize = true;
            this.rdPersonalContact.Location = new System.Drawing.Point(213, 288);
            this.rdPersonalContact.Name = "rdPersonalContact";
            this.rdPersonalContact.Size = new System.Drawing.Size(111, 17);
            this.rdPersonalContact.TabIndex = 1;
            this.rdPersonalContact.TabStop = true;
            this.rdPersonalContact.Text = "Personal Contacts";
            this.rdPersonalContact.UseVisualStyleBackColor = true;
            // 
            // rdBusinessContact
            // 
            this.rdBusinessContact.AccessibleName = "";
            this.rdBusinessContact.AutoSize = true;
            this.rdBusinessContact.Location = new System.Drawing.Point(213, 265);
            this.rdBusinessContact.Name = "rdBusinessContact";
            this.rdBusinessContact.Size = new System.Drawing.Size(112, 17);
            this.rdBusinessContact.TabIndex = 2;
            this.rdBusinessContact.TabStop = true;
            this.rdBusinessContact.Text = "Business Contacts";
            this.rdBusinessContact.UseVisualStyleBackColor = true;
            // 
            // ContactgroupBox
            // 
            this.ContactgroupBox.AccessibleName = "";
            this.ContactgroupBox.Controls.Add(this.rdBusinessContact);
            this.ContactgroupBox.Controls.Add(this.DgVContacts);
            this.ContactgroupBox.Controls.Add(this.rdPersonalContact);
            this.ContactgroupBox.Location = new System.Drawing.Point(9, 14);
            this.ContactgroupBox.Name = "ContactgroupBox";
            this.ContactgroupBox.Size = new System.Drawing.Size(504, 334);
            this.ContactgroupBox.TabIndex = 3;
            this.ContactgroupBox.TabStop = false;
            this.ContactgroupBox.Text = "Contacts";
            this.ContactgroupBox.Enter += new System.EventHandler(this.ContactsRadioBox_Enter);
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.Transparent;
            this.LoginPanel.Controls.Add(this.tbUserName);
            this.LoginPanel.Controls.Add(this.tbUserPass);
            this.LoginPanel.Controls.Add(this.lbUserName);
            this.LoginPanel.Controls.Add(this.lbUserPass);
            this.LoginPanel.Controls.Add(this.btLogin);
            this.LoginPanel.Location = new System.Drawing.Point(12, 14);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(461, 445);
            this.LoginPanel.TabIndex = 48;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(183, 26);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(244, 20);
            this.tbUserName.TabIndex = 0;
            // 
            // tbUserPass
            // 
            this.tbUserPass.Location = new System.Drawing.Point(183, 80);
            this.tbUserPass.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbUserPass.Name = "tbUserPass";
            this.tbUserPass.PasswordChar = '*';
            this.tbUserPass.Size = new System.Drawing.Size(244, 20);
            this.tbUserPass.TabIndex = 1;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(80, 35);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(55, 13);
            this.lbUserName.TabIndex = 2;
            this.lbUserName.Text = "Username";
            // 
            // lbUserPass
            // 
            this.lbUserPass.AutoSize = true;
            this.lbUserPass.Location = new System.Drawing.Point(84, 89);
            this.lbUserPass.Name = "lbUserPass";
            this.lbUserPass.Size = new System.Drawing.Size(53, 13);
            this.lbUserPass.TabIndex = 3;
            this.lbUserPass.Text = "Password";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(250, 158);
            this.btLogin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(111, 35);
            this.btLogin.TabIndex = 5;
            this.btLogin.Text = "LOGIN";
            this.btLogin.UseVisualStyleBackColor = true;
            // 
            // ContactsDGPanel
            // 
            this.ContactsDGPanel.BackColor = System.Drawing.Color.Transparent;
            this.ContactsDGPanel.Controls.Add(this.ContactgroupBox);
            this.ContactsDGPanel.Location = new System.Drawing.Point(667, 12);
            this.ContactsDGPanel.Name = "ContactsDGPanel";
            this.ContactsDGPanel.Size = new System.Drawing.Size(516, 373);
            this.ContactsDGPanel.TabIndex = 49;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbPcontact);
            this.panel1.Controls.Add(this.btPcontact);
            this.panel1.Controls.Add(this.tbPersonalContact);
            this.panel1.Location = new System.Drawing.Point(479, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 317);
            this.panel1.TabIndex = 50;
            // 
            // tbPersonalContact
            // 
            this.tbPersonalContact.Location = new System.Drawing.Point(39, 59);
            this.tbPersonalContact.Name = "tbPersonalContact";
            this.tbPersonalContact.Size = new System.Drawing.Size(100, 20);
            this.tbPersonalContact.TabIndex = 0;
            this.tbPersonalContact.TextChanged += new System.EventHandler(this.tbPersonalContact_TextChanged);
            // 
            // btPcontact
            // 
            this.btPcontact.Location = new System.Drawing.Point(52, 85);
            this.btPcontact.Name = "btPcontact";
            this.btPcontact.Size = new System.Drawing.Size(75, 23);
            this.btPcontact.TabIndex = 1;
            this.btPcontact.Text = "Create";
            this.btPcontact.UseVisualStyleBackColor = true;
            this.btPcontact.Click += new System.EventHandler(this.btPcontact_Click);
            // 
            // lbPcontact
            // 
            this.lbPcontact.AutoSize = true;
            this.lbPcontact.Location = new System.Drawing.Point(27, 35);
            this.lbPcontact.Name = "lbPcontact";
            this.lbPcontact.Size = new System.Drawing.Size(122, 13);
            this.lbPcontact.TabIndex = 2;
            this.lbPcontact.Text = "Create Personal Contact";
            this.lbPcontact.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ContactManager8971416.Properties.Resources.telefony_telefon_evolyuciya;
            this.ClientSize = new System.Drawing.Size(1216, 497);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ContactsDGPanel);
            this.Controls.Add(this.LoginPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgVContacts)).EndInit();
            this.ContactgroupBox.ResumeLayout(false);
            this.ContactgroupBox.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ContactsDGPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgVContacts;
        private System.Windows.Forms.RadioButton rdPersonalContact;
        private System.Windows.Forms.RadioButton rdBusinessContact;
        private System.Windows.Forms.GroupBox ContactgroupBox;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbUserPass;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbUserPass;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Panel ContactsDGPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbPersonalContact;
        private System.Windows.Forms.Label lbPcontact;
        private System.Windows.Forms.Button btPcontact;
    }
}

