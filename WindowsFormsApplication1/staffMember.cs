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
    public partial class staffMember : Form
    {
        public staffMember()
        {
          
            InitializeComponent();
        }

        private void ProcessReturnedGame_Click(object sender, EventArgs e)
        {
            
            Form process = new processReturningGame();
            process.Show();
            this.Hide();
        }

        private void ViewReserveIssueGames_Click(object sender, EventArgs e)
        {
            Form viewReserveIssue = new view_reserve_issue_game();
            viewReserveIssue.Show();
            this.Hide();
        }

        private void EnquireOnAvailability_Click(object sender, EventArgs e)
        {
            Form enquiryAvailability = new enquiryAvailability();
            enquiryAvailability.Show();
            this.Hide();

        }

        private void Customers_Click(object sender, EventArgs e)
        {
            
            Form customer = new add_update_delete_customer();
            customer.Show();
            this.Hide();


        }

        private void staffMember_Load(object sender, EventArgs e)
        {

        }

        private void return_to_home_page_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
