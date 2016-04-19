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
    public partial class formUpdateStaff : Form
    {




        public string fname
        {

            set { textBoxName.Text = value; }
        }
        public string sname
        {

            set { textBoxSurname.Text = value; }

        }



        public formUpdateStaff()
        {

            InitializeComponent();
            //   StoreAssistant.readAssistants(); 
            StoreAssistant.readAssistants();
            RefreshListView();
        }

        private void buttonGoBack_Click(object sender, EventArgs e) //go back to previous form
        {
            Close();
        }

        private void buttonAddNewStaff_Click(object sender, EventArgs e) //to make sura tha ID is unique
        {
            int id = int.Parse(textBoxId.Text);

            bool unique = true;
            foreach (StoreAssistant guy in Program.staffList)
            {
                if (guy._id == id)
                {
                    unique = false;
                }
            }

            if (unique == true)
            {
                string name = textBoxName.Text;
                string surname = textBoxSurname.Text;
                string address = textBoxAddress.Text;
                int phNumber = int.Parse(textBoxPhoneNr.Text);
                string password = textBoxPassword.Text;






                StoreAssistant newGuy = new StoreAssistant(id, name, surname, address, phNumber, password);
                Program.staffList.Add(newGuy);
                StoreAssistant.writeAssistants();

                MessageBox.Show("New Staff Successfuly Added!");
                RefreshListView();
                cleanBoxes();
            }


            else
                MessageBox.Show("This ID already exist. Create other one");
        }

        public void cleanBoxes() //clear text in all boxes
        {
            foreach (Control tBox in Controls)
            {
                if (tBox is TextBox)
                { tBox.Text = string.Empty; }
            }
        }



        public void RefreshListView() // refresh displayed items in the list
        {
            listView1.Items.Clear();
            listView1.BeginUpdate();
            foreach (StoreAssistant staff in Program.staffList)
            {
                ListViewItem lvi = new ListViewItem(staff._id.ToString());
                lvi.SubItems.Add(staff._name);
                lvi.SubItems.Add(staff._surname);
                lvi.SubItems.Add(staff._phoneNr.ToString("D1"));
                lvi.SubItems.Add(staff._address);

                lvi.SubItems.Add(staff._password);
                listView1.Items.Add(lvi);
            }
            listView1.EndUpdate();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) //to let choose row
        {
            foreach (ListViewItem staff in listView1.SelectedItems)
            {
                textBoxId.Text = staff.SubItems[0].Text;
                textBoxName.Text = staff.SubItems[1].Text;
                textBoxSurname.Text = staff.SubItems[2].Text;

                textBoxAddress.Text = staff.SubItems[3].Text;
                textBoxPhoneNr.Text = staff.SubItems[4].Text.ToString();



                textBoxName.ReadOnly = false;
                textBoxSurname.ReadOnly = false;
                textBoxAddress.ReadOnly = false;
                textBoxPhoneNr.ReadOnly = false;
                textBoxPassword.ReadOnly = false;




            }
        }



        private void formUpdateStaff_Load(object sender, EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdateStaff_Click(object sender, EventArgs e) //update details
        {

            foreach (StoreAssistant guy in Program.staffList)
            {
                if (guy._id == int.Parse(listView1.SelectedItems[0].SubItems[0].Text))
                {
                    //  guy._id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                    guy._name = textBoxName.Text;
                    guy._surname = textBoxSurname.Text;
                    guy._phoneNr = int.Parse(textBoxPhoneNr.Text);
                    guy._address = textBoxAddress.Text;
                    guy._password = textBoxPassword.Text;



                }

            }

            RefreshListView();
            StoreAssistant.writeAssistants();
            cleanBoxes();
        }

        //private void listView1_MouseClick(object sender, MouseEventArgs e) //click and get details from list to textboxes
        //{
        //    int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
        //    string name = listView1.SelectedItems[0].SubItems[1].Text;
        //    string surname = listView1.SelectedItems[0].SubItems[2].Text;
        //    string password = listView1.SelectedItems[0].SubItems[5].Text;
        //    string address = listView1.SelectedItems[0].SubItems[4].Text;
        //    int phone = int.Parse(listView1.SelectedItems[0].SubItems[3].Text);
        //    // textBoxId.Text = id.ToString();
        //    textBoxName.Text = name;
        //    textBoxSurname.Text = surname;
        //    textBoxPhoneNr.Text = phone.ToString();
        //    textBoxAddress.Text = address;
        //    textBoxPassword.Text = password;


        //}

        private void button1_Click(object sender, EventArgs e) // DELETE SELECTED RECORD
        {


            if (listView1.SelectedItems.Count > 0)
            {
                int IdToDelete = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                foreach (StoreAssistant staff in Program.staffList)
                {
                    if (staff._id == IdToDelete)
                    {
                        Program.staffList.Remove(staff);
                        break;
                    }
                }
                StoreAssistant.writeAssistants();
                RefreshListView();
                MessageBox.Show("REcord has been deleted!");
                cleanBoxes();
            }
            else
            {
                MessageBox.Show("Click on one of the records first");
            }


        }

        private void buttonClearStaffForm_Click(object sender, EventArgs e)
        {
            cleanBoxes();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           


        }

        private void buttonGenerateId_Click(object sender, EventArgs e)
        {
            Random randomNr = new Random();
            int nr = randomNr.Next(100, 100000);
            textBoxId.Text = nr.ToString();
            foreach (StoreAssistant guy in Program.staffList)
            {
                if (guy._id != nr)
                {
                    textBoxId.Text = nr.ToString();
                }
                else
                    MessageBox.Show(" This ID already EXIST! Please regenerate new ID !");
            }





        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string name = listView1.SelectedItems[0].SubItems[1].Text;
            string surname = listView1.SelectedItems[0].SubItems[2].Text;
            string password = listView1.SelectedItems[0].SubItems[5].Text;
            string address = listView1.SelectedItems[0].SubItems[4].Text;
            int phone = int.Parse(listView1.SelectedItems[0].SubItems[3].Text);
            // textBoxId.Text = id.ToString();
            textBoxName.Text = name;
            textBoxSurname.Text = surname;
            textBoxPhoneNr.Text = phone.ToString("D1");
            textBoxAddress.Text = address;
            textBoxPassword.Text = password;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idToFind = int.Parse(textBoxFindById.Text);
            listView1.Items.Clear();
            listView1.BeginUpdate();
            bool isFound = false;
            foreach (StoreAssistant staff in Program.staffList)
            {
                if (idToFind == staff._id)
                {
                    ListViewItem lvi = new ListViewItem(staff._id.ToString());
                    lvi.SubItems.Add(staff._name);
                    lvi.SubItems.Add(staff._surname);
                    lvi.SubItems.Add(staff._phoneNr.ToString());
                    lvi.SubItems.Add(staff._address);

                    lvi.SubItems.Add(staff._password);
                    listView1.Items.Add(lvi);
                    isFound = true;
                }
            }
           

            if (!isFound)
            {
                MessageBox.Show(" Staff Member with this ID DOES NOT EXIST !");
            }
 listView1.EndUpdate();
         
        }

        private void buttonDisplayAll_Click(object sender, EventArgs e)
        {
            cleanBoxes();
            RefreshListView();
        }
    }
}