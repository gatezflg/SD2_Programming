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
    public partial class form_processReturningGame : Form
    {
        public form_processReturningGame()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void return_to_previous_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            Form staffMember = new form_staffMember();
            staffMember.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //on click change status from rented to in stock

        }

        private void processReturningGame_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rented_list_view_SelectedIndexChanged(object sender, EventArgs e)
        {
            //display games that have a status of Rented
            DateTime actualTime = DateTime.Now;
            foreach (ListViewItem item in rented_list_view.SelectedItems)
            {

              //  textBoxGameName.Text = item.SubItem[0].Text;





            }

        }
    }
}
