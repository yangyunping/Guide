﻿namespace UI.LED
{
    partial class FrmScreenSettingSearch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.dgvScreenSetting = new System.Windows.Forms.DataGridView();
            this.btnModify = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreenSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.bntDelete);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtKey);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 70);
            this.panel1.TabIndex = 3;
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(491, 15);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(79, 38);
            this.bntDelete.TabIndex = 4;
            this.bntDelete.Text = "删 除";
            this.bntDelete.UseVisualStyleBackColor = true;
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(302, 15);
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
            this.label1.Location = new System.Drawing.Point(41, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "关键字";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(96, 22);
            this.txtKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(168, 24);
            this.txtKey.TabIndex = 0;
            // 
            // dgvScreenSetting
            // 
            this.dgvScreenSetting.AllowUserToAddRows = false;
            this.dgvScreenSetting.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvScreenSetting.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvScreenSetting.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvScreenSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScreenSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvScreenSetting.Location = new System.Drawing.Point(0, 70);
            this.dgvScreenSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvScreenSetting.MultiSelect = false;
            this.dgvScreenSetting.Name = "dgvScreenSetting";
            this.dgvScreenSetting.ReadOnly = true;
            this.dgvScreenSetting.RowHeadersWidth = 11;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvScreenSetting.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvScreenSetting.RowTemplate.Height = 23;
            this.dgvScreenSetting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScreenSetting.Size = new System.Drawing.Size(850, 452);
            this.dgvScreenSetting.TabIndex = 4;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(394, 15);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(79, 38);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "修 改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // FrmScreenSettingSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvScreenSetting);
            this.Controls.Add(this.panel1);
            this.Name = "FrmScreenSettingSearch";
            this.Size = new System.Drawing.Size(850, 522);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreenSetting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.DataGridView dgvScreenSetting;
        private System.Windows.Forms.Button btnModify;
    }
}
