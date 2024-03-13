using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjBookStore
{
    public class RJcs
    {
         public void Open_DropdownMenu(RJDropdownMenu dropdownMenu, object sender)
        {
            Control control = (Control)sender;
            dropdownMenu.VisibleChanged += (sender2, ev) =>
            DropdownMenu_VisibleChanged(sender2, ev, control, dropdownMenu);
            dropdownMenu.Show(control, control.Width, 0);
        }

        public void DropdownMenu_VisibleChanged(object sender, EventArgs e, Control ctrl, RJDropdownMenu dropdownMenu)
        {
            if (!IsInDesignMode(ctrl))
            {
                if (dropdownMenu.Visible)
                {
                    ctrl.BackColor = Color.FromArgb(159, 161, 244);
                }
                else
                {
                    ctrl.BackColor = Color.FromArgb(98, 102, 244);
                }
            }

        }
        public bool IsInDesignMode(Control control)
        {
            return (control.Site != null) && control.Site.DesignMode;
        }
    }
}
