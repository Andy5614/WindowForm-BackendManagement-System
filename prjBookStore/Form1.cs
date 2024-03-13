using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjBookStore
{
    public partial class Form1 : Form
    {
        private Form _currentForm = null;
        public Form1()
        {
            InitializeComponent();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
        }

        //private void 募資活動ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FFundrasingcsMain f = new FFundrasingcsMain();
        //    f.MdiParent = this;
        //    f.WindowState = FormWindowState.Maximized;
        //    f.Show();
        //}

        //private void 優惠活動ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FEventcs f = new FEventcs();
        //    f.MdiParent = this;
        //    f.WindowState = FormWindowState.Maximized;
        //    f.Show();
 
        
        //}

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxMAx_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                
            }
        }

        private void pictureBoxCLOSE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void 編輯ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_currentForm != null)
            {
                _currentForm.Close();
            }

            FFundrasingcsMain f = new FFundrasingcsMain();
            //f.MdiParent = this;
            //f.WindowState = FormWindowState.Maximized;
            //f.Show();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(f);
            f.Show();
            _currentForm = f;
            //new RJcs().Open_DropdownMenu(rjDropdownMenu1, sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_currentForm != null)
            {
                _currentForm.Close();
            }
            FEventcs f = new FEventcs();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(f);
            f.Show();
            _currentForm = f;
            //new RJcs().Open_DropdownMenu(rjDropdownMenu1, sender);
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
