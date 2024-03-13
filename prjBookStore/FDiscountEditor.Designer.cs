namespace prjBookStore
{
    partial class FDiscountEditor
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
            this.Btncancle = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.CDiscountPercentage = new prjBookStore.Model.colum();
            this.CDiscountName = new prjBookStore.Model.colum();
            this.SuspendLayout();
            // 
            // Btncancle
            // 
            this.Btncancle.Location = new System.Drawing.Point(194, 307);
            this.Btncancle.Name = "Btncancle";
            this.Btncancle.Size = new System.Drawing.Size(156, 71);
            this.Btncancle.TabIndex = 15;
            this.Btncancle.Text = "取消";
            this.Btncancle.UseVisualStyleBackColor = true;
            this.Btncancle.Click += new System.EventHandler(this.Btncancle_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(377, 307);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(156, 71);
            this.BtnAdd.TabIndex = 14;
            this.BtnAdd.Text = "新增";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // CDiscountPercentage
            // 
            this.CDiscountPercentage.ColumnName = "折扣比例(%)";
            this.CDiscountPercentage.ColumValue = "";
            this.CDiscountPercentage.Location = new System.Drawing.Point(12, 125);
            this.CDiscountPercentage.Name = "CDiscountPercentage";
            this.CDiscountPercentage.Size = new System.Drawing.Size(538, 48);
            this.CDiscountPercentage.TabIndex = 1;
            // 
            // CDiscountName
            // 
            this.CDiscountName.ColumnName = "折扣名稱";
            this.CDiscountName.ColumValue = "";
            this.CDiscountName.Location = new System.Drawing.Point(44, 47);
            this.CDiscountName.Name = "CDiscountName";
            this.CDiscountName.Size = new System.Drawing.Size(507, 45);
            this.CDiscountName.TabIndex = 0;
            // 
            // FDiscountEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(206)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(618, 380);
            this.Controls.Add(this.Btncancle);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.CDiscountPercentage);
            this.Controls.Add(this.CDiscountName);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.Name = "FDiscountEditor";
            this.Text = "FDiscount";
            this.Load += new System.EventHandler(this.FDiscount_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Model.colum CDiscountName;
        private Model.colum CDiscountPercentage;
        private System.Windows.Forms.Button Btncancle;
        private System.Windows.Forms.Button BtnAdd;
    }
}