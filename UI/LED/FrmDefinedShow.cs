﻿using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmDefinedShow : Form
    {
        private int programInx = 0;//节目数量
        private int fontSize = 24;//字体大小
        private int fontColor = 0x00FF;//字体颜色
        private string fontName = "宋体";//字体名称
        public FrmDefinedShow()
        {
            InitializeComponent();
            IniteData();
        }
        /// <summary>
        /// 加载基础信息
        /// </summary>
        private void IniteData()
        {
            //txt文件读取信息
            string ledSettingPath = Application.StartupPath + @"\\" + @"LEDSetting.txt";//LED配置文件
            string actionShowPath = Application.StartupPath + @"\\" + @"ActionShow.txt";//播放方式文件 
            if (File.Exists(actionShowPath))
            {
                //播放方式
                DataTable dt = new DataTable();
                dt.Columns.Add("编号");
                dt.Columns.Add("名称");
                DataTable dtAction = PublicClass.GetXMLInfo(actionShowPath, dt, "ActionType", "AcitonId", "ActionName");
                cmbShowType.DataSource = dtAction;
                cmbShowType.ValueMember = "编号";
                cmbShowType.DisplayMember = "名称";
            }
            if (File.Exists(ledSettingPath))
            {
                //LED
                DataTable dt1 = new DataTable();
                dt1.Columns.Add("编号");
                dt1.Columns.Add("地址");
                DataTable dtLED = PublicClass.GetXMLInfo(ledSettingPath, dt1, "LEDNum", "LEDid", "LEDAddress");
                cmbLEDId.DataSource = dtLED;
                cmbLEDId.ValueMember = "地址";
                cmbLEDId.DisplayMember = "编号";
            }
        }
        private void btnFontSetting_Click(object sender, EventArgs e)
        {
            if (fontDialogLed.ShowDialog()== DialogResult.OK)
            {
                fontName = fontDialogLed.Font.Name;
                fontSize = Convert.ToInt32(fontDialogLed.Font.Size);
            }
        }

        private void btnFontColor_Click(object sender, EventArgs e)
        {
            try
            {
                if (colorDialogLed.ShowDialog() == DialogResult.OK)
                {
                    string name = colorDialogLed.Color.Name;
                    string color = ColorTranslator.ToHtml(Color.FromArgb(colorDialogLed.Color.R, colorDialogLed.Color.G, colorDialogLed.Color.B));
                    fontColor = Convert.ToInt32(color.Replace("#", "0x"),16);
                    //fontColor = int.Parse(color.Replace("#", "0x"));
                    //fontColor =Convert.ToInt32(Color.FromArgb(colorDialogLed.Color.B, colorDialogLed.Color.G, colorDialogLed.Color.R).ToArgb());
                }
            }
            catch (Exception ex) { }
        }

        private void btnAddTxt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbLEDId.SelectedValue.ToString()) || string.IsNullOrEmpty(cmbShowType.SelectedValue.ToString()))
            {
                MessageBox.Show("请完善LED信息！");
                return;
            }
            if (LEDShow.LedOpen(Convert.ToInt32(cmbLEDId.SelectedValue)))
            {
                 LEDShow.AddText(Convert.ToInt32(cmbLEDId.SelectedValue),txtContent.Text, programInx,Convert.ToInt32(cmbShowType.SelectedValue), fontName, fontSize, fontColor);
            }
        }

        private void btnAddTime_Click(object sender, EventArgs e)
        {
            if (chkYear.Checked || chkWeek.Checked || chkTime.Checked)
            {
                if (LEDShow.LedOpen(Convert.ToInt32(cmbLEDId.SelectedValue)))
                {
                    LEDShow.AddDateTime(Convert.ToInt32(cmbLEDId.SelectedValue), programInx,chkYear.Checked,chkWeek.Checked,chkTime.Checked,fontName, fontSize, fontColor);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LEDShow.DeleteProgram(Convert.ToInt32(cmbLEDId.SelectedValue));
            lblProgram.Text = "节目：" + 0;
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (LEDShow.SendData(Convert.ToInt32(cmbLEDId.SelectedValue)))//发送节目
            {
                MessageBox.Show("发送成功！");
            }
        }

        private void btnAddProgram_Click(object sender, EventArgs e)
        {
            AddProgram();
        }

        private void btnAddPro_Click(object sender, EventArgs e)
        {
            AddProgram();
        }
        private void AddProgram()
        {
            if (chkDelete.Checked)
            {
                LEDShow.DeleteProgram(Convert.ToInt32(cmbLEDId.SelectedValue));//删除指定控制卡所有节目
            }
            programInx = LEDShow.AddProgram(Convert.ToInt32(cmbLEDId.SelectedValue), 10);
            lblProgram.Text = "节目：" + (programInx+1);
        }

        private void btndefault_Click(object sender, EventArgs e)
        {
            fontSize = 24;
            fontColor = 0x00FF;
            fontName = "宋体";
        }
    }
}
