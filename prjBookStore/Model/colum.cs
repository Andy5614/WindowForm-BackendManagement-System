using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjBookStore.Model
{
    public partial class colum : UserControl
    {
        public colum()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public string ColumnName
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public string ColumValue
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
           
    }
}
