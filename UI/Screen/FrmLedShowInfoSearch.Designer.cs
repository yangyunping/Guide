﻿namespace UI.LED
{
    partial class FrmScreenShowLogSearch
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTemShow = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReSetShow = new System.Windows.Forms.Button();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbShowState = new System.Windows.Forms.ComboBox();
            this.bntDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemShow)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTemShow
            // 
            this.dgvTemShow.AllowUserToAddRows = false;
            this.dgvTemShow.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvTemShow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTemShow.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvTemShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTemShow.Location = new System.Drawing.Point(0, 70);
            this.dgvTemShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTemShow.MultiSelect = false;
            this.dgvTemShow.Name = "dgvTemShow";
            this.dgvTemShow.RowHeadersWidth = 11;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvTemShow.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTemShow.RowTemplate.Height = 23;
            this.dgvTemShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTemShow.Size = new System.Drawing.Size(934, 429);
            this.dgvTemShow.TabIndex = 3;
            this.dgvTemShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTemShow_CellClick);
            this.dgvTemShow.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTemShow_CellFormatting);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReSetShow);
            this.panel1.Controls.Add(this.chkAll);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbShowState);
            this.panel1.Controls.Add(this.bntDelete);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtKey);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 70);
            this.panel1.TabIndex = 2;
            // 
            // btnReSetShow
            // 
            this.btnReSetShow.Location = new System.Drawing.Point(593, 17);
            this.btnReSetShow.Name = "btnReSetShow";
            this.btnReSetShow.Size = new System.Drawing.Size(79, 38);
            this.btnReSetShow.TabIndex = 8;
            this.btnReSetShow.Text = "重置显示";
            this.btnReSetShow.UseVisualStyleBackColor = true;
            this.btnReSetShow.Click += new System.EventHandler(this.btnReSetShow_Click);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(427, 27);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(54, 23);
            this.chkAll.TabIndex = 7;
            this.chkAll.Text = "全选";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "显示状态";
            // 
            // cmbShowState
            // 
            this.cmbShowState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShowState.FormattingEnabled = true;
            this.cmbShowState.Items.AddRange(new object[] {
            "全部",
            "准备显示",
            "显示成功",
            "显示失败"});
            this.cmbShowState.Location = new System.Drawing.Point(87, 24);
            this.cmbShowState.Name = "cmbShowState";
            this.cmbShowState.Size = new System.Drawing.Size(121, 27);
            this.cmbShowState.TabIndex = 5;
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(690, 17);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(79, 38);
            this.bntDelete.TabIndex = 4;
            this.bntDelete.Text = "删 除";
            this.bntDelete.UseVisualStyleBackColor = true;
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(496, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 38);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查 询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "关键字";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(275, 25);
            this.txtKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(129, 24);
            this.txtKey.TabIndex = 0;
            // 
            // FrmScreenShowLogSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTemShow);
            this.Controls.Add(this.panel1);
            this.Name = "FrmScreenShowLogSearch";
            this.Size = new System.Drawing.Size(934, 499);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemShow)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTemShow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbShowState;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.Button btnReSetShow;
    }
}
