using prjBookStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjBookStore
{
    public class ViewRefresh<T> where T : class
    {
        public void refresh(DataGridView p) 
        {
            using (var db = new dbPlusNEntities()) 
            {
                var data = db.Set<T>().ToList();
                p.DataSource = data;
            }
        }
    }
}
