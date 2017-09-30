using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Absence
{
    public partial class gestion_stagiaires : UserControl
    {
        public gestion_stagiaires()
        {
            InitializeComponent();
        }

        private void Gestion_des_stagiaires_tab_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox2.Enabled = true;
                groupBox1.Enabled = false;
            }else if (radioButton2.Checked)
            {
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox2.Enabled = true;
                groupBox1.Enabled = false;
            }
            else if (radioButton2.Checked)
            {
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;
            }
        }
    }
}
