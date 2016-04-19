namespace WindowsFormsApplication1
{
    partial class managerView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        //
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
            this.updateStaff = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updateStaff
            // 
            this.updateStaff.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.updateStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStaff.Location = new System.Drawing.Point(12, 12);
            this.updateStaff.Name = "updateStaff";
            this.updateStaff.Size = new System.Drawing.Size(200, 200);
            this.updateStaff.TabIndex = 0;
            this.updateStaff.Text = "View / Add / Insert / Detele \r\nStaff Members";
            this.updateStaff.UseVisualStyleBackColor = true;
            this.updateStaff.Click += new System.EventHandler(this.Update_Staff_click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(222, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 200);
            this.button2.TabIndex = 1;
            this.button2.Text = "Reports";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 200);
            this.button3.TabIndex = 2;
            this.button3.Text = "View / Add / Update / Delete\r\nGames";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(222, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 200);
            this.button4.TabIndex = 3;
            this.button4.Text = "Customers";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // managerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 430);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.updateStaff);
            this.MinimumSize = new System.Drawing.Size(454, 469);
            this.Name = "managerView";
            this.Text = "managerView";
            this.Load += new System.EventHandler(this.managerView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateStaff;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

    }
}

