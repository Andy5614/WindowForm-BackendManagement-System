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
    public partial class FFundrasingAndPlanADD : Form
    {

        private DialogResult _isOk;
        public DialogResult confirm
        {
            get { return _isOk; }
        }

        private tFundrasing _fundrasing;
        public tFundrasing fundrasing
        {
            
            get
            {
                if (_fundrasing == null)
                    _fundrasing = new tFundrasing();
                _fundrasing.fEventName = cName.ColumValue;
                _fundrasing.fFundrasingGoal = Convert.ToDecimal(cMoney.ColumValue);
                _fundrasing.fCurrentAmount = Convert.ToDecimal(cCurrentmoney.ColumValue);
                _fundrasing.fFundraisingDescription = txtcontent.Text;
                return _fundrasing;
            }
            set
            {
                _fundrasing = value;
                cName.ColumValue = _fundrasing.fEventName;
                cMoney.ColumValue = _fundrasing.fFundrasingGoal.ToString();
                cCurrentmoney.ColumValue = _fundrasing.fCurrentAmount.ToString();
                txtcontent.Text = _fundrasing.fFundraisingDescription.ToString();
            }
        }//fundrasing屬性

        private tFundrasingPlan _fundrasingPlan;
        public tFundrasingPlan fundrasingPlan
        {
            get 
            { 
                if (_fundrasingPlan == null)
                    _fundrasingPlan = new tFundrasingPlan();
                _fundrasingPlan.fPlanName = cPlanName.ColumValue;
                _fundrasingPlan.fPlanAmount = Convert.ToInt32(cPlanMoney.ColumValue);
                _fundrasingPlan.fPlanDescription = txtplan.Text;
                return _fundrasingPlan; 
            }
            set 
            { 
                _fundrasingPlan = value;
                cPlanName.ColumValue = _fundrasingPlan.fPlanName;
                cPlanMoney.ColumValue = _fundrasingPlan.fPlanAmount.ToString();
                txtplan.Text = _fundrasingPlan.fPlanDescription;
            }
        } //fundrasingPlan屬性
        public FFundrasingAndPlanADD()
        {
            InitializeComponent();
        }

        private void FFundrasingFundrasingPlanEditor_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) //拿開始時間
        {
            if (_fundrasing == null)
                _fundrasing = new tFundrasing();
            _fundrasing.fStartdate = dateTimePicker1.Value;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) //拿結束時間
        {
            if (_fundrasing == null)
                _fundrasing = new tFundrasing();
            _fundrasing.fEnddate = dateTimePicker2.Value;
        }

        private void button2_Click(object sender, EventArgs e)  //確定按鈕
        {
            if (!isUiValidated())
                return;
            _isOk = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)  //取消按鈕
        {
            _isOk = DialogResult.Cancel;
            this.Close();
        }
        private bool isUiValidated()  //欄位條件設定
        {
            string msg = "";
            if (string.IsNullOrEmpty(cName.ColumValue)) 
                msg += "\r\n募資名稱不可空白";
            if (string.IsNullOrEmpty(cPlanName.ColumValue))
                msg += "\r\n計畫名稱不可空白";
            if (!IsNumber.isNumber(cMoney.ColumValue))
                msg += "\r\n募資金額不可空白，且需填入數字";
            if (!IsNumber.isNumber(cPlanMoney.ColumValue))
                msg += "\r\n計畫金額不可空白，且需填入數字";
            if (Convert.ToInt32(cPlanMoney.ColumValue)> Convert.ToInt32(cMoney.ColumValue))
                msg += "\r\n計畫金額不可大於募資金額";

            if (!string.IsNullOrEmpty(msg))
                MessageBox.Show(msg);
            return msg == "";
        }

        private void cStart_Load(object sender, EventArgs e)
        {

        }
    }
}
