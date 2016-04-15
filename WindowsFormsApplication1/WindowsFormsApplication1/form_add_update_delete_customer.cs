using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class form_add_update_delete_customer : Form
    {
        public form_add_update_delete_customer()
        {
            InitializeComponent();
            Member.read_members();
            //AccountTransaction.ReadTransactionList();
            //AccountTransaction.ReadIndividualTransactionList();
            RefreshListView();  
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void customer_ID_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void customer_Contact_Number_Click(object sender, EventArgs e)
        {

        }

        private void add_update_delete_customer_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            //checks for all boxes filled
            ValidateForm();
            if (!IsValid)
            {
                MessageBox.Show("Please Fill All TextBoxes");
                return;
            }

            int id = int.Parse(textBoxCustomerID.Text);
            string name = textBoxCustomerFirstName.Text;
            string surname = textBoxCustomerSurname.Text;
            int phNumber = int.Parse(textBoxCustomerPNr.Text);
            string address = textBoxCustomerAddress.Text;
            string sID = id.ToString();
            string sPhNumber = phNumber.ToString();
            //Validating number inputs
            bool isValid = Regex.IsMatch(sID, @"^[0-9]+$");
            if (isValid == false)
            {
                MessageBox.Show("ID Should Be A Number With No Spaces");
                return;
            }
            bool isValid2 = Regex.IsMatch(sPhNumber, @"^[0-9]+$");
            if (isValid2 == false)
            {
                MessageBox.Show("Phone Number Should Be A Number With No Spaces");
                return;
            }

            Member entry = new Member(id, name, surname, address, phNumber, false);
            Program.memberList.Add(entry);
            Member.write_Member_To_File();

            AccountTransaction AC = new AccountTransaction(0, 0, 20, "", entry); //new Account created when member created.Member fee added
            Program.transactionList.Add(AC);
            AccountTransaction.WriteTransactionList();
            //individual transaction saved
            foreach (Member i in Program.memberList)
            {
                if (i._id == id)
                {
                    AccountTransaction individualTransaction = new AccountTransaction(0, 0, 20, "M", i);
                    Program.individualTransList.Add(individualTransaction);
                    AccountTransaction.writeIndividualTransactionList();
                }
            }
           RefreshListView();
            //Close();
            MessageBox.Show("New Customer Successfuly Added!");
            //Close();
           // ResetAllBoxes();
        }

        private void update_Details_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int selectedId = int.Parse(listView1.SelectedItems[0].Text);

                foreach (Member i in Program.memberList)
                {
                    if (i._id == selectedId)
                    {
                        i._name = textBoxCustomerFirstName.Text;
                        i._surname = textBoxCustomerSurname.Text;
                        i._address = textBoxCustomerAddress.Text;
                        i._phoneNr = int.Parse(textBoxCustomerPNr.Text);
                    }
                }
                Member.write_Member_To_File();
                RefreshListView();
                ResetAllBoxes();
            }
            else
                MessageBox.Show("....Please choose data in the table to edit....");
        }

        private void delete_Customer_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int selectedId = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                foreach (Member i in Program.memberList)
                {
                    if (i._id == selectedId)
                    {
                        Program.memberList.Remove(i);
                        break;
                    }
                }
                Member.write_Member_To_File();
                RefreshListView();
            }
            else
            {
                MessageBox.Show("You have to choose Member from the list first");
            }
        }

        

        private void return_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            Form staffMember = new form_staffMember();
            staffMember.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem member in listView1.SelectedItems)
            {
                textBoxCustomerID.Text = member.SubItems[0].Text;
                textBoxCustomerFirstName.Text = member.SubItems[1].Text;
                textBoxCustomerSurname.Text = member.SubItems[2].Text;
                textBoxCustomerPNr.Text = member.SubItems[4].Text;
                textBoxCustomerAddress.Text = member.SubItems[3].Text;
            }
        }

        private void textBoxCustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void generateID_Click(object sender, EventArgs e)
        {
            generateNewId();
        }

        public void generateNewId()
        {
            Random rID = new Random();
            int num = rID.Next(100, 999);
            textBoxCustomerID.Text = num.ToString();
            foreach (Member i in Program.memberList)
            {
                if (i._id != num)
                {
                    textBoxCustomerID.Text = num.ToString();
                }
                else
                    MessageBox.Show("!!!!AREADY EXISTS!!! Please generate another ID number....");
            }

        }
        //private void add_update_delete_customer_Load(object sender, EventArgs e)
        //{
        //    Member.write_Member_To_File();
        //}
        public void RefreshListView()
        {
            listView1.Items.Clear();
            listView1.BeginUpdate();
            foreach (Member i in Program.memberList)
            {
                ListViewItem lvi = new ListViewItem(i._id.ToString());
                lvi.SubItems.Add(i._name);
                lvi.SubItems.Add(i._surname);
                lvi.SubItems.Add(i._address);
                lvi.SubItems.Add(i._phoneNr.ToString());
                lvi.SubItems.Add(i.ISReserved.ToString()); ////lvi.SubItems.Add(gameLibrary.ISDamaged.ToString());
                listView1.Items.Add(lvi);
            }
            listView1.EndUpdate();
        }

        public bool IsValid
        {
            get;
            set;
        }
        private void ValidateForm()
        {
            Action<Control.ControlCollection> func = null;
            this.IsValid = true;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        if (String.IsNullOrWhiteSpace(control.Text))
                        {
                            this.IsValid = false;
                        }

                        else if (String.IsNullOrEmpty(control.Text))
                        {
                            this.IsValid = false;
                        }
                        else
                            func(control.Controls);
            };
            func(Controls);
        }
        public void ResetAllBoxes()
        {
            foreach (Control tBox in Controls)
            {
                if (tBox is TextBox)
                { tBox.Text = string.Empty; }
            }
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
             ResetAllBoxes();
        }
    }
}
