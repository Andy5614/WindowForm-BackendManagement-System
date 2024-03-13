namespace prjBookStore
{
    partial class FFundrasingAndPlanEditor
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cStart = new prjBookStore.Model.colum();
            this.cMoney = new prjBookStore.Model.colum();
            this.cName = new prjBookStore.Model.colum();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcontent = new System.Windows.Forms.TextBox();
            this.cCurrentmoney = new prjBookStore.Model.colum();
            this.cEnd = new prjBookStore.Model.colum();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtplan = new System.Windows.Forms.TextBox();
            this.cPlanMoney = new prjBookStore.Model.colum();
            this.cPlanName = new prjBookStore.Model.colum();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(780, 109);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 27);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(790, 365);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 57);
            this.button1.TabIndex = 8;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(908, 366);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 57);
            this.button2.TabIndex = 9;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cStart
            // 
            this.cStart.ColumnName = "募資開始日";
            this.cStart.ColumValue = "";
            this.cStart.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.cStart.Location = new System.Drawing.Point(560, 104);
            this.cStart.Name = "cStart";
            this.cStart.Size = new System.Drawing.Size(414, 38);
            this.cStart.TabIndex = 4;
            // 
            // cMoney
            // 
            this.cMoney.ColumnName = "募資金額";
            this.cMoney.ColumValue = "";
            this.cMoney.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.cMoney.Location = new System.Drawing.Point(51, 90);
            this.cMoney.Name = "cMoney";
            this.cMoney.Size = new System.Drawing.Size(414, 46);
            this.cMoney.TabIndex = 1;
            this.cMoney.Load += new System.EventHandler(this.colum2_Load);
            // 
            // cName
            // 
            this.cName.ColumnName = "募資名稱";
            this.cName.ColumValue = "";
            this.cName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.cName.Location = new System.Drawing.Point(52, 23);
            this.cName.Name = "cName";
            this.cName.Size = new System.Drawing.Size(414, 43);
            this.cName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F);
            this.label1.Location = new System.Drawing.Point(51, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 35);
            this.label1.TabIndex = 12;
            this.label1.Text = "募資內容";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtcontent
            // 
            this.txtcontent.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.txtcontent.Location = new System.Drawing.Point(52, 276);
            this.txtcontent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcontent.Multiline = true;
            this.txtcontent.Name = "txtcontent";
            this.txtcontent.Size = new System.Drawing.Size(962, 80);
            this.txtcontent.TabIndex = 13;
            // 
            // cCurrentmoney
            // 
            this.cCurrentmoney.ColumnName = "當前金額";
            this.cCurrentmoney.ColumValue = "";
            this.cCurrentmoney.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.cCurrentmoney.Location = new System.Drawing.Point(51, 158);
            this.cCurrentmoney.Name = "cCurrentmoney";
            this.cCurrentmoney.Size = new System.Drawing.Size(414, 44);
            this.cCurrentmoney.TabIndex = 3;
            // 
            // cEnd
            // 
            this.cEnd.ColumnName = "募資結束日";
            this.cEnd.ColumValue = "";
            this.cEnd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.cEnd.Location = new System.Drawing.Point(560, 152);
            this.cEnd.Name = "cEnd";
            this.cEnd.Size = new System.Drawing.Size(414, 47);
            this.cEnd.TabIndex = 5;
            this.cEnd.Load += new System.EventHandler(this.cEnd_Load);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(774, 158);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(184, 27);
            this.dateTimePicker2.TabIndex = 7;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(38, 10);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 56);
            this.button3.TabIndex = 11;
            this.button3.Text = "新增計畫";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(206)))), ((int)(((byte)(176)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.txtcontent);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.cEnd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cCurrentmoney);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cStart);
            this.panel1.Controls.Add(this.cName);
            this.panel1.Controls.Add(this.cMoney);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 835);
            this.panel1.TabIndex = 14;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(0, 432);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(1023, 399);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(726, 359);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 58);
            this.button4.TabIndex = 16;
            this.button4.Text = "修改";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(1027, 435);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(869, 400);
            this.panel2.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, -3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(865, 399);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(206)))), ((int)(((byte)(176)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtplan);
            this.panel3.Controls.Add(this.cPlanMoney);
            this.panel3.Controls.Add(this.cPlanName);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(1027, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(869, 425);
            this.panel3.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(604, 360);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 57);
            this.button6.TabIndex = 21;
            this.button6.Text = "刪除";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(487, 360);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 57);
            this.button5.TabIndex = 14;
            this.button5.Text = "取消";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F);
            this.label2.Location = new System.Drawing.Point(39, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 35);
            this.label2.TabIndex = 20;
            this.label2.Text = "計畫內容";
            // 
            // txtplan
            // 
            this.txtplan.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.txtplan.Location = new System.Drawing.Point(38, 276);
            this.txtplan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtplan.Multiline = true;
            this.txtplan.Name = "txtplan";
            this.txtplan.Size = new System.Drawing.Size(782, 80);
            this.txtplan.TabIndex = 19;
            // 
            // cPlanMoney
            // 
            this.cPlanMoney.ColumnName = "計畫金額";
            this.cPlanMoney.ColumValue = "";
            this.cPlanMoney.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.cPlanMoney.Location = new System.Drawing.Point(467, 109);
            this.cPlanMoney.Name = "cPlanMoney";
            this.cPlanMoney.Size = new System.Drawing.Size(366, 40);
            this.cPlanMoney.TabIndex = 18;
            // 
            // cPlanName
            // 
            this.cPlanName.ColumnName = "計畫名稱";
            this.cPlanName.ColumValue = "";
            this.cPlanName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.cPlanName.Location = new System.Drawing.Point(38, 109);
            this.cPlanName.Name = "cPlanName";
            this.cPlanName.Size = new System.Drawing.Size(366, 38);
            this.cPlanName.TabIndex = 17;
            // 
            // FFundrasingAndPlanEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1896, 835);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FFundrasingAndPlanEditor";
            this.Text = "FFundrasingEditor";
            this.Load += new System.EventHandler(this.FFundrasingEditor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Model.colum cName;
        private Model.colum cMoney;
        private Model.colum cStart;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcontent;
        private Model.colum cCurrentmoney;
        private Model.colum cEnd;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtplan;
        private Model.colum cPlanMoney;
        private Model.colum cPlanName;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}