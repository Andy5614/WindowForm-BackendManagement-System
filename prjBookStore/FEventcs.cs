using prjBookStore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prjBookStore
{
    public partial class FEventcs : Form
    {
        public FEventcs()
        {
            InitializeComponent();
            this.Controls.Add(menuStrip1);
            menuStrip1.Dock = DockStyle.Top;
        }

        private void FEventcs_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh() //更新畫面
        {
            dbPlusNEntities db = new dbPlusNEntities();
            var query = from e in db.tEvent
                        join d in db.tDiscount
                        on e.fEventID equals d.fEventID into events
                        from d in events.DefaultIfEmpty()
                        select new
                        {
                            活動編號 = e.fEventID,
                            活動名稱 = e.fEventName,
                            活動類型 = e.fEventType,
                            活動內容 = e.fEventDescription,
                            開始時間 = e.fStratdate,
                            結束時間 = e.fEnddate,
                            折扣名稱 = d != null ?d.fDiscountName: null,
                            折扣優惠 = d != null ? (Math.Round((double)d.fDiscountPercentage*100, 2).ToString()+"%") : (string)null,
                        };
            dataGridView1.DataSource = query.ToList();
            dataGridView1.DataSource = query.ToList();
            dataGridView1.DataBindingComplete += (sender, e) =>
            {
                CSStyle.restGridRowColor(dataGridView1);  // 在DataBindingComplete事件中設置顏色
            };
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void AddeventtoolStrip_Click_1(object sender, EventArgs e) //新增活動
        {
            FEventEditorcs f = new FEventEditorcs();
            f.ShowDialog();
            if (f.confirm == DialogResult.OK)
            {
                dbPlusNEntities db = new dbPlusNEntities();
                db.tEvent.Add(f.Event);
                db.SaveChanges();
                MessageBox.Show("新增成功");
                refresh();
            }
        }

        private void AddDiscounttoolStrip_Click(object sender, EventArgs e) //新增活動折扣
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("請選取欲新增折扣之活動!");
                return;
            }
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(id))
                return;
            int fEventID = Convert.ToInt32(id);
            FDiscountEditor f   = new FDiscountEditor(fEventID);
            f.ShowDialog();


            if (f.confirm == DialogResult.OK)
            {
                dbPlusNEntities db = new dbPlusNEntities();
                db.tDiscount.Add(f.Discount);
                db.SaveChanges();
                MessageBox.Show("新增成功");
                refresh();
            }
        }

        private void UpdateToolStrip_Click(object sender, EventArgs e)//編輯活動及折扣
        {
            if (dataGridView1.CurrentRow == null)
                return;
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(id))
                return;
            int fEventID = Convert.ToInt32(id);
            dbPlusNEntities db = new dbPlusNEntities();
            tEvent Event = db.tEvent.FirstOrDefault(p => p.fEventID == fEventID);
            if (Event == null)
                return;
            FEventAndDiscountEditorcs f = new FEventAndDiscountEditorcs(fEventID);  //把 ID傳入編輯視窗
            f.Event = Event;
            f.ShowDialog();
            refresh();
        }

        private void DeleteToolStrip_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
                return;
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(id))
                return;
            if (MessageBox.Show("確定要刪除該筆資料嗎?", "確認", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            int fEvenetID = Convert.ToInt32(id);
            dbPlusNEntities db = new dbPlusNEntities();
            tEvent Event = db.tEvent.FirstOrDefault(p => p.fEventID == fEvenetID);
            if (Event == null)
                return;
            var discount = db.tDiscount.Where(p => p.fEventID == fEvenetID).ToList();  //先刪除外部連結
            foreach (var d in discount)
            {
                db.tDiscount.Remove(d);
            }
            db.tEvent.Remove(Event);
            db.SaveChanges();
            refresh();
        }

        private void SearchToolStrip_Click(object sender, EventArgs e) //查詢
        {
            dbPlusNEntities db = new dbPlusNEntities();

            DateTime date;
            bool isDateValid = DateTime.TryParse(textBox1.Text, out date); //判斷輸入的文字是否為datetime type


            var query = from Evenet in db.tEvent
                        join Discount in db.tDiscount
                        on Evenet.fEventID equals Discount.fEventID into Events
                        from Discount in Events.DefaultIfEmpty()

                        where Evenet.fEventName.Contains(textBox1.Text) ||
                        Evenet.fEventType.Contains(textBox1.Text) ||
                        (isDateValid && (Evenet.fStratdate == date || Evenet.fEnddate == date))

                        select new
                        {
                            活動編號 = Evenet.fEventID,
                            活動名稱 = Evenet.fEventName,
                            活動類型 = Evenet.fEventType,
                            活動內容 = Evenet.fEventDescription,
                            開始時間 = Evenet.fStratdate,
                            結束時間 = Evenet.fEnddate,
                            折扣名稱 = Discount != null ? Discount.fDiscountName : null,
                            折扣優惠 = Discount != null ? (Math.Round((double)Discount.fDiscountPercentage * 100, 2).ToString() + "%") : (string)null,
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void 活動產品折扣表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (dbPlusNEntities db = new dbPlusNEntities())
            {
                //將資料表資料所需資料找出，存入匿名變數中(List)
                var report = db.tEvent
                       .Select(Evnet => new
                       {
                           EventID = Evnet.fEventID,
                           EventName = Evnet.fEventName,
                           Discount = Evnet.tDiscount
                              .Select(Discount => new
                              {
                                  DiscountID = Discount.fDiscountID,
                                  DiscountName = Discount.fDiscountName,
                                  DiscountPercentage = Discount.fDiscountPercentage,
                                  Catrgory = Discount.tCategory
                                           .Select(DiscountCategory => new
                                           {
                                               CategoryName = DiscountCategory.fCategoryName,
                                               Book = DiscountCategory.tBook 
                                                         .Select(Product => new
                                                         {
                                                             ProductName = Product.fTitle,
                                                         })
                                                         .ToList(),
                                                Merchandise = DiscountCategory.tMerchandise
                                                            .Select(Product=> new
                                                            {
                                                                MerchandiseName =  Product.fMerchandiseName,
                                                            })
                                                            .ToList()
                                           })
                                           .ToList()
                              })
                              .ToList()
                       })
                       .ToList();
                
                //格式化匿名變數中的資料   
                var formattedReport = new List<dynamic>();
                foreach( var item in report )
                {
                    foreach( var item2 in item.Discount)
                    {
                        foreach(var item3 in item2.Catrgory) 
                        {
                            var mergedProducts = item3.Book.
                                Select(book => new
                                {
                                    ProductName = book.ProductName,
                                })
                                .Union(item3.Merchandise
                                    .Select(merchandise => new
                                    {
                                        ProductName = merchandise.MerchandiseName,
                                    })
                                    );
                            foreach(var item4 in mergedProducts)
                            {
                                var newRow = new
                                {
                                    item.EventID,
                                    item.EventName,
                                    item2.DiscountName,
                                    DiscountPercentage = (Math.Round((double)item2.DiscountPercentage * 100, 2).ToString() + "%"),
                                    item3.CategoryName,
                                    item4.ProductName,
                                };
                                formattedReport.Add(newRow);
                            }
                        }
                    }
                }
                dataGridView1.DataSource = formattedReport;

            }
        }
    }
}
