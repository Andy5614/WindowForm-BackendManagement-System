namespace prjBookStore
{
    partial class FFundrasingPlanEditor
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
            this.cPlanName = new prjBookStore.Model.colum();
            this.cPlanMoney = new prjBookStore.Model.colum();
            this.txtplan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cPlanName
            // 
            this.cPlanName.ColumnName = "計畫名稱";
            this.cPlanName.ColumValue = "";
            this.cPlanName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.cPlanName.Location = new System.Drawing.Point(48, 35);
            this.cPlanName.Name = "cPlanName";
            this.cPlanName.Size = new System.Drawing.Size(372, 37);
            this.cPlanName.TabIndex = 0;
            // 
            // cPlanMoney
            // 
            this.cPlanMoney.ColumnName = "計畫金額";
            this.cPlanMoney.ColumValue = "";
            this.cPlanMoney.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.cPlanMoney.Location = new System.Drawing.Point(456, 35);
            this.cPlanMoney.Name = "cPlanMoney";
            this.cPlanMoney.Size = new System.Drawing.Size(457, 37);
            this.cPlanMoney.TabIndex = 4;
            // 
            // txtplan
            // 
            this.txtplan.Location = new System.Drawing.Point(48, 206);
            this.txtplan.Multiline = true;
            this.txtplan.Name = "txtplan";
            this.txtplan.Size = new System.Drawing.Size(864, 186);
            this.txtplan.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(53, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "計畫內容";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 68);
            this.button1.TabIndex = 7;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(720, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 68);
            this.button2.TabIndex = 8;
            this.button2.Text = "確定";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FFundrasingPlanEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(206)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(954, 546);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtplan);
            this.Controls.Add(this.cPlanMoney);
            this.Controls.Add(this.cPlanName);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.Name = "FFundrasingPlanEditor";
            this.Text = "FFundrasingPlanEditor";
            this.Load += new System.EventHandler(this.FFundrasingPlanEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Model.colum cPlanName;
        private Model.colum cPlanMoney;
        private System.Windows.Forms.TextBox txtplan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}