﻿namespace UI
{
    partial class FrmDefinedShow
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.cmbLEDId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbShowType = new System.Windows.Forms.ComboBox();
            this.btnFontColor = new System.Windows.Forms.Button();
            this.fontDialogLed = new System.Windows.Forms.FontDialog();
            this.colorDialogLed = new System.Windows.Forms.ColorDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddTxt = new System.Windows.Forms.Button();
            this.btnAddTime = new System.Windows.Forms.Button();
            this.btnSendData = new System.Windows.Forms.Button();
            this.chkYear = new System.Windows.Forms.CheckBox();
            this.chkWeek = new System.Windows.Forms.CheckBox();
            this.chkTime = new System.Windows.Forms.CheckBox();
            this.btndefault = new System.Windows.Forms.Button();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.chkFoild = new System.Windows.Forms.CheckBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTIme = new System.Windows.Forms.TextBox();
            this.btnFontSetting = new System.Windows.Forms.Button();
            this.chkLines = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "LED编号";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(107, 169);
            this.txtContent.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(391, 63);
            this.txtContent.TabIndex = 1;
            // 
            // cmbLEDId
            // 
            this.cmbLEDId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLEDId.FormattingEnabled = true;
            this.cmbLEDId.Location = new System.Drawing.Point(109, 31);
            this.cmbLEDId.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbLEDId.Name = "cmbLEDId";
            this.cmbLEDId.Size = new System.Drawing.Size(143, 28);
            this.cmbLEDId.TabIndex = 2;
            this.cmbLEDId.SelectedIndexChanged += new System.EventHandler(this.cmbLEDId_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "播放方式";
            // 
            // cmbShowType
            // 
            this.cmbShowType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShowType.FormattingEnabled = true;
            this.cmbShowType.Location = new System.Drawing.Point(368, 31);
            this.cmbShowType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbShowType.Name = "cmbShowType";
            this.cmbShowType.Size = new System.Drawing.Size(132, 28);
            this.cmbShowType.TabIndex = 6;
            // 
            // btnFontColor
            // 
            this.btnFontColor.Enabled = false;
            this.btnFontColor.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnFontColor.Location = new System.Drawing.Point(352, 94);
            this.btnFontColor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFontColor.Name = "btnFontColor";
            this.btnFontColor.Size = new System.Drawing.Size(71, 42);
            this.btnFontColor.TabIndex = 9;
            this.btnFontColor.Text = "字体颜色";
            this.btnFontColor.UseVisualStyleBackColor = true;
            this.btnFontColor.Visible = false;
            this.btnFontColor.Click += new System.EventHandler(this.btnFontColor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "播放内容";
            // 
            // btnAddTxt
            // 
            this.btnAddTxt.Location = new System.Drawing.Point(404, 253);
            this.btnAddTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddTxt.Name = "btnAddTxt";
            this.btnAddTxt.Size = new System.Drawing.Size(96, 42);
            this.btnAddTxt.TabIndex = 13;
            this.btnAddTxt.Text = "添加文本";
            this.btnAddTxt.UseVisualStyleBackColor = true;
            this.btnAddTxt.Click += new System.EventHandler(this.btnAddTxt_Click);
            // 
            // btnAddTime
            // 
            this.btnAddTime.Location = new System.Drawing.Point(404, 314);
            this.btnAddTime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddTime.Name = "btnAddTime";
            this.btnAddTime.Size = new System.Drawing.Size(96, 42);
            this.btnAddTime.TabIndex = 14;
            this.btnAddTime.Text = "添加时间";
            this.btnAddTime.UseVisualStyleBackColor = true;
            this.btnAddTime.Click += new System.EventHandler(this.btnAddTime_Click);
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(402, 382);
            this.btnSendData.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(96, 40);
            this.btnSendData.TabIndex = 15;
            this.btnSendData.Text = "发送显示";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // chkYear
            // 
            this.chkYear.AutoSize = true;
            this.chkYear.Location = new System.Drawing.Point(107, 323);
            this.chkYear.Name = "chkYear";
            this.chkYear.Size = new System.Drawing.Size(70, 24);
            this.chkYear.TabIndex = 16;
            this.chkYear.Text = "年月日";
            this.chkYear.UseVisualStyleBackColor = true;
            // 
            // chkWeek
            // 
            this.chkWeek.AutoSize = true;
            this.chkWeek.Location = new System.Drawing.Point(192, 323);
            this.chkWeek.Name = "chkWeek";
            this.chkWeek.Size = new System.Drawing.Size(56, 24);
            this.chkWeek.TabIndex = 17;
            this.chkWeek.Text = "星期";
            this.chkWeek.UseVisualStyleBackColor = true;
            // 
            // chkTime
            // 
            this.chkTime.AutoSize = true;
            this.chkTime.Location = new System.Drawing.Point(265, 323);
            this.chkTime.Name = "chkTime";
            this.chkTime.Size = new System.Drawing.Size(56, 24);
            this.chkTime.TabIndex = 18;
            this.chkTime.Text = "时间";
            this.chkTime.UseVisualStyleBackColor = true;
            // 
            // btndefault
            // 
            this.btndefault.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btndefault.Location = new System.Drawing.Point(427, 94);
            this.btndefault.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btndefault.Name = "btndefault";
            this.btndefault.Size = new System.Drawing.Size(71, 42);
            this.btndefault.TabIndex = 23;
            this.btndefault.Text = "默认字体";
            this.btndefault.UseVisualStyleBackColor = true;
            this.btndefault.Visible = false;
            this.btndefault.Click += new System.EventHandler(this.btndefault_Click);
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Location = new System.Drawing.Point(107, 262);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(112, 24);
            this.chkDelete.TabIndex = 24;
            this.chkDelete.Text = "清除已有显示";
            this.chkDelete.UseVisualStyleBackColor = true;
            // 
            // chkFoild
            // 
            this.chkFoild.AutoSize = true;
            this.chkFoild.Checked = true;
            this.chkFoild.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFoild.Location = new System.Drawing.Point(107, 390);
            this.chkFoild.Name = "chkFoild";
            this.chkFoild.Size = new System.Drawing.Size(84, 24);
            this.chkFoild.TabIndex = 25;
            this.chkFoild.Text = "字体加粗";
            this.chkFoild.UseVisualStyleBackColor = true;
            // 
            // cmbPosition
            // 
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Items.AddRange(new object[] {
            "",
            "居中",
            "左对齐",
            "右对齐"});
            this.cmbPosition.Location = new System.Drawing.Point(107, 102);
            this.cmbPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(145, 28);
            this.cmbPosition.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.label3.Location = new System.Drawing.Point(40, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 60;
            this.label3.Text = "显示位置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.label4.Location = new System.Drawing.Point(237, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 68;
            this.label4.Text = "循环时长";
            // 
            // txtTIme
            // 
            this.txtTIme.Location = new System.Drawing.Point(304, 261);
            this.txtTIme.Name = "txtTIme";
            this.txtTIme.Size = new System.Drawing.Size(67, 26);
            this.txtTIme.TabIndex = 67;
            this.txtTIme.Text = "10";
            // 
            // btnFontSetting
            // 
            this.btnFontSetting.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnFontSetting.Location = new System.Drawing.Point(276, 94);
            this.btnFontSetting.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFontSetting.Name = "btnFontSetting";
            this.btnFontSetting.Size = new System.Drawing.Size(70, 42);
            this.btnFontSetting.TabIndex = 3;
            this.btnFontSetting.Text = "字体设置";
            this.btnFontSetting.UseVisualStyleBackColor = true;
            this.btnFontSetting.Click += new System.EventHandler(this.btnFontSetting_Click);
            // 
            // chkLines
            // 
            this.chkLines.AutoSize = true;
            this.chkLines.Location = new System.Drawing.Point(327, 323);
            this.chkLines.Name = "chkLines";
            this.chkLines.Size = new System.Drawing.Size(56, 24);
            this.chkLines.TabIndex = 69;
            this.chkLines.Text = "多行";
            this.chkLines.UseVisualStyleBackColor = true;
            // 
            // FrmDefinedShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 441);
            this.Controls.Add(this.chkLines);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTIme);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkFoild);
            this.Controls.Add(this.chkDelete);
            this.Controls.Add(this.btndefault);
            this.Controls.Add(this.chkTime);
            this.Controls.Add(this.chkWeek);
            this.Controls.Add(this.chkYear);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.btnAddTime);
            this.Controls.Add(this.btnAddTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFontColor);
            this.Controls.Add(this.cmbShowType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFontSetting);
            this.Controls.Add(this.cmbLEDId);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDefinedShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自定义实时显示";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.ComboBox cmbLEDId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbShowType;
        private System.Windows.Forms.Button btnFontColor;
        private System.Windows.Forms.FontDialog fontDialogLed;
        private System.Windows.Forms.ColorDialog colorDialogLed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddTxt;
        private System.Windows.Forms.Button btnAddTime;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.CheckBox chkYear;
        private System.Windows.Forms.CheckBox chkWeek;
        private System.Windows.Forms.CheckBox chkTime;
        private System.Windows.Forms.Button btndefault;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.CheckBox chkFoild;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTIme;
        private System.Windows.Forms.Button btnFontSetting;
        private System.Windows.Forms.CheckBox chkLines;
    }
}