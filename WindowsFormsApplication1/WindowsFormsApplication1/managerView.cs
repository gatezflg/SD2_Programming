using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApplication1
{
    public partial class managerView : Form
    {

        public managerView()
        {

           

            //FileInfo aFile = new FileInfo("staff.bin");
            //if (aFile.Exists)
            //{
            //    BinaryFormatter bformatter = new BinaryFormatter();
            //    FileStream staffFile = new FileStream("staff.bin", FileMode.Open, FileAccess.Read);
            //    Program.staffList = bformatter.Deserialize(staffFile) as ArrayList;
            //    staffFile.Close();
            //}
            InitializeComponent();
        }

        private void Update_Staff_click(object sender, EventArgs e)
        {
            formUpdateStaff form = new formUpdateStaff();
            form.Show();
            this.Hide();


         
        }

        private void managerView_Load(object sender, EventArgs e)
        {

        }

        private void managerView_Load_1(object sender, EventArgs e)
        {

        }

        

        private void managerView_Load_2(object sender, EventArgs e)
        {

        }

        
    }
}
