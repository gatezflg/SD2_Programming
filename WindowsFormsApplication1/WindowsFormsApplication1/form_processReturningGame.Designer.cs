namespace WindowsFormsApplication1
{
    partial class form_processReturningGame
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
            this.return_game = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.return_to_previous = new System.Windows.Forms.Button();
            this.rented_list_view = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxGameName = new System.Windows.Forms.TextBox();
            this.textBoxHireDate = new System.Windows.Forms.TextBox();
            this.textBoxReturnDate = new System.Windows.Forms.TextBox();
            this.textBoxActualReturnDate = new System.Windows.Forms.TextBox();
            this.textBoxGameID = new System.Windows.Forms.TextBox();
            this.textBoxStockID = new System.Windows.Forms.TextBox();
            this.textBoxMemberID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.MemberFirstName = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // return_game
            // 
            this.return_game.AccessibleDescription = "change status of game on click";
            this.return_game.AccessibleName = "return";
            this.return_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_game.Location = new System.Drawing.Point(28, 442);
            this.return_game.Name = "return_game";
            this.return_game.Size = new System.Drawing.Size(124, 39);
            this.return_game.TabIndex = 0;
            this.return_game.Text = "Return Game";
            this.return_game.UseVisualStyleBackColor = true;
            this.return_game.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Games out on rent";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // return_to_previous
            // 
            this.return_to_previous.AccessibleDescription = "Return to menu";
            this.return_to_previous.AccessibleName = "return";
            this.return_to_previous.Location = new System.Drawing.Point(607, 458);
            this.return_to_previous.Name = "return_to_previous";
            this.return_to_previous.Size = new System.Drawing.Size(75, 23);
            this.return_to_previous.TabIndex = 3;
            this.return_to_previous.Text = "Return";
            this.return_to_previous.UseVisualStyleBackColor = true;
            this.return_to_previous.Click += new System.EventHandler(this.return_to_previous_Click);
            // 
            // rented_list_view
            // 
            this.rented_list_view.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.rented_list_view.Location = new System.Drawing.Point(229, 58);
            this.rented_list_view.Name = "rented_list_view";
            this.rented_list_view.Size = new System.Drawing.Size(513, 194);
            this.rented_list_view.TabIndex = 4;
            this.rented_list_view.UseCompatibleStateImageBehavior = false;
            this.rented_list_view.View = System.Windows.Forms.View.Details;
            this.rented_list_view.SelectedIndexChanged += new System.EventHandler(this.rented_list_view_SelectedIndexChanged);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView2.Location = new System.Drawing.Point(229, 274);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(290, 116);
            this.listView2.TabIndex = 5;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Game Name";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hire Date";
            this.columnHeader2.Width = 63;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Return Date";
            this.columnHeader3.Width = 73;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Actual Return Date";
            this.columnHeader4.Width = 106;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "GameID";
            this.columnHeader5.Width = 53;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "StockID";
            this.columnHeader6.Width = 76;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "MemberID";
            this.columnHeader7.Width = 66;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Member First Name";
            this.columnHeader8.Width = 110;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Member Surname";
            this.columnHeader9.Width = 96;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Member ID";
            this.columnHeader10.Width = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Game Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Actual Return Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "StockID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "GameID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Return Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Hire Date";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBoxGameName
            // 
            this.textBoxGameName.Location = new System.Drawing.Point(116, 58);
            this.textBoxGameName.Name = "textBoxGameName";
            this.textBoxGameName.Size = new System.Drawing.Size(100, 20);
            this.textBoxGameName.TabIndex = 12;
            // 
            // textBoxHireDate
            // 
            this.textBoxHireDate.Location = new System.Drawing.Point(116, 84);
            this.textBoxHireDate.Name = "textBoxHireDate";
            this.textBoxHireDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxHireDate.TabIndex = 13;
            // 
            // textBoxReturnDate
            // 
            this.textBoxReturnDate.Location = new System.Drawing.Point(116, 110);
            this.textBoxReturnDate.Name = "textBoxReturnDate";
            this.textBoxReturnDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxReturnDate.TabIndex = 14;
            // 
            // textBoxActualReturnDate
            // 
            this.textBoxActualReturnDate.Location = new System.Drawing.Point(116, 136);
            this.textBoxActualReturnDate.Name = "textBoxActualReturnDate";
            this.textBoxActualReturnDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxActualReturnDate.TabIndex = 15;
            // 
            // textBoxGameID
            // 
            this.textBoxGameID.Location = new System.Drawing.Point(116, 162);
            this.textBoxGameID.Name = "textBoxGameID";
            this.textBoxGameID.Size = new System.Drawing.Size(100, 20);
            this.textBoxGameID.TabIndex = 16;
            // 
            // textBoxStockID
            // 
            this.textBoxStockID.Location = new System.Drawing.Point(116, 188);
            this.textBoxStockID.Name = "textBoxStockID";
            this.textBoxStockID.Size = new System.Drawing.Size(100, 20);
            this.textBoxStockID.TabIndex = 17;
            // 
            // textBoxMemberID
            // 
            this.textBoxMemberID.Location = new System.Drawing.Point(116, 214);
            this.textBoxMemberID.Name = "textBoxMemberID";
            this.textBoxMemberID.Size = new System.Drawing.Size(100, 20);
            this.textBoxMemberID.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "MemberID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Member ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Member Surname";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Member First Name";
            // 
            // MemberFirstName
            // 
            this.MemberFirstName.Location = new System.Drawing.Point(116, 286);
            this.MemberFirstName.Name = "MemberFirstName";
            this.MemberFirstName.Size = new System.Drawing.Size(100, 20);
            this.MemberFirstName.TabIndex = 23;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(116, 314);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 24;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(116, 340);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 25;
            // 
            // processReturningGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 511);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.MemberFirstName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxMemberID);
            this.Controls.Add(this.textBoxStockID);
            this.Controls.Add(this.textBoxGameID);
            this.Controls.Add(this.textBoxActualReturnDate);
            this.Controls.Add(this.textBoxReturnDate);
            this.Controls.Add(this.textBoxHireDate);
            this.Controls.Add(this.textBoxGameName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.rented_list_view);
            this.Controls.Add(this.return_to_previous);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.return_game);
            this.Name = "processReturningGame";
            this.Text = "processReturningGame";
            this.Load += new System.EventHandler(this.processReturningGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button return_game;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button return_to_previous;
        private System.Windows.Forms.ListView rented_list_view;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxGameName;
        private System.Windows.Forms.TextBox textBoxHireDate;
        private System.Windows.Forms.TextBox textBoxReturnDate;
        private System.Windows.Forms.TextBox textBoxActualReturnDate;
        private System.Windows.Forms.TextBox textBoxGameID;
        private System.Windows.Forms.TextBox textBoxStockID;
        private System.Windows.Forms.TextBox textBoxMemberID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox MemberFirstName;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
    }
}