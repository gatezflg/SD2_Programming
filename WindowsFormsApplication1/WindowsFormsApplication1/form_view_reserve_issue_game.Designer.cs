namespace WindowsFormsApplication1
{
    partial class form_view_reserve_issue_game
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.member_ID = new System.Windows.Forms.Label();
            this.Search_By_Game = new System.Windows.Forms.Label();
            this.reserve_game = new System.Windows.Forms.Button();
            this.Issue_game = new System.Windows.Forms.Button();
            this.return_to_previous = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(62, 205);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(489, 173);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // member_ID
            // 
            this.member_ID.AccessibleDescription = "enter member ID";
            this.member_ID.AccessibleName = "member_ID";
            this.member_ID.AutoSize = true;
            this.member_ID.Location = new System.Drawing.Point(91, 68);
            this.member_ID.Name = "member_ID";
            this.member_ID.Size = new System.Drawing.Size(59, 13);
            this.member_ID.TabIndex = 1;
            this.member_ID.Text = "Member ID";
            this.member_ID.Click += new System.EventHandler(this.label1_Click);
            // 
            // Search_By_Game
            // 
            this.Search_By_Game.AccessibleDescription = "Name of game";
            this.Search_By_Game.AccessibleName = "Search_By_Game";
            this.Search_By_Game.AutoSize = true;
            this.Search_By_Game.Location = new System.Drawing.Point(340, 68);
            this.Search_By_Game.Name = "Search_By_Game";
            this.Search_By_Game.Size = new System.Drawing.Size(87, 13);
            this.Search_By_Game.TabIndex = 2;
            this.Search_By_Game.Text = "Search By Game";
            this.Search_By_Game.Click += new System.EventHandler(this.label2_Click);
            // 
            // reserve_game
            // 
            this.reserve_game.AccessibleDescription = "reserve game";
            this.reserve_game.AccessibleName = "reserve_game";
            this.reserve_game.Location = new System.Drawing.Point(150, 395);
            this.reserve_game.Name = "reserve_game";
            this.reserve_game.Size = new System.Drawing.Size(75, 23);
            this.reserve_game.TabIndex = 3;
            this.reserve_game.Text = "Reserve";
            this.reserve_game.UseVisualStyleBackColor = true;
            this.reserve_game.Click += new System.EventHandler(this.reserve_game_Click);
            // 
            // Issue_game
            // 
            this.Issue_game.AccessibleDescription = "Issue game";
            this.Issue_game.AccessibleName = "Issue_game";
            this.Issue_game.Location = new System.Drawing.Point(406, 394);
            this.Issue_game.Name = "Issue_game";
            this.Issue_game.Size = new System.Drawing.Size(75, 23);
            this.Issue_game.TabIndex = 4;
            this.Issue_game.Text = "Issue";
            this.Issue_game.UseVisualStyleBackColor = true;
            // 
            // return_to_previous
            // 
            this.return_to_previous.AccessibleDescription = "return to previous form";
            this.return_to_previous.AccessibleName = "return";
            this.return_to_previous.Location = new System.Drawing.Point(256, 475);
            this.return_to_previous.Name = "return_to_previous";
            this.return_to_previous.Size = new System.Drawing.Size(75, 23);
            this.return_to_previous.TabIndex = 5;
            this.return_to_previous.Text = "Return";
            this.return_to_previous.UseVisualStyleBackColor = true;
            this.return_to_previous.Click += new System.EventHandler(this.return_to_previous_Click);
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "member_ID";
            this.textBox1.Location = new System.Drawing.Point(84, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.AccessibleName = "Search_By_Game";
            this.textBox2.Location = new System.Drawing.Point(340, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 20);
            this.textBox2.TabIndex = 7;
            // 
            // form_view_reserve_issue_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 544);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.return_to_previous);
            this.Controls.Add(this.Issue_game);
            this.Controls.Add(this.reserve_game);
            this.Controls.Add(this.Search_By_Game);
            this.Controls.Add(this.member_ID);
            this.Controls.Add(this.listBox1);
            this.Name = "form_view_reserve_issue_game";
            this.Text = "view_reserve_issue_game";
            this.Load += new System.EventHandler(this.form_view_reserve_issue_game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label member_ID;
        private System.Windows.Forms.Label Search_By_Game;
        private System.Windows.Forms.Button reserve_game;
        private System.Windows.Forms.Button Issue_game;
        private System.Windows.Forms.Button return_to_previous;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}