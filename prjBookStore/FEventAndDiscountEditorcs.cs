using prjBookStore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjBookStore
{
    public partial class FEventAndDiscountEditorcs : Form
    {
        private DialogResult _isOk;
        private dbPlusNEntities _db;
        private tDiscount _currentDiscount;
        private int _EventID;
        private int _DiscountID;
        private tEvent _event;
        public tEvent Event
        {
            get
            {
                if (_event == null)
                    _event = new tEvent();
                _event.fEventName = CEventName.ColumValue;
                _event.fEventDescription = txtcontent.Text;
                _event.fEventType = CEventtype.ColumValue;
                return _event;
            }
            set
            {
                _event = value;
                CEventName.ColumValue = _event.fEventName;
                txtcontent.Text = _event.fEventDescription;
                CEventtype.ColumValue = _event.fEventType;
            }
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
            set 
            {
                _discount = value;
                CDiscountName.ColumValue = _discount.fDiscountName;
                CDiscountPercentage.ColumValue = (_discount.fDiscountPercentage*100).ToString() + "%";
            }
        }
        public FEventAndDiscountEditorcs(int i)
        {
            InitializeComponent();
            _EventID = i;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void colum6_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) //折扣顯示欄位
        {
            if (dataGridView2.CurrentRow == null)
                return;
            string id = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(id))
                return;

            _DiscountID = Convert.ToInt32(id);
            _db = new dbPlusNEntities();
            _currentDiscount = _db.tDiscount.FirstOrDefault(p => p.fDiscountID == _DiscountID);
            if (_currentDiscount == null)
                return;
            CDiscountName.ColumValue = _currentDiscount.fDiscountName;
            CDiscountPercentage.ColumValue = (Math.Round((double)_currentDiscount.fDiscountPercentage * 100, 2).ToString() + "%");
        }



        private void FEventAndDiscountEditorcs_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh() //更新左右畫面
        {
            dbPlusNEntities db = new dbPlusNEntities();
            var data = from d in db.tEvent
                       where d.fEventID == _EventID
                       select new
                       {
                           活動名稱 = d.fEventName,
                           活動類型 = d.fEventType,
                           活動內容 = d.fEventDescription,
                           開始時間 = d.fStratdate,
                           結束時間 = d.fEnddate,
                       };
            dataGridView1.DataSource = data.ToList();

            var plan = from p in db.tDiscount
                       where p.fEventID == _EventID
                       select new
                       {
                           折扣編號 = p.fDiscountID,
                           折扣名稱 = p.fDiscountName,
                           折扣優惠 = (Math.Round((double)p.fDiscountPercentage * 100, 2).ToString() + "%")
                       };
            dataGridView2.DataSource = plan.ToList();
        }

        private void StartTimePicker_ValueChanged(object sender, EventArgs e) //取得開始時間
        {
            if (_event == null)
                _event = new tEvent();
            _event.fStratdate = StartTimePicker.Value;

        }

        private void colum3_Load(object sender, EventArgs e)
        {

        }

        private void EndDateTimePicker_ValueChanged(object sender, EventArgs e) //取得結束時間
        {
            if (_event == null)
                _event = new tEvent();
            _event.fEnddate = EndDateTimePicker.Value;
        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            _isOk = DialogResult.Cancel;
            this.Close();
        }

        private void BtnUpdateButton_Click(object sender, EventArgs e) //修改活動
        {
            if (!isUiValidated())
                return;
            dbPlusNEntities db = new dbPlusNEntities();
            tEvent E = db.tEvent.FirstOrDefault(p => p.fEventID == _EventID);
            if (E == null)
                return;
            E.fEventName = Event.fEventName;
            E.fEventType = Event.fEventType;
            E.fEventDescription = Event.fEventDescription;
            E.fStratdate = Event.fStratdate;
            E.fEnddate = Event.fEnddate;
            db.SaveChanges();
            refresh();
            MessageBox.Show("修改成功");
        }
        private bool isUiValidated()
        {
            string msg = "";
            if (string.IsNullOrEmpty(CEventName.ColumValue))
                msg += "\r\n活動名稱不可空白";
            if (string.IsNullOrEmpty(CEventtype.ColumValue))
                msg += "\r\n活動類型不可空白";

            if (!string.IsNullOrEmpty(msg))
                MessageBox.Show(msg);
            return msg == "";
        } //修改活動防呆

        private void BtnUpdate_Click(object sender, EventArgs e) //修改折扣
        {
            if (!isDiscountUiValidated())
                return;
            dbPlusNEntities db = new dbPlusNEntities();
            tDiscount D = db.tDiscount.FirstOrDefault(p => p.fDiscountID == _DiscountID);
            if (D == null)
                return;
            D.fDiscountName = Discount.fDiscountName;
            D.fDiscountPercentage = Convert.ToDecimal(Discount.fDiscountPercentage);
            db.SaveChanges();
            refresh();
            MessageBox.Show("修改成功");
        }

        private bool isDiscountUiValidated() //修改折扣防呆
        {
            string msg = "";
            if (string.IsNullOrEmpty(CDiscountName.ColumValue))
                msg += "\r\n折扣名稱不可空白";
            if (!IsNumber.isNumber(CDiscountPercentage.ColumValue))
                msg += "\r\n折扣比例不可空白，且需為數字";

            if (!string.IsNullOrEmpty(msg))
                MessageBox.Show(msg);
            return msg == "";
        }

        private void BtnCancleClick_Click(object sender, EventArgs e)
        {
            _isOk = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) //刪除折扣
        {
            if (dataGridView1.CurrentCell == null)
                return;
            string id = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(id))
                return;
            if (MessageBox.Show("確定要刪除該筆資料嗎?", "確認", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            int fid = Convert.ToInt32(id);
            dbPlusNEntities db = new dbPlusNEntities();
            tDiscount Discount = db.tDiscount.FirstOrDefault(p => p.fDiscountID == fid);
            if (Discount == null)
                return;
            db.tDiscount.Remove(Discount);
            db.SaveChanges();
            refresh();
        }
    }
    
}
