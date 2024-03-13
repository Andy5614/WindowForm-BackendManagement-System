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
    public partial class FFundrasingAndPlanEditor : Form
    {
        private int _fundrasingID;
        private tFundrasingPlan _currentPlan; //計畫的物件屬性
        private dbPlusNEntities _db; //計畫的資料庫
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
                cCurrentmoney.ColumValue =_fundrasing.fCurrentAmount.ToString();
                txtcontent.Text=_fundrasing.fFundraisingDescription.ToString();
                _fundrasingID = fundrasing.fFundrasingID;
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
                _fundrasingPlan.fPlanAmount = Convert.ToDecimal(cPlanMoney.ColumValue);
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
        public FFundrasingAndPlanEditor(int p)
        {
            InitializeComponent();
            _fundrasingID = p;

        }//傳入fundrasingID

        private void colum3_Load(object sender, EventArgs e)
        {

        }

        private void colum2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) 
        {
            FFundrasingPlanEditor f = new FFundrasingPlanEditor(_fundrasingID);
            f.ShowDialog();
            refresh();
        }//新增計畫按鈕

        private void FFundrasingEditor_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh() //更新左右畫面
        {
            dbPlusNEntities db = new dbPlusNEntities();
            var data = from d in db.tFundrasing
                       where d.fFundrasingID == _fundrasingID
                       select new
                       {
                           募資專案編號 =  d.fFundrasingID,
                           募資專案名稱 =  d.fEventName,
                           募資專案內容 =  d.fFundraisingDescription,
                           目標金額 = (int)fundrasing.fFundrasingGoal,
                           當前金額 = (int)fundrasing.fCurrentAmount,
                           開始日期 = fundrasing.fStartdate,
                           結束日期 = fundrasing.fEnddate,
                       };
            dataGridView2.DataSource = data.ToList();

            var plan = from p in db.tFundrasingPlan
                       where p.fFundrasingID == _fundrasingID
                       select new
                       {
                           計畫編號 = p.fPlanID,
                           計畫名稱 = p.fPlanName,
                           計畫內容 = p.fPlanAmount,
                           計畫金額 = p.fPlanDescription
                       };
            dataGridView1.DataSource = plan.ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (_fundrasing == null)
                _fundrasing = new tFundrasing();
            _fundrasing.fStartdate = dateTimePicker1.Value;
        }//取得開始時間

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (_fundrasing == null)
                _fundrasing = new tFundrasing();
            _fundrasing.fEnddate = dateTimePicker2.Value;
        }//取得結束時間

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

          
        }

        private void button1_Click(object sender, EventArgs e)//取消按鈕
        {
            _isOk = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //修改募資活動
        {
            if (!isUiValidated())
                return;
            //_isOk = DialogResult.OK;

            dbPlusNEntities db = new dbPlusNEntities();
            tFundrasing fund = db.tFundrasing.FirstOrDefault(p => p.fFundrasingID == _fundrasingID);
            if (fund == null)
                return;
            fund.fEventName = fundrasing.fEventName;
            fund.fFundrasingGoal = fundrasing.fFundrasingGoal;
            fund.fCurrentAmount = fundrasing.fCurrentAmount;
            fund.fFundraisingDescription = fundrasing.fFundraisingDescription;
            fund.fStartdate = _fundrasing.fStartdate;
            fund.fEnddate= _fundrasing.fEnddate;
            db.SaveChanges();
            refresh();
            MessageBox.Show("修改成功");
        }

        private bool isUiValidated()//募資活動防呆
        {
            string msg = "";
            if (string.IsNullOrEmpty(cName.ColumValue)) //空白故為True
                msg += "\r\n活動名稱不可空白";
            if (!IsNumber.isNumber(cMoney.ColumValue)) 
                msg += "\r\n募款目標金額不可空白，且需填入數字";
            if (!string.IsNullOrEmpty(msg))
                MessageBox.Show(msg);
            return msg == "";
        } 

        private void cEnd_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) //修改計畫
        {
            if (!isUiValidatedplan())
                return;
            if (_currentPlan == null)
                return;
            _currentPlan.fPlanName = cPlanName.ColumValue;
            _currentPlan.fPlanAmount = Convert.ToDecimal(cPlanMoney.ColumValue);
            _currentPlan.fPlanDescription = txtplan.Text;
            _db.SaveChanges();
            MessageBox.Show("修改成功");
            refresh();
        }

        private bool isUiValidatedplan()//修改計畫防呆
        {
            string msg = "";
            if (string.IsNullOrEmpty(cPlanName.ColumValue)) //空白故為True
                msg += "\r\n計畫名稱不可空白";
            if (!IsNumber.isNumber(cPlanMoney.ColumValue))
                msg += "\r\n計畫金額不可空白，且需填入數字";
            if (!string.IsNullOrEmpty(msg))
                MessageBox.Show(msg);
            return msg == "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //將dataGridView(計畫)中資料顯示在欄位上
        {
            if (dataGridView1.CurrentRow == null)
                return;
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(id))
                return;
            int fPlanID = Convert.ToInt32(id);
            _db = new dbPlusNEntities();
            _currentPlan = _db.tFundrasingPlan.FirstOrDefault(p => p.fPlanID == fPlanID);
            if (_currentPlan == null)
                return;
            cPlanName.ColumValue = _currentPlan.fPlanName;
            cPlanMoney.ColumValue = _currentPlan.fPlanAmount.ToString();
            txtplan.Text = _currentPlan.fPlanDescription;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _isOk = DialogResult.Cancel;
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e) //刪除計畫
        {
            if (dataGridView1.CurrentCell == null)
                return;
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(id))
                return;
            if (MessageBox.Show("確定要刪除該筆資料嗎?", "確認", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            int fid = Convert.ToInt32(id);
            dbPlusNEntities db = new dbPlusNEntities();
            tFundrasingPlan plan = db.tFundrasingPlan.FirstOrDefault(p => p.fPlanID == fid);
            if (plan == null)
                return;
            db.tFundrasingPlan.Remove(plan);
            db.SaveChanges();
            refresh();
        }
    }
}
