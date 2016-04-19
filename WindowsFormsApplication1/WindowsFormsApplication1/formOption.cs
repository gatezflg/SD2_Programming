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
    public partial class formOption : Form
    {
        public formOption()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_staffMember form = new form_staffMember();
            form.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            managerView form = new managerView();
            form.ShowDialog();
            this.Close();
        }

        private void formOption_Load(object sender, EventArgs e)
        {

        }
    }
}
