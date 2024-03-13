namespace prjBookStore
{
    partial class FEventAndDiscountEditorcs
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
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BtnUpdateButton = new System.Windows.Forms.Button();
            this.BtnCancle = new System.Windows.Forms.Button();
            this.txtcontent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colum4 = new prjBookStore.Model.colum();
            this.colum3 = new prjBookStore.Model.colum();
            this.CEventtype = new prjBookStore.Model.colum();
            this.CEventName = new prjBookStore.Model.colum();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.CDiscountPercentage = new prjBookStore.Model.colum();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnCancleClick = new System.Windows.Forms.Button();
            this.CDiscountName = new prjBookStore.Model.colum();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(206)))), ((int)(((byte)(176)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.EndDateTimePicker);
            this.panel1.Controls.Add(this.StartTimePicker);
            this.panel1.Controls.Add(this.BtnUpdateButton);
            this.panel1.Controls.Add(this.BtnCancle);
            this.panel1.Controls.Add(this.txtcontent);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.colum4);
            this.panel1.Controls.Add(this.colum3);
            this.panel1.Controls.Add(this.CEventtype);
            this.panel1.Controls.Add(this.CEventName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 319);
            this.panel1.TabIndex = 0;
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Location = new System.Drawing.Point(665, 90);
            this.EndDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(204, 27);
            this.EndDateTimePicker.TabIndex = 29;
            this.EndDateTimePicker.ValueChanged += new System.EventHandler(this.EndDateTimePicker_ValueChanged);
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.Location = new System.Drawing.Point(665, 30);
            this.StartTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.Size = new System.Drawing.Size(204, 27);
            this.StartTimePicker.TabIndex = 28;
            this.StartTimePicker.ValueChanged += new System.EventHandler(this.StartTimePicker_ValueChanged);
            // 
            // BtnUpdateButton
            // 
            this.BtnUpdateButton.Location = new System.Drawing.Point(758, 254);
            this.BtnUpdateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnUpdateButton.Name = "BtnUpdateButton";
            this.BtnUpdateButton.Size = new System.Drawing.Size(111, 57);
            this.BtnUpdateButton.TabIndex = 27;
            this.BtnUpdateButton.Text = "修改";
            this.BtnUpdateButton.UseVisualStyleBackColor = true;
            this.BtnUpdateButton.Click += new System.EventHandler(this.BtnUpdateButton_Click);
            // 
            // BtnCancle
            // 
            this.BtnCancle.Location = new System.Drawing.Point(875, 255);
            this.BtnCancle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCancle.Name = "BtnCancle";
            this.BtnCancle.Size = new System.Drawing.Size(111, 57);
            this.BtnCancle.TabIndex = 26;
            this.BtnCancle.Text = "取消";
            this.BtnCancle.UseVisualStyleBackColor = true;
            this.BtnCancle.Click += new System.EventHandler(this.BtnCancle_Click);
            // 
            // txtcontent
            // 
            this.txtcontent.Location = new System.Drawing.Point(11, 191);
            this.txtcontent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcontent.Multiline = true;
            this.txtcontent.Name = "txtcontent";
            this.txtcontent.Size = new System.Drawing.Size(875, 55);
            this.txtcontent.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(11, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "活動內容";
            // 
            // colum4
            // 
            this.colum4.ColumnName = "結束時間";
            this.colum4.ColumValue = "";
            this.colum4.Location = new System.Drawing.Point(503, 90);
            this.colum4.Name = "colum4";
            this.colum4.Size = new System.Drawing.Size(366, 36);
            this.colum4.TabIndex = 3;
            // 
            // colum3
            // 
            this.colum3.ColumnName = "開始時間";
            this.colum3.ColumValue = "";
            this.colum3.Location = new System.Drawing.Point(503, 30);
            this.colum3.Name = "colum3";
            this.colum3.Size = new System.Drawing.Size(366, 36);
            this.colum3.TabIndex = 2;
            this.colum3.Load += new System.EventHandler(this.colum3_Load);
            // 
            // CEventtype
            // 
            this.CEventtype.ColumnName = "活動類型";
            this.CEventtype.ColumValue = "";
            this.CEventtype.Location = new System.Drawing.Point(10, 90);
            this.CEventtype.Name = "CEventtype";
            this.CEventtype.Size = new System.Drawing.Size(366, 36);
            this.CEventtype.TabIndex = 1;
            // 
            // CEventName
            // 
            this.CEventName.ColumnName = "活動名稱";
            this.CEventName.ColumValue = "";
            this.CEventName.Location = new System.Drawing.Point(16, 30);
            this.CEventName.Name = "CEventName";
            this.CEventName.Size = new System.Drawing.Size(366, 36);
            this.CEventName.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(0, 326);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1047, 455);
            this.panel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 451);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(1054, 326);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 455);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(666, 451);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(206)))), ((int)(((byte)(176)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.CDiscountPercentage);
            this.panel4.Controls.Add(this.BtnUpdate);
            this.panel4.Controls.Add(this.BtnCancleClick);
            this.panel4.Controls.Add(this.CDiscountName);
            this.panel4.Location = new System.Drawing.Point(1054, 3);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(670, 317);
            this.panel4.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 252);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 57);
            this.button1.TabIndex = 31;
            this.button1.Text = "刪除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CDiscountPercentage
            // 
            this.CDiscountPercentage.ColumnName = "折扣比例(%)";
            this.CDiscountPercentage.ColumValue = "";
            this.CDiscountPercentage.Location = new System.Drawing.Point(141, 96);
            this.CDiscountPercentage.Name = "CDiscountPercentage";
            this.CDiscountPercentage.Size = new System.Drawing.Size(394, 38);
            this.CDiscountPercentage.TabIndex = 30;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(287, 252);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(111, 57);
            this.BtnUpdate.TabIndex = 29;
            this.BtnUpdate.Text = "修改";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnCancleClick
            // 
            this.BtnCancleClick.Location = new System.Drawing.Point(539, 252);
            this.BtnCancleClick.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCancleClick.Name = "BtnCancleClick";
            this.BtnCancleClick.Size = new System.Drawing.Size(111, 57);
            this.BtnCancleClick.TabIndex = 28;
            this.BtnCancleClick.Text = "取消";
            this.BtnCancleClick.UseVisualStyleBackColor = true;
            this.BtnCancleClick.Click += new System.EventHandler(this.BtnCancleClick_Click);
            // 
            // CDiscountName
            // 
            this.CDiscountName.ColumnName = "折扣名稱";
            this.CDiscountName.ColumValue = "";
            this.CDiscountName.Location = new System.Drawing.Point(141, 27);
            this.CDiscountName.Name = "CDiscountName";
            this.CDiscountName.Size = new System.Drawing.Size(394, 36);
            this.CDiscountName.TabIndex = 4;
            // 
            // FEventAndDiscountEditorcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1738, 812);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FEventAndDiscountEditorcs";
            this.Text = "FEventAndDiscountEditorcs";
            this.Load += new System.EventHandler(this.FEventAndDiscountEditorcs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private Model.colum CEventName;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private Model.colum colum4;
        private Model.colum colum3;
        private Model.colum CEventtype;
        private System.Windows.Forms.TextBox txtcontent;
        private System.Windows.Forms.Button BtnUpdateButton;
        private System.Windows.Forms.Button BtnCancle;
        private System.Windows.Forms.Panel panel4;
        private Model.colum CDiscountPercentage;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnCancleClick;
        private Model.colum CDiscountName;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.Button button1;
    }
}