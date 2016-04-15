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
    public partial class form_AccountTransactions : Form
    {
        public form_AccountTransactions()
        {
            InitializeComponent();

            AccountTransaction.ReadTransactionList();

            foreach (AccountTransaction account in Program.transactionList)
            {
                ListViewItem lvi = new ListViewItem(account.RentalFee.ToString());
                lvi.SubItems.Add(account.LateFee.ToString());
                lvi.SubItems.Add(account.MemberFee.ToString());
                lvi.SubItems.Add(account.Member._name.ToString());
                lvi.SubItems.Add(account.Member._surname.ToString());
                lvi.SubItems.Add(account.Member._id.ToString());
                listView1.Items.Add(lvi);
            }
        }
    }
}
