using prjBookStore.Model;
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
    public partial class FDiscountEditor : Form
    {

        private int _EventID; //傳入的Event pK
        private DialogResult _isOk;
        public DialogResult confirm
        {
            get { return _isOk; }
        }
        private tDiscount _discount;
        public tDiscount Discount
        {
            get
            {
                if (_discount == null)
                    _discount = new tDiscount();
                _discount.fDiscountName = CDiscountName.ColumValue;
                _discount.fDiscountPercentage = (Convert.ToDecimal(CDiscountPercentage.ColumValue)) / 100;
                _discount.fEventID = _EventID;
                return _discount;
            }
        }
        public FDiscountEditor(int i)
        {
            InitializeComponent();
            _EventID = i;
           
        }

        private void FDiscount_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)  //新增按鈕
        {
            if (!isUiValidated())
                return;
            _isOk = DialogResult.OK;
            this.Close();
        }

        private bool isUiValidated()//防呆
        {
            string msg = "";
            if (string.IsNullOrEmpty(CDiscountName.ColumValue))
                msg += "\r\n折扣名稱不可空白";
            if (string.IsNullOrEmpty(CDiscountPercentage.ColumValue))
                msg += "\r\n折扣比例不可空白";

            if (!string.IsNullOrEmpty(msg))
                MessageBox.Show(msg);
            return msg == "";
        }

        private void Btncancle_Click(object sender, EventArgs e) //取消按鈕
        {
            _isOk = DialogResult.Cancel;
            this.Close();
        }
    }
}
