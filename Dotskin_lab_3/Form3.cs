using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dotskin_lab_3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form2 Main = this.Owner as Form2;
            if (textBox1.Text != "")
            {
                if (this.radioSec1.Checked == true)
                    Main.listBoxSection1.Items.Add(this.textBox1.Text);

                else Main.listBoxSection2.Items.Add(this.textBox1.Text);

                this.Close();

            }
        }
    }
}
