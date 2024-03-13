using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjBookStore
{
    internal class CSStyle
    {
        public static void restGridRowColor(DataGridView grd)
        {
            grd.Columns[0].Width = 70;
            bool isColoChanged = true;
            foreach (DataGridViewRow r in grd.Rows)
            {
                isColoChanged = !isColoChanged;
                r.DefaultCellStyle.BackColor = Color.FromArgb(165, 210, 169);
                if (isColoChanged)
                    r.DefaultCellStyle.BackColor = Color.FromArgb(239, 250, 252);
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 14);
                r.Height = 40;
            }
        
        }
    }
}
