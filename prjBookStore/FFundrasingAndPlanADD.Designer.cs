namespace prjBookStore
{
    partial class FFundrasingAndPlanADD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtcontent = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cEnd = new prjBookStore.Model.colum();
            this.label1 = new System.Windows.Forms.Label();
            this.cCurrentmoney = new prjBookStore.Model.colum();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cStart = new prjBookStore.Model.colum();
            this.cName = new prjBookStore.Model.colum();
            this.cMoney = new prjBookStore.Model.colum();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtplan = new System.Windows.Forms.TextBox();
            this.cPlanMoney = new prjBookStore.Model.colum();
            this.cPlanName = new prjBookStore.Model.colum();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(206)))), ((int)(((byte)(176)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtcontent);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.cEnd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cCurrentmoney);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.cStart);
            this.panel1.Controls.Add(this.cName);
            this.panel1.Controls.Add(this.cMoney);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1378, 444);
            this.panel1.TabIndex = 0;
            // 
            // txtcontent
            // 
            this.txtcontent.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.txtcontent.Location = new System.Drawing.Point(142, 281);
            this.txtcontent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcontent.Multiline = true;
            this.txtcontent.Name = "txtcontent";
            this.txtcontent.Size = new System.Drawing.Size(954, 119);
            this.txtcontent.TabIndex = 24;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(911, 156);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(177, 27);
            this.dateTimePicker2.TabIndex = 20;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // cEnd
            // 
            this.cEnd.ColumnName = "募資結束日";
            this.cEnd.ColumValue = "";
            this.cEnd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.cEnd.Location = new System.Drawing.Point(673, 156);
            this.cEnd.Name = "cEnd";
            this.cEnd.Size = new System.Drawing.Size(423, 47);
            this.cEnd.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F);
            this.label1.Location = new System.Drawing.Point(141, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 36);
            this.label1.TabIndex = 23;
            this.label1.Text = "募資內容";
            // 
            // cCurrentmoney
            // 
            this.cCurrentmoney.ColumnName = "當前金額";
            this.cCurrentmoney.ColumValue = "";
            this.cCurrentmoney.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.cCurrentmoney.Location = new System.Drawing.Point(142, 156);
            this.cCurrentmoney.Name = "cCurrentmoney";
            this.cCurrentmoney.Size = new System.Drawing.Size(414, 47);
            this.cCurrentmoney.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.Location = new System.Drawing.Point(911, 76);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 27);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cStart
            // 
            this.cStart.ColumnName = "募資開始日";
            this.cStart.ColumValue = "";
            this.cStart.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.cStart.Location = new System.Drawing.Point(673, 76);
            this.cStart.Name = "cStart";
            this.cStart.Size = new System.Drawing.Size(423, 42);
            this.cStart.TabIndex = 17;
            this.cStart.Load += new System.EventHandler(this.cStart_Load);
            // 
            // cName
            // 
            this.cName.ColumnName = "募資名稱";
            this.cName.ColumValue = "";
            this.cName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.cName.Location = new System.Drawing.Point(142, 33);
            this.cName.Name = "cName";
            this.cName.Size = new System.Drawing.Size(414, 43);
            this.cName.TabIndex = 14;
            // 
            // cMoney
            // 
            this.cMoney.ColumnName = "募資金額";
            this.cMoney.ColumValue = "";
            this.cMoney.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.cMoney.Location = new System.Drawing.Point(142, 95);
            this.cMoney.Name = "cMoney";
            this.cMoney.Size = new System.Drawing.Size(414, 44);
            this.cMoney.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(984, 328);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 57);
            this.button2.TabIndex = 22;
            this.button2.Text = "新增";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(866, 327);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 57);
            this.button1.TabIndex = 21;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(206)))), ((int)(((byte)(176)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtplan);
            this.panel2.Controls.Add(this.cPlanMoney);
            this.panel2.Controls.Add(this.cPlanName);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 444);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1378, 427);
            this.panel2.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F);
            this.label2.Location = new System.Drawing.Point(141, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 36);
            this.label2.TabIndex = 12;
            this.label2.Text = "計畫內容";
            // 
            // txtplan
            // 
            this.txtplan.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.txtplan.Location = new System.Drawing.Point(142, 151);
            this.txtplan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtplan.Multiline = true;
            this.txtplan.Name = "txtplan";
            this.txtplan.Size = new System.Drawing.Size(954, 142);
            this.txtplan.TabIndex = 11;
            // 
            // cPlanMoney
            // 
            this.cPlanMoney.ColumnName = "計畫金額";
            this.cPlanMoney.ColumValue = "";
            this.cPlanMoney.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.cPlanMoney.Location = new System.Drawing.Point(673, 24);
            this.cPlanMoney.Name = "cPlanMoney";
            this.cPlanMoney.Size = new System.Drawing.Size(366, 42);
            this.cPlanMoney.TabIndex = 10;
            // 
            // cPlanName
            // 
            this.cPlanName.ColumnName = "計畫名稱";
            this.cPlanName.ColumValue = "";
            this.cPlanName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.cPlanName.Location = new System.Drawing.Point(147, 24);
            this.cPlanName.Name = "cPlanName";
            this.cPlanName.Size = new System.Drawing.Size(366, 42);
            this.cPlanName.TabIndex = 9;
            // 
            // FFundrasingAndPlanADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 871);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FFundrasingAndPlanADD";
            this.Text = "FFundrasingFundrasingPlanEditor";
            this.Load += new System.EventHandler(this.FFundrasingFundrasingPlanEditor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtcontent;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private Model.colum cEnd;
        private System.Windows.Forms.Label label1;
        private Model.colum cCurrentmoney;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private Model.colum cStart;
        private Model.colum cName;
        private Model.colum cMoney;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtplan;
        private Model.colum cPlanMoney;
        private Model.colum cPlanName;
    }
}