namespace WindowsFormsApplication1
{
    partial class enquiryAvailability
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
            this.game_title = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.return_to_menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // game_title
            // 
            this.game_title.AccessibleDescription = "enter game title";
            this.game_title.AccessibleName = "game_title";
            this.game_title.AutoSize = true;
            this.game_title.Location = new System.Drawing.Point(114, 80);
            this.game_title.Name = "game_title";
            this.game_title.Size = new System.Drawing.Size(86, 13);
            this.game_title.TabIndex = 1;
            this.game_title.Text = "Enter Game Title";
            this.game_title.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(85, 142);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(358, 225);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 3;
            // 
            // return_to_menu
            // 
            this.return_to_menu.AccessibleDescription = "return to menu";
            this.return_to_menu.AccessibleName = "return";
            this.return_to_menu.Location = new System.Drawing.Point(211, 419);
            this.return_to_menu.Name = "return_to_menu";
            this.return_to_menu.Size = new System.Drawing.Size(92, 31);
            this.return_to_menu.TabIndex = 4;
            this.return_to_menu.Text = "Return";
            this.return_to_menu.UseVisualStyleBackColor = true;
            this.return_to_menu.Click += new System.EventHandler(this.return_to_menu_Click);
            // 
            // enquiryAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 490);
            this.Controls.Add(this.return_to_menu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.game_title);
            this.Name = "enquiryAvailability";
            this.Text = "enquiryAvailability";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label game_title;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button return_to_menu;

    }
}