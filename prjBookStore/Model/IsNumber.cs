using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBookStore.Model
{
    public class IsNumber //判斷是否輸入為int
    {
        public static bool isNumber(string p)
        {
            try
            {
                double d = Convert.ToDouble(p);
                return true;
            }
            catch { return false; }
        }
    }
}
