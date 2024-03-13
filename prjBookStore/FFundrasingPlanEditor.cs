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
using System.Xml.Linq;

namespace prjBookStore
{

    public partial class FFundrasingPlanEditor : Form
    {
        private int _fundrasingID;
        private DialogResult _isOk;
        public DialogResult confirm;
        private tFundrasingPlan _plan;
        public tFundrasingPlan Plan 
        {
            get 
            { 
                if (_plan == null)
                    _plan = new tFundrasingPlan();
                _plan.fPlanName = cPlanName.ColumValue;
                _plan.fPlanAmount = Convert.ToInt32(cPlanMoney.ColumValue);
                _plan.fPlanDescription = txtplan.Text;
                _plan.fFundrasingID = _fundrasingID;
                return _plan; 
            }
            set 
            { 
                _plan = value; 
                cPlanName.ColumValue = _plan.fPlanName;
                cPlanMoney.ColumValue = _plan.fPlanAmount.ToString();
                txtplan.Text = _plan.fPlanDescription;
            }
        } //plan的屬性
        public FFundrasingPlanEditor(int ID)
        {
            InitializeComponent();
            this._fundrasingID = ID;
        }//建構子及fundrasing PK

        private void FFundrasingPlanEditor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _isOk = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //新增按鍵
        {
            if (!isUiValidated())
                return;
            if (_fundrasingID<=0)
                return;
            //_isOk = DialogResult.OK;
            dbPlusNEntities db = new dbPlusNEntities();
            db.tFundrasingPlan.Add(Plan);
            db.SaveChanges();
            MessageBox.Show("資料新增成功");
            this.Close();
        }

        private bool isUiValidated() //資料填寫限制
        {
            string msg = "";
            if (string.IsNullOrEmpty(cPlanName.ColumnName)) //空白故為True
                msg += "\r\n計畫名稱不可空白";
            if (!IsNumber.isNumber(cPlanMoney.ColumValue))
                msg += "\r\n計畫金額不可空白，且需填入數字";
            if (!string.IsNullOrEmpty(msg))
                MessageBox.Show(msg);
            return msg == "";
        }
    }
}
