namespace prjBookStore
{
    partial class FEventEditorcs
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
            this.StartdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.EnddateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.Btncancle = new System.Windows.Forms.Button();
            this.colum6 = new prjBookStore.Model.colum();
            this.CeventName = new prjBookStore.Model.colum();
            this.colum4 = new prjBookStore.Model.colum();
            this.CEevnetcontent = new prjBookStore.Model.colum();
            this.CEventType = new prjBookStore.Model.colum();
            this.SuspendLayout();
            // 
            // StartdateTimePicker1
            // 
            this.StartdateTimePicker1.Location = new System.Drawing.Point(377, 187);
            this.StartdateTimePicker1.Name = "StartdateTimePicker1";
            this.StartdateTimePicker1.Size = new System.Drawing.Size(203, 27);
            this.StartdateTimePicker1.TabIndex = 10;
            this.StartdateTimePicker1.ValueChanged += new System.EventHandler(this.StartdateTimePicker1_ValueChanged);
            // 
            // EnddateTimePicker2
            // 
            this.EnddateTimePicker2.Location = new System.Drawing.Point(377, 272);
            this.EnddateTimePicker2.Name = "EnddateTimePicker2";
            this.EnddateTimePicker2.Size = new System.Drawing.Size(203, 27);
            this.EnddateTimePicker2.TabIndex = 11;
            this.EnddateTimePicker2.ValueChanged += new System.EventHandler(this.EnddateTimePicker2_ValueChanged);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(631, 509);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(156, 71);
            this.BtnAdd.TabIndex = 12;
            this.BtnAdd.Text = "新增";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // Btncancle
            // 
            this.Btncancle.Location = new System.Drawing.Point(468, 509);
            this.Btncancle.Name = "Btncancle";
            this.Btncancle.Size = new System.Drawing.Size(156, 71);
            this.Btncancle.TabIndex = 13;
            this.Btncancle.Text = "取消";
            this.Btncancle.UseVisualStyleBackColor = true;
            this.Btncancle.Click += new System.EventHandler(this.Btncancle_Click);
            // 
            // colum6
            // 
            this.colum6.ColumnName = "結束日期";
            this.colum6.ColumValue = "";
            this.colum6.Location = new System.Drawing.Point(144, 257);
            this.colum6.Name = "colum6";
            this.colum6.Size = new System.Drawing.Size(436, 62);
            this.colum6.TabIndex = 9;
            // 
            // CeventName
            // 
            this.CeventName.ColumnName = "活動名稱";
            this.CeventName.ColumValue = "";
            this.CeventName.Location = new System.Drawing.Point(144, 14);
            this.CeventName.Name = "CeventName";
            this.CeventName.Size = new System.Drawing.Size(436, 62);
            this.CeventName.TabIndex = 8;
            this.CeventName.Load += new System.EventHandler(this.colum5_Load);
            // 
            // colum4
            // 
            this.colum4.ColumnName = "開始日期";
            this.colum4.ColumValue = "";
            this.colum4.Location = new System.Drawing.Point(144, 172);
            this.colum4.Name = "colum4";
            this.colum4.Size = new System.Drawing.Size(436, 62);
            this.colum4.TabIndex = 7;
            // 
            // CEevnetcontent
            // 
            this.CEevnetcontent.ColumnName = "活動內容";
            this.CEevnetcontent.ColumValue = "";
            this.CEevnetcontent.Location = new System.Drawing.Point(144, 343);
            this.CEevnetcontent.Name = "CEevnetcontent";
            this.CEevnetcontent.Size = new System.Drawing.Size(436, 61);
            this.CEevnetcontent.TabIndex = 6;
            // 
            // CEventType
            // 
            this.CEventType.ColumnName = "活動類型";
            this.CEventType.ColumValue = "";
            this.CEventType.Location = new System.Drawing.Point(144, 94);
            this.CEventType.Name = "CEventType";
            this.CEventType.Size = new System.Drawing.Size(436, 62);
            this.CEventType.TabIndex = 5;
            // 
            // FEventEditorcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(206)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(831, 638);
            this.Controls.Add(this.Btncancle);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.EnddateTimePicker2);
            this.Controls.Add(this.StartdateTimePicker1);
            this.Controls.Add(this.colum6);
            this.Controls.Add(this.CeventName);
            this.Controls.Add(this.colum4);
            this.Controls.Add(this.CEevnetcontent);
            this.Controls.Add(this.CEventType);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.Name = "FEventEditorcs";
            this.Text = "FEventEditorcs";
            this.Load += new System.EventHandler(this.FEventEditorcs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Model.colum colum4;
        private Model.colum CEevnetcontent;
        private Model.colum CEventType;
        private Model.colum CeventName;
        private Model.colum colum6;
        private System.Windows.Forms.DateTimePicker StartdateTimePicker1;
        private System.Windows.Forms.DateTimePicker EnddateTimePicker2;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button Btncancle;
    }
}