using prjBookStore.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace prjBookStore
{
    public partial class FFundrasingcsMain : Form
    {
        public FFundrasingcsMain()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FFundrasingcs_Load(object sender, EventArgs e) //載入視窗
        {
            refresh();

        }

        private void refresh()  //更新畫面
        {
            dbPlusNEntities db = new dbPlusNEntities();
            var query = from fundrasing in db.tFundrasing
                        join plan in db.tFundrasingPlan
                        on fundrasing.fFundrasingID equals plan.fFundrasingID into plans
                        from plan in plans.DefaultIfEmpty()  //DefaultIfEmpty() 方法返回一個包含單個元素（默認值）的集合
                        select new
                        {
                            募資專案編號 = fundrasing.fFundrasingID,
                            募資專案名稱 = fundrasing.fEventName,
                            募資專案內容 = fundrasing.fFundraisingDescription,
                            目標金額 = (int)fundrasing.fFundrasingGoal,
                            當前金額 = (int)fundrasing.fCurrentAmount,
                            開始日期 = fundrasing.fStartdate,
                            結束日期 = fundrasing.fEnddate,
                            計畫名稱 = plan != null ? plan.fPlanName : null,
                            計畫內容 = plan != null ? plan.fPlanDescription : null,
                            計畫金額 = plan != null ? (int)plan.fPlanAmount : (decimal?)null,
                        };
            dataGridView1.DataSource = query.ToList();
            dataGridView1.DataBindingComplete += (sender, e) =>
            {
                CSStyle.restGridRowColor(dataGridView1);  // 在DataBindingComplete事件中設置顏色
            };
            //var ID = from fundrasing in db.tFundrasing
            //         join plan in db.tFundrasingPlan
            //         on fundrasing.fFundrasingID equals plan.fFundrasingID into plans
            //         from plan in plans.DefaultIfEmpty()  //DefaultIfEmpty() 方法返回一個包含單個元素（默認值）的集合
            //         select new
            //         {
            //             募資專案編號=fundrasing.fFundrasingID,
            //         }
            //var IDList = ID.ToList();
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{

            //        dataGridView1.Rows[i].Tag = IDList[i].募資專案編號;

            //}

        }

        private void toolStripButton4_Click(object sender, EventArgs e) //新增按鈕
        {
            FFundrasingAndPlanADD f = new FFundrasingAndPlanADD();
            f.ShowDialog();
            if (f.confirm == DialogResult.OK)
            {
                dbPlusNEntities db = new dbPlusNEntities();
                db.tFundrasing.Add(f.fundrasing);
                db.SaveChanges();

                int newFundrasingID = f.fundrasing.fFundrasingID;
                f.fundrasingPlan.fFundrasingID = newFundrasingID;

                db.tFundrasingPlan.Add(f.fundrasingPlan);
                db.SaveChanges();
                MessageBox.Show("新增成功");
                refresh();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e) //編輯按鈕(開啟編輯視窗)
        {
            if (dataGridView1.CurrentRow == null)
                return;
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(id))
                return;
            int fFundrasingID = Convert.ToInt32(id);
            dbPlusNEntities db = new dbPlusNEntities();
            tFundrasing fund = db.tFundrasing.FirstOrDefault(p => p.fFundrasingID == fFundrasingID);
            if (fund == null)
                return;
            FFundrasingAndPlanEditor f = new FFundrasingAndPlanEditor(fFundrasingID);  //把 ID傳入編輯視窗
            f.fundrasing = fund;
            f.ShowDialog();
            refresh();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)//刪除按鈕
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
            tFundrasing fund = db.tFundrasing.FirstOrDefault(p => p.fFundrasingID == fid);
            if (fund == null)
                return;
            var plans = db.tFundrasingPlan.Where(plan => plan.fFundrasingID == fid).ToList();  //先刪除外部連結
            foreach (var plan in plans)
            {
                db.tFundrasingPlan.Remove(plan);
            }
            db.tFundrasing.Remove(fund);
            db.SaveChanges();
            refresh();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)//查詢按鈕
        {
            dbPlusNEntities db = new dbPlusNEntities();

            DateTime date;
            bool isDateValid = DateTime.TryParse(textBox1.Text, out date); //判斷輸入的文字是否為datetime type

            Decimal money;
            bool isDecimalValid = Decimal.TryParse(textBox1.Text, out money); //判斷輸入的文字是否為Decimal type

            var query = from fundrasing in db.tFundrasing
                        join plan in db.tFundrasingPlan
                        on fundrasing.fFundrasingID equals plan.fFundrasingID into plans
                        from plan in plans.DefaultIfEmpty()

                        where fundrasing.fEventName.Contains(textBox1.Text) ||
                        fundrasing.fFundraisingDescription.Contains(textBox1.Text) ||
                        (isDateValid && (fundrasing.fStartdate == date || fundrasing.fEnddate == date)) ||
                        (isDecimalValid && (fundrasing.fCurrentAmount == money || fundrasing.fFundrasingGoal == money))


                        select new
                        {
                            募資專案編號 = fundrasing.fFundrasingID,
                            募資專案名稱 = fundrasing.fEventName,
                            募資專案內容 = fundrasing.fFundraisingDescription,
                            目標金額 = (int)fundrasing.fFundrasingGoal,
                            當前金額 = (int)fundrasing.fCurrentAmount,
                            開始日期 = fundrasing.fStartdate,
                            結束日期 = fundrasing.fEnddate,
                            計畫名稱 = plan != null ? plan.fPlanName : null,
                            計畫內容 = plan != null ? plan.fPlanDescription : null,
                            計畫金額 = plan != null ? (int)plan.fPlanAmount : (decimal?)null,
                        };
            dataGridView1.DataSource = query.ToList();

        }

        private void 會員與募資計畫報表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //先將對應的資料存入report變數
            using (dbPlusNEntities db = new dbPlusNEntities())
            {
                var report = db.tMember
                    .Select(member => new
                    {
                        MemberID = member.fMemberId,
                        MemberName = member.fName,
                        FundraisingPlans = member.tFundrasingPlan
                            .Select(plan => plan.fPlanName)
                            .ToList()
                    })
                    .ToList();

                // 處理 FundraisingPlans 的顯示格式
                var formattedReport = new List<dynamic>();

                foreach (var item in report)
                {
                    foreach (var plan in item.FundraisingPlans)
                    {
                        var newRow = new
                        {
                            item.MemberID,
                            item.MemberName,
                            fPlanName = plan
                        };

                        formattedReport.Add(newRow);
                    }
                }

                dataGridView1.DataSource = formattedReport;
            }
        }

        private void 查詢ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FFundrasingAndPlanADD f = new FFundrasingAndPlanADD();
            f.ShowDialog();
            if (f.confirm == DialogResult.OK)
            {
                dbPlusNEntities db = new dbPlusNEntities();
                db.tFundrasing.Add(f.fundrasing);
                db.SaveChanges();

                int newFundrasingID = f.fundrasing.fFundrasingID;
                f.fundrasingPlan.fFundrasingID = newFundrasingID;

                db.tFundrasingPlan.Add(f.fundrasingPlan);
                db.SaveChanges();
                MessageBox.Show("新增成功");
                refresh();
            }
        }

        private void 編輯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(id))
                return;
            int fFundrasingID = Convert.ToInt32(id);
            dbPlusNEntities db = new dbPlusNEntities();
            tFundrasing fund = db.tFundrasing.FirstOrDefault(p => p.fFundrasingID == fFundrasingID);
            if (fund == null)
                return;
            FFundrasingAndPlanEditor f = new FFundrasingAndPlanEditor(fFundrasingID);  //把 ID傳入編輯視窗
            f.fundrasing = fund;
            f.ShowDialog();
            refresh();
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
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
            tFundrasing fund = db.tFundrasing.FirstOrDefault(p => p.fFundrasingID == fid);
            if (fund == null)
                return;
            var plans = db.tFundrasingPlan.Where(plan => plan.fFundrasingID == fid).ToList();  //先刪除外部連結
            foreach (var plan in plans)
            {
                db.tFundrasingPlan.Remove(plan);
            }
            db.tFundrasing.Remove(fund);
            db.SaveChanges();
            refresh();
        }

        private void 查詢ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dbPlusNEntities db = new dbPlusNEntities();

            DateTime date;
            bool isDateValid = DateTime.TryParse(textBox1.Text, out date); //判斷輸入的文字是否為datetime type

            Decimal money;
            bool isDecimalValid = Decimal.TryParse(textBox1.Text, out money); //判斷輸入的文字是否為Decimal type

            var query = from fundrasing in db.tFundrasing
                        join plan in db.tFundrasingPlan
                        on fundrasing.fFundrasingID equals plan.fFundrasingID into plans
                        from plan in plans.DefaultIfEmpty()

                        where fundrasing.fEventName.Contains(textBox1.Text) ||
                        fundrasing.fFundraisingDescription.Contains(textBox1.Text) ||
                        (isDateValid && (fundrasing.fStartdate == date || fundrasing.fEnddate == date)) ||
                        (isDecimalValid && (fundrasing.fCurrentAmount == money || fundrasing.fFundrasingGoal == money))


                        select new
                        {
                            募資專案編號 = fundrasing.fFundrasingID,
                            募資專案名稱 = fundrasing.fEventName,
                            募資專案內容 = fundrasing.fFundraisingDescription,
                            目標金額 = (int)fundrasing.fFundrasingGoal,
                            當前金額 = (int)fundrasing.fCurrentAmount,
                            開始日期 = fundrasing.fStartdate,
                            結束日期 = fundrasing.fEnddate,
                            計畫名稱 = plan != null ? plan.fPlanName : null,
                            計畫內容 = plan != null ? plan.fPlanDescription : null,
                            計畫金額 = plan != null ? (int)plan.fPlanAmount : (decimal?)null,
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void 會員與募資計畫報表ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //先將對應的資料存入report變數
            using (dbPlusNEntities db = new dbPlusNEntities())
            {
                var report = db.tMember
                    .Select(member => new
                    {
                        MemberID = member.fMemberId,
                        MemberName = member.fName,
                        FundraisingPlans = member.tFundrasingPlan
                            .Select(plan => plan.fPlanName)
                            .ToList()
                    })
                    .ToList();

                // 處理 FundraisingPlans 的顯示格式
                var formattedReport = new List<dynamic>();

                foreach (var item in report)
                {
                    foreach (var plan in item.FundraisingPlans)
                    {
                        var newRow = new
                        {
                            item.MemberID,
                            item.MemberName,
                            fPlanName = plan
                        };

                        formattedReport.Add(newRow);
                    }
                }

                dataGridView1.DataSource = formattedReport;
            }
        }
    }
}

