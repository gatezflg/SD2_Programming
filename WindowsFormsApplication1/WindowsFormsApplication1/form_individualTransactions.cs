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
    public partial class form_individualTransactions : Form
    {
       // private formStart A;
        public form_individualTransactions() //<---formStart parent
        {
            InitializeComponent();
           // MdiParent = parent;
           // A = parent;
            AccountTransaction.ReadIndividualTransactionList();

            foreach (AccountTransaction account in Program.individualTransList)
            {
                if (account.TransactionType == "R")
                {
                    ListViewItem lvi = new ListViewItem(account.Member._id.ToString());
                    lvi.SubItems.Add(account.Member._name.ToString());
                    lvi.SubItems.Add(account.Member._phoneNr.ToString());
                    lvi.SubItems.Add("Rental fee");
                    lvi.SubItems.Add(account.RentalFee.ToString());
                    listView1.Items.Add(lvi);
                }
                if (account.TransactionType == "L")
                {
                    ListViewItem lvi = new ListViewItem(account.Member._id.ToString());
                    lvi.SubItems.Add(account.Member._name.ToString());
                    lvi.SubItems.Add(account.Member._phoneNr.ToString());
                    lvi.SubItems.Add("Late Fee");
                    lvi.SubItems.Add(account.LateFee.ToString());
                    listView1.Items.Add(lvi);
                }
                if (account.TransactionType == "M")
                {
                    ListViewItem lvi = new ListViewItem(account.Member._id.ToString());
                    lvi.SubItems.Add(account.Member._name.ToString());
                    lvi.SubItems.Add(account.Member._phoneNr.ToString());
                    lvi.SubItems.Add("Membership Fee");
                    lvi.SubItems.Add(account.MemberFee.ToString());
                    listView1.Items.Add(lvi);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
