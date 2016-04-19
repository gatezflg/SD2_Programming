namespace WindowsFormsApplication1
{
    partial class formUpdateStaff
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
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNr = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonGenerateId = new System.Windows.Forms.Button();
            this.buttonAddNewStaff = new System.Windows.Forms.Button();
            this.buttonUpdateStaff = new System.Windows.Forms.Button();
            this.buttonClearStaffForm = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxFindById = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDisplayAll = new System.Windows.Forms.Button();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(65, 9);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 0;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(65, 36);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(65, 65);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 2;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(326, 43);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 72);
            this.textBoxAddress.TabIndex = 3;
            // 
            // textBoxPhoneNr
            // 
            this.textBoxPhoneNr.Location = new System.Drawing.Point(326, 9);
            this.textBoxPhoneNr.Name = "textBoxPhoneNr";
            this.textBoxPhoneNr.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhoneNr.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(65, 95);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(10, 9);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 6;
            this.ID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "PhoneNr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password";
            // 
            // buttonGenerateId
            // 
            this.buttonGenerateId.Location = new System.Drawing.Point(172, 9);
            this.buttonGenerateId.Name = "buttonGenerateId";
            this.buttonGenerateId.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerateId.TabIndex = 12;
            this.buttonGenerateId.Text = "GenerateID";
            this.buttonGenerateId.UseVisualStyleBackColor = true;
            this.buttonGenerateId.Click += new System.EventHandler(this.buttonGenerateId_Click);
            // 
            // buttonAddNewStaff
            // 
            this.buttonAddNewStaff.Location = new System.Drawing.Point(13, 143);
            this.buttonAddNewStaff.Name = "buttonAddNewStaff";
            this.buttonAddNewStaff.Size = new System.Drawing.Size(75, 36);
            this.buttonAddNewStaff.TabIndex = 13;
            this.buttonAddNewStaff.Text = "ADD NEW";
            this.buttonAddNewStaff.UseVisualStyleBackColor = true;
            this.buttonAddNewStaff.Click += new System.EventHandler(this.buttonAddNewStaff_Click);
            // 
            // buttonUpdateStaff
            // 
            this.buttonUpdateStaff.Location = new System.Drawing.Point(94, 143);
            this.buttonUpdateStaff.Name = "buttonUpdateStaff";
            this.buttonUpdateStaff.Size = new System.Drawing.Size(92, 36);
            this.buttonUpdateStaff.TabIndex = 14;
            this.buttonUpdateStaff.Text = "UPDATE";
            this.buttonUpdateStaff.UseVisualStyleBackColor = true;
            this.buttonUpdateStaff.Click += new System.EventHandler(this.buttonUpdateStaff_Click);
            // 
            // buttonClearStaffForm
            // 
            this.buttonClearStaffForm.Location = new System.Drawing.Point(270, 143);
            this.buttonClearStaffForm.Name = "buttonClearStaffForm";
            this.buttonClearStaffForm.Size = new System.Drawing.Size(75, 36);
            this.buttonClearStaffForm.TabIndex = 15;
            this.buttonClearStaffForm.Text = "CLEAR ALL BOXES";
            this.buttonClearStaffForm.UseVisualStyleBackColor = true;
            this.buttonClearStaffForm.Click += new System.EventHandler(this.buttonClearStaffForm_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderName,
            this.columnHeaderSurname,
            this.columnHeaderNumber,
            this.columnHeaderAddress});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(13, 230);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(413, 188);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "ID";
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            // 
            // columnHeaderSurname
            // 
            this.columnHeaderSurname.Text = "Surname";
            // 
            // columnHeaderNumber
            // 
            this.columnHeaderNumber.Text = "ContactNr";
            this.columnHeaderNumber.Width = 80;
            // 
            // columnHeaderAddress
            // 
            this.columnHeaderAddress.Text = "Address";
            this.columnHeaderAddress.Width = 155;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 19;
            this.button2.Text = "Find";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxFindById
            // 
            this.textBoxFindById.Location = new System.Drawing.Point(95, 201);
            this.textBoxFindById.Name = "textBoxFindById";
            this.textBoxFindById.Size = new System.Drawing.Size(70, 20);
            this.textBoxFindById.TabIndex = 20;
            this.textBoxFindById.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Search by ID\r\n";
            // 
            // buttonDisplayAll
            // 
            this.buttonDisplayAll.Location = new System.Drawing.Point(270, 185);
            this.buttonDisplayAll.Name = "buttonDisplayAll";
            this.buttonDisplayAll.Size = new System.Drawing.Size(75, 37);
            this.buttonDisplayAll.TabIndex = 22;
            this.buttonDisplayAll.Text = "DISPLAY ALL";
            this.buttonDisplayAll.UseVisualStyleBackColor = true;
            this.buttonDisplayAll.Click += new System.EventHandler(this.buttonDisplayAll_Click);
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Image = global::WindowsFormsApplication1.Properties.Resources.goBackBtn;
            this.buttonGoBack.Location = new System.Drawing.Point(351, 143);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(75, 78);
            this.buttonGoBack.TabIndex = 16;
            this.buttonGoBack.Text = "GO BACK";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // formUpdateStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 430);
            this.Controls.Add(this.buttonDisplayAll);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxFindById);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.buttonClearStaffForm);
            this.Controls.Add(this.buttonUpdateStaff);
            this.Controls.Add(this.buttonAddNewStaff);
            this.Controls.Add(this.buttonGenerateId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxPhoneNr);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxId);
            this.MinimumSize = new System.Drawing.Size(454, 469);
            this.Name = "formUpdateStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "formUpdateStaff";
            this.Load += new System.EventHandler(this.formUpdateStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPhoneNr;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonGenerateId;
        private System.Windows.Forms.Button buttonAddNewStaff;
        private System.Windows.Forms.Button buttonUpdateStaff;
        private System.Windows.Forms.Button buttonClearStaffForm;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderSurname;
        private System.Windows.Forms.ColumnHeader columnHeaderNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderAddress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxFindById;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonDisplayAll;
    }
}