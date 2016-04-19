using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class form_view_reserve_issue_game : Form
    {
        public form_view_reserve_issue_game()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void return_to_previous_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            Form staffMember = new form_staffMember();
            staffMember.Show();
        }

        private void reserve_game_Click(object sender, EventArgs e)
        {

        }

        private void form_view_reserve_issue_game_Load(object sender, EventArgs e)
        {

        }

       
    }
}
