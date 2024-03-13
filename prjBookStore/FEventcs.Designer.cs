namespace prjBookStore
{
    partial class FEventcs
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddeventtoolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.AddDiscounttoolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.活動產品折扣表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(900, 540);
            this.dataGridView1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Bisque;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMenuItem,
            this.UpdateToolStrip,
            this.DeleteToolStrip,
            this.SearchToolStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(900, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddMenuItem
            // 
            this.AddMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddeventtoolStrip,
            this.AddDiscounttoolStrip});
            this.AddMenuItem.Name = "AddMenuItem";
            this.AddMenuItem.Size = new System.Drawing.Size(53, 24);
            this.AddMenuItem.Text = "新增";
            // 
            // AddeventtoolStrip
            // 
            this.AddeventtoolStrip.Name = "AddeventtoolStrip";
            this.AddeventtoolStrip.Size = new System.Drawing.Size(224, 26);
            this.AddeventtoolStrip.Text = "新增活動";
            this.AddeventtoolStrip.Click += new System.EventHandler(this.AddeventtoolStrip_Click_1);
            // 
            // AddDiscounttoolStrip
            // 
            this.AddDiscounttoolStrip.Name = "AddDiscounttoolStrip";
            this.AddDiscounttoolStrip.Size = new System.Drawing.Size(224, 26);
            this.AddDiscounttoolStrip.Text = "新增活動折扣";
            this.AddDiscounttoolStrip.Click += new System.EventHandler(this.AddDiscounttoolStrip_Click);
            // 
            // UpdateToolStrip
            // 
            this.UpdateToolStrip.Name = "UpdateToolStrip";
            this.UpdateToolStrip.Size = new System.Drawing.Size(53, 24);
            this.UpdateToolStrip.Text = "編輯";
            this.UpdateToolStrip.Click += new System.EventHandler(this.UpdateToolStrip_Click);
            // 
            // DeleteToolStrip
            // 
            this.DeleteToolStrip.Name = "DeleteToolStrip";
            this.DeleteToolStrip.Size = new System.Drawing.Size(53, 24);
            this.DeleteToolStrip.Text = "刪除";
            this.DeleteToolStrip.Click += new System.EventHandler(this.DeleteToolStrip_Click);
            // 
            // SearchToolStrip
            // 
            this.SearchToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.活動產品折扣表ToolStripMenuItem});
            this.SearchToolStrip.Name = "SearchToolStrip";
            this.SearchToolStrip.Size = new System.Drawing.Size(53, 24);
            this.SearchToolStrip.Text = "查詢";
            this.SearchToolStrip.Click += new System.EventHandler(this.SearchToolStrip_Click);
            // 
            // 活動產品折扣表ToolStripMenuItem
            // 
            this.活動產品折扣表ToolStripMenuItem.Name = "活動產品折扣表ToolStripMenuItem";
            this.活動產品折扣表ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.活動產品折扣表ToolStripMenuItem.Text = "活動產品折扣表";
            this.活動產品折扣表ToolStripMenuItem.Click += new System.EventHandler(this.活動產品折扣表ToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(243, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 27);
            this.textBox1.TabIndex = 3;
            // 
            // FEventcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 570);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FEventcs";
            this.Text = "FFEventcs";
            this.Load += new System.EventHandler(this.FEventcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UpdateToolStrip;
        private System.Windows.Forms.ToolStripMenuItem AddMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddeventtoolStrip;
        private System.Windows.Forms.ToolStripMenuItem AddDiscounttoolStrip;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStrip;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStrip;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem 活動產品折扣表ToolStripMenuItem;
    }
}