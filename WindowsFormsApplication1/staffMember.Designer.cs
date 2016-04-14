namespace WindowsFormsApplication1
{
    partial class staffMember
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
            this.ProcessReturnedGame = new System.Windows.Forms.Button();
            this.EnquireOnAvailability = new System.Windows.Forms.Button();
            this.ViewReserveIssueGames = new System.Windows.Forms.Button();
            this.Customers = new System.Windows.Forms.Button();
            this.return_to_home_page = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProcessReturnedGame
            // 
            this.ProcessReturnedGame.AccessibleName = "ProcessReturnedGame";
            this.ProcessReturnedGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessReturnedGame.Location = new System.Drawing.Point(21, 28);
            this.ProcessReturnedGame.Name = "ProcessReturnedGame";
            this.ProcessReturnedGame.Size = new System.Drawing.Size(160, 139);
            this.ProcessReturnedGame.TabIndex = 0;
            this.ProcessReturnedGame.Text = "Process Returned Game";
            this.ProcessReturnedGame.UseVisualStyleBackColor = true;
            this.ProcessReturnedGame.Click += new System.EventHandler(this.ProcessReturnedGame_Click);
            // 
            // EnquireOnAvailability
            // 
            this.EnquireOnAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnquireOnAvailability.Location = new System.Drawing.Point(187, 28);
            this.EnquireOnAvailability.Name = "EnquireOnAvailability";
            this.EnquireOnAvailability.Size = new System.Drawing.Size(148, 139);
            this.EnquireOnAvailability.TabIndex = 1;
            this.EnquireOnAvailability.Text = "Enquire on Availability ";
            this.EnquireOnAvailability.UseVisualStyleBackColor = true;
            this.EnquireOnAvailability.Click += new System.EventHandler(this.EnquireOnAvailability_Click);
            // 
            // ViewReserveIssueGames
            // 
            this.ViewReserveIssueGames.AccessibleName = "View ReserveIssue Games";
            this.ViewReserveIssueGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewReserveIssueGames.Location = new System.Drawing.Point(21, 173);
            this.ViewReserveIssueGames.Name = "ViewReserveIssueGames";
            this.ViewReserveIssueGames.Size = new System.Drawing.Size(160, 134);
            this.ViewReserveIssueGames.TabIndex = 2;
            this.ViewReserveIssueGames.Text = "View/Reserve/Issue Games";
            this.ViewReserveIssueGames.UseVisualStyleBackColor = true;
            this.ViewReserveIssueGames.Click += new System.EventHandler(this.ViewReserveIssueGames_Click);
            // 
            // Customers
            // 
            this.Customers.AccessibleName = "Customers";
            this.Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customers.Location = new System.Drawing.Point(187, 174);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(148, 134);
            this.Customers.TabIndex = 3;
            this.Customers.Text = "Customers";
            this.Customers.UseVisualStyleBackColor = true;
            this.Customers.Click += new System.EventHandler(this.Customers_Click);
            // 
            // return_to_home_page
            // 
            this.return_to_home_page.AccessibleDescription = "return to home page";
            this.return_to_home_page.AccessibleName = "return";
            this.return_to_home_page.Location = new System.Drawing.Point(140, 329);
            this.return_to_home_page.Name = "return_to_home_page";
            this.return_to_home_page.Size = new System.Drawing.Size(75, 23);
            this.return_to_home_page.TabIndex = 4;
            this.return_to_home_page.Text = "Return";
            this.return_to_home_page.UseVisualStyleBackColor = true;
            this.return_to_home_page.Click += new System.EventHandler(this.return_to_home_page_Click);
            // 
            // staffMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 364);
            this.Controls.Add(this.return_to_home_page);
            this.Controls.Add(this.Customers);
            this.Controls.Add(this.ViewReserveIssueGames);
            this.Controls.Add(this.EnquireOnAvailability);
            this.Controls.Add(this.ProcessReturnedGame);
            this.Name = "staffMember";
            this.Text = "staffMember";
            this.Load += new System.EventHandler(this.staffMember_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ProcessReturnedGame;
        private System.Windows.Forms.Button EnquireOnAvailability;
        private System.Windows.Forms.Button ViewReserveIssueGames;
        private System.Windows.Forms.Button Customers;
        private System.Windows.Forms.Button return_to_home_page;
    }
}