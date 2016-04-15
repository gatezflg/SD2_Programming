namespace WindowsFormsApplication1
{
    partial class form_add_update_delete_customer
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
            this.customer_ID = new System.Windows.Forms.Label();
            this.customer_firstName = new System.Windows.Forms.Label();
            this.customer_Surname = new System.Windows.Forms.Label();
            this.customer_Address = new System.Windows.Forms.Label();
            this.customer_Contact_Number = new System.Windows.Forms.Label();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.textBoxCustomerFirstName = new System.Windows.Forms.TextBox();
            this.textBoxCustomerSurname = new System.Windows.Forms.TextBox();
            this.textBoxCustomerPNr = new System.Windows.Forms.TextBox();
            this.textBoxCustomerAddress = new System.Windows.Forms.TextBox();
            this.addCustomer = new System.Windows.Forms.Button();
            this.update_Details = new System.Windows.Forms.Button();
            this.delete_Customer = new System.Windows.Forms.Button();
            this.return_btn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.generateID = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customer_ID
            // 
            this.customer_ID.AccessibleDescription = "customer id";
            this.customer_ID.AccessibleName = "customer_id";
            this.customer_ID.AutoSize = true;
            this.customer_ID.Location = new System.Drawing.Point(26, 53);
            this.customer_ID.Name = "customer_ID";
            this.customer_ID.Size = new System.Drawing.Size(63, 13);
            this.customer_ID.TabIndex = 0;
            this.customer_ID.Text = "Customer Id";
            this.customer_ID.Click += new System.EventHandler(this.customer_ID_Click);
            // 
            // customer_firstName
            // 
            this.customer_firstName.AccessibleDescription = "customer firstname";
            this.customer_firstName.AccessibleName = "customer_firstName";
            this.customer_firstName.AutoSize = true;
            this.customer_firstName.Location = new System.Drawing.Point(26, 76);
            this.customer_firstName.Name = "customer_firstName";
            this.customer_firstName.Size = new System.Drawing.Size(52, 13);
            this.customer_firstName.TabIndex = 1;
            this.customer_firstName.Text = "Firstname";
            // 
            // customer_Surname
            // 
            this.customer_Surname.AccessibleDescription = "customer surname";
            this.customer_Surname.AccessibleName = "customer_Surname";
            this.customer_Surname.AutoSize = true;
            this.customer_Surname.Location = new System.Drawing.Point(26, 102);
            this.customer_Surname.Name = "customer_Surname";
            this.customer_Surname.Size = new System.Drawing.Size(49, 13);
            this.customer_Surname.TabIndex = 2;
            this.customer_Surname.Text = "Surname";
            // 
            // customer_Address
            // 
            this.customer_Address.AccessibleDescription = "customer address";
            this.customer_Address.AccessibleName = "customer_Address";
            this.customer_Address.AutoSize = true;
            this.customer_Address.Location = new System.Drawing.Point(254, 53);
            this.customer_Address.Name = "customer_Address";
            this.customer_Address.Size = new System.Drawing.Size(45, 13);
            this.customer_Address.TabIndex = 3;
            this.customer_Address.Text = "Address";
            this.customer_Address.Click += new System.EventHandler(this.label4_Click);
            // 
            // customer_Contact_Number
            // 
            this.customer_Contact_Number.AccessibleDescription = "customer contact number";
            this.customer_Contact_Number.AccessibleName = "customer_Contact_Number";
            this.customer_Contact_Number.AutoSize = true;
            this.customer_Contact_Number.Location = new System.Drawing.Point(26, 142);
            this.customer_Contact_Number.Name = "customer_Contact_Number";
            this.customer_Contact_Number.Size = new System.Drawing.Size(84, 13);
            this.customer_Contact_Number.TabIndex = 4;
            this.customer_Contact_Number.Text = "Contact Number";
            this.customer_Contact_Number.Click += new System.EventHandler(this.customer_Contact_Number_Click);
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Location = new System.Drawing.Point(117, 50);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(41, 20);
            this.textBoxCustomerID.TabIndex = 5;
            this.textBoxCustomerID.TextChanged += new System.EventHandler(this.textBoxCustomerID_TextChanged);
            // 
            // textBoxCustomerFirstName
            // 
            this.textBoxCustomerFirstName.Location = new System.Drawing.Point(117, 76);
            this.textBoxCustomerFirstName.Name = "textBoxCustomerFirstName";
            this.textBoxCustomerFirstName.Size = new System.Drawing.Size(114, 20);
            this.textBoxCustomerFirstName.TabIndex = 6;
            this.textBoxCustomerFirstName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxCustomerSurname
            // 
            this.textBoxCustomerSurname.Location = new System.Drawing.Point(117, 102);
            this.textBoxCustomerSurname.Name = "textBoxCustomerSurname";
            this.textBoxCustomerSurname.Size = new System.Drawing.Size(114, 20);
            this.textBoxCustomerSurname.TabIndex = 7;
            // 
            // textBoxCustomerPNr
            // 
            this.textBoxCustomerPNr.Location = new System.Drawing.Point(117, 139);
            this.textBoxCustomerPNr.Name = "textBoxCustomerPNr";
            this.textBoxCustomerPNr.Size = new System.Drawing.Size(114, 20);
            this.textBoxCustomerPNr.TabIndex = 8;
            // 
            // textBoxCustomerAddress
            // 
            this.textBoxCustomerAddress.Location = new System.Drawing.Point(305, 53);
            this.textBoxCustomerAddress.Multiline = true;
            this.textBoxCustomerAddress.Name = "textBoxCustomerAddress";
            this.textBoxCustomerAddress.Size = new System.Drawing.Size(115, 106);
            this.textBoxCustomerAddress.TabIndex = 10;
            this.textBoxCustomerAddress.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // addCustomer
            // 
            this.addCustomer.AccessibleDescription = "add a customer";
            this.addCustomer.AccessibleName = "addCustomer";
            this.addCustomer.Location = new System.Drawing.Point(73, 505);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(68, 23);
            this.addCustomer.TabIndex = 11;
            this.addCustomer.Text = "Add";
            this.addCustomer.UseVisualStyleBackColor = true;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // update_Details
            // 
            this.update_Details.AccessibleDescription = "update customer details";
            this.update_Details.AccessibleName = "update_Details";
            this.update_Details.Location = new System.Drawing.Point(181, 505);
            this.update_Details.Name = "update_Details";
            this.update_Details.Size = new System.Drawing.Size(75, 23);
            this.update_Details.TabIndex = 12;
            this.update_Details.Text = "Update";
            this.update_Details.UseVisualStyleBackColor = true;
            this.update_Details.Click += new System.EventHandler(this.update_Details_Click);
            // 
            // delete_Customer
            // 
            this.delete_Customer.AccessibleDescription = "delete customer";
            this.delete_Customer.AccessibleName = "delete_Customer";
            this.delete_Customer.Location = new System.Drawing.Point(305, 505);
            this.delete_Customer.Name = "delete_Customer";
            this.delete_Customer.Size = new System.Drawing.Size(75, 23);
            this.delete_Customer.TabIndex = 13;
            this.delete_Customer.Text = "Delete";
            this.delete_Customer.UseVisualStyleBackColor = true;
            this.delete_Customer.Click += new System.EventHandler(this.delete_Customer_Click);
            // 
            // return_btn
            // 
            this.return_btn.AccessibleDescription = "return to previous screen";
            this.return_btn.AccessibleName = "return";
            this.return_btn.Location = new System.Drawing.Point(181, 540);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(75, 23);
            this.return_btn.TabIndex = 14;
            this.return_btn.Text = "Return";
            this.return_btn.UseVisualStyleBackColor = true;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(50, 260);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(370, 239);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CustomerID";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 63;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Surname";
            this.columnHeader3.Width = 54;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Address";
            this.columnHeader4.Width = 91;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Contact Number";
            this.columnHeader5.Width = 89;
            // 
            // generateID
            // 
            this.generateID.AccessibleName = "generate_ID";
            this.generateID.Location = new System.Drawing.Point(164, 50);
            this.generateID.Name = "generateID";
            this.generateID.Size = new System.Drawing.Size(67, 20);
            this.generateID.TabIndex = 16;
            this.generateID.Text = "Generate";
            this.generateID.UseVisualStyleBackColor = true;
            this.generateID.Click += new System.EventHandler(this.generateID_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(305, 184);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(75, 23);
            this.refresh_button.TabIndex = 17;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // form_add_update_delete_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 560);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.generateID);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.delete_Customer);
            this.Controls.Add(this.update_Details);
            this.Controls.Add(this.addCustomer);
            this.Controls.Add(this.textBoxCustomerAddress);
            this.Controls.Add(this.textBoxCustomerPNr);
            this.Controls.Add(this.textBoxCustomerSurname);
            this.Controls.Add(this.textBoxCustomerFirstName);
            this.Controls.Add(this.textBoxCustomerID);
            this.Controls.Add(this.customer_Contact_Number);
            this.Controls.Add(this.customer_Address);
            this.Controls.Add(this.customer_Surname);
            this.Controls.Add(this.customer_firstName);
            this.Controls.Add(this.customer_ID);
            this.Name = "form_add_update_delete_customer";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "add_update_delete_customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customer_ID;
        private System.Windows.Forms.Label customer_firstName;
        private System.Windows.Forms.Label customer_Surname;
        private System.Windows.Forms.Label customer_Address;
        private System.Windows.Forms.Label customer_Contact_Number;
        private System.Windows.Forms.TextBox textBoxCustomerFirstName;
        private System.Windows.Forms.TextBox textBoxCustomerSurname;
        private System.Windows.Forms.TextBox textBoxCustomerPNr;
        private System.Windows.Forms.TextBox textBoxCustomerAddress;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.Button update_Details;
        private System.Windows.Forms.Button delete_Customer;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        internal System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.Button generateID;
        private System.Windows.Forms.Button refresh_button;
    }
}