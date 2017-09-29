using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Absence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int statu;
        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.ItemSize = new Size(tabControl1.Width / 2 -1, tabControl1.ItemSize.Height);
            
            mini_logo.Visible = false;
            statu = 0;
            
        }
        private void Close_pictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Maximise_pictureBox_Click(object sender, EventArgs e)
        {
            if (statu == 0)
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                Left = Top = 0;
                Width = Screen.PrimaryScreen.WorkingArea.Width;
                Height = Screen.PrimaryScreen.WorkingArea.Height;
                statu = 1;
                Maximise_pictureBox.Location = new Point(Maximise_pictureBox.Location.X + 410, Maximise_pictureBox.Location.Y);
                Close_pictureBox.Location = new Point(Close_pictureBox.Location.X + 410, Close_pictureBox.Location.Y);
                Minimise_pictureBox.Location = new Point(Minimise_pictureBox.Location.X + 410, Minimise_pictureBox.Location.Y);
                tabControl1.ItemSize = new Size(tabControl1.Width / 2 - 1, tabControl1.ItemSize.Height);
            }
            else
            {
                Maximise_pictureBox.Location = new Point(892, Maximise_pictureBox.Location.Y);
                Minimise_pictureBox.Location = new Point(855, Minimise_pictureBox.Location.Y);
                Close_pictureBox.Location = new Point(924, Close_pictureBox.Location.Y);
                this.Width = 958;
                this.Height = 631;
                this.CenterToScreen();
                tabControl1.ItemSize = new Size(tabControl1.Width / 2 - 1, tabControl1.ItemSize.Height);
                statu = 0;
            }
        }

        private void Humbutton_Click(object sender, EventArgs e)
        {
            if (Tree_Menu_panel.Width > 63)
            {
                timer1.Start();
                Tree_Menu_panel_animator.HideSync(Logo_PictureBox);
                Logo_PictureBox.Visible = false;
                mini_logo.Location = new Point(12, 34);
                mini_logo.Visible = true;
            }
            else
            {
                timer2.Start();
                mini_logo.Visible = false;
                Logo_PictureBox.Visible = false;
                logo_animator.ShowSync(Logo_PictureBox,false,null);
            }
        }


        private void Header_Panel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (statu == 0)
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                Left = Top = 0;
                Width = Screen.PrimaryScreen.WorkingArea.Width;
                Height = Screen.PrimaryScreen.WorkingArea.Height;
                statu = 1;
                Maximise_pictureBox.Location = new Point(Maximise_pictureBox.Location.X + 410, Maximise_pictureBox.Location.Y);
                Close_pictureBox.Location = new Point(Close_pictureBox.Location.X + 410, Close_pictureBox.Location.Y);
                Minimise_pictureBox.Location = new Point(Minimise_pictureBox.Location.X + 410, Minimise_pictureBox.Location.Y);
                tabControl1.ItemSize = new Size(tabControl1.Width / 2 - 1, tabControl1.ItemSize.Height);
            }
            else
            {
                Maximise_pictureBox.Location = new Point(892, Maximise_pictureBox.Location.Y);
                Minimise_pictureBox.Location = new Point(855, Minimise_pictureBox.Location.Y);
                Close_pictureBox.Location = new Point(924, Close_pictureBox.Location.Y);
                this.Width = 958;
                this.Height = 631;
                this.CenterToScreen();
                tabControl1.ItemSize = new Size(tabControl1.Width / 2 - 1, tabControl1.ItemSize.Height);

                statu = 0;
            }

        }

        private void Minimise_pictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Tree_Menu_panel.Width < 256)
            {
                Tree_Menu_panel.Width += 20;
                timer2.Start();
                tabControl1.ItemSize = new Size(tabControl1.Width / 2 - 1, tabControl1.ItemSize.Height);
            }
            else
            {
                timer2.Stop();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Tree_Menu_panel.Width > 63)
            {
                Tree_Menu_panel.Width -= 20;
                tabControl1.ItemSize = new Size(tabControl1.Width / 2 - 1, tabControl1.ItemSize.Height);
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }
        

        private void Gestion_des_stagiaires_tab_Click(object sender, EventArgs e)
        {

        }

        private void btn_stat_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_stagi_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
        }
    }
}
